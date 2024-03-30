using System.Reflection;
using System.Text.Json;
using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Core.Converters;
using FactorioSharp.Rcon.Model.Builtins;

namespace FactorioSharp.Rcon.Core.Parsing;

static class FactorioRconParser
{
    static readonly JsonSerializerOptions JsonSerializerOptions = new(JsonSerializerDefaults.General)
    {
        Converters =
        {
            new OneOfJsonConverterFactory()
        }
    };

    public static TFactorioRconModel Parse<TFactorioRconModel>(string stringValue) => (TFactorioRconModel)Parse(stringValue, typeof(TFactorioRconModel))!;

    static object? Parse(string stringValue, Type type)
    {
        if (type.IsTableType())
        {
            return ParseTableType(stringValue, type);
        }

        if (type.IsArray)
        {
            return ParseArray(stringValue, type);
        }

        if (type.IsEnum)
        {
            if (int.TryParse(stringValue, out int enumIndex))
            {
                return Enum.GetValues(type).GetValue(enumIndex);
            }

            var valuesWithLuaName = Enum.GetValues(type)
                .OfType<object>()
                .Select(
                    v =>
                    {
                        MemberInfo? valueMember = type.GetMember(v.ToString()).FirstOrDefault(m => m.DeclaringType == type);
                        FactorioRconDefinitionValueAttribute? attribute = valueMember?.GetCustomAttribute<FactorioRconDefinitionValueAttribute>();
                        return new { Value = v, LuaName = attribute?.Name };
                    }
                );
            return valuesWithLuaName.SingleOrDefault(v => v.LuaName == stringValue)?.Value
                   ?? throw new InvalidOperationException($"Invalid value {stringValue} for enum type {type}");
        }

        if (type == typeof(LuaNil))
        {
            return null;
        }

        if (type == typeof(sbyte))
        {
            return sbyte.TryParse(stringValue, out sbyte value) ? value : 0;
        }

        if (type == typeof(short))
        {
            return short.TryParse(stringValue, out short value) ? value : 0;
        }

        if (type == typeof(int))
        {
            return int.TryParse(stringValue, out int value) ? value : 0;
        }

        if (type == typeof(long))
        {
            return long.TryParse(stringValue, out long value) ? value : 0;
        }

        if (type == typeof(byte))
        {
            return byte.TryParse(stringValue, out byte value) ? value : 0;
        }

        if (type == typeof(ushort))
        {
            return ushort.TryParse(stringValue, out ushort value) ? value : 0;
        }

        if (type == typeof(uint))
        {
            return uint.TryParse(stringValue, out uint value) ? value : 0;
        }

        if (type == typeof(ulong))
        {
            return ulong.TryParse(stringValue, out ulong value) ? value : 0;
        }

        if (type == typeof(float))
        {
            return float.TryParse(stringValue, out float value) ? value : 0;
        }

        if (type == typeof(double))
        {
            return double.TryParse(stringValue, out double value) ? value : 0;
        }

        if (type == typeof(bool))
        {
            return bool.TryParse(stringValue, out bool value) && value;
        }

        if (type == typeof(string))
        {
            return stringValue;
        }

        throw new InvalidOperationException($"Unknown value type {type}");
    }

    static object? ParseTableType(string stringValue, Type type) => JsonSerializer.Deserialize(stringValue, type, JsonSerializerOptions);

    static object ParseArray(string stringValue, Type type)
    {

        Type? elementType = type.GetElementType();
        if (elementType == null)
        {
            throw new InvalidOperationException($"Could not determine element type of array type {type}");
        }

        int start = stringValue.IndexOf('{');
        int end = stringValue.LastIndexOf('}');
        if (start < 0 || end < 0 || end <= start)
        {
            throw new InvalidOperationException($"Value {stringValue} is not a valid array");
        }

        IEnumerable<string> values = stringValue.Substring(start, end - start + 1).Split(',').Select(s => s.Trim());
        return values.Select(v => Parse(v, elementType)).ToList();
    }
}
