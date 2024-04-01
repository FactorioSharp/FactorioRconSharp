using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Builtins;

public class LuaArray<T>
{
    readonly List<T> _values;

    public LuaArray(IEnumerable<T>? values = null)
    {
        _values = values?.ToList() ?? [];
    }

    [FactorioRconLengthOperator]
    public int Length => _values.Count;

    public T this[int index] {
        get => _values[index];
        set => _values[index] = value;
    }
}
