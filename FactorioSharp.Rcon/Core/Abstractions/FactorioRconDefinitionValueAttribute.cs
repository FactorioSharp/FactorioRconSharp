namespace FactorioSharp.Rcon.Core.Abstractions;

[AttributeUsage(AttributeTargets.Field)]
public class FactorioRconDefinitionValueAttribute : Attribute
{
    public FactorioRconDefinitionValueAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
