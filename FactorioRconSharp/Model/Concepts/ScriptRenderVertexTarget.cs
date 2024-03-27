#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// One vertex of a ScriptRenderPolygon.
/// </summary>
[FactorioRconConcept("ScriptRenderVertexTarget")]
public abstract class ScriptRenderVertexTarget
{
  [FactorioRconAttribute("target")]
  public Union_2570cd50128d4b35b85d8a174fdba3f6 Target { get; set; }

  /// <summary>
  /// Only used if `target` is a LuaEntity.
  /// </summary>
  [FactorioRconAttribute("target_offset")]
  public Vector TargetOffset { get; set; }

}

