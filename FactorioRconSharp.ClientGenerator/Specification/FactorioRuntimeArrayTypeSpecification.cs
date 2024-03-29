namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeArrayTypeSpecification : FactorioRuntimeTypeSpecification, IEquatable<FactorioRuntimeArrayTypeSpecification>
{
    public required FactorioRuntimeTypeSpecification Value { get; init; }

    public override bool Equals(FactorioRuntimeTypeSpecification? other)
    {
        if (other is FactorioRuntimeArrayTypeSpecification arrayType)
        {
            return Equals(arrayType);
        }

        return false;
    }

    public bool Equals(FactorioRuntimeArrayTypeSpecification? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Value.Equals(other.Value);
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
        return Equals((FactorioRuntimeArrayTypeSpecification)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(FactorioRuntimeArrayTypeSpecification? left, FactorioRuntimeArrayTypeSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeArrayTypeSpecification? left, FactorioRuntimeArrayTypeSpecification? right) => !Equals(left, right);
}
