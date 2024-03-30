#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Resistance")]
public class Resistance
{
  /// <summary>
  ///     Absolute damage decrease
  /// </summary>
  [FactorioRconAttribute("decrease")]
    public float Decrease { get; set; }

  /// <summary>
  ///     Percentual damage decrease
  /// </summary>
  [FactorioRconAttribute("percent")]
    public float Percent { get; set; }
}
