#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// One vertex of a ScriptRenderPolygon.
/// </summary>
[FactorioRconConcept("ScriptRenderVertexTarget")]
public class ScriptRenderVertexTarget
{
  [FactorioRconAttribute("target")]
  public Union113870108 Target { get; set; }

  /// <summary>
  /// Only used if `target` is a LuaEntity.
  /// </summary>
  [FactorioRconAttribute("target_offset")]
  public Vector TargetOffset { get; set; }

}

