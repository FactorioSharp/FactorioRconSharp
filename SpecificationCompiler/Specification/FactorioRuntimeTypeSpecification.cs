﻿using System.Runtime.CompilerServices;

namespace SpecificationCompiler.Specification;

public abstract class FactorioRuntimeTypeSpecification : IEquatable<FactorioRuntimeTypeSpecification>
{
    public abstract bool Equals(FactorioRuntimeTypeSpecification? other);

    public override bool Equals(object? obj) => Equals(obj as FactorioRuntimeTypeSpecification);
    public override int GetHashCode() => RuntimeHelpers.GetHashCode(this);

    public static bool operator ==(FactorioRuntimeTypeSpecification? left, FactorioRuntimeTypeSpecification? right) => Equals(left, right);

    public static bool operator !=(FactorioRuntimeTypeSpecification? left, FactorioRuntimeTypeSpecification? right) => !Equals(left, right);
}
