namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeParameterSpecification
{
    public required string Name { get; set; }
    public required int Order { get; set; }
    public required string Description { get; set; }
    public required FactorioRuntimeTypeSpecification Type { get; set; }
    public required bool Optional { get; set; }
}
