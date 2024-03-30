namespace SpecificationCompiler.Model;

/// <summary>
///     A class in the factorio model
/// </summary>
public class FactorioModelClass : FactorioModelTopLevelStatement
{
    public string? BaseClass { get; set; }

    public bool IsPartial { get; set; }

    public FactorioModelClassProperty[] Properties { get; set; } = Array.Empty<FactorioModelClassProperty>();
    public FactorioModelClassOperator[] Operators { get; set; } = Array.Empty<FactorioModelClassOperator>();
    public FactorioModelClassMethod[] Methods { get; set; } = Array.Empty<FactorioModelClassMethod>();
}
