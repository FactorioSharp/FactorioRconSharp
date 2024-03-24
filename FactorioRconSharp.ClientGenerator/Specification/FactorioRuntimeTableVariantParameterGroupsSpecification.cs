namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeTableVariantParameterGroupsSpecification
{
    public required string Name { get; set; }
    public required int Order { get; set; }
    public string? Description { get; set; }
    public FactorioRuntimeParameterSpecification[] Parameters { get; set; } = Array.Empty<FactorioRuntimeParameterSpecification>();
}
