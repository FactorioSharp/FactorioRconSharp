#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("FluidBoxFilter")]
public abstract class FluidBoxFilter
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

}

