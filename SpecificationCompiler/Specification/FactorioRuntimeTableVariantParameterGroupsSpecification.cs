namespace SpecificationCompiler.Specification;

public class FactorioRuntimeTableVariantParameterGroupsSpecification : IEquatable<FactorioRuntimeTableVariantParameterGroupsSpecification>
{
    public required string Name { get; init; }
    public required int Order { get; init; }
    public string? Description { get; init; }
    public FactorioRuntimeParameterSpecification[] Parameters { get; init; } = Array.Empty<FactorioRuntimeParameterSpecification>();

    public bool Equals(FactorioRuntimeTableVariantParameterGroupsSpecification? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Name == other.Name && Order == other.Order && Description == other.Description && Parameters.SequenceEqual(other.Parameters);
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
        return Equals((FactorioRuntimeTableVariantParameterGroupsSpecification)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Name, Order, Description, Parameters.Aggregate(0, HashCode.Combine));

    public static bool operator ==(FactorioRuntimeTableVariantParameterGroupsSpecification? left, FactorioRuntimeTableVariantParameterGroupsSpecification? right) =>
        Equals(left, right);

    public static bool operator !=(FactorioRuntimeTableVariantParameterGroupsSpecification? left, FactorioRuntimeTableVariantParameterGroupsSpecification? right) =>
        !Equals(left, right);
}
