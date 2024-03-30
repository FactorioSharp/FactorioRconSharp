#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("GunShift4Way")]
public class GunShift4Way
{
    [FactorioRconAttribute("north")]
    public Vector North { get; set; }

    [FactorioRconAttribute("east")]
    public Vector East { get; set; }

    [FactorioRconAttribute("south")]
    public Vector South { get; set; }

    [FactorioRconAttribute("west")]
    public Vector West { get; set; }
}
