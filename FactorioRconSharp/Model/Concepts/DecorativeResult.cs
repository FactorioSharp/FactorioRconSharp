#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("DecorativeResult")]
public abstract class DecorativeResult
{
  [FactorioRconAttribute("position")]
  public TilePosition Position { get; set; }

  [FactorioRconAttribute("decorative")]
  public LuaDecorativePrototype Decorative { get; set; }

  [FactorioRconAttribute("amount")]
  public uint Amount { get; set; }

}

public abstract class Table54145554
{
  [FactorioRconAttribute("position")]
  public TilePosition Position { get; set; }

  [FactorioRconAttribute("decorative")]
  public LuaDecorativePrototype Decorative { get; set; }

  [FactorioRconAttribute("amount")]
  public uint Amount { get; set; }

}

