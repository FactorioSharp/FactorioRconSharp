#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("FluidBoxFilterSpec")]
public abstract class FluidBoxFilterSpec
{
  /// <summary>
  /// Fluid prototype name of the filtered fluid.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The minimum temperature allowed into the fluidbox.
  /// </summary>
  [FactorioRconAttribute("minimum_temperature")]
  public double MinimumTemperature { get; set; }

  /// <summary>
  /// The maximum temperature allowed into the fluidbox.
  /// </summary>
  [FactorioRconAttribute("maximum_temperature")]
  public double MaximumTemperature { get; set; }

  /// <summary>
  /// Force the filter to be set, regardless of current fluid content.
  /// </summary>
  [FactorioRconAttribute("force")]
  public bool Force { get; set; }

}

public abstract class Table43635917
{
  /// <summary>
  /// Fluid prototype name of the filtered fluid.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The minimum temperature allowed into the fluidbox.
  /// </summary>
  [FactorioRconAttribute("minimum_temperature")]
  public double MinimumTemperature { get; set; }

  /// <summary>
  /// The maximum temperature allowed into the fluidbox.
  /// </summary>
  [FactorioRconAttribute("maximum_temperature")]
  public double MaximumTemperature { get; set; }

  /// <summary>
  /// Force the filter to be set, regardless of current fluid content.
  /// </summary>
  [FactorioRconAttribute("force")]
  public bool Force { get; set; }

}

