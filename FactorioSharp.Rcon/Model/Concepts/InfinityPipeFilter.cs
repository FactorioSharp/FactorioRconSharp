#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A single filter used by an infinity-pipe type entity.
/// </summary>
[FactorioRconConcept("InfinityPipeFilter")]
public class InfinityPipeFilter
{
  /// <summary>
  ///     Name of the fluid.
  /// </summary>
  [FactorioRconAttribute("name")]
    public string Name { get; set; }

  /// <summary>
  ///     The fill percentage the pipe (`0.5` for 50%). Can't be negative.
  /// </summary>
  [FactorioRconAttribute("percentage")]
    public double Percentage { get; set; }

  /// <summary>
  ///     The temperature of the fluid. Defaults to the default/minimum temperature of the fluid.
  /// </summary>
  [FactorioRconAttribute("temperature")]
    public double Temperature { get; set; }

  /// <summary>
  ///     Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
    public Literals2137799683 Mode { get; set; }
}
