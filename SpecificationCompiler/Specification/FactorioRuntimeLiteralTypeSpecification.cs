namespace SpecificationCompiler.Specification;

public class FactorioRuntimeLiteralTypeSpecification : FactorioRuntimeTypeSpecification, IEquatable<FactorioRuntimeLiteralTypeSpecification>
{
    public required object Value { get; init; }

    public override bool Equals(FactorioRuntimeTypeSpecification? other)
    {
        if (other is FactorioRuntimeLiteralTypeSpecification literalType)
        {
            return Equals(literalType);
        }

        return false;
    }

    public bool Equals(FactorioRuntimeLiteralTypeSpecification? other)
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
        return Equals((FactorioRuntimeLiteralTypeSpecification)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(FactorioRuntimeLiteralTypeSpecification? left, FactorioRuntimeLiteralTypeSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeLiteralTypeSpecification? left, FactorioRuntimeLiteralTypeSpecification? right) => !Equals(left, right);
}
