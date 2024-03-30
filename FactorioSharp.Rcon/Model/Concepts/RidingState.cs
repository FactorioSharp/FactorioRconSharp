#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Definitions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("RidingState")]
public class RidingState
{
    [FactorioRconAttribute("acceleration")]
    public RidingAccelerationEnum Acceleration { get; set; }

    [FactorioRconAttribute("direction")]
    public RidingDirectionEnum Direction { get; set; }
}
