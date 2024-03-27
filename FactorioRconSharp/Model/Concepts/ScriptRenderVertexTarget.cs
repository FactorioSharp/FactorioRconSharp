#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// One vertex of a ScriptRenderPolygon.
/// </summary>
[FactorioRconConcept("ScriptRenderVertexTarget")]
public abstract class ScriptRenderVertexTarget
{
  [FactorioRconAttribute("target")]
  public Union48624990 Target { get; set; }

  /// <summary>
  /// Only used if `target` is a LuaEntity.
  /// </summary>
  [FactorioRconAttribute("target_offset")]
  public Vector TargetOffset { get; set; }

}

public abstract class Table34272077
{
  [FactorioRconAttribute("target")]
  public Union48624990 Target { get; set; }

  /// <summary>
  /// Only used if `target` is a LuaEntity.
  /// </summary>
  [FactorioRconAttribute("target_offset")]
  public Vector TargetOffset { get; set; }

}

[GenerateOneOf]
public abstract partial class Union48624990: OneOfBase<MapPosition, LuaEntity>
{
}

