namespace FactorioRconSharp.Model.Builtins;

/// <summary>
///     Tables are enclosed in curly brackets, like this `{}`.
/// </summary>
public class LuaTable
{
    readonly Dictionary<object, object> _values = new();

    public object this[object key] {
        get => _values.GetValueOrDefault(key);
        set => _values[key] = value;
    }
}
