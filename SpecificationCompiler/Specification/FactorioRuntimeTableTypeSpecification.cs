namespace SpecificationCompiler.Specification;

public class FactorioRuntimeTableTypeSpecification : FactorioRuntimeTypeSpecification, IEquatable<FactorioRuntimeTableTypeSpecification>
{
    public FactorioRuntimeParameterSpecification[] Parameters { get; init; } = Array.Empty<FactorioRuntimeParameterSpecification>();
    public FactorioRuntimeTableVariantParameterGroupsSpecification[] VariantParameterGroups { get; init; } = Array.Empty<FactorioRuntimeTableVariantParameterGroupsSpecification>();
    public string? VariantParameterDescription { get; init; }

    public override bool Equals(FactorioRuntimeTypeSpecification? other)
    {
        if (other is FactorioRuntimeTableTypeSpecification tableType)
        {
            return Equals(tableType);
        }

        return false;
    }

    public bool Equals(FactorioRuntimeTableTypeSpecification? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Parameters.SequenceEqual(other.Parameters)
               && VariantParameterGroups.SequenceEqual(other.VariantParameterGroups)
               && VariantParameterDescription == other.VariantParameterDescription;
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
        return Equals((FactorioRuntimeTableTypeSpecification)obj);
    }

    public override int GetHashCode() =>
        HashCode.Combine(Parameters.Aggregate(0, HashCode.Combine), VariantParameterGroups.Aggregate(0, HashCode.Combine), VariantParameterDescription);

    public static bool operator ==(FactorioRuntimeTableTypeSpecification? left, FactorioRuntimeTableTypeSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeTableTypeSpecification? left, FactorioRuntimeTableTypeSpecification? right) => !Equals(left, right);
}
