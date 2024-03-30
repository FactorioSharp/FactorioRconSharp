#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("CircularProjectileCreationSpecification")]
public class CircularProjectileCreationSpecification
{
    [FactorioRconAttribute("[1]")]
    public RealOrientation First { get; set; }

    [FactorioRconAttribute("[2]")]
    public Vector Second { get; set; }
}
