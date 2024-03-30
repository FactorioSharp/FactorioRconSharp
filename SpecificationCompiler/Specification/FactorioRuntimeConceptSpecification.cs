namespace SpecificationCompiler.Specification;

public class FactorioRuntimeConceptSpecification
{
    public required string Name { get; set; }
    public required int Order { get; set; }
    public required string Description { get; set; }
    public required FactorioRuntimeTypeSpecification Type { get; set; }
}
