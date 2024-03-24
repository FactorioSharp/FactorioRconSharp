namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeUnionTypeSpecification : FactorioRuntimeTypeSpecification
{
    public FactorioRuntimeTypeSpecification[] Options { get; set; } = Array.Empty<FactorioRuntimeTypeSpecification>();
    public bool FullFormat { get; set; }
}