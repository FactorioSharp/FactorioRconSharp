#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A table used to define a manual shape for a piece of equipment.
/// </summary>
[FactorioRconConcept("EquipmentPoint")]
public class EquipmentPoint
{
    [FactorioRconAttribute("x")]
    public uint X { get; set; }

    [FactorioRconAttribute("y")]
    public uint Y { get; set; }
}
