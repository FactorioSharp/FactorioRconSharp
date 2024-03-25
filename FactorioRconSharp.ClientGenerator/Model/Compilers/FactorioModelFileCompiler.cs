using System.Text;
using CaseExtensions;
using FactorioRconSharp.ClientGenerator.Specification;

namespace FactorioRconSharp.ClientGenerator.Model.Compilers;

public class FactorioModelFileCompiler
{
    readonly FactorioRuntimeApiSpecification _specification;

    public FactorioModelFileCompiler(FactorioRuntimeApiSpecification specification)
    {
        _specification = specification;
    }

    public FactorioModelFile CompileClassFile(string clsName)
    {
        FactorioRuntimeClassSpecification? cls = _specification.Classes.SingleOrDefault(c => c.Name == clsName);
        if (cls == null)
        {
            throw new InvalidOperationException($"Could not find specification of class {clsName}");
        }

        return new FactorioModelFile
        {
            Name = cls.Name.ToPascalCase(),
            Namespace = "FactorioRconSharp.Model.Classes",
            Usings =
            [
                "FactorioRconSharp.Model.Builtins",
                "FactorioRconSharp.Model.Concepts",
                "FactorioRconSharp.Model.Definitions"
            ],
            Classes =
            [
                CompileClass(cls)
            ]
        };
    }

    public FactorioModelFile CompileConceptFile(string conceptName)
    {
        FactorioRuntimeConceptSpecification? concept = _specification.Concepts.SingleOrDefault(c => c.Name == conceptName);
        if (concept == null)
        {
            throw new InvalidOperationException($"Could not find specification of concept {conceptName}");
        }

        return new FactorioModelFile
        {
            Name = concept.Name.ToPascalCase(),
            Namespace = "FactorioRconSharp.Model.Concepts",
            Usings =
            [
                "FactorioRconSharp.Model.Builtins",
                "FactorioRconSharp.Model.Classes",
                "FactorioRconSharp.Model.Definitions"
            ],
            Classes =
            [
                CompileClass(concept)
            ]
        };
    }

    public FactorioModelFile CompileDefinitionFile(string definitionName)
    {
        FactorioRuntimeDefinitionSpecification? definition = _specification.Defines.SingleOrDefault(c => c.Name == definitionName);
        if (definition == null)
        {
            throw new InvalidOperationException($"Could not find specification of concept {definitionName}");
        }

        return new FactorioModelFile
        {
            Name = definition.Name.ToPascalCase(),
            Namespace = "FactorioRconSharp.Model.Definitions",
            Enums =
            [
                CompileEnum(definition)
            ]
        };
    }

    FactorioModelClass CompileClass(FactorioRuntimeClassSpecification cls) =>
        new()
        {
            Name = cls.Name.ToPascalCase(),
            LuaName = cls.Name,
            Documentation = new FactorioModelDocumentation
            {
                Summary = cls.Description, Examples = BuildExamples(cls.Examples)
            },
            IsFactorioClass = true,
            Properties = cls.Attributes.OrderBy(a => a.Order)
                .Select(CompileProperty)
                .Concat(cls.Operators.Where(o => o.Name == FactorioRuntimeOperatorName.Length).Select(CompileProperty))
                .ToArray(),
            Operators = cls.Operators.OrderBy(o => o.Order).Where(o => o.Name != FactorioRuntimeOperatorName.Length).Select(CompileOperator).ToArray(),
            Methods = cls.Methods.OrderBy(m => m.Order).Select(CompileMethod).ToArray()
        };

    FactorioModelClass CompileClass(FactorioRuntimeConceptSpecification concept) =>
        new()
        {
            Name = concept.Name.ToPascalCase(),
            LuaName = concept.Name,
            Documentation = new FactorioModelDocumentation
            {
                Summary = concept.Description
            },
            IsFactorioConcept = true
        };

    FactorioModelEnum CompileEnum(FactorioRuntimeDefinitionSpecification definition) =>
        new()
        {
            Name = definition.Name.ToPascalCase(),
            LuaName = definition.Name,
            Documentation = new FactorioModelDocumentation { Summary = definition.Description },
            Values = definition.Values.OrderBy(v => v.Order).Select(CompileEnumValue).ToArray()
        };

    FactorioModelEnumValue CompileEnumValue(FactorioRuntimeDefinitionValueSpecification definitionValue) =>
        new()
        {
            Name = definitionValue.Name.ToPascalCase(),
            LuaName = definitionValue.Name,
            Documentation = new FactorioModelDocumentation { Summary = definitionValue.Description }
        };

    FactorioModelClassProperty CompileProperty(FactorioRuntimeAttributeSpecification attribute) =>
        new()
        {
            Name = attribute.Name.ToPascalCase(),
            LuaName = attribute.Name,
            Documentation = new FactorioModelDocumentation { Summary = attribute.Description },
            Type = BuildTypeName(attribute.Type),
            Optional = attribute.Optional,
            Read = attribute.Read,
            Write = attribute.Write
        };

    FactorioModelClassProperty CompileProperty(FactorioRuntimeOperatorSpecification op) =>
        new()
        {
            Name = op.Name switch
            {
                FactorioRuntimeOperatorName.Length => "Length",
                _ => throw new ArgumentOutOfRangeException(nameof(op.Name), op.Name, null)
            },
            LuaName = op.Name switch
            {
                FactorioRuntimeOperatorName.Length => "length",
                _ => throw new ArgumentOutOfRangeException(nameof(op.Name), op.Name, null)
            },
            Documentation = new FactorioModelDocumentation { Summary = op.Description },
            Type = BuildTypeName(op.Type),
            Optional = op.Optional,
            Read = op.Read,
            Write = op.Write
        };

    FactorioModelClassOperator CompileOperator(FactorioRuntimeOperatorSpecification op) =>
        new()
        {
            OperatorType = op.Name switch
            {
                FactorioRuntimeOperatorName.Index => FactorioModelClassOperatorType.Indexer,
                FactorioRuntimeOperatorName.Call => FactorioModelClassOperatorType.Call,
                _ => throw new ArgumentOutOfRangeException(nameof(op.Name), op.Name, null)
            },
            Documentation = new FactorioModelDocumentation { Summary = op.Description },
            KeyType = "uint",
            ReturnType = BuildTypeName(op.Type),
            Optional = op.Optional,
            Read = op.Read,
            Write = op.Write
        };

    FactorioModelClassMethod CompileMethod(FactorioRuntimeMethodSpecification method) =>
        new()
        {
            Name = method.Name.ToPascalCase(),
            LuaName = method.Name,
            Documentation = new FactorioModelDocumentation
            {
                Summary = method.Description, Remarks = string.Join(Environment.NewLine, method.Notes)
            },
            Parameters = method.Parameters.OrderBy(p => p.Order).Select(CompileParameter).ToArray(),
            ReturnType = BuildReturnType(method.ReturnValues.OrderBy(v => v.Order).ToArray())
        };

    FactorioModelClassMethodParameter CompileParameter(FactorioRuntimeParameterSpecification parameter) =>
        new()
        {
            Name = parameter.Name.ToCamelCase(),
            LuaName = parameter.Name,
            Type = BuildTypeName(parameter.Type),
            Optional = parameter.Optional
        };

    static string? BuildExamples(string[] examples)
    {
        switch (examples.Length)
        {
            case 0:
                return null;
            case 1:
                return examples[0];
            default:
                StringBuilder result = new();
                result.Append("<list type=\"bullet\">");
                foreach (string example in examples)
                {
                    result.Append($"  <item>{example}</item>");
                }
                result.Append("</list>");

                return result.ToString();
        }

    }

    string BuildTypeName(FactorioRuntimeTypeSpecification type, bool optional)
    {
        string typeName = BuildTypeName(type);
        return optional ? $"{typeName}?" : typeName;
    }

    string BuildTypeName(FactorioRuntimeTypeSpecification? type)
    {
        switch (type)
        {
            case null:
                return "void";
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

                        return simpleType.Name.ToPascalCase();
                }
            case FactorioRuntimeStructTypeSpecification structType:
                return "Struct";
            case FactorioRuntimeArrayTypeSpecification arrayType:
                return $"{BuildTypeName(arrayType.Value)}[]";
            case FactorioRuntimeFunctionTypeSpecification functionType:
                return $"Action<{string.Join(", ", functionType.Parameters.Select(BuildTypeName))}>";
            case FactorioRuntimeLiteralTypeSpecification literalType:
                return "Literal";
            case FactorioRuntimeTableTypeSpecification tableType:
                return $"LuaTable<{string.Join(", ", tableType.Parameters.OrderBy(p => p.Order).Select(p => BuildTypeName(p.Type, p.Optional)))}>";
            case FactorioRuntimeTupleTypeSpecification tupleType:
                return $"({string.Join(", ", tupleType.Parameters.OrderBy(p => p.Order).Select(p => BuildTypeName(p.Type, p.Optional)))})";
            case FactorioRuntimeUnionTypeSpecification unionType:
                return $"LuaUnion<{string.Join(", ", unionType.Options.Select(BuildTypeName))}>";
            case FactorioRuntimeKeyValueTypeSpecification keyValueType:
                return keyValueType.Name switch
                {
                    "dictionary" => $"Dictionary<{BuildTypeName(keyValueType.Key)}, {BuildTypeName(keyValueType.Value)}>",
                    _ => $"{keyValueType.Name.ToPascalCase()}<{BuildTypeName(keyValueType.Key)}, {BuildTypeName(keyValueType.Value)}>"
                };
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }
    }

    string? BuildReturnType(FactorioRuntimeMethodReturnValueSpecification[] returnValues)
    {
        switch (returnValues.Length)
        {
            case 0:
                return null;
            case 1:
                return BuildTypeName(returnValues[0].Type, returnValues[0].Optional);
            default:
                return $"({string.Join(", ", returnValues.Select(p => BuildTypeName(p.Type, p.Optional)))})";
        }
    }
}
