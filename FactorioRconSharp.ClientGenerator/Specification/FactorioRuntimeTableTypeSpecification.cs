namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeTableTypeSpecification : FactorioRuntimeTypeSpecification
{
    public FactorioRuntimeParameterSpecification[] Parameters { get; set; } = Array.Empty<FactorioRuntimeParameterSpecification>();
    public FactorioRuntimeTableVariantParameterGroupsSpecification[] VariantParameterGroups { get; set; } = Array.Empty<FactorioRuntimeTableVariantParameterGroupsSpecification>();
    public string? VariantParameterDescription { get; set; }
}
