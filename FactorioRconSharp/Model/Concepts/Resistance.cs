#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("Resistance")]
public abstract class Resistance
{
  /// <summary>
  /// Absolute damage decrease
  /// </summary>
  [FactorioRconAttribute("decrease")]
  public float Decrease { get; set; }

  /// <summary>
  /// Percentual damage decrease
  /// </summary>
  [FactorioRconAttribute("percent")]
  public float Percent { get; set; }

}

public abstract class Table16125021
{
  /// <summary>
  /// Absolute damage decrease
  /// </summary>
  [FactorioRconAttribute("decrease")]
  public float Decrease { get; set; }

  /// <summary>
  /// Percentual damage decrease
  /// </summary>
  [FactorioRconAttribute("percent")]
  public float Percent { get; set; }

}

