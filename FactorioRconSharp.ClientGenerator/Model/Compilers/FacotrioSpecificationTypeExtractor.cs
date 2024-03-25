using FactorioRconSharp.ClientGenerator.Specification;

namespace FactorioRconSharp.ClientGenerator.Model.Compilers;

public static class FacotrioSpecificationTypeExtractor
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

    public static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeClassSpecification cls) => cls.Attributes.SelectMany(ExtractTypes);

    public static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeConceptSpecification concept)
    {
        yield return concept.Type;

        foreach (FactorioRuntimeTypeSpecification type in ExtractTypes(concept.Type))
        {
            yield return type;
        }
    }

    static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeAttributeSpecification attribute)
    {
        yield return attribute.Type;

        foreach (FactorioRuntimeTypeSpecification type in ExtractTypes(attribute.Type))
        {
            yield return type;
        }
    }

    static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(FactorioRuntimeTypeSpecification type)
    {
        switch (type)
        {
            case FactorioRuntimeSimpleTypeSpecification simpleType:
                break;
            case FactorioRuntimeKeyValueTypeSpecification keyValueType:
                yield return keyValueType.Key;

                foreach (FactorioRuntimeTypeSpecification keyType in ExtractTypes(keyValueType.Key))
                {
                    yield return keyType;
                }

                yield return keyValueType.Value;

                foreach (FactorioRuntimeTypeSpecification valueType in ExtractTypes(keyValueType.Value))
                {
                    yield return valueType;
                }

                break;
            case FactorioRuntimeArrayTypeSpecification arrayType:
                yield return arrayType.Value;

                foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(arrayType.Value))
                {
                    yield return elementType;
                }

                break;
            case FactorioRuntimeFunctionTypeSpecification functionType:
                foreach (FactorioRuntimeTypeSpecification parameter in functionType.Parameters)
                {
                    yield return parameter;

                    foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(parameter))
                    {
                        yield return elementType;
                    }
                }

                break;
            case FactorioRuntimeLiteralTypeSpecification literalType:
                break;
            case FactorioRuntimeTableTypeSpecification tableType:
                foreach (FactorioRuntimeParameterSpecification parameter in tableType.Parameters)
                {
                    yield return parameter.Type;

                    foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(parameter.Type))
                    {
                        yield return elementType;
                    }
                }

                foreach (FactorioRuntimeTableVariantParameterGroupsSpecification group in tableType.VariantParameterGroups)
                {
                    foreach (FactorioRuntimeParameterSpecification parameter in group.Parameters)
                    {
                        yield return parameter.Type;

                        foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(parameter.Type))
                        {
                            yield return elementType;
                        }
                    }
                }

                break;
            case FactorioRuntimeTupleTypeSpecification tupleType:
                foreach (FactorioRuntimeParameterSpecification parameter in tupleType.Parameters)
                {
                    yield return parameter.Type;

                    foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(parameter.Type))
                    {
                        yield return elementType;
                    }
                }

                break;
            case FactorioRuntimeUnionTypeSpecification unionType:
                foreach (FactorioRuntimeTypeSpecification option in unionType.Options)
                {
                    yield return option;

                    foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(option))
                    {
                        yield return elementType;
                    }
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
