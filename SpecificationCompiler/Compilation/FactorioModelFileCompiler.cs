using System.Text;
using CaseExtensions;
using SpecificationCompiler.Model;
using SpecificationCompiler.Specification;

namespace SpecificationCompiler.Compilation;

public class FactorioModelFileCompiler
{
    readonly FactorioRuntimeApiSpecification _specification;
    readonly Dictionary<int, string> _anonymousTypeNames = new();

    /// <summary>
    ///     Seeded random used to make anonymous type names uniques.
    ///     It needs to be seeded to avoid changing the names every time the generator is executed
    /// </summary>
    readonly Random _random = new("Compilation FTW".GetHashCode());

    public FactorioModelFileCompiler(FactorioRuntimeApiSpecification specification)
    {
        _specification = specification;
    }

    public FactorioModelClass CompileClassFile(string clsName, FactorioModelClass[] compiledBaseClasses)
    {
        FactorioRuntimeClassSpecification? cls = _specification.Classes.SingleOrDefault(c => c.Name == clsName);
        if (cls == null)
        {
            throw new InvalidOperationException($"Could not find specification of class {clsName}");
        }

        return CompileClass(cls, compiledBaseClasses);
    }

    public (FactorioModelTopLevelStatement CompiledConcept, IEnumerable<FactorioModelTopLevelStatement> AuxiliaryTypes) CompileConceptFile(string conceptName)
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

    public FactorioModelTopLevelStatement CompileGlobals() =>
        new FactorioModelClass
        {
            Name = "FactorioRconGlobals",
            Documentation = new FactorioModelDocumentation { Summary = "Objects and methods available globally in the Factorio console" },
            IsAbstract = true,
            Properties = _specification.GlobalObjects.Select(
                    o => new FactorioModelClassProperty
                    {
                        Name = SanitizeLuaName(o.Name),
                        LuaName = o.Name,
                        Documentation = new FactorioModelDocumentation { Summary = o.Description },
                        IsStatic = false,
                        Type = BuildTypeName(o.Type),
                        Optional = false,
                        Read = true,
                        Write = false
                    }
                )
                .ToArray(),
            Methods = _specification.GlobalFunctions.Select(CompileMethod).ToArray()
        };

    FactorioModelClass CompileClass(FactorioRuntimeClassSpecification cls, FactorioModelClass[] compiledBaseClasses)
    {
        string name = SanitizeLuaName(cls.Name);

        IEnumerable<FactorioRuntimeAttributeSpecification> attributesNotInBaseClasses =
            cls.Attributes.Where(a => compiledBaseClasses.SelectMany(c => c.Properties).All(p => p.LuaName != a.Name));
        FactorioModelClassProperty[] properties = attributesNotInBaseClasses.OrderBy(a => a.Order)
            .Select(a => CompileProperty(a, name))
            .Concat(cls.Operators.Where(o => o.Name != FactorioRuntimeOperatorName.Index).Select(CompileProperty))
            .ToArray();

        FactorioModelClassOperator[] operators = cls.Operators.OrderBy(o => o.Order).Where(o => o.Name == FactorioRuntimeOperatorName.Index).Select(CompileOperator).ToArray();

        IEnumerable<FactorioRuntimeMethodSpecification> methodsNotInBaseClasses =
            cls.Methods.Where(a => compiledBaseClasses.SelectMany(c => c.Methods).All(p => p.LuaName != a.Name));
        FactorioModelClassMethod[] methods = methodsNotInBaseClasses.OrderBy(m => m.Order).Select(CompileMethod).ToArray();

        return new FactorioModelClass
        {
            Name = name,
            LuaName = cls.Name,
            Documentation = new FactorioModelDocumentation
            {
                Summary = cls.Description, Examples = BuildExamples(cls.Examples)
            },
            BaseClass = cls.BaseClasses.Length == 0 ? "LuaObject" : cls.BaseClasses.First(),
            IsAbstract = operators.Length > 0 || methods.Length > 0 || compiledBaseClasses.Any(c => c.IsAbstract),
            IsFactorioClass = true,
            Properties = properties,
            Operators = operators,
            Methods = methods
        };
    }

    (FactorioModelTopLevelStatement CompiledConcept, IEnumerable<FactorioModelTopLevelStatement> AuxiliaryTypes) CompileConcept(FactorioRuntimeConceptSpecification concept)
    {
        string name = SanitizeLuaName(concept.Name);

        FactorioModelTopLevelStatement compiledConcept;
        IEnumerable<FactorioModelTopLevelStatement> auxiliaryTypes = Array.Empty<FactorioModelTopLevelStatement>();
        switch (concept.Type)
        {
            case FactorioRuntimeSimpleTypeSpecification:
            case FactorioRuntimeArrayTypeSpecification:
            case FactorioRuntimeFunctionTypeSpecification:
            case FactorioRuntimeKeyValueTypeSpecification:
                compiledConcept = new FactorioModelClass
                {
                    Name = name,
                    BaseClass = $"Alias<{BuildTypeName(concept.Type)}>"
                };
                break;
            case FactorioRuntimeLiteralTypeSpecification literalType:
                compiledConcept = CompileLiteralType(literalType, name);
                break;
            case FactorioRuntimeStructTypeSpecification structType:
                compiledConcept = CompileStructType(structType, name);
                break;
            case FactorioRuntimeTableTypeSpecification tableType:
                compiledConcept = CompileTableType(tableType, name);
                break;
            case FactorioRuntimeTupleTypeSpecification tupleType:
                compiledConcept = CompileTupleType(tupleType, name);
                break;
            case FactorioRuntimeUnionTypeSpecification unionType:
                (compiledConcept, auxiliaryTypes) = CompileUnionType(unionType, name);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        compiledConcept.Name = name;
        compiledConcept.LuaName = concept.Name;
        compiledConcept.Documentation = new FactorioModelDocumentation
        {
            Summary = concept.Description
        };
        compiledConcept.IsFactorioConcept = true;

        return (compiledConcept, auxiliaryTypes);
    }

    IEnumerable<FactorioModelEnum> CompileDefinition(FactorioRuntimeDefinitionSpecification definition, string namePrefix = "", string luaNamePrefix = "")
    {
        string enumName = $"{namePrefix}{SanitizeLuaName(definition.Name)}";
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
            Name = SanitizeLuaName(definitionValue.Name),
            LuaName = definitionValue.Name,
            Documentation = new FactorioModelDocumentation { Summary = definitionValue.Description }
        };

    FactorioModelClassProperty CompileProperty(FactorioRuntimeAttributeSpecification attribute, string className)
    {
        string name = SanitizeLuaName(attribute.Name);
        if (name == className)
        {
            name = $"{name}Prop";
        }

        return new FactorioModelClassProperty
        {
            Name = name,
            LuaName = attribute.Name,
            Documentation = new FactorioModelDocumentation { Summary = attribute.Description },
            Type = BuildTypeName(attribute.Type),
            Optional = attribute.Optional,
            Read = attribute.Read,
            Write = attribute.Write
        };
    }

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

    FactorioModelClassProperty CompileProperty(FactorioRuntimeParameterSpecification parameter, string className)
    {
        string name = SanitizeLuaName(parameter.Name);
        if (name == className)
        {
            name = $"{name}Prop";
        }

        return new FactorioModelClassProperty
        {
            Name = name,
            LuaName = parameter.Name,
            Documentation = new FactorioModelDocumentation { Summary = parameter.Description },
            Type = BuildTypeName(parameter.Type),
            Optional = parameter.Optional,
            Read = true,
            Write = true
        };
    }

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
            Name = SanitizeLuaName(method.Name),
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

                        return ReplaceInvalidSharpIdentifierCharacters(name.Replace('.', '_').ToPascalCase()).ToPascalCase();
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

    public IEnumerable<FactorioModelTopLevelStatement> CompileType(FactorioRuntimeTypeSpecification type)
    {
        FactorioModelTopLevelStatement[] result;
        switch (type)
        {
            case FactorioRuntimeSimpleTypeSpecification:
            case FactorioRuntimeArrayTypeSpecification:
            case FactorioRuntimeFunctionTypeSpecification:
            case FactorioRuntimeKeyValueTypeSpecification:
                return Enumerable.Empty<FactorioModelTopLevelStatement>();
            case FactorioRuntimeLiteralTypeSpecification literalType:
                result = [CompileLiteralType(literalType)];
                break;
            case FactorioRuntimeStructTypeSpecification structType:
                result = [CompileStructType(structType)];
                break;
            case FactorioRuntimeTableTypeSpecification tableType:
                result = [CompileTableType(tableType)];
                break;
            case FactorioRuntimeTupleTypeSpecification tupleType:
                result = [CompileTupleType(tupleType)];
                break;
            case FactorioRuntimeUnionTypeSpecification unionType:
                (FactorioModelTopLevelStatement compiledType, IEnumerable<FactorioModelTopLevelStatement> auxiliaryTypes) = CompileUnionType(unionType);
                result = new[] { compiledType }.Concat(auxiliaryTypes).ToArray();
                break;
            default:
                throw new NotSupportedException($"Cannot compile type into top-level statement {type.GetType()}");
        }

        _anonymousTypeNames[GetTypeId(type)] = result[0].Name;

        return result;
    }

    FactorioModelEnum CompileLiteralType(FactorioRuntimeLiteralTypeSpecification literalType, string? className = null)
    {
        string name = className ?? GenerateUniqueTypeName("Literal", literalType);

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
            Name = SanitizeLuaName(valueName), LuaName = valueName,
            Documentation = new FactorioModelDocumentation { Summary = $"Literal value: {literalType.Value}" }
        };
    }

    FactorioModelClass CompileStructType(FactorioRuntimeStructTypeSpecification structType, string? className = null)
    {
        string name = className ?? GenerateUniqueTypeName("Struct", structType);
        return new FactorioModelClass
        {
            Name = name,
            Properties = structType.Attributes.OrderBy(a => a.Order).Select(a => CompileProperty(a, name)).ToArray()
        };
    }

    FactorioModelClass CompileTableType(FactorioRuntimeTableTypeSpecification tableType, string? className = null)
    {
        string name = className ?? GenerateUniqueTypeName("Table", tableType);
        return new FactorioModelClass
        {
            Name = name,
            Properties = tableType.Parameters.OrderBy(p => p.Order).Select(p => CompileProperty(p, name)).ToArray()
        };
    }

    FactorioModelClass CompileTupleType(FactorioRuntimeTupleTypeSpecification tupleType, string? className = null)
    {
        string name = className ?? GenerateUniqueTypeName("Tuple", tupleType);
        return new FactorioModelClass
        {
            Name = name,
            Properties = tupleType.Parameters.OrderBy(p => p.Order).Select(p => CompileProperty(p, name)).ToArray()
        };
    }

    (FactorioModelTopLevelStatement, IEnumerable<FactorioModelTopLevelStatement>) CompileUnionType(FactorioRuntimeUnionTypeSpecification unionType, string? className = null)
    {
        if (unionType.IsUnionOfLiterals(out FactorioRuntimeLiteralTypeSpecification[] literals))
        {
            return (new FactorioModelEnum
            {
                Name = className ?? GenerateUniqueTypeName("Literals", unionType),
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
            }, []);
        }

        string unionClassName = GenerateUniqueTypeName("Union", unionType);

        const int maxUnionSize = 9;
        if (unionType.Options.Length <= maxUnionSize)
        {
            return (new FactorioModelClass
            {
                Name = unionClassName,
                BaseClass = $"OneOfBase<{string.Join(", ", unionType.Options.Select(BuildTypeName))}>",
                Attributes = ["GenerateOneOf"],
                IsPartial = true,
                RequireAdditionalUsing = ["OneOf"]
            }, []);
        }

        int numberOfAuxiliaries = (int)Math.Ceiling((float)unionType.Options.Length / maxUnionSize);
        List<FactorioModelTopLevelStatement> auxiliaries = new();
        for (int i = 0; i < numberOfAuxiliaries; i++)
        {
            IEnumerable<FactorioRuntimeTypeSpecification> options = unionType.Options.Skip(i * maxUnionSize).Take(maxUnionSize);
            auxiliaries.Add(
                new FactorioModelClass
                {
                    Name = $"{unionClassName}_{i}",
                    BaseClass = $"OneOfBase<{string.Join(", ", options.Select(BuildTypeName))}>",
                    Attributes = ["GenerateOneOf"],
                    IsPartial = true,
                    RequireAdditionalUsing = ["OneOf"]
                }
            );
        }

        return (new FactorioModelClass
        {
            Name = unionClassName,
            BaseClass = $"OneOfBase<{string.Join(", ", auxiliaries.Select(a => a.Name))}>",
            Attributes = ["GenerateOneOf"],
            IsPartial = true,
            RequireAdditionalUsing = ["OneOf"]
        }, auxiliaries);
    }

    static int GetTypeId(FactorioRuntimeTypeSpecification type) => type.GetHashCode();

    string GenerateUniqueTypeName(string name, FactorioRuntimeTypeSpecification _) => $"{name}{Math.Abs(_random.Next(0, int.MaxValue))}";

    static string ToPascalCase(string str) =>
        str switch
        {
            "-" => "-",
            _ => str.ToPascalCase()
        };

    static string EscapeSharpKeyword(string symbol)
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

    static string ReplaceInvalidSharpIdentifierCharacters(string str) =>
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

    static string SanitizeLuaName(string name) => ReplaceInvalidSharpIdentifierCharacters(ToPascalCase(name)).ToPascalCase();
}
