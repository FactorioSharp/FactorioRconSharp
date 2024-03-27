namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeUnionTypeSpecification : FactorioRuntimeTypeSpecification, IEquatable<FactorioRuntimeUnionTypeSpecification>
{
    public FactorioRuntimeTypeSpecification[] Options { get; init; } = Array.Empty<FactorioRuntimeTypeSpecification>();
    public bool FullFormat { get; init; }

    public override bool Equals(FactorioRuntimeTypeSpecification? other)
    {
        if (other is FactorioRuntimeUnionTypeSpecification unionType)
        {
            return Equals(unionType);
        }

        return false;
    }

    public bool Equals(FactorioRuntimeUnionTypeSpecification? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Options.SequenceEqual(other.Options) && FullFormat == other.FullFormat;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }
        if (ReferenceEquals(this, obj))
        {
            return true;
        }
        if (obj.GetType() != GetType())
        {
            return false;
        }
        return Equals((FactorioRuntimeUnionTypeSpecification)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Options.Aggregate(0, HashCode.Combine), FullFormat);

    public static bool operator ==(FactorioRuntimeUnionTypeSpecification? left, FactorioRuntimeUnionTypeSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeUnionTypeSpecification? left, FactorioRuntimeUnionTypeSpecification? right) => !Equals(left, right);
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
