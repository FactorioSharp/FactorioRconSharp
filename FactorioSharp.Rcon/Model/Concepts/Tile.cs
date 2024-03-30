#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Tile")]
public class Tile
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

