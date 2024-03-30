#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Fluid")]
public class Fluid
{
  /// <summary>
  /// Fluid prototype name of the fluid.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// Amount of the fluid.
  /// </summary>
  [FactorioRconAttribute("amount")]
  public double Amount { get; set; }

  /// <summary>
  /// The temperature. When reading from <see cref="LuaFluidBox" />, this field will always be present. It is not necessary to specify it when writing, however. When not specified, the fluid will be set to the fluid's default temperature as specified in the fluid's prototype.
  /// </summary>
  [FactorioRconAttribute("temperature")]
  public double Temperature { get; set; }

}

