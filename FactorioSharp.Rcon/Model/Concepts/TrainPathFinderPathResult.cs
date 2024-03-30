#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TrainPathFinderPathResult")]
public class TrainPathFinderPathResult
{
  /// <summary>
  /// True if found path.
  /// </summary>
  [FactorioRconAttribute("found_path")]
  public bool FoundPath { get; set; }

  /// <summary>
  /// Only returned if `return_path` was set to true and path was found. Contains all rails in order that are part of the found path.
  /// </summary>
  [FactorioRconAttribute("path")]
  public List<LuaEntity> Path { get; set; }

  /// <summary>
  /// If path was found, provides index of the specific goal to which the path goes to.
  /// </summary>
  [FactorioRconAttribute("goal_index")]
  public uint GoalIndex { get; set; }

  /// <summary>
  /// Penalty of the path to goal if path was found.
  /// </summary>
  [FactorioRconAttribute("penalty")]
  public double Penalty { get; set; }

  /// <summary>
  /// If path was found, provides total length of all rails of the path.
  /// </summary>
  [FactorioRconAttribute("total_length")]
  public double TotalLength { get; set; }

  /// <summary>
  /// If path was found, tells if the path was reached from the `from_front` or train's front end.
  /// </summary>
  [FactorioRconAttribute("is_front")]
  public bool IsFront { get; set; }

  /// <summary>
  /// Amount of steps pathfinder performed. This is a measure of how expensive this search was.
  /// </summary>
  [FactorioRconAttribute("steps_count")]
  public uint StepsCount { get; set; }

}

