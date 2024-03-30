#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("FluidBoxFilterSpec")]
public class FluidBoxFilterSpec: IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

