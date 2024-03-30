namespace SpecificationCompiler.Specification;

public class FactorioRuntimeGlobalObjectSpecification
{
    public required string Name { get; set; }
    public required int Order { get; set; }
    public string? Description { get; set; }
    public required FactorioRuntimeTypeSpecification Type { get; set; }
}
