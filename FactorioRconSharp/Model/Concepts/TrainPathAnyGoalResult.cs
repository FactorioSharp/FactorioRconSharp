#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TrainPathAnyGoalResult")]
public class TrainPathAnyGoalResult
{
  /// <summary>
  /// True if any goal was accessible.
  /// </summary>
  [FactorioRconAttribute("found_path")]
  public bool FoundPath { get; set; }

  /// <summary>
  /// If any goal was accessible, this gives index of the particular goal that was found.
  /// </summary>
  [FactorioRconAttribute("goal_index")]
  public uint GoalIndex { get; set; }

  /// <summary>
  /// Penalty of the path to goal if a goal was accessible.
  /// </summary>
  [FactorioRconAttribute("penalty")]
  public double Penalty { get; set; }

  /// <summary>
  /// Amount of steps pathfinder performed. This is a measure of how expensive this search was.
  /// </summary>
  [FactorioRconAttribute("steps_count")]
  public uint StepsCount { get; set; }

}

