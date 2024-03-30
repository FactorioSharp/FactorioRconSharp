#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TrainPathAllGoalsResult")]
public class TrainPathAllGoalsResult
{
  /// <summary>
  ///     Amount of goals that are accessible.
  /// </summary>
  [FactorioRconAttribute("amount_accessible")]
    public uint AmountAccessible { get; set; }

  /// <summary>
  ///     Array of the same length as requested goals: each field will tell if related goal is accessible for the train.
  /// </summary>
  [FactorioRconAttribute("accessible")]
    public List<bool> Accessible { get; set; }

  /// <summary>
  ///     Array of the same length as requested goals. Only present if request type was `"all-goals-penalties"`.
  /// </summary>
  [FactorioRconAttribute("penalties")]
    public List<double> Penalties { get; set; }

  /// <summary>
  ///     Amount of steps pathfinder performed. This is a measure of how expensive this search was.
  /// </summary>
  [FactorioRconAttribute("steps_count")]
    public uint StepsCount { get; set; }
}
