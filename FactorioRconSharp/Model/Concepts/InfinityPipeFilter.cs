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
/// A single filter used by an infinity-pipe type entity.
/// </summary>
[FactorioRconConcept("InfinityPipeFilter")]
public class InfinityPipeFilter
{
  /// <summary>
  /// Name of the fluid.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The fill percentage the pipe (`0.5` for 50%). Can't be negative.
  /// </summary>
  [FactorioRconAttribute("percentage")]
  public double Percentage { get; set; }

  /// <summary>
  /// The temperature of the fluid. Defaults to the default/minimum temperature of the fluid.
  /// </summary>
  [FactorioRconAttribute("temperature")]
  public double Temperature { get; set; }

  /// <summary>
  /// Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Literals345820148 Mode { get; set; }

}

