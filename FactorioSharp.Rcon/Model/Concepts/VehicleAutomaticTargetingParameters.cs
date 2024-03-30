#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("VehicleAutomaticTargetingParameters")]
public class VehicleAutomaticTargetingParameters
{
    [FactorioRconAttribute("auto_target_without_gunner")]
    public bool AutoTargetWithoutGunner { get; set; }

    [FactorioRconAttribute("auto_target_with_gunner")]
    public bool AutoTargetWithGunner { get; set; }
}
