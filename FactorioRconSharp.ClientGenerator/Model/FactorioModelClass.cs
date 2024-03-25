namespace FactorioRconSharp.ClientGenerator.Model;

/// <summary>
///     A class in the factorio model
/// </summary>
public class FactorioModelClass
{
    public required string Name { get; set; }
    public required string LuaName { get; set; }
    public required int Order { get; set; }
    public FactorioModelDocumentation? Documentation { get; set; }

    public string? BaseClassName { get; set; }
    public string[] Interfaces { get; set; } = Array.Empty<string>();

    public FactorioModelClassProperty[] Properties { get; set; } = Array.Empty<FactorioModelClassProperty>();
    public FactorioModelClassOperator[] Operators { get; set; } = Array.Empty<FactorioModelClassOperator>();
    public FactorioModelClassMethod[] Methods { get; set; } = Array.Empty<FactorioModelClassMethod>();
}
