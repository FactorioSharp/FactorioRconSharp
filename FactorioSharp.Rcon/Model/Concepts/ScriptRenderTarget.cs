#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ScriptRenderTarget")]
public class ScriptRenderTarget
{
    [FactorioRconAttribute("entity")]
    public LuaEntity Entity { get; set; }

    [FactorioRconAttribute("entity_offset")]
    public Vector EntityOffset { get; set; }

    [FactorioRconAttribute("position")]
    public MapPosition Position { get; set; }
}
