#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("SpawnPointDefinition")]
public class SpawnPointDefinition
{
  /// <summary>
  ///     Evolution factor for which this weight applies.
  /// </summary>
  [FactorioRconAttribute("evolution_factor")]
    public double EvolutionFactor { get; set; }

  /// <summary>
  ///     Probability of spawning this unit at this evolution factor.
  /// </summary>
  [FactorioRconAttribute("weight")]
    public double Weight { get; set; }
}
