using System.Text;
using CaseExtensions;
using FactorioRconSharp.ClientGenerator.Model;
using FactorioRconSharp.ClientGenerator.Specification;

namespace FactorioRconSharp.ClientGenerator.Compilation;

public class FactorioModelFileCompiler
{
    readonly FactorioRuntimeApiSpecification _specification;
    readonly Dictionary<int, string> _anonymousTypeNames = new();

    public FactorioModelFileCompiler(FactorioRuntimeApiSpecification specification)
    {
        _specification = specification;
    }

    public FactorioModelClass CompileClassFile(string clsName)
    {
        FactorioRuntimeClassSpecification? cls = _specification.Classes.SingleOrDefault(c => c.Name == clsName);
        if (cls == null)
        {
            throw new InvalidOperationException($"Could not find specification of class {clsName}");
        }

        return CompileClass(cls);
    }

    public FactorioModelTopLevelStatement CompileConceptFile(string conceptName)
    {
        FactorioRuntimeConceptSpecification? concept = _specification.Concepts.SingleOrDefault(c => c.Name == conceptName);
        if (concept == null)
        {
            throw new InvalidOperationException($"Could not find specification of concept {conceptName}");
        }

        return CompileConcept(concept);
    }

    public IEnumerable<FactorioModelEnum> CompileDefinitionFile(string definitionName)
    {
        FactorioRuntimeDefinitionSpecification? definition = _specification.Defines.SingleOrDefault(c => c.Name == definitionName);
        if (definition == null)
        {
            throw new InvalidOperationException($"Could not find specification of definition {definitionName}");
        }

        return CompileDefinition(definition);
    }

    FactorioModelClass CompileClass(FactorioRuntimeClassSpecification cls) =>
        new()
        {
            Name = ReplaceInvalidIdentifierCharacters(cls.Name).ToPascalCase(),
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

        symbol.Name = ReplaceInvalidIdentifierCharacters(concept.Name).ToPascalCase();
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
        string enumName = $"{namePrefix}{ReplaceInvalidIdentifierCharacters(definition.Name).ToPascalCase()}";
        string luaName = $"{luaNamePrefix}{definition.Name}";

        return new[]
        {
            new FactorioModelEnum
            {
                Name = $"{enumName}Enum",
                LuaName = luaName,
                Documentation = new FactorioModelDocumentation { Summary = definition.Description },
                Values = definition.Values.OrderBy(v => v.Order)
                    .Select(CompileEnumValue)
                    .GroupBy(v => v.Name)
                    .Select(
                        g => g.Count() == 1
                            ? g.First()
                            : new FactorioModelEnumValue
                            {
                                Name = g.Key,
                                LuaName = g.First().LuaName,
                                Documentation = new FactorioModelDocumentation { Summary = string.Join(Environment.NewLine, g.Select(v => v.Documentation?.Summary)) }
                            }
                    )
                    .ToArray()
            }
        }.Concat(definition.Subkeys.SelectMany(def => CompileDefinition(def, enumName, $"{luaName}.")));
    }

    FactorioModelEnumValue CompileEnumValue(FactorioRuntimeDefinitionValueSpecification definitionValue) =>
        new()
        {
            Name = ReplaceInvalidIdentifierCharacters(definitionValue.Name).ToPascalCase(),
            LuaName = definitionValue.Name,
            Documentation = new FactorioModelDocumentation { Summary = definitionValue.Description }
        };

    FactorioModelClassProperty CompileProperty(FactorioRuntimeAttributeSpecification attribute) =>
        new()
        {
            Name = ReplaceInvalidIdentifierCharacters(attribute.Name).ToPascalCase(),
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
            Name = ReplaceInvalidIdentifierCharacters(parameter.Name).ToPascalCase(),
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
            Name = ReplaceInvalidIdentifierCharacters(method.Name).ToPascalCase(),
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

                        return ReplaceInvalidIdentifierCharacters(name).Replace('.', '_').ToPascalCase();
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
            case FactorioRuntimeLiteralTypeSpecification:
            case FactorioRuntimeStructTypeSpecification:
            case FactorioRuntimeTableTypeSpecification:
            case FactorioRuntimeTupleTypeSpecification:
            case FactorioRuntimeUnionTypeSpecification:
                int typeId = GetTypeId(type);
                return _anonymousTypeNames.GetValueOrDefault(typeId)
                       ?? throw new InvalidOperationException(
                           $"Could not find name of anonymous type {typeId}. Make sure you compile the anonymous types before compiling the symbols that use them."
                       );
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

    string ReplaceInvalidIdentifierCharacters(string str) =>
        str.Replace("+", "add")
            .Replace("-", "subtract")
            .Replace("*", "multiply")
            .Replace("/", "divide")
            .Replace(">=", "ge")
            .Replace("≥", "ge")
            .Replace(">>", "lsr")
            .Replace(">", "gt")
            .Replace("<=", "le")
            .Replace("≤", "le")
            .Replace("<<", "lsl")
            .Replace("<", "lt")
            .Replace("!=", "ne")
            .Replace("≠", "ne")
            .Replace("==", "eqeq")
            .Replace("=", "eq")
            .Replace("%", "percent")
            .Replace("^", "pow")
            .Replace("[1]", "first")
            .Replace("[2]", "second");

    public FactorioModelTopLevelStatement? CompileType(FactorioRuntimeTypeSpecification type)
    {
        FactorioModelTopLevelStatement result;
        switch (type)
        {
            case FactorioRuntimeSimpleTypeSpecification:
            case FactorioRuntimeArrayTypeSpecification:
            case FactorioRuntimeFunctionTypeSpecification:
            case FactorioRuntimeKeyValueTypeSpecification:
                return null;
            case FactorioRuntimeLiteralTypeSpecification literalType:
                result = CompileLiteralType(literalType);
                break;
            case FactorioRuntimeStructTypeSpecification structType:
                result = CompileStructType(structType);
                break;
            case FactorioRuntimeTableTypeSpecification tableType:
                result = CompileTableType(tableType);
                break;
            case FactorioRuntimeTupleTypeSpecification tupleType:
                result = CompileTupleType(tupleType);
                break;
            case FactorioRuntimeUnionTypeSpecification unionType:
                result = CompileUnionType(unionType);
                break;
            default:
                throw new NotSupportedException($"Cannot compile type into top-level statement {type.GetType()}");
        }

        _anonymousTypeNames[GetTypeId(type)] = result.Name;

        return result;
    }

    FactorioModelEnum CompileLiteralType(FactorioRuntimeLiteralTypeSpecification literalType)
    {
        string name = GenerateUniqueTypeName("Literal");

        return new FactorioModelEnum
        {
            Name = name,
            Documentation = new FactorioModelDocumentation { Summary = $"Literal value: {literalType.Value}" },
            Values = [CompileLiteralValue(literalType)]
        };
    }

    FactorioModelEnumValue CompileLiteralValue(FactorioRuntimeLiteralTypeSpecification literalType)
    {
        string valueName = literalType.Value.ToString() ?? "value";
        return new FactorioModelEnumValue
        {
            Name = ReplaceInvalidIdentifierCharacters(valueName).ToPascalCase(), LuaName = valueName,
            Documentation = new FactorioModelDocumentation { Summary = $"Literal value: {literalType.Value}" }
        };
    }

    FactorioModelClass CompileStructType(FactorioRuntimeStructTypeSpecification structType)
    {
        string name = GenerateUniqueTypeName("Struct");
        return new FactorioModelClass
        {
            Name = name,
            Properties = structType.Attributes.OrderBy(a => a.Order).Select(CompileProperty).ToArray()
        };
    }

    FactorioModelClass CompileTableType(FactorioRuntimeTableTypeSpecification tableType)
    {
        string name = GenerateUniqueTypeName("Table");
        return new FactorioModelClass
        {
            Name = name,
            Properties = tableType.Parameters.OrderBy(p => p.Order).Select(CompileProperty).ToArray()
        };
    }

    FactorioModelClass CompileTupleType(FactorioRuntimeTupleTypeSpecification tupleType)
    {
        string name = GenerateUniqueTypeName("Tuple");
        return new FactorioModelClass
        {
            Name = name,
            Properties = tupleType.Parameters.OrderBy(p => p.Order).Select(CompileProperty).ToArray()
        };
    }

    FactorioModelTopLevelStatement CompileUnionType(FactorioRuntimeUnionTypeSpecification unionType)
    {
        if (unionType.IsUnionOfLiterals(out FactorioRuntimeLiteralTypeSpecification[] literals))
        {
            return new FactorioModelEnum
            {
                Name = GenerateUniqueTypeName("Literals"),
                Documentation = new FactorioModelDocumentation { Summary = $"Union of literals:{string.Join("", literals.Select(l => $"{Environment.NewLine}  - {l.Value}"))}" },
                Values = literals.Select(CompileLiteralValue)
                    .GroupBy(v => v.Name)
                    .Select(
                        g => g.Count() == 1
                            ? g.First()
                            : new FactorioModelEnumValue
                            {
                                Name = g.Key,
                                LuaName = g.First().LuaName,
                                Documentation = new FactorioModelDocumentation { Summary = $"Literal value: {string.Join(", ", g.Select(v => v.LuaName))}" }
                            }
                    )
                    .ToArray()
            };
        }

        return new FactorioModelClass
        {
            Name = GenerateUniqueTypeName("Union"),
            BaseClass = $"OneOfBase<{string.Join(", ", unionType.Options.Select(BuildTypeName))}>",
            Attributes = ["GenerateOneOf"],
            IsPartial = true,
            RequireAdditionalUsing = ["OneOf"]
        };
    }

    static int GetTypeId(FactorioRuntimeTypeSpecification type) => type.GetHashCode();

    static string GenerateUniqueTypeName(string name) => $"{name}_{Guid.NewGuid():N}";
}
