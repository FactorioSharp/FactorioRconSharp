namespace SpecificationCompiler.Specification;

public class FactorioRuntimeClassSpecification
{
    public required string Name { get; set; }
    public required int Order { get; set; }
    public required string Description { get; set; }
    public FactorioRuntimeAttributeSpecification[] Attributes { get; set; } = Array.Empty<FactorioRuntimeAttributeSpecification>();
    public FactorioRuntimeMethodSpecification[] Methods { get; set; } = Array.Empty<FactorioRuntimeMethodSpecification>();
    public FactorioRuntimeOperatorSpecification[] Operators { get; set; } = Array.Empty<FactorioRuntimeOperatorSpecification>();
    public string[] Examples { get; set; } = Array.Empty<string>();
    public required bool Abstract { get; set; }
    public string[] BaseClasses { get; set; } = Array.Empty<string>();
}
