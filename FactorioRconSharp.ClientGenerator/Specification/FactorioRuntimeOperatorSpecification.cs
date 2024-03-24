namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeOperatorSpecification
{
    public required string Name { get; set; }
    public required int Order { get; set; }
    public required string Description { get; set; }
    public FactorioRuntimeTypeSpecification? Type { get; set; }
    public bool Optional { get; set; } = false;
    public bool Read { get; set; } = false;
    public bool Write { get; set; } = false;
}
