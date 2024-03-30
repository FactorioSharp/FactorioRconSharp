#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("AmmoType")]
public class AmmoType
{
  [FactorioRconAttribute("action")]
  public List<TriggerItem> Action { get; set; }

  [FactorioRconAttribute("target_type")]
  public TargetType TargetType { get; set; }

  /// <summary>
  /// When `true`, the gun will be able to shoot even when the target is out of range. Only applies when `target_type` is `position`. The gun will fire at the maximum range in the direction of the target position. Defaults to `false`.
  /// </summary>
  [FactorioRconAttribute("clamp_position")]
  public bool ClampPosition { get; set; }

  /// <summary>
  /// Ammo category of this ammo.
  /// </summary>
  [FactorioRconAttribute("category")]
  public string Category { get; set; }

  /// <summary>
  /// Energy consumption of a single shot, if applicable. Defaults to `0`.
  /// </summary>
  [FactorioRconAttribute("energy_consumption")]
  public double EnergyConsumption { get; set; }

  [FactorioRconAttribute("range_modifier")]
  public double RangeModifier { get; set; }

  [FactorioRconAttribute("cooldown_modifier")]
  public double CooldownModifier { get; set; }

  [FactorioRconAttribute("consumption_modifier")]
  public double ConsumptionModifier { get; set; }

}

