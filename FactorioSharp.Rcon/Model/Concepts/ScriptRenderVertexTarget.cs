#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     One vertex of a ScriptRenderPolygon.
/// </summary>
[FactorioRconConcept("ScriptRenderVertexTarget")]
public class ScriptRenderVertexTarget
{
    [FactorioRconAttribute("target")]
    public Union5349442 Target { get; set; }

    /// <summary>
    ///     Only used if `target` is a LuaEntity.
    /// </summary>
    [FactorioRconAttribute("target_offset")]
    public Vector TargetOffset { get; set; }
}
