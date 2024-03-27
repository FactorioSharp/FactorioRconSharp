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
/// The settings used by a heat-interface type entity.
/// </summary>
[FactorioRconConcept("HeatSetting")]
public abstract class HeatSetting
{
  /// <summary>
  /// The target temperature. Defaults to the minimum temperature of the heat buffer.
  /// </summary>
  [FactorioRconAttribute("temperature")]
  public double Temperature { get; set; }

  /// <summary>
  /// Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Literals_f75f1cba6e98411cad0faec8903619c0 Mode { get; set; }

}

