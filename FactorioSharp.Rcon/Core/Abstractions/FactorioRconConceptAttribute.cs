namespace FactorioSharp.Rcon.Core.Abstractions;

[AttributeUsage(AttributeTargets.Class)]
public class FactorioRconConceptAttribute : Attribute
{
    public FactorioRconConceptAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
