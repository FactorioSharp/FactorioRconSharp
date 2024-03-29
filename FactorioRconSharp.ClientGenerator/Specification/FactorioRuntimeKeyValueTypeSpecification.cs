namespace FactorioRconSharp.ClientGenerator.Specification;

public class FactorioRuntimeKeyValueTypeSpecification : FactorioRuntimeTypeSpecification, IEquatable<FactorioRuntimeKeyValueTypeSpecification>
{
    public required string Name { get; init; }
    public required FactorioRuntimeTypeSpecification Key { get; init; }
    public required FactorioRuntimeTypeSpecification Value { get; init; }

    public override bool Equals(FactorioRuntimeTypeSpecification? other)
    {
        if (other is FactorioRuntimeKeyValueTypeSpecification keyValueType)
        {
            return Equals(keyValueType);
        }

        return false;
    }

    public bool Equals(FactorioRuntimeKeyValueTypeSpecification? other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }
        if (ReferenceEquals(this, other))
        {
            return true;
        }
        return Name == other.Name && Key.Equals(other.Key) && Value.Equals(other.Value);
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
        return Equals((FactorioRuntimeKeyValueTypeSpecification)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Name, Key, Value);

    public static bool operator ==(FactorioRuntimeKeyValueTypeSpecification? left, FactorioRuntimeKeyValueTypeSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeKeyValueTypeSpecification? left, FactorioRuntimeKeyValueTypeSpecification? right) => !Equals(left, right);
}
