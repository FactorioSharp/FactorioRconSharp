#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("RailEnd")]
public abstract class RailEnd
{
  [FactorioRconAttribute("rail")]
  public LuaEntity Rail { get; set; }

  [FactorioRconAttribute("direction")]
  public RailDirectionEnum Direction { get; set; }

}

public abstract class Table8587493
{
  [FactorioRconAttribute("rail")]
  public LuaEntity Rail { get; set; }

  [FactorioRconAttribute("direction")]
  public RailDirectionEnum Direction { get; set; }

}

