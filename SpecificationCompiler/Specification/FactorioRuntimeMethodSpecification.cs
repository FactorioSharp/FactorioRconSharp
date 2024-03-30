namespace SpecificationCompiler.Specification;

public class FactorioRuntimeMethodSpecification
{
    public required string Name { get; set; }
    public required int Order { get; set; }
    public required string Description { get; set; }
    public string[] Notes { get; set; } = Array.Empty<string>();
    public FactorioRuntimeParameterSpecification[] Parameters { get; set; } = Array.Empty<FactorioRuntimeParameterSpecification>();
    public FactorioRuntimeMethodReturnValueSpecification[] ReturnValues { get; set; } = Array.Empty<FactorioRuntimeMethodReturnValueSpecification>();
    public bool TakesTable { get; set; } = false;
}
