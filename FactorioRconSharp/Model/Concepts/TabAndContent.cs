#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TabAndContent")]
public abstract class TabAndContent
{
  [FactorioRconAttribute("tab")]
  public LuaGuiElement Tab { get; set; }

  [FactorioRconAttribute("content")]
  public LuaGuiElement Content { get; set; }

}

public abstract class Table593062
{
  [FactorioRconAttribute("tab")]
  public LuaGuiElement Tab { get; set; }

  [FactorioRconAttribute("content")]
  public LuaGuiElement Content { get; set; }

}

