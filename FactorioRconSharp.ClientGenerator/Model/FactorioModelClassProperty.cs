namespace FactorioRconSharp.ClientGenerator.Model;

/// <summary>
///     A property of a class in the factorio model
/// </summary>
public class FactorioModelClassProperty
{
    public required string Name { get; set; }
    public string? LuaName { get; set; }
    public FactorioModelDocumentation? Documentation { get; set; }

    public bool IsStatic { get; set; }

    public required string Type { get; set; }
    public required bool Optional { get; set; }
    public required bool Read { get; set; }
    public required bool Write { get; set; }
}
