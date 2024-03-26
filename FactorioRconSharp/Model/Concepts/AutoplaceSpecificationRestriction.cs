#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("AutoplaceSpecificationRestriction")]
public abstract class AutoplaceSpecificationRestriction
{
  /// <summary>
  /// Tile prototype name
  /// </summary>
  [FactorioRconAttribute("first")]
  public string First { get; set; }

  /// <summary>
  /// Second prototype name
  /// </summary>
  [FactorioRconAttribute("second")]
  public string Second { get; set; }

}

public abstract class Table51882681
{
  /// <summary>
  /// Tile prototype name
  /// </summary>
  [FactorioRconAttribute("first")]
  public string First { get; set; }

  /// <summary>
  /// Second prototype name
  /// </summary>
  [FactorioRconAttribute("second")]
  public string Second { get; set; }

}

