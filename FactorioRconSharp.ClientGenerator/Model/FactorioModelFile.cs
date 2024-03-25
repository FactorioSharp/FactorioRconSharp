namespace FactorioRconSharp.ClientGenerator.Model;

/// <summary>
///     A file in the factorio model
/// </summary>
public class FactorioModelFile
{
    public required string Name { get; set; }
    public string? Namespace { get; set; }
    public string[] Usings { get; set; } = Array.Empty<string>();

    public FactorioModelClass[] Classes { get; set; } = Array.Empty<FactorioModelClass>();
}
