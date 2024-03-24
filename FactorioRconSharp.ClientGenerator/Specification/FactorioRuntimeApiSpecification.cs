namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeApiSpecification
{
    public required string Application { get; set; }
    public required string ApplicationVersion { get; set; }
    public required int ApiVersion { get; set; }
    public required string Stage { get; set; }
    public FactorioRuntimeClassSpecification[] Classes { get; set; } = Array.Empty<FactorioRuntimeClassSpecification>();
    public FactorioRuntimeConceptSpecification[] Concepts { get; set; } = Array.Empty<FactorioRuntimeConceptSpecification>();
}
