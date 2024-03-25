namespace FactorioRconSharp.ClientGenerator.Model;

public class FactorioModelEnumValue
{
    public required string Name { get; set; }
    public required string LuaName { get; set; }
    public FactorioModelDocumentation? Documentation { get; set; }
}
