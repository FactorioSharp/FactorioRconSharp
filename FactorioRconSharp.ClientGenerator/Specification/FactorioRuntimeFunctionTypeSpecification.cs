namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeFunctionTypeSpecification : FactorioRuntimeTypeSpecification, IEquatable<FactorioRuntimeFunctionTypeSpecification>
{
    public FactorioRuntimeTypeSpecification[] Parameters { get; init; } = Array.Empty<FactorioRuntimeTypeSpecification>();

    public override bool Equals(FactorioRuntimeTypeSpecification? other)
    {
        if (other is FactorioRuntimeFunctionTypeSpecification functionType)
        {
            return Equals(functionType);
        }

        return false;
    }

    public bool Equals(FactorioRuntimeFunctionTypeSpecification? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Parameters.SequenceEqual(other.Parameters);
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
        return Equals((FactorioRuntimeFunctionTypeSpecification)obj);
    }

    public override int GetHashCode() => Parameters.Aggregate(0, HashCode.Combine);

    public static bool operator ==(FactorioRuntimeFunctionTypeSpecification? left, FactorioRuntimeFunctionTypeSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeFunctionTypeSpecification? left, FactorioRuntimeFunctionTypeSpecification? right) => !Equals(left, right);
}
