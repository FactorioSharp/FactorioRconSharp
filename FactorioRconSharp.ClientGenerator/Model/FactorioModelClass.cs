namespace FactorioRconSharp.ClientGenerator.Model;

/// <summary>
///     A class in the factorio model
/// </summary>
public class FactorioModelClass
{
    public required string Name { get; set; }
    public required string LuaName { get; set; }
    public FactorioModelDocumentation? Documentation { get; set; }

    public bool IsStatic { get; set; }
    public bool IsFactorioClass { get; set; }
    public bool IsFactorioConcept { get; set; }

    public FactorioModelClassProperty[] Properties { get; set; } = Array.Empty<FactorioModelClassProperty>();
    public FactorioModelClassOperator[] Operators { get; set; } = Array.Empty<FactorioModelClassOperator>();
    public FactorioModelClassMethod[] Methods { get; set; } = Array.Empty<FactorioModelClassMethod>();
}
