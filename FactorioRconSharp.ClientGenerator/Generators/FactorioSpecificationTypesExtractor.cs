using FactorioRconSharp.ClientGenerator.Specification;

namespace FactorioRconSharp.ClientGenerator.Generators;

static class FactorioSpecificationTypesExtractor
{
    public static IEnumerable<string> ExtractTypes(FactorioRuntimeApiSpecification specification)
    {
        foreach (FactorioRuntimeClassSpecification cls in specification.Classes)
        {
            yield return cls.Name;

            foreach (FactorioRuntimeAttributeSpecification attribute in cls.Attributes)
            {
                foreach (string p in ExtractTypes(attribute))
                {
                    yield return p;
                }
            }
        }

        foreach (FactorioRuntimeConceptSpecification concept in specification.Concepts)
        {
            yield return concept.Name;

            foreach (string type in ExtractTypes(concept.Type))
            {
                yield return type;
            }
        }
    }

    static IEnumerable<string> ExtractTypes(FactorioRuntimeAttributeSpecification attribute) => ExtractTypes(attribute.Type);

    static IEnumerable<string> ExtractTypes(FactorioRuntimeTypeSpecification type)
    {
        switch (type)
        {
            case FactorioRuntimeSimpleTypeSpecification simpleType:
                yield return simpleType.Name;
                break;
            case FactorioRuntimeKeyValueTypeSpecification keyValueType:
                foreach (string keyType in ExtractTypes(keyValueType.Key))
                {
                    yield return keyType;
                }

                foreach (string valueType in ExtractTypes(keyValueType.Value))
                {
                    yield return valueType;
                }

                break;
            case FactorioRuntimeArrayTypeSpecification arrayType:
                foreach (string elementType in ExtractTypes(arrayType.Value))
                {
                    yield return elementType;
                }

                break;
            case FactorioRuntimeFunctionTypeSpecification functionType:
                foreach (FactorioRuntimeTypeSpecification parameter in functionType.Parameters)
                {
                    foreach (string elementType in ExtractTypes(parameter))
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
                    foreach (string elementType in ExtractTypes(parameter.Type))
                    {
                        yield return elementType;
                    }
                }

                foreach (FactorioRuntimeTableVariantParameterGroupsSpecification group in tableType.VariantParameterGroups)
                {
                    foreach (FactorioRuntimeParameterSpecification parameter in group.Parameters)
                    {
                        foreach (string elementType in ExtractTypes(parameter.Type))
                        {
                            yield return elementType;
                        }
                    }
                }

                break;
            case FactorioRuntimeTupleTypeSpecification tupleType:
                foreach (FactorioRuntimeParameterSpecification parameter in tupleType.Parameters)
                {
                    foreach (string elementType in ExtractTypes(parameter.Type))
                    {
                        yield return elementType;
                    }
                }

                break;
            case FactorioRuntimeUnionTypeSpecification unionType:
                foreach (FactorioRuntimeTypeSpecification option in unionType.Options)
                {
                    foreach (string elementType in ExtractTypes(option))
                    {
                        yield return elementType;
                    }
                }

                break;
            case FactorioRuntimeStructTypeSpecification structType:
                foreach (FactorioRuntimeAttributeSpecification attribute in structType.Attributes)
                {
                    foreach (string attributeType in ExtractTypes(attribute))
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
