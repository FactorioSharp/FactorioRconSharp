#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// Various game-related settings. Updating any of the attributes will immediately take effect in the game engine.
/// </summary>
[FactorioRconConcept("MapSettings")]
public class MapSettings
{
  [FactorioRconAttribute("pollution")]
  public PollutionMapSettings Pollution { get; set; }

  [FactorioRconAttribute("enemy_evolution")]
  public EnemyEvolutionMapSettings EnemyEvolution { get; set; }

  [FactorioRconAttribute("enemy_expansion")]
  public EnemyExpansionMapSettings EnemyExpansion { get; set; }

  [FactorioRconAttribute("unit_group")]
  public UnitGroupMapSettings UnitGroup { get; set; }

  [FactorioRconAttribute("steering")]
  public SteeringMapSetting Steering { get; set; }

  [FactorioRconAttribute("path_finder")]
  public PathFinderMapSettings PathFinder { get; set; }

  /// <summary>
  /// If a behavior fails this many times, the enemy (or enemy group) is destroyed. This solves biters getting stuck within their own base.
  /// </summary>
  [FactorioRconAttribute("max_failed_behavior_count")]
  public uint MaxFailedBehaviorCount { get; set; }

}

