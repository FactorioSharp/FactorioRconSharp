using SpecificationCompiler.Specification;

namespace SpecificationCompiler.Compilation;

public static class FactorioSpecificationTypeExtractor
{
    public static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(this FactorioRuntimeApiSpecification specification)
    {
        foreach (FactorioRuntimeClassSpecification cls in specification.Classes)
        {
            foreach (FactorioRuntimeTypeSpecification factorioRuntimeTypeSpecification in ExtractTypes(cls))
            {
                yield return factorioRuntimeTypeSpecification;
            }
        }

        foreach (FactorioRuntimeConceptSpecification concept in specification.Concepts)
        {
            foreach (FactorioRuntimeTypeSpecification factorioRuntimeTypeSpecification1 in ExtractTypes(concept))
            {
                yield return factorioRuntimeTypeSpecification1;
            }
        }
    }

    public static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeClassSpecification cls) =>
        cls.Attributes.SelectMany(ExtractTypes).Concat(cls.Operators.SelectMany(ExtractTypes)).Concat(cls.Methods.SelectMany(ExtractTypes));

    public static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeConceptSpecification concept)
    {
        foreach (FactorioRuntimeTypeSpecification type in ExtractTypes(concept.Type))
        {
            yield return type;
        }
    }

    static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeOperatorSpecification op)
    {
        if (op.Type == null)
        {
            yield break;
        }

        foreach (FactorioRuntimeTypeSpecification type in ExtractTypes(op.Type))
        {
            yield return type;
        }

        yield return op.Type;
    }

    public static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeMethodSpecification method) =>
        method.Parameters.SelectMany(ExtractTypes).Concat(method.ReturnValues.SelectMany(ExtractTypes));

    static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeParameterSpecification parameter)
    {
        foreach (FactorioRuntimeTypeSpecification type in ExtractTypes(parameter.Type))
        {
            yield return type;
        }

        yield return parameter.Type;
    }

    static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeMethodReturnValueSpecification returnValue)
    {
        foreach (FactorioRuntimeTypeSpecification type in ExtractTypes(returnValue.Type))
        {
            yield return type;
        }

        yield return returnValue.Type;
    }

    static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeAttributeSpecification attribute)
    {
        foreach (FactorioRuntimeTypeSpecification type in ExtractTypes(attribute.Type))
        {
            yield return type;
        }

        yield return attribute.Type;
    }

    public static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeTypeSpecification type)
    {
        switch (type)
        {
            case FactorioRuntimeSimpleTypeSpecification simpleType:
                break;
            case FactorioRuntimeKeyValueTypeSpecification keyValueType:

                foreach (FactorioRuntimeTypeSpecification keyType in ExtractTypes(keyValueType.Key))
                {
                    yield return keyType;
                }

                yield return keyValueType.Key;

                foreach (FactorioRuntimeTypeSpecification valueType in ExtractTypes(keyValueType.Value))
                {
                    yield return valueType;
                }

                yield return keyValueType.Value;

                break;
            case FactorioRuntimeArrayTypeSpecification arrayType:
                foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(arrayType.Value))
                {
                    yield return elementType;
                }

                yield return arrayType.Value;

                break;
            case FactorioRuntimeFunctionTypeSpecification functionType:
                foreach (FactorioRuntimeTypeSpecification parameter in functionType.Parameters)
                {
                    foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(parameter))
                    {
                        yield return elementType;
                    }

                    yield return parameter;
                }

                break;
            case FactorioRuntimeLiteralTypeSpecification literalType:
                break;
            case FactorioRuntimeTableTypeSpecification tableType:
                foreach (FactorioRuntimeParameterSpecification parameter in tableType.Parameters)
                {
                    foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(parameter.Type))
                    {
                        yield return elementType;
                    }

                    yield return parameter.Type;
                }

                foreach (FactorioRuntimeTableVariantParameterGroupsSpecification group in tableType.VariantParameterGroups)
                {
                    foreach (FactorioRuntimeParameterSpecification parameter in group.Parameters)
                    {
                        foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(parameter.Type))
                        {
                            yield return elementType;
                        }

                        yield return parameter.Type;
                    }
                }

                break;
            case FactorioRuntimeTupleTypeSpecification tupleType:
                foreach (FactorioRuntimeParameterSpecification parameter in tupleType.Parameters)
                {
                    foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(parameter.Type))
                    {
                        yield return elementType;
                    }

                    yield return parameter.Type;
                }

                break;
            case FactorioRuntimeUnionTypeSpecification unionType:
                if (unionType.IsUnionOfLiterals(out _))
                {
                    // in this case, the inner literals should not be considered as individual types
                    break;
                }

                foreach (FactorioRuntimeTypeSpecification option in unionType.Options)
                {
                    foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(option))
                    {
                        yield return elementType;
                    }

                    yield return option;
                }

                break;
            case FactorioRuntimeStructTypeSpecification structType:
                foreach (FactorioRuntimeAttributeSpecification attribute in structType.Attributes)
                {
                    foreach (FactorioRuntimeTypeSpecification attributeType in ExtractTypes(attribute))
                    {
                        yield return attributeType;
                    }
                }

                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type));

        }
    }
}
