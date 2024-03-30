#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ChartTagSpec")]
public class ChartTagSpec
{
    [FactorioRconAttribute("position")]
    public MapPosition Position { get; set; }

    [FactorioRconAttribute("icon")]
    public SignalID Icon { get; set; }

    [FactorioRconAttribute("text")]
    public string Text { get; set; }

    [FactorioRconAttribute("last_user")]
    public PlayerIdentification LastUser { get; set; }
}
