namespace FactorioRconSharp.ClientGenerator.Model;

/// <summary>
///     A method of a class in the factorio model
/// </summary>
public class FactorioModelClassMethod
{
    public required string Name { get; set; }
    public required string LuaName { get; set; }
    public required int Order { get; set; }
    public FactorioModelDocumentation? Documentation { get; set; }

    public FactorioModelClassMethodParameter[] Parameters { get; set; } = Array.Empty<FactorioModelClassMethodParameter>();
    public required string? ReturnType { get; set; }
}
