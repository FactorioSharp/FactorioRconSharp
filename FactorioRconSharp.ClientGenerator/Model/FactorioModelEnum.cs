namespace FactorioRconSharp.ClientGenerator.Model;

public class FactorioModelEnum
{
    public required string Name { get; set; }
    public required string LuaName { get; set; }
    public FactorioModelDocumentation? Documentation { get; set; }
    public FactorioModelEnumValue[] Values { get; set; } = Array.Empty<FactorioModelEnumValue>();
}
