using System.Text.Json;
using System.Text.Json.Serialization;
using FactorioRconSharp.ClientGenerator.Specification;

namespace FactorioRconSharp.ClientGenerator.Converters;

public class FactorioRuntimeTypeSpecificationConverter : JsonConverter<FactorioRuntimeTypeSpecification>
{
    public override FactorioRuntimeTypeSpecification? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.String:
                return new FactorioRuntimeSimpleTypeSpecification { Name = reader.GetString() ?? throw new JsonException() };
            case JsonTokenType.StartObject:
                string? complexType = null;
                FactorioRuntimeTypeSpecification? complexTypeKey = null;
                FactorioRuntimeTypeSpecification? complexTypeValue = null;
                object? literalValue = null;
                bool? fullFormat = null;
                List<FactorioRuntimeTypeSpecification> unionOptions = new();
                List<FactorioRuntimeTypeSpecification> typeParameters = new();
                List<FactorioRuntimeParameterSpecification> parameters = new();

                while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
                {
                    switch (reader.TokenType)
                    {
                        case JsonTokenType.PropertyName:
                            switch (reader.GetString())
                            {
                                case "complex_type":
                                    reader.Read();
                                    complexType = reader.GetString();
                                    break;
                                case "key":
                                    reader.Read();
                                    complexTypeKey = Read(ref reader, typeof(FactorioRuntimeTypeSpecification), options);
                                    break;
                                case "value":
                                    switch (complexType)
                                    {
                                        case "literal":
                                            reader.Read();
                                            literalValue = JsonSerializer.Deserialize<object>(ref reader, options);
                                            break;
                                        default:
                                            reader.Read();
                                            complexTypeValue = Read(ref reader, typeof(FactorioRuntimeTypeSpecification), options);
                                            break;
                                    }
                                    break;
                                case "full_format":
                                    reader.Read();
                                    fullFormat = reader.GetBoolean();
                                    break;
                                case "options":
                                    reader.Read();
                                    if (reader.TokenType != JsonTokenType.StartArray)
                                    {
                                        throw new JsonException("Expected type.options to be an array");
                                    }

                                    while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                                    {
                                        FactorioRuntimeTypeSpecification? type = Read(ref reader, typeof(FactorioRuntimeTypeSpecification), options);
                                        unionOptions.Add(type);
                                    }

                                    break;
                                case "parameters":
                                    reader.Read();
                                    if (reader.TokenType != JsonTokenType.StartArray)
                                    {
                                        throw new JsonException("Expected type.options to be an array");
                                    }

                                    switch (complexType)
                                    {
                                        case "table":
                                            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                                            {
                                                FactorioRuntimeParameterSpecification? parameter =
                                                    JsonSerializer.Deserialize<FactorioRuntimeParameterSpecification>(ref reader, options) ?? throw new JsonException();
                                                parameters.Add(parameter);
                                            }
                                            break;
                                        case "function":
                                        default:
                                            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                                            {
                                                FactorioRuntimeTypeSpecification? type = Read(ref reader, typeof(FactorioRuntimeTypeSpecification), options);
                                                typeParameters.Add(type);
                                            }
                                            break;
                                    }

                                    break;
                            }

                            break;
                    }
                }

                switch (complexType)
                {
                    case "union":
                        return new FactorioRuntimeUnionTypeSpecification { Options = unionOptions.ToArray(), FullFormat = fullFormat ?? false };
                    case "function":
                        return new FactorioRuntimeFunctionTypeSpecification { Parameters = typeParameters.ToArray() };
                    case "array":
                        if (complexTypeValue == null)
                        {
                            throw new NotSupportedException("Could not find value.");
                        }

                        return new FactorioRuntimeArrayTypeSpecification { Value = complexTypeValue };
                    case "table":
                        return new FactorioRuntimeTableTypeSpecification { Parameters = parameters.ToArray() };
                    case "literal":
                        if (literalValue == null)
                        {
                            throw new NotSupportedException("Could not find value of literal type.");
                        }

                        return new FactorioRuntimeLiteralTypeSpecification { Value = literalValue };
                    case null:
                        throw new NotSupportedException("Could not find complex type.");
                    default:
                        if (complexTypeKey == null)
                        {
                            throw new NotSupportedException("Could not find key of complex type.");
                        }

                        if (complexTypeValue == null)
                        {
                            throw new NotSupportedException("Could not find value of complex type.");
                        }

                        return new FactorioRuntimeKeyValueTypeSpecification { Name = complexType, Key = complexTypeKey, Value = complexTypeValue };
                }

        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, FactorioRuntimeTypeSpecification value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case FactorioRuntimeSimpleTypeSpecification simpleType:
                writer.WriteStringValue(simpleType.Name);
                break;
            case FactorioRuntimeLiteralTypeSpecification literalType:
                writer.WriteStartObject();
                writer.WriteString("complex_type", "literal");
                writer.WritePropertyName("value");
                JsonSerializer.Serialize(writer, literalType.Value, options);
                writer.WriteEndObject();
                break;
            case FactorioRuntimeArrayTypeSpecification arrayType:
                writer.WriteStartObject();
                writer.WriteString("complex_type", "array");
                writer.WritePropertyName("value");
                Write(writer, arrayType.Value, options);
                writer.WriteEndObject();
                break;
            case FactorioRuntimeFunctionTypeSpecification functionType:
                writer.WriteStartObject();
                writer.WriteString("complex_type", "literal");
                writer.WritePropertyName("parameters");
                writer.WriteStartArray();
                foreach (FactorioRuntimeTypeSpecification parameter in functionType.Parameters)
                {
                    Write(writer, parameter, options);
                }
                writer.WriteEndArray();
                writer.WriteEndObject();
                break;
            case FactorioRuntimeTableTypeSpecification tableType:
                writer.WriteStartObject();
                writer.WriteString("complex_type", "literal");
                writer.WritePropertyName("parameters");
                JsonSerializer.Serialize(writer, tableType.Parameters, options);
                writer.WriteEndObject();
                break;
            case FactorioRuntimeKeyValueTypeSpecification keyValueType:
                writer.WriteStartObject();
                writer.WriteString("complex_type", keyValueType.Name);
                writer.WritePropertyName("key");
                Write(writer, keyValueType.Key, options);
                writer.WritePropertyName("value");
                Write(writer, keyValueType.Value, options);
                writer.WriteEndObject();
                break;
            case FactorioRuntimeUnionTypeSpecification unionType:
                writer.WriteStartObject();
                writer.WriteString("complex_type", "union");

                writer.WriteStartArray("options");
                foreach (FactorioRuntimeTypeSpecification option in unionType.Options)
                {
                    Write(writer, option, options);
                }
                writer.WriteEndArray();

                writer.WriteEndObject();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(value));

        }
    }
}
