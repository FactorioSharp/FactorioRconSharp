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
/// Candidate chunks are given scores to determine which one of them should be expanded into. This score takes into account various settings noted below. The iteration is over a square region centered around the chunk for which the calculation is done, and includes the central chunk as well. Distances are calculated as [Manhattan distance](https://en.wikipedia.org/wiki/Taxicab_geometry).
/// 
/// The pseudocode algorithm to determine a chunk's score is as follows:
/// 
/// ```
/// player = 0
/// for neighbour in all chunks within enemy_building_influence_radius from chunk:
///   player += number of player buildings on neighbour
///           * building_coefficient
///           * neighbouring_chunk_coefficient^distance(chunk, neighbour)
/// 
/// base = 0
/// for neighbour in all chunk within friendly_base_influence_radius from chunk:
///   base += num of enemy bases on neighbour
///           * other_base_coefficient
///           * neighbouring_base_chunk_coefficient^distance(chunk, neighbour)
/// 
/// score(chunk) = 1 / (1 + player + base)
/// ```
/// </summary>
[FactorioRconConcept("EnemyExpansionMapSettings")]
public abstract class EnemyExpansionMapSettings
{
  /// <summary>
  /// Whether enemy expansion is enabled at all.
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; set; }

  /// <summary>
  /// Distance in chunks from the furthest base around to prevent expansions from reaching too far into the player's territory. Defaults to `7`.
  /// </summary>
  [FactorioRconAttribute("max_expansion_distance")]
  public uint MaxExpansionDistance { get; set; }

  /// <summary>
  /// Defaults to `2`.
  /// </summary>
  [FactorioRconAttribute("friendly_base_influence_radius")]
  public uint FriendlyBaseInfluenceRadius { get; set; }

  /// <summary>
  /// Defaults to `2`.
  /// </summary>
  [FactorioRconAttribute("enemy_building_influence_radius")]
  public uint EnemyBuildingInfluenceRadius { get; set; }

  /// <summary>
  /// Defaults to `0.1`.
  /// </summary>
  [FactorioRconAttribute("building_coefficient")]
  public double BuildingCoefficient { get; set; }

  /// <summary>
  /// Defaults to `2.0`.
  /// </summary>
  [FactorioRconAttribute("other_base_coefficient")]
  public double OtherBaseCoefficient { get; set; }

  /// <summary>
  /// Defaults to `0.5`.
  /// </summary>
  [FactorioRconAttribute("neighbouring_chunk_coefficient")]
  public double NeighbouringChunkCoefficient { get; set; }

  /// <summary>
  /// Defaults to `0.4`.
  /// </summary>
  [FactorioRconAttribute("neighbouring_base_chunk_coefficient")]
  public double NeighbouringBaseChunkCoefficient { get; set; }

  /// <summary>
  /// A chunk has to have at most this high of a percentage of unbuildable tiles for it to be considered a candidate to avoid chunks full of water as candidates. Defaults to `0.9`, or 90%.
  /// </summary>
  [FactorioRconAttribute("max_colliding_tiles_coefficient")]
  public double MaxCollidingTilesCoefficient { get; set; }

  /// <summary>
  /// The minimum size of a biter group that goes to build a new base. This is multiplied by the evolution factor. Defaults to `5`.
  /// </summary>
  [FactorioRconAttribute("settler_group_min_size")]
  public uint SettlerGroupMinSize { get; set; }

  /// <summary>
  /// The maximum size of a biter group that goes to build a new base. This is multiplied by the evolution factor. Defaults to `20`.
  /// </summary>
  [FactorioRconAttribute("settler_group_max_size")]
  public uint SettlerGroupMaxSize { get; set; }

  /// <summary>
  /// The minimum time between expansions in ticks. The actual cooldown is adjusted to the current evolution levels. Defaults to `4*3 600=14 400` ticks.
  /// </summary>
  [FactorioRconAttribute("min_expansion_cooldown")]
  public uint MinExpansionCooldown { get; set; }

  /// <summary>
  /// The maximum time between expansions in ticks. The actual cooldown is adjusted to the current evolution levels. Defaults to `60*3 600=216 000` ticks.
  /// </summary>
  [FactorioRconAttribute("max_expansion_cooldown")]
  public uint MaxExpansionCooldown { get; set; }

}

public abstract class Table44927025
{
  /// <summary>
  /// Whether enemy expansion is enabled at all.
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; set; }

  /// <summary>
  /// Distance in chunks from the furthest base around to prevent expansions from reaching too far into the player's territory. Defaults to `7`.
  /// </summary>
  [FactorioRconAttribute("max_expansion_distance")]
  public uint MaxExpansionDistance { get; set; }

  /// <summary>
  /// Defaults to `2`.
  /// </summary>
  [FactorioRconAttribute("friendly_base_influence_radius")]
  public uint FriendlyBaseInfluenceRadius { get; set; }

  /// <summary>
  /// Defaults to `2`.
  /// </summary>
  [FactorioRconAttribute("enemy_building_influence_radius")]
  public uint EnemyBuildingInfluenceRadius { get; set; }

  /// <summary>
  /// Defaults to `0.1`.
  /// </summary>
  [FactorioRconAttribute("building_coefficient")]
  public double BuildingCoefficient { get; set; }

  /// <summary>
  /// Defaults to `2.0`.
  /// </summary>
  [FactorioRconAttribute("other_base_coefficient")]
  public double OtherBaseCoefficient { get; set; }

  /// <summary>
  /// Defaults to `0.5`.
  /// </summary>
  [FactorioRconAttribute("neighbouring_chunk_coefficient")]
  public double NeighbouringChunkCoefficient { get; set; }

  /// <summary>
  /// Defaults to `0.4`.
  /// </summary>
  [FactorioRconAttribute("neighbouring_base_chunk_coefficient")]
  public double NeighbouringBaseChunkCoefficient { get; set; }

  /// <summary>
  /// A chunk has to have at most this high of a percentage of unbuildable tiles for it to be considered a candidate to avoid chunks full of water as candidates. Defaults to `0.9`, or 90%.
  /// </summary>
  [FactorioRconAttribute("max_colliding_tiles_coefficient")]
  public double MaxCollidingTilesCoefficient { get; set; }

  /// <summary>
  /// The minimum size of a biter group that goes to build a new base. This is multiplied by the evolution factor. Defaults to `5`.
  /// </summary>
  [FactorioRconAttribute("settler_group_min_size")]
  public uint SettlerGroupMinSize { get; set; }

  /// <summary>
  /// The maximum size of a biter group that goes to build a new base. This is multiplied by the evolution factor. Defaults to `20`.
  /// </summary>
  [FactorioRconAttribute("settler_group_max_size")]
  public uint SettlerGroupMaxSize { get; set; }

  /// <summary>
  /// The minimum time between expansions in ticks. The actual cooldown is adjusted to the current evolution levels. Defaults to `4*3 600=14 400` ticks.
  /// </summary>
  [FactorioRconAttribute("min_expansion_cooldown")]
  public uint MinExpansionCooldown { get; set; }

  /// <summary>
  /// The maximum time between expansions in ticks. The actual cooldown is adjusted to the current evolution levels. Defaults to `60*3 600=216 000` ticks.
  /// </summary>
  [FactorioRconAttribute("max_expansion_cooldown")]
  public uint MaxExpansionCooldown { get; set; }

}

