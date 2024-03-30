namespace FactorioSharp.Rcon.Core.Abstractions;

[AttributeUsage(AttributeTargets.Enum)]
public class FactorioRconDefinitionAttribute : Attribute
{
    public FactorioRconDefinitionAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
