using System.Text;
using CaseExtensions;
using FactorioRconSharp.ClientGenerator.Specification;

namespace FactorioRconSharp.ClientGenerator.Model.Compilers;

public class FactorioModelFileCompiler
{
    readonly FactorioRuntimeApiSpecification _specification;
    readonly Dictionary<int, FactorioModelClass> _anonymousTypes = new();

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

        List<FactorioModelClass> nestedClasses = new();

        foreach (FactorioRuntimeTypeSpecification type in FacotrioSpecificationTypeExtractor.ExtractTypes(cls))
        {
            switch (type)
            {
                case FactorioRuntimeLiteralTypeSpecification literalType:
                    FactorioModelClass compiledLiteralType = CompileLiteralType(literalType);
                    _anonymousTypes[literalType.GetHashCode()] = compiledLiteralType;
                    nestedClasses.Add(compiledLiteralType);
                    break;
                case FactorioRuntimeStructTypeSpecification structType:
                    FactorioModelClass compiledStructType = CompileStructType(structType);
                    _anonymousTypes[structType.GetHashCode()] = compiledStructType;
                    nestedClasses.Add(compiledStructType);
                    break;
                case FactorioRuntimeTableTypeSpecification tableType:
                    FactorioModelClass compiledTableType = CompileTableType(tableType);
                    _anonymousTypes[tableType.GetHashCode()] = compiledTableType;
                    nestedClasses.Add(compiledTableType);
                    break;
            }
        }

        return new FactorioModelFile
        {
            Name = cls.Name.ToPascalCase(),
            Namespace = "FactorioRconSharp.Model.Classes",
            Usings =
            [
                "FactorioRconSharp.Model.Builtins",
                "FactorioRconSharp.Model.Concepts",
                "FactorioRconSharp.Model.Definitions",
                "OneOf"
            ],
            Classes = new[] { CompileClasses(cls) }.Concat(nestedClasses).ToArray()
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
                "FactorioRconSharp.Model.Definitions",
                "OneOf"
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
            Name = $"{definition.Name.ToPascalCase()}Enum",
            Namespace = "FactorioRconSharp.Model.Definitions",
            Usings =
            [
                "FactorioRconSharp.Model.Builtins",
                "FactorioRconSharp.Model.Classes",
                "FactorioRconSharp.Model.Concepts"
            ],
            Enums = CompileEnums(definition)
        };
    }

    FactorioModelClass CompileClasses(FactorioRuntimeClassSpecification cls) =>
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
                .Concat(cls.Operators.Where(o => o.Name != FactorioRuntimeOperatorName.Index).Select(CompileProperty))
                .ToArray(),
            Operators = cls.Operators.OrderBy(o => o.Order).Where(o => o.Name == FactorioRuntimeOperatorName.Index).Select(CompileOperator).ToArray(),
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

    FactorioModelEnum[] CompileEnums(FactorioRuntimeDefinitionSpecification definition, string namePrefix = "", string luaNamePrefix = "")
    {
        string enumName = $"{namePrefix}{definition.Name.ToPascalCase()}";
        string luaName = $"{luaNamePrefix}{definition.Name}";

        return new[]
            {
                new FactorioModelEnum
                {
                    Name = $"{enumName}Enum",
                    LuaName = luaName,
                    Documentation = new FactorioModelDocumentation { Summary = definition.Description },
                    Values = definition.Values.OrderBy(v => v.Order).Select(CompileEnumValue).ToArray()
                }
            }.Concat(definition.Subkeys.SelectMany(def => CompileEnums(def, enumName, $"{luaName}.")))
            .ToArray();
    }

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
                FactorioRuntimeOperatorName.Call => "Call",
                _ => throw new ArgumentOutOfRangeException(nameof(op.Name), op.Name, null)
            },
            LuaName = op.Name switch
            {
                FactorioRuntimeOperatorName.Length => "length",
                FactorioRuntimeOperatorName.Call => "call",
                _ => throw new ArgumentOutOfRangeException(nameof(op.Name), op.Name, null)
            },
            Documentation = new FactorioModelDocumentation { Summary = op.Description },
            Type = BuildTypeName(op.Type),
            Optional = op.Optional,
            Read = op.Read,
            Write = op.Write
        };

    FactorioModelClassProperty CompileProperty(FactorioRuntimeParameterSpecification parameter) =>
        new()
        {
            Name = parameter.Name.ToPascalCase(),
            LuaName = parameter.Name,
            Documentation = new FactorioModelDocumentation { Summary = parameter.Description },
            Type = BuildTypeName(parameter.Type),
            Optional = parameter.Optional,
            Read = true,
            Write = true
        };

    FactorioModelClassOperator CompileOperator(FactorioRuntimeOperatorSpecification op) =>
        new()
        {
            OperatorType = op.Name switch
            {
                FactorioRuntimeOperatorName.Index => FactorioModelClassOperatorType.Indexer,
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
            Name = EscapeSharpKeyword(parameter.Name.ToCamelCase()),
            LuaName = parameter.Name,
            Type = BuildTypeName(parameter.Type),
            Optional = parameter.Optional
        };

    FactorioModelClass CompileLiteralType(FactorioRuntimeLiteralTypeSpecification literalType)
    {
        string name = $"Literal{literalType.GetHashCode()}";
        return new FactorioModelClass
        {
            Name = name,
            Documentation = new FactorioModelDocumentation { Summary = $"Literal value: {literalType.Value}" },
            Properties =
            [
                new FactorioModelClassProperty
                {
                    Name = "Value",
                    LuaName = literalType.Value.ToString() ?? "",
                    Documentation = new FactorioModelDocumentation { Summary = $"Literal value: {literalType.Value}" },
                    Type = "object",
                    IsStatic = true,
                    Optional = false,
                    Read = true,
                    Write = false
                }
            ]
        };
    }

    FactorioModelClass CompileStructType(FactorioRuntimeStructTypeSpecification structType)
    {
        string name = $"Struct{structType.GetHashCode()}";
        return new FactorioModelClass
        {
            Name = name,
            Properties = structType.Attributes.OrderBy(a => a.Order).Select(CompileProperty).ToArray()
        };
    }

    FactorioModelClass CompileTableType(FactorioRuntimeTableTypeSpecification tableType)
    {
        string name = $"Table{tableType.GetHashCode()}";
        return new FactorioModelClass
        {
            Name = name,
            Properties = tableType.Parameters.OrderBy(p => p.Order).Select(CompileProperty).ToArray()
        };
    }

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
                    case "float":
                    case "double":
                        return simpleType.Name;

                    case "boolean":
                        return "bool";

                    case "int8":
                        return "sbyte";
                    case "int16":
                        return "short";
                    case "int":
                        return "int";
                    case "int64":
                        return "long";

                    case "uint8":
                        return "byte";
                    case "uint16":
                        return "ushort";
                    case "uint":
                        return "uint";
                    case "uint64":
                        return "ulong";

                    case "nil":
                        return "LuaNil";
                    case "table":
                        return "LuaTable";

                    default:
                        string name = simpleType.Name;

                        if (name.StartsWith("defines."))
                        {
                            name = $"{name[8..]}Enum";
                        }

                        return name.Replace('.', '_').ToPascalCase();
                }
            case FactorioRuntimeArrayTypeSpecification arrayType:
                return $"{BuildTypeName(arrayType.Value)}[]";
            case FactorioRuntimeFunctionTypeSpecification functionType:
                return functionType.Parameters.Length > 0 ? $"Action<{string.Join(", ", functionType.Parameters.Select(BuildTypeName))}>" : "Action";
            case FactorioRuntimeTupleTypeSpecification tupleType:
                return $"({string.Join(", ", tupleType.Parameters.OrderBy(p => p.Order).Select(p => BuildTypeName(p.Type, p.Optional)))})";
            case FactorioRuntimeUnionTypeSpecification unionType:
                return $"OneOf<{string.Join(", ", unionType.Options.Select(BuildTypeName))}>";
            case FactorioRuntimeKeyValueTypeSpecification keyValueType:
                return keyValueType.Name switch
                {
                    "dictionary" => $"Dictionary<{BuildTypeName(keyValueType.Key)}, {BuildTypeName(keyValueType.Value)}>",
                    _ => $"{keyValueType.Name.ToPascalCase()}<{BuildTypeName(keyValueType.Key)}, {BuildTypeName(keyValueType.Value)}>"
                };
            case FactorioRuntimeLiteralTypeSpecification literalType:
                return $"Literal{literalType.GetHashCode()}";
            case FactorioRuntimeStructTypeSpecification structType:
                return $"Struct{structType.GetHashCode()}";
            case FactorioRuntimeTableTypeSpecification tableType:
                return $"Table{tableType.GetHashCode()}";
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

    string EscapeSharpKeyword(string symbol)
    {
        switch (symbol)
        {
            case "event":
            case "string":
            case "interface":
                return $"@{symbol}";
            default:
                return symbol;
        }
    }
}
