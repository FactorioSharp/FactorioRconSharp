#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("Tile")]
public abstract class Tile
{
  /// <summary>
  /// The position of the tile.
  /// </summary>
  [FactorioRconAttribute("position")]
  public TilePosition Position { get; set; }

  /// <summary>
  /// The prototype name of the tile.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

public abstract class Table7752592
{
  /// <summary>
  /// The position of the tile.
  /// </summary>
  [FactorioRconAttribute("position")]
  public TilePosition Position { get; set; }

  /// <summary>
  /// The prototype name of the tile.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

