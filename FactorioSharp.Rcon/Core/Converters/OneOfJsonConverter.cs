using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using OneOf;

namespace FactorioSharp.Rcon.Core.Converters;

class OneOfJsonConverterFactory : JsonConverterFactory
{
    static readonly Type[] OneOfGenericTypes = AppDomain.CurrentDomain.GetAssemblies()
        .First(a => a.GetName().Name == "OneOf")
        .GetTypes()
        .Where(t => new Regex("OneOf`\\d").IsMatch(t.Name))
        .OrderBy(t => t.Name)
        .ToArray();

    public override bool CanConvert(Type typeToConvert) => typeof(IOneOf).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options) => new OneOfJsonConverter();

    class OneOfJsonConverter : JsonConverter<IOneOf>
    {
        public override IOneOf? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            object? value = JsonSerializer.Deserialize(ref reader, typeof(object), options);
            if (value == null)
            {
                return null;
            }

            string reserialized = JsonSerializer.Serialize(value, options);

            Type[] possibleTypes = FindPossibleUnionTypes(typeToConvert);
            for (int index = 0; index < possibleTypes.Length; index++)
            {
                Type type = possibleTypes[index];

                object? deserialized = JsonSerializer.Deserialize(reserialized, type, options);
                if (deserialized == null)
                {
                    continue;
                }

                MethodInfo? factoryMethod = GetOneOfFactoryMethod(possibleTypes, index);
                if (factoryMethod == null)
                {
                    continue;
                }

                IOneOf ctorInput = (IOneOf)factoryMethod.Invoke(null, [deserialized]);
                IOneOf? result = (IOneOf)Activator.CreateInstance(typeToConvert, ctorInput);

                return result;
            }

            throw new InvalidOperationException($"Cannot convert value of type {value.GetType()} to type {typeToConvert}");
        }

        public override IOneOf ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? paramName = reader.GetString();
            if (paramName == null)
            {
                throw new InvalidOperationException("Invalid parameter name");
            }

            Type[] possibleTypes = FindPossibleUnionTypes(typeToConvert);
            for (int index = 0; index < possibleTypes.Length; index++)
            {
                Type type = possibleTypes[index];

                if (type == typeof(string))
                {
                    MethodInfo? factoryMethod = GetOneOfFactoryMethod(possibleTypes, index);
                    if (factoryMethod == null)
                    {
                        continue;
                    }

                    IOneOf ctorInput = (IOneOf)factoryMethod.Invoke(this, [paramName]);
                    return (IOneOf)Activator.CreateInstance(typeToConvert, ctorInput);
                }
            }

            throw new InvalidOperationException($"Cannot convert value of type {typeToConvert} to parameter name");
        }


        public override void Write(Utf8JsonWriter writer, IOneOf value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value.Value, options);

        public override void WriteAsPropertyName(Utf8JsonWriter writer, IOneOf value, JsonSerializerOptions options) =>
            JsonSerializer.Serialize(writer, value.Value.ToString(), options);

        static bool TryDeserializeFromString(string value, Type typeToConvert, JsonSerializerOptions options, [NotNullWhen(true)] out IOneOf? result)
        {
            Type[] possibleTypes = FindPossibleUnionTypes(typeToConvert);
            for (int index = 0; index < possibleTypes.Length; index++)
            {
                Type type = possibleTypes[index];

                object? deserialized = JsonSerializer.Deserialize(value, type, options);
                if (deserialized == null)
                {
                    continue;
                }

                Type oneOfTypeGeneric = OneOfGenericTypes[possibleTypes.Length - 1];
                Type oneOfType = oneOfTypeGeneric.MakeGenericType(possibleTypes);
                MethodInfo? factoryMethod = oneOfType.GetMethod($"FromT{index}", BindingFlags.Static | BindingFlags.Public);
                if (factoryMethod == null)
                {
                    continue;
                }

                IOneOf ctorInput = (IOneOf)factoryMethod.Invoke(null, [deserialized]);
                result = (IOneOf)Activator.CreateInstance(typeToConvert, ctorInput);

                return true;
            }

            result = null;
            return false;
        }

        /// <summary>
        ///     Get the method OneOf&lt;T1,...Tn&gt;.FromTi where n is the length of <see cref="possibleTypes" /> and i is typeIndex
        /// </summary>
        static MethodInfo? GetOneOfFactoryMethod(Type[] possibleTypes, int typeIndex)
        {
            Type oneOfTypeGeneric = OneOfGenericTypes[possibleTypes.Length - 1];
            Type oneOfType = oneOfTypeGeneric.MakeGenericType(possibleTypes);
            MethodInfo? factoryMethod = oneOfType.GetMethod($"FromT{typeIndex}", BindingFlags.Static | BindingFlags.Public);
            return factoryMethod;
        }
    }

    static Type[] FindPossibleUnionTypes(Type typeToConvert)
    {
        while (true)
        {
            if (typeToConvert.IsGenericType && typeToConvert.Name.StartsWith("OneOf"))
            {
                return typeToConvert.GetGenericArguments();
            }

            typeToConvert = typeToConvert.BaseType ?? throw new InvalidOperationException($"Could not find possible types for union for type {typeToConvert}");
        }
    }
}
