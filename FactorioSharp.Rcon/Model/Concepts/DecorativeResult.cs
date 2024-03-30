#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("DecorativeResult")]
public class DecorativeResult
{
  [FactorioRconAttribute("position")]
  public TilePosition Position { get; set; }

  [FactorioRconAttribute("decorative")]
  public LuaDecorativePrototype Decorative { get; set; }

  [FactorioRconAttribute("amount")]
  public uint Amount { get; set; }

}

