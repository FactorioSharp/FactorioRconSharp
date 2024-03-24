using CaseExtensions;
using FactorioRconSharp.ClientGenerator.Specification;

namespace FactorioRconSharp.ClientGenerator.Generators;

class FactorioModelGenerator
{
    readonly FactorioRuntimeApiSpecification _specification;
    readonly string _baseClassName;
    readonly Dictionary<string, string> _luaClassToClassName;

    public FactorioModelGenerator(FactorioRuntimeApiSpecification specification)
    {
        _specification = specification;
        _baseClassName = GenerateModelBaseClassName(specification.ApplicationVersion);
        _luaClassToClassName = FactorioSpecificationTypesExtractor.ExtractTypes(specification).Distinct().ToDictionary(t => t, ComputeClassName);
    }

    public async Task Generate(string outPath)
    {
        string[] elementsToSkip = ["LuaRCON"];

        if (Directory.Exists(outPath))
        {
            Directory.Delete(outPath, true);
        }

        Directory.CreateDirectory(outPath);

        string baseClassPath = await GenerateBaseModelClass(outPath);
        Console.WriteLine($"[{nameof(FactorioModelGenerator)}] Base class for all models has been generated and exported to {baseClassPath}...");

        foreach (FactorioRuntimeClassSpecification cls in _specification.Classes)
        {
            if (elementsToSkip.Contains(cls.Name))
            {
                Console.WriteLine($"[{nameof(FactorioModelGenerator)}] Class {cls.Name} skipped.");
            }

            string path = await GenerateClass(cls, outPath);
            Console.WriteLine($"[{nameof(FactorioModelGenerator)}] Class for model {cls.Name} has been generated and exported to {path}...");
        }

        foreach (FactorioRuntimeConceptSpecification concept in _specification.Concepts)
        {
            if (elementsToSkip.Contains(concept.Name))
            {
                Console.WriteLine($"[{nameof(FactorioModelGenerator)}] Concept {concept.Name} skipped.");
            }

            string path = await GenerateClass(concept, outPath);
            Console.WriteLine($"[{nameof(FactorioModelGenerator)}] Concept for model {concept.Name} has been generated and exported to {path}...");
        }
    }

    async Task<string> GenerateBaseModelClass(string outPath)
    {
        string baseClassContent = await File.ReadAllTextAsync("Resource/FactorioRconModelBase.cs");
        string baseModelClass = baseClassContent.Replace("FactorioRconModelBase", _baseClassName);
        string baseModelFile = Path.Join(outPath, _baseClassName + ".cs");
        await File.WriteAllTextAsync(baseModelFile, baseModelClass);

        return baseModelFile;
    }

    async Task<string> GenerateClass(FactorioRuntimeClassSpecification cls, string outPath)
    {
        (string className, string classContent) = ComputeClassContent(cls);

        string generatedModelPath = Path.Join(outPath, className + ".cs");
        await File.WriteAllTextAsync(generatedModelPath, classContent);

        return generatedModelPath;
    }

    async Task<string> GenerateClass(FactorioRuntimeConceptSpecification concept, string outPath)
    {
        (string className, string classContent) = ComputeClassContent(concept);

        string generatedModelPath = Path.Join(outPath, className + ".cs");
        await File.WriteAllTextAsync(generatedModelPath, classContent);

        return generatedModelPath;
    }

    (string className, string classContent) ComputeClassContent(FactorioRuntimeClassSpecification cls)
    {
        if (IsKnownModel(cls.Name, out string generatedClassName, out string modelContent))
        {
            return (generatedClassName, modelContent.Replace("FactorioRconModelBase", _baseClassName));
        }

        SharpCodeWriter writer = new();

        WriteUsings(writer);
        writer.AppendLine();

        WriteDocumentation(writer, cls.Description, [], cls.Examples);

        generatedClassName = _luaClassToClassName[cls.Name];

        writer.AppendLine($"public {(cls.Abstract ? "abstract " : "")}class {generatedClassName}: {_baseClassName}");
        writer.AppendLine("{");
        writer.Indent();

        foreach (FactorioRuntimeAttributeSpecification attribute in cls.Attributes.OrderBy(a => a.Order))
        {
            WriteAttribute(attribute, writer);
        }

        writer.Unindent();
        writer.AppendLine("}");

        return (generatedClassName, writer.ToString());
    }

    (string className, string classContent) ComputeClassContent(FactorioRuntimeConceptSpecification concept)
    {
        SharpCodeWriter writer = new();

        WriteUsings(writer);
        writer.AppendLine();

        WriteDocumentation(writer, concept.Description, [], []);

        string generatedClassName = _luaClassToClassName[concept.Name];

        writer.AppendLine($"public class {generatedClassName}: {_baseClassName}");
        writer.AppendLine("{");
        writer.AppendLine("}");

        return (generatedClassName, writer.ToString());
    }

    static string GenerateModelBaseClassName(string version)
    {
        string versionSanitized = version.Replace('.', '_');
        return $"FactorioRconModelBase_v{versionSanitized}";
    }

    string ComputeType(FactorioRuntimeTypeSpecification type, bool nullable)
    {
        string typeStr = ComputeType(type);
        return nullable ? $"{typeStr}?" : typeStr;
    }

    string ComputeType(FactorioRuntimeTypeSpecification type)
    {
        switch (type)
        {
            case FactorioRuntimeSimpleTypeSpecification simpleType:
                switch (simpleType.Name)
                {
                    case "string":
                    case "int":
                    case "uint":
                    case "float":
                    case "double":
                        return simpleType.Name;
                    case "boolean":
                        return "bool";
                    case "int8":
                        return "sbyte";
                    case "uint8":
                        return "byte";
                    case "int16":
                        return "short";
                    case "uint16":
                        return "ushort";
                    default:
                        if (simpleType.Name.StartsWith("defines."))
                        {
                            return $"FactorioRcon{simpleType.Name[8..].ToPascalCase()}";
                        }

                        return _luaClassToClassName[simpleType.Name];
                }
            case FactorioRuntimeArrayTypeSpecification arrayType:
                return $"{ComputeType(arrayType.Value)}[]";
            case FactorioRuntimeFunctionTypeSpecification functionType:
                return $"Action<{string.Join(", ", functionType.Parameters.Select(ComputeType))}>";
            case FactorioRuntimeLiteralTypeSpecification literalType:
                return "Literal";
            case FactorioRuntimeTableTypeSpecification tableType:
                return $"FactorioRconTable<{string.Join(", ", tableType.Parameters.OrderBy(p => p.Order).Select(p => ComputeType(p.Type, p.Optional)))}>";
            case FactorioRuntimeUnionTypeSpecification unionType:
                return $"FactorioRconUnion<{string.Join(", ", unionType.Options.Select(ComputeType))}>";
            case FactorioRuntimeKeyValueTypeSpecification keyValueType:
                return keyValueType.Name switch
                {
                    "dictionary" => $"Dictionary<{ComputeType(keyValueType.Key)}, {ComputeType(keyValueType.Value)}>",
                    _ => $"{_luaClassToClassName[keyValueType.Name]}<{ComputeType(keyValueType.Key)}, {ComputeType(keyValueType.Value)}>"
                };
            default:
                throw new ArgumentOutOfRangeException(nameof(type));
        }
    }

    void WriteUsings(SharpCodeWriter writer) => writer.AppendLine("using FactorioRconSharp.Core.Abstractions;");

    void WriteDocumentation(SharpCodeWriter writer, string description, string[] notes, string[] examples)
    {
        description = _luaClassToClassName.Aggregate(description, (current, entry) => current.Replace(entry.Key, entry.Value));

        writer.Comment();
        writer.AppendLine("<summary>");
        writer.AppendLine($"{description}");
        writer.AppendLine("</summary>");
        writer.Uncomment();
    }

    void WriteAttribute(FactorioRuntimeAttributeSpecification attribute, SharpCodeWriter writer)
    {
        if (attribute is { Read: false, Write: false })
        {
            writer.AppendCommentLine($"Attribute {attribute.Name} skipped because it cannot be read or written");
            writer.AppendLine();
            return;
        }

        WriteDocumentation(writer, attribute.Description, [], []);

        string propertyType = ComputeType(attribute.Type, attribute.Optional);
        string propertyName = attribute.Name.ToPascalCase();
        string getter = attribute.Read ? "get;" : "private get;";
        string setter = attribute.Write ? "set;" : "private set;";

        writer.AppendLine($"[FactorioRconAttribute(\"{attribute.Name}\")]");
        writer.AppendLine($"public {propertyType} {propertyName} {{ {getter} {setter} }}");

        writer.AppendLine();
    }

    static bool IsKnownModel(string luaClassName, out string generatedClassName, out string generatedClassContent)
    {
        switch (luaClassName)
        {
            case "LuaCustomTable":
                generatedClassName = "FactorioRconCustomTable";
                generatedClassContent = File.ReadAllText("Resource/LuaCustomTable.cs");
                return true;
            default:
                generatedClassName = "";
                generatedClassContent = "";
                return false;
        }
    }

    static string ComputeClassName(string luaClassName)
    {
        string result = luaClassName;

        if (result.StartsWith("Lua"))
        {
            result = result[3..];
        }

        return $"FactorioRcon{result}";
    }
}
