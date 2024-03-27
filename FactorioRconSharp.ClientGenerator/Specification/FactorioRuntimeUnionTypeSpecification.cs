namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeUnionTypeSpecification : FactorioRuntimeTypeSpecification
{
    public FactorioRuntimeTypeSpecification[] Options { get; set; } = Array.Empty<FactorioRuntimeTypeSpecification>();
    public bool FullFormat { get; set; }
}

public static class FactorioRuntimeUnionTypeSpecificationExtensions
{
    public static bool IsUnionOfLiterals(this FactorioRuntimeUnionTypeSpecification unionType, out FactorioRuntimeLiteralTypeSpecification[] literals)
    {
        if (unionType.Options.All(o => o is FactorioRuntimeLiteralTypeSpecification))
        {
            literals = unionType.Options.OfType<FactorioRuntimeLiteralTypeSpecification>().ToArray();
            return true;
        }

        literals = Array.Empty<FactorioRuntimeLiteralTypeSpecification>();
        return false;
    }
}
