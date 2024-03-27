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

        IEnumerable<FactorioRuntimeTypeSpecification> types = FactorioSpecificationTypeExtractor.ExtractTypes(cls);
        IEnumerable<FactorioModelTopLevelStatement> statementsFromNestedTypes = types.SelectMany(CompileType);

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
            Statements = new[] { CompileClass(cls) }.Concat(statementsFromNestedTypes).ToArray()
        };
    }

    public FactorioModelFile CompileConceptFile(string conceptName)
    {
        FactorioRuntimeConceptSpecification? concept = _specification.Concepts.SingleOrDefault(c => c.Name == conceptName);
        if (concept == null)
        {
            throw new InvalidOperationException($"Could not find specification of concept {conceptName}");
        }

        IEnumerable<FactorioRuntimeTypeSpecification> types = FactorioSpecificationTypeExtractor.ExtractTypes(concept);
        IEnumerable<FactorioModelTopLevelStatement> nestedSymbols = types.SelectMany(CompileType);

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
            Statements = new[] { CompileConcept(concept) }.Concat(nestedSymbols).ToArray()
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
            Statements = CompileDefinition(definition).ToArray<FactorioModelTopLevelStatement>()
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
            BaseClass = "LuaObject",
            IsFactorioClass = true,
            Properties = cls.Attributes.OrderBy(a => a.Order)
                .Select(CompileProperty)
                .Concat(cls.Operators.Where(o => o.Name != FactorioRuntimeOperatorName.Index).Select(CompileProperty))
                .ToArray(),
            Operators = cls.Operators.OrderBy(o => o.Order).Where(o => o.Name == FactorioRuntimeOperatorName.Index).Select(CompileOperator).ToArray(),
            Methods = cls.Methods.OrderBy(m => m.Order).Select(CompileMethod).ToArray()
        };

    FactorioModelTopLevelStatement CompileConcept(FactorioRuntimeConceptSpecification concept)
    {
        FactorioModelTopLevelStatement symbol;
        switch (concept.Type)
        {
            case FactorioRuntimeSimpleTypeSpecification:
            case FactorioRuntimeArrayTypeSpecification:
            case FactorioRuntimeFunctionTypeSpecification:
            case FactorioRuntimeKeyValueTypeSpecification:
                symbol = new FactorioModelClass
                {
                    Name = "",
                    BaseClass = BuildTypeName(concept.Type)
                };
                break;
            case FactorioRuntimeLiteralTypeSpecification literalType:
                symbol = CompileLiteralType(literalType);
                break;
            case FactorioRuntimeStructTypeSpecification structType:
                symbol = CompileStructType(structType);
                break;
            case FactorioRuntimeTableTypeSpecification tableType:
                symbol = CompileTableType(tableType);
                break;
            case FactorioRuntimeTupleTypeSpecification tupleType:
                symbol = CompileTupleType(tupleType);
                break;
            case FactorioRuntimeUnionTypeSpecification unionType:
                symbol = CompileUnionType(unionType);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        symbol.Name = concept.Name.ToPascalCase();
        symbol.LuaName = concept.Name;
        symbol.Documentation = new FactorioModelDocumentation
        {
            Summary = concept.Description
        };
        symbol.IsFactorioConcept = true;

        return symbol;
    }

    IEnumerable<FactorioModelEnum> CompileDefinition(FactorioRuntimeDefinitionSpecification definition, string namePrefix = "", string luaNamePrefix = "")
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
        }.Concat(definition.Subkeys.SelectMany(def => CompileDefinition(def, enumName, $"{luaName}.")));
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

    FactorioModelEnum CompileLiteralType(FactorioRuntimeLiteralTypeSpecification literalType)
    {
        string name = $"Literal{literalType.GetHashCode()}";
        string valueName = literalType.Value.ToString() ?? "value";

        return new FactorioModelEnum
        {
            Name = name,
            Documentation = new FactorioModelDocumentation { Summary = $"Literal value: {literalType.Value}" },
            Values = new[]
            {
                new FactorioModelEnumValue
                    { Name = valueName.ToPascalCase(), LuaName = valueName, Documentation = new FactorioModelDocumentation { Summary = $"Literal value: {literalType.Value}" } }
            }
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

    FactorioModelClass CompileTupleType(FactorioRuntimeTupleTypeSpecification tupleType)
    {
        string name = $"Tuple{tupleType.GetHashCode()}";
        return new FactorioModelClass
        {
            Name = name,
            Properties = tupleType.Parameters.OrderBy(p => p.Order).Select(CompileProperty).ToArray()
        };
    }

    FactorioModelClass CompileUnionType(FactorioRuntimeUnionTypeSpecification unionType)
    {
        string name = $"Union{unionType.GetHashCode()}";
        return new FactorioModelClass
        {
            Name = name,
            BaseClass = $"OneOfBase<{string.Join(", ", unionType.Options.Select(BuildTypeName))}>",
            Attributes = ["GenerateOneOf"],
            IsPartial = true
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
                        return "string";

                    case "float":
                        return "float";
                    case "double":
                    case "number":
                        return "double";

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
                return $"List<{BuildTypeName(arrayType.Value)}>";
            case FactorioRuntimeFunctionTypeSpecification functionType:
                return functionType.Parameters.Length > 0 ? $"Action<{string.Join(", ", functionType.Parameters.Select(BuildTypeName))}>" : "Action";
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
            case FactorioRuntimeTupleTypeSpecification tupleType:
                return $"Tuple{tupleType.GetHashCode()}";
            case FactorioRuntimeUnionTypeSpecification unionType:
                return $"Union{unionType.GetHashCode()}";
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

    IEnumerable<FactorioModelTopLevelStatement> CompileType(FactorioRuntimeTypeSpecification type)
    {
        switch (type)
        {
            case FactorioRuntimeLiteralTypeSpecification literalType:
                yield return CompileLiteralType(literalType);
                break;
            case FactorioRuntimeStructTypeSpecification structType:
                yield return CompileStructType(structType);
                break;
            case FactorioRuntimeTableTypeSpecification tableType:
                yield return CompileTableType(tableType);
                break;
            case FactorioRuntimeTupleTypeSpecification tupleType:
                yield return CompileTupleType(tupleType);
                break;
            case FactorioRuntimeUnionTypeSpecification unionType:
                yield return CompileUnionType(unionType);
                break;
        }
    }
}
