namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeKeyValueTypeSpecification : FactorioRuntimeTypeSpecification
{
    public required string Name { get; set; }
    public required FactorioRuntimeTypeSpecification Key { get; set; }
    public required FactorioRuntimeTypeSpecification Value { get; set; }
}