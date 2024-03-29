namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeStructTypeSpecification : FactorioRuntimeTypeSpecification, IEquatable<FactorioRuntimeStructTypeSpecification>
{
    public FactorioRuntimeAttributeSpecification[] Attributes { get; init; } = Array.Empty<FactorioRuntimeAttributeSpecification>();

    public override bool Equals(FactorioRuntimeTypeSpecification? other)
    {
        if (other is FactorioRuntimeStructTypeSpecification structType)
        {
            return Equals(structType);
        }

        return false;
    }

    public bool Equals(FactorioRuntimeStructTypeSpecification? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Attributes.SequenceEqual(other.Attributes);
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
        return Equals((FactorioRuntimeStructTypeSpecification)obj);
    }

    public override int GetHashCode() => Attributes.Aggregate(0, HashCode.Combine);

    public static bool operator ==(FactorioRuntimeStructTypeSpecification? left, FactorioRuntimeStructTypeSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeStructTypeSpecification? left, FactorioRuntimeStructTypeSpecification? right) => !Equals(left, right);
}
