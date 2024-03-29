#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// These values represent a percentual increase in evolution. This means a value of `0.1` would increase evolution by 10%.
/// </summary>
[FactorioRconConcept("EnemyEvolutionMapSettings")]
public class EnemyEvolutionMapSettings
{
  /// <summary>
  /// Whether enemy evolution is enabled at all.
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; set; }

  /// <summary>
  /// The amount evolution naturally progresses by every second. Defaults to `0.000004`.
  /// </summary>
  [FactorioRconAttribute("time_factor")]
  public double TimeFactor { get; set; }

  /// <summary>
  /// The amount evolution progresses for every destroyed spawner. Defaults to `0.002`.
  /// </summary>
  [FactorioRconAttribute("destroy_factor")]
  public double DestroyFactor { get; set; }

  /// <summary>
  /// The amount evolution progresses for every unit of pollution. Defaults to `0.0000009`.
  /// </summary>
  [FactorioRconAttribute("pollution_factor")]
  public double PollutionFactor { get; set; }

}

