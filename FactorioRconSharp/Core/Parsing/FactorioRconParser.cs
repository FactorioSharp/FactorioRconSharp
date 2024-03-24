using FactorioRconSharp.Core.Abstractions;

namespace FactorioRconSharp.Core.Parsing;

public static class FactorioRconParser
{
    public static TFactorioRconModel Parse<TFactorioRconModel>(string stringValue) => (TFactorioRconModel)Parse(stringValue, typeof(TFactorioRconModel));

    static object Parse(string stringValue, Type type)
    {
        if (typeof(IFactorioRconModel).IsAssignableFrom(type))
        {
            return ParseFactorioRconModel(stringValue, type);
        }

        if (type.IsArray)
        {
            return ParseArray(stringValue, type);
        }

        if (type == typeof(uint))
        {
            return uint.TryParse(stringValue, out uint value) ? value : 0;
        }

        if (type == typeof(long))
        {
            return long.TryParse(stringValue, out long value) ? value : 0;
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

    static object ParseFactorioRconModel(string stringValue, Type type)
    {

        object? result = Activator.CreateInstance(type);
        if (result == null)
        {
            throw new InvalidOperationException($"Could not activate instance of type {type}");
        }

        ((IFactorioRconModel)result).Load(stringValue);

        return result;
    }

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
