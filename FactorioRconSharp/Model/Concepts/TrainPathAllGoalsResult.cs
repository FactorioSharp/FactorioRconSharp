#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TrainPathAllGoalsResult")]
public abstract class TrainPathAllGoalsResult
{
  /// <summary>
  /// Amount of goals that are accessible.
  /// </summary>
  [FactorioRconAttribute("amount_accessible")]
  public uint AmountAccessible { get; set; }

  /// <summary>
  /// Array of the same length as requested goals: each field will tell if related goal is accessible for the train.
  /// </summary>
  [FactorioRconAttribute("accessible")]
  public List<bool> Accessible { get; set; }

  /// <summary>
  /// Array of the same length as requested goals. Only present if request type was `"all-goals-penalties"`.
  /// </summary>
  [FactorioRconAttribute("penalties")]
  public List<double> Penalties { get; set; }

  /// <summary>
  /// Amount of steps pathfinder performed. This is a measure of how expensive this search was.
  /// </summary>
  [FactorioRconAttribute("steps_count")]
  public uint StepsCount { get; set; }

}

public abstract class Table5230407
{
  /// <summary>
  /// Amount of goals that are accessible.
  /// </summary>
  [FactorioRconAttribute("amount_accessible")]
  public uint AmountAccessible { get; set; }

  /// <summary>
  /// Array of the same length as requested goals: each field will tell if related goal is accessible for the train.
  /// </summary>
  [FactorioRconAttribute("accessible")]
  public List<bool> Accessible { get; set; }

  /// <summary>
  /// Array of the same length as requested goals. Only present if request type was `"all-goals-penalties"`.
  /// </summary>
  [FactorioRconAttribute("penalties")]
  public List<double> Penalties { get; set; }

  /// <summary>
  /// Amount of steps pathfinder performed. This is a measure of how expensive this search was.
  /// </summary>
  [FactorioRconAttribute("steps_count")]
  public uint StepsCount { get; set; }

}

