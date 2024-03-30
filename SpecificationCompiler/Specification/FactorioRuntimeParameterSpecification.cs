namespace SpecificationCompiler.Specification;

public class FactorioRuntimeParameterSpecification : IEquatable<FactorioRuntimeParameterSpecification>
{
    public required string Name { get; init; }
    public required int Order { get; init; }
    public required string Description { get; init; }
    public required FactorioRuntimeTypeSpecification Type { get; init; }
    public required bool Optional { get; init; }

    public bool Equals(FactorioRuntimeParameterSpecification? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Name == other.Name && Order == other.Order && Description == other.Description && Type.Equals(other.Type) && Optional == other.Optional;
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
        return Equals((FactorioRuntimeParameterSpecification)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Name, Order, Description, Type, Optional);

    public static bool operator ==(FactorioRuntimeParameterSpecification? left, FactorioRuntimeParameterSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeParameterSpecification? left, FactorioRuntimeParameterSpecification? right) => !Equals(left, right);
}
