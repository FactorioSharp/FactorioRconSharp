namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeTupleTypeSpecification : FactorioRuntimeTypeSpecification, IEquatable<FactorioRuntimeTupleTypeSpecification>
{
    public FactorioRuntimeParameterSpecification[] Parameters { get; init; } = Array.Empty<FactorioRuntimeParameterSpecification>();

    public override bool Equals(FactorioRuntimeTypeSpecification? other)
    {
        if (other is FactorioRuntimeTupleTypeSpecification tupleType)
        {
            return Equals(tupleType);
        }

        return false;
    }

    public bool Equals(FactorioRuntimeTupleTypeSpecification? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Parameters.Equals(other.Parameters);
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
        return Equals((FactorioRuntimeTupleTypeSpecification)obj);
    }

    public override int GetHashCode() => Parameters.GetHashCode();

    public static bool operator ==(FactorioRuntimeTupleTypeSpecification? left, FactorioRuntimeTupleTypeSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeTupleTypeSpecification? left, FactorioRuntimeTupleTypeSpecification? right) => !Equals(left, right);
}
