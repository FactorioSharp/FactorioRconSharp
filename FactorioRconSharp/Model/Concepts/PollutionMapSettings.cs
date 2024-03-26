#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// These values are for the time frame of one second (60 ticks).
/// </summary>
[FactorioRconConcept("PollutionMapSettings")]
public abstract class PollutionMapSettings
{
  /// <summary>
  /// Whether pollution is enabled at all.
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; set; }

  /// <summary>
  /// The amount that is diffused to a neighboring chunk (possibly repeated for other directions as well). Defaults to `0.02`.
  /// </summary>
  [FactorioRconAttribute("diffusion_ratio")]
  public double DiffusionRatio { get; set; }

  /// <summary>
  /// The amount of PUs that need to be in a chunk for it to start diffusing. Defaults to `15`.
  /// </summary>
  [FactorioRconAttribute("min_to_diffuse")]
  public double MinToDiffuse { get; set; }

  /// <summary>
  /// The amount of pollution eaten by a chunk's tiles as a percentage of 1. Defaults to `1`.
  /// </summary>
  [FactorioRconAttribute("ageing")]
  public double Ageing { get; set; }

  /// <summary>
  /// Any amount of pollution larger than this value is visualized as this value instead. Defaults to `150`.
  /// </summary>
  [FactorioRconAttribute("expected_max_per_chunk")]
  public double ExpectedMaxPerChunk { get; set; }

  /// <summary>
  /// Any amount of pollution smaller than this value (but bigger than zero) is visualized as this value instead. Defaults to `50`.
  /// </summary>
  [FactorioRconAttribute("min_to_show_per_chunk")]
  public double MinToShowPerChunk { get; set; }

  /// <summary>
  /// Defaults to `60`.
  /// </summary>
  [FactorioRconAttribute("min_pollution_to_damage_trees")]
  public double MinPollutionToDamageTrees { get; set; }

  /// <summary>
  /// Defaults to `150`.
  /// </summary>
  [FactorioRconAttribute("pollution_with_max_forest_damage")]
  public double PollutionWithMaxForestDamage { get; set; }

  /// <summary>
  /// Defaults to `50`.
  /// </summary>
  [FactorioRconAttribute("pollution_per_tree_damage")]
  public double PollutionPerTreeDamage { get; set; }

  /// <summary>
  /// Defaults to `10`.
  /// </summary>
  [FactorioRconAttribute("pollution_restored_per_tree_damage")]
  public double PollutionRestoredPerTreeDamage { get; set; }

  /// <summary>
  /// Defaults to `20`.
  /// </summary>
  [FactorioRconAttribute("max_pollution_to_restore_trees")]
  public double MaxPollutionToRestoreTrees { get; set; }

  /// <summary>
  /// Defaults to `1`.
  /// </summary>
  [FactorioRconAttribute("enemy_attack_pollution_consumption_modifier")]
  public double EnemyAttackPollutionConsumptionModifier { get; set; }

}

public abstract class Table18805330
{
  /// <summary>
  /// Whether pollution is enabled at all.
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; set; }

  /// <summary>
  /// The amount that is diffused to a neighboring chunk (possibly repeated for other directions as well). Defaults to `0.02`.
  /// </summary>
  [FactorioRconAttribute("diffusion_ratio")]
  public double DiffusionRatio { get; set; }

  /// <summary>
  /// The amount of PUs that need to be in a chunk for it to start diffusing. Defaults to `15`.
  /// </summary>
  [FactorioRconAttribute("min_to_diffuse")]
  public double MinToDiffuse { get; set; }

  /// <summary>
  /// The amount of pollution eaten by a chunk's tiles as a percentage of 1. Defaults to `1`.
  /// </summary>
  [FactorioRconAttribute("ageing")]
  public double Ageing { get; set; }

  /// <summary>
  /// Any amount of pollution larger than this value is visualized as this value instead. Defaults to `150`.
  /// </summary>
  [FactorioRconAttribute("expected_max_per_chunk")]
  public double ExpectedMaxPerChunk { get; set; }

  /// <summary>
  /// Any amount of pollution smaller than this value (but bigger than zero) is visualized as this value instead. Defaults to `50`.
  /// </summary>
  [FactorioRconAttribute("min_to_show_per_chunk")]
  public double MinToShowPerChunk { get; set; }

  /// <summary>
  /// Defaults to `60`.
  /// </summary>
  [FactorioRconAttribute("min_pollution_to_damage_trees")]
  public double MinPollutionToDamageTrees { get; set; }

  /// <summary>
  /// Defaults to `150`.
  /// </summary>
  [FactorioRconAttribute("pollution_with_max_forest_damage")]
  public double PollutionWithMaxForestDamage { get; set; }

  /// <summary>
  /// Defaults to `50`.
  /// </summary>
  [FactorioRconAttribute("pollution_per_tree_damage")]
  public double PollutionPerTreeDamage { get; set; }

  /// <summary>
  /// Defaults to `10`.
  /// </summary>
  [FactorioRconAttribute("pollution_restored_per_tree_damage")]
  public double PollutionRestoredPerTreeDamage { get; set; }

  /// <summary>
  /// Defaults to `20`.
  /// </summary>
  [FactorioRconAttribute("max_pollution_to_restore_trees")]
  public double MaxPollutionToRestoreTrees { get; set; }

  /// <summary>
  /// Defaults to `1`.
  /// </summary>
  [FactorioRconAttribute("enemy_attack_pollution_consumption_modifier")]
  public double EnemyAttackPollutionConsumptionModifier { get; set; }

}

