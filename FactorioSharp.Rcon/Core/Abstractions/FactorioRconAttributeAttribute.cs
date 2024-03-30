namespace FactorioSharp.Rcon.Core.Abstractions;

[AttributeUsage(AttributeTargets.Property)]
public class FactorioRconAttributeAttribute : Attribute
{
    public FactorioRconAttributeAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
