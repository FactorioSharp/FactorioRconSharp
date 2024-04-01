#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("AttackParameters")]
public class AttackParameters
{
  /// <summary>
  /// The type of AttackParameter.
  /// </summary>
  [FactorioRconAttribute("type")]
  public Literals1612390030 Type { get; set; }

  /// <summary>
  /// Maximum range of attack.
  /// </summary>
  [FactorioRconAttribute("range")]
  public float Range { get; set; }

  /// <summary>
  /// Minimum range of attack. Used with flamethrower turrets to prevent self-immolation.
  /// </summary>
  [FactorioRconAttribute("min_range")]
  public float MinRange { get; set; }

  /// <summary>
  /// Defines how the range is determined.
  /// </summary>
  [FactorioRconAttribute("range_mode")]
  public Literals1850457581 RangeMode { get; set; }

  /// <summary>
  /// When searching for the nearest enemy to attack, `fire_penalty` is added to the enemy's distance if they are on fire.
  /// </summary>
  [FactorioRconAttribute("fire_penalty")]
  public float FirePenalty { get; set; }

  /// <summary>
  /// When searching for an enemy to attack, a higher `rotate_penalty` will discourage targeting enemies that would take longer to turn to face.
  /// </summary>
  [FactorioRconAttribute("rotate_penalty")]
  public float RotatePenalty { get; set; }

  /// <summary>
  /// When searching for an enemy to attack, a higher `health_penalty` will discourage targeting enemies with high health. A negative penalty will do the opposite.
  /// </summary>
  [FactorioRconAttribute("health_penalty")]
  public float HealthPenalty { get; set; }

  /// <summary>
  /// If less than `range`, the entity will choose a random distance between `range` and `min_attack_distance` and attack from that distance. Used for spitters.
  /// </summary>
  [FactorioRconAttribute("min_attack_distance")]
  public float MinAttackDistance { get; set; }

  /// <summary>
  /// The arc that the entity can attack in as a fraction of a circle. A value of `1` means the full 360 degrees.
  /// </summary>
  [FactorioRconAttribute("turn_range")]
  public float TurnRange { get; set; }

  /// <summary>
  /// Multiplier applied to the damage of an attack.
  /// </summary>
  [FactorioRconAttribute("damage_modifier")]
  public float DamageModifier { get; set; }

  /// <summary>
  /// Multiplier applied to the ammo consumption of an attack.
  /// </summary>
  [FactorioRconAttribute("ammo_consumption_modifier")]
  public float AmmoConsumptionModifier { get; set; }

  /// <summary>
  /// Minimum amount of ticks between shots. If this is less than `1`, multiple shots can be performed per tick.
  /// </summary>
  [FactorioRconAttribute("cooldown")]
  public float Cooldown { get; set; }

  /// <summary>
  /// Number of ticks it takes for the weapon to actually shoot after it has been ordered to do so.
  /// </summary>
  [FactorioRconAttribute("warmup")]
  public uint Warmup { get; set; }

  [FactorioRconAttribute("movement_slow_down_factor")]
  public double MovementSlowDownFactor { get; set; }

  [FactorioRconAttribute("movement_slow_down_cooldown")]
  public float MovementSlowDownCooldown { get; set; }

  [FactorioRconAttribute("ammo_type")]
  public AmmoType AmmoType { get; set; }

  /// <summary>
  /// List of the names of compatible <see cref="LuaAmmoCategoryPrototype" />.
  /// </summary>
  [FactorioRconAttribute("ammo_categories")]
  public LuaArray<string> AmmoCategories { get; set; }

}

