#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("Decorative")]
public abstract class Decorative
{
  /// <summary>
  /// The name of the decorative prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("position")]
  public TilePosition Position { get; set; }

  [FactorioRconAttribute("amount")]
  public byte Amount { get; set; }

}

public abstract class Table32101292
{
  /// <summary>
  /// The name of the decorative prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("position")]
  public TilePosition Position { get; set; }

  [FactorioRconAttribute("amount")]
  public byte Amount { get; set; }

}

