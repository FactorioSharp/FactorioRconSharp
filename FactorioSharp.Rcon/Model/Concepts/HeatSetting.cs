#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     The settings used by a heat-interface type entity.
/// </summary>
[FactorioRconConcept("HeatSetting")]
public class HeatSetting
{
  /// <summary>
  ///     The target temperature. Defaults to the minimum temperature of the heat buffer.
  /// </summary>
  [FactorioRconAttribute("temperature")]
    public double Temperature { get; set; }

  /// <summary>
  ///     Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
    public Literals2128439232 Mode { get; set; }
}
