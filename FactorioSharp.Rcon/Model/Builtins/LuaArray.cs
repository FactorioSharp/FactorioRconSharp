using System.Collections;
using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Builtins;

public class LuaArray<T> : IReadOnlyList<T>
{
    readonly List<T> _values;

    public LuaArray(IEnumerable<T>? values = null)
    {
        _values = values?.ToList() ?? [];
    }

    [FactorioRconLengthOperator]
    public int Count => _values.Count;

    public T this[int index] => _values[index];
    public IEnumerator<T> GetEnumerator() => _values.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_values).GetEnumerator();
}
