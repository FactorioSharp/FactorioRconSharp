#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("SpawnPointDefinition")]
public abstract class SpawnPointDefinition
{
  /// <summary>
  /// Evolution factor for which this weight applies.
  /// </summary>
  [FactorioRconAttribute("evolution_factor")]
  public double EvolutionFactor { get; set; }

  /// <summary>
  /// Probability of spawning this unit at this evolution factor.
  /// </summary>
  [FactorioRconAttribute("weight")]
  public double Weight { get; set; }

}

public abstract class Table27867915
{
  /// <summary>
  /// Evolution factor for which this weight applies.
  /// </summary>
  [FactorioRconAttribute("evolution_factor")]
  public double EvolutionFactor { get; set; }

  /// <summary>
  /// Probability of spawning this unit at this evolution factor.
  /// </summary>
  [FactorioRconAttribute("weight")]
  public double Weight { get; set; }

}

