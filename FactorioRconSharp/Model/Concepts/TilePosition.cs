#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Coordinates of a tile on a <see cref="MapPosition" />, except it rounds any non-integer `x`/`y` down to whole numbers. It can be specified either with or without explicit keys.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TilePosition")]
public abstract partial class TilePosition: OneOfBase<Table45227282, Table16105313>
{
}

public abstract class Table45227282
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Table16105313
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

