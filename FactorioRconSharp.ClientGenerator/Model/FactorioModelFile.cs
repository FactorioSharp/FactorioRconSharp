namespace FactorioRconSharp.ClientGenerator.Model;

/// <summary>
///     A file in the factorio model
/// </summary>
public class FactorioModelFile
{
    public required string Name { get; set; }
    public string? Namespace { get; set; }
    public string[] Usings { get; set; } = Array.Empty<string>();

    public FactorioModelTopLevelStatement[] Statements { get; set; } = Array.Empty<FactorioModelTopLevelStatement>();
}
