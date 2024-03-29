namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeMethodReturnValueSpecification
{
    public required int Order { get; set; }
    public required string Description { get; set; }
    public required FactorioRuntimeTypeSpecification Type { get; set; }
    public required bool Optional { get; set; }
}
