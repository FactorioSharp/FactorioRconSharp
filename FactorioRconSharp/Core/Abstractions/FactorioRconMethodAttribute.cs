namespace FactorioRconSharp.Core.Abstractions;

[AttributeUsage(AttributeTargets.Method)]
public class FactorioRconMethodAttribute : Attribute
{
    public FactorioRconMethodAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
