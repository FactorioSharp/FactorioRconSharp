namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeSimpleTypeSpecification : FactorioRuntimeTypeSpecification, IEquatable<FactorioRuntimeSimpleTypeSpecification>
{
    public required string Name { get; init; }
    public string? Description { get; init; }

    public override bool Equals(FactorioRuntimeTypeSpecification? other)
    {
        if (other is FactorioRuntimeSimpleTypeSpecification simpleType)
        {
            return Equals(simpleType);
        }

        return false;
    }

    public bool Equals(FactorioRuntimeSimpleTypeSpecification? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Name == other.Name && Description == other.Description;
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
        return Equals((FactorioRuntimeSimpleTypeSpecification)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Name, Description);

    public static bool operator ==(FactorioRuntimeSimpleTypeSpecification? left, FactorioRuntimeSimpleTypeSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeSimpleTypeSpecification? left, FactorioRuntimeSimpleTypeSpecification? right) => !Equals(left, right);
}
