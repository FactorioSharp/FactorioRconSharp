#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TrainPathAnyGoalResult")]
public class TrainPathAnyGoalResult: IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

