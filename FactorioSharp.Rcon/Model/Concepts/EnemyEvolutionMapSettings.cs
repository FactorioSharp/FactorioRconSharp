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
/// These values represent a percentual increase in evolution. This means a value of `0.1` would increase evolution by 10%.
/// </summary>
[FactorioRconConcept("EnemyEvolutionMapSettings")]
public class EnemyEvolutionMapSettings: IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

