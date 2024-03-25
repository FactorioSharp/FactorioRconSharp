namespace FactorioRconSharp.Core.Abstractions;

[AttributeUsage(AttributeTargets.Class)]
public class FactorioRconClassAttribute : Attribute
{
    public FactorioRconClassAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
