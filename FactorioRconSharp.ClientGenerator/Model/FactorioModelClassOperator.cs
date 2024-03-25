namespace FactorioRconSharp.ClientGenerator.Model;

/// <summary>
///     An operator of a class in the factorio model
/// </summary>
public class FactorioModelClassOperator
{
    public required FactorioModelClassOperatorType OperatorType { get; set; }
    public FactorioModelDocumentation? Documentation { get; set; }

    public required string KeyType { get; set; }
    public required string ReturnType { get; set; }
    public required bool Optional { get; set; }
    public required bool Read { get; set; }
    public required bool Write { get; set; }
}
