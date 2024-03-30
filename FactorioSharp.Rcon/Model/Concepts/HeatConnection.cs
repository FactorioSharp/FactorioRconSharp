#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Definitions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("HeatConnection")]
public class HeatConnection
{
    [FactorioRconAttribute("position")]
    public Vector Position { get; set; }

    [FactorioRconAttribute("direction")]
    public DirectionEnum Direction { get; set; }
}
