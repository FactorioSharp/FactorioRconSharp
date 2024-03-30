namespace FactorioSharp.Rcon.Model.Builtins;

/// <summary>
///     Base class use to encapsulate any type in an alias type, e.g. <c>public class Path: Alias&lt;string&gt;</c>
/// </summary>
public class Alias<T>
{
    public T Value { get; set; }

    public static implicit operator T(Alias<T> alias) => alias.Value;
    public static implicit operator Alias<T>(T value) => new() { Value = value };
}
