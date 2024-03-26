#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("OldTileAndPosition")]
public abstract class OldTileAndPosition
{
  [FactorioRconAttribute("old_tile")]
  public LuaTilePrototype OldTile { get; set; }

  [FactorioRconAttribute("position")]
  public TilePosition Position { get; set; }

}

public abstract class Table16083019
{
  [FactorioRconAttribute("old_tile")]
  public LuaTilePrototype OldTile { get; set; }

  [FactorioRconAttribute("position")]
  public TilePosition Position { get; set; }

}

