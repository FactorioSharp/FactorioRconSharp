namespace FactorioRconSharp.ClientGenerator.Model;

public abstract class FactorioModelTopLevelStatement
{
    public required string Name { get; set; }
    public string? LuaName { get; set; }
    public FactorioModelDocumentation? Documentation { get; set; }
    public string[] Attributes { get; set; } = Array.Empty<string>();
    public bool IsFactorioClass { get; set; }
    public bool IsFactorioConcept { get; set; }
    public string[] RequireAdditionalUsing { get; set; } = Array.Empty<string>();
}
