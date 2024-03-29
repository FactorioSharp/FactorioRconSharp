#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

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

