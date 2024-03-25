using FactorioRconSharp.ClientGenerator.Specification;

namespace FactorioRconSharp.ClientGenerator.Model.Compilers;

public static class FacotrioSpecificationTypeExtractor
{
    public static IEnumerable<FactorioRuntimeTypeSpecification> ExtractTypes(this FactorioRuntimeApiSpecification specification)
    {
        foreach (FactorioRuntimeClassSpecification cls in specification.Classes)
        {
            foreach (FactorioRuntimeAttributeSpecification attribute in cls.Attributes)
            {
                foreach (FactorioRuntimeTypeSpecification type in ExtractTypes(attribute))
                {
                    yield return type;
                }
            }
        }

        foreach (FactorioRuntimeConceptSpecification concept in specification.Concepts)
        {
            foreach (FactorioRuntimeTypeSpecification type in ExtractTypes(concept.Type))
            {
                yield return type;
            }
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
                foreach (FactorioRuntimeTypeSpecification keyType in ExtractTypes(keyValueType.Key))
                {
                    yield return keyType;
                }

                foreach (FactorioRuntimeTypeSpecification valueType in ExtractTypes(keyValueType.Value))
                {
                    yield return valueType;
                }

                break;
            case FactorioRuntimeArrayTypeSpecification arrayType:
                foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(arrayType.Value))
                {
                    yield return elementType;
                }

                break;
            case FactorioRuntimeFunctionTypeSpecification functionType:
                foreach (FactorioRuntimeTypeSpecification parameter in functionType.Parameters)
                {
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
                    foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(parameter.Type))
                    {
                        yield return elementType;
                    }
                }

                foreach (FactorioRuntimeTableVariantParameterGroupsSpecification group in tableType.VariantParameterGroups)
                {
                    foreach (FactorioRuntimeParameterSpecification parameter in group.Parameters)
                    {
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
                    foreach (FactorioRuntimeTypeSpecification elementType in ExtractTypes(parameter.Type))
                    {
                        yield return elementType;
                    }
                }

                break;
            case FactorioRuntimeUnionTypeSpecification unionType:
                foreach (FactorioRuntimeTypeSpecification option in unionType.Options)
                {
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
