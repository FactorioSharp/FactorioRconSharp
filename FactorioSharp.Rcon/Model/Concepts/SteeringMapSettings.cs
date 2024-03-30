#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("SteeringMapSettings")]
public class SteeringMapSettings
{
    [FactorioRconAttribute("default")]
    public SteeringMapSetting Default { get; set; }

    [FactorioRconAttribute("moving")]
    public SteeringMapSetting Moving { get; set; }
}
