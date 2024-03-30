#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TabAndContent")]
public class TabAndContent
{
    [FactorioRconAttribute("tab")]
    public LuaGuiElement Tab { get; set; }

    [FactorioRconAttribute("content")]
    public LuaGuiElement Content { get; set; }
}
