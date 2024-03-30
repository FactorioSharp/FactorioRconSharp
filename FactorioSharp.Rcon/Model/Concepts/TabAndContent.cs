#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TabAndContent")]
public class TabAndContent
{
  [FactorioRconAttribute("tab")]
  public LuaGuiElement Tab { get; set; }

  [FactorioRconAttribute("content")]
  public LuaGuiElement Content { get; set; }

}

