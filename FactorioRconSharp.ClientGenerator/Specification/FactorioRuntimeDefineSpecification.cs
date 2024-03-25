namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeDefinitionSpecification
{
    public required string Name { get; set; }
    public required int Order { get; set; }
    public string? Description { get; set; }
    public FactorioRuntimeDefinitionValueSpecification[] Values { get; set; } = Array.Empty<FactorioRuntimeDefinitionValueSpecification>();
}
