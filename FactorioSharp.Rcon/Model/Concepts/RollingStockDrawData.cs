#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("RollingStockDrawData")]
public class RollingStockDrawData
{
    [FactorioRconAttribute("position")]
    public MapPosition Position { get; set; }

    [FactorioRconAttribute("orientaton")]
    public RealOrientation Orientaton { get; set; }
}
