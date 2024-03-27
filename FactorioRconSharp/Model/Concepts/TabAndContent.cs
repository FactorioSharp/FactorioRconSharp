#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TabAndContent")]
public abstract class TabAndContent
{
  [FactorioRconAttribute("tab")]
  public LuaGuiElement Tab { get; set; }

  [FactorioRconAttribute("content")]
  public LuaGuiElement Content { get; set; }

}

