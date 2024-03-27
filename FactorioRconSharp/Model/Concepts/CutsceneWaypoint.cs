#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CutsceneWaypoint")]
public abstract class CutsceneWaypoint
{
  /// <summary>
  /// Position to pan the camera to.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  /// <summary>
  /// Entity or unit group to pan the camera to.
  /// </summary>
  [FactorioRconAttribute("target")]
  public Union58648462 Target { get; set; }

  /// <summary>
  /// How many ticks it will take to reach this waypoint from the previous one.
  /// </summary>
  [FactorioRconAttribute("transition_time")]
  public uint TransitionTime { get; set; }

  /// <summary>
  /// Time in ticks to wait before moving to the next waypoint.
  /// </summary>
  [FactorioRconAttribute("time_to_wait")]
  public uint TimeToWait { get; set; }

  /// <summary>
  /// Zoom level to be set when the waypoint is reached. When not specified, the previous waypoint's zoom is used.
  /// </summary>
  [FactorioRconAttribute("zoom")]
  public double Zoom { get; set; }

}

public abstract class Table52932533
{
  /// <summary>
  /// Position to pan the camera to.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  /// <summary>
  /// Entity or unit group to pan the camera to.
  /// </summary>
  [FactorioRconAttribute("target")]
  public Union58648462 Target { get; set; }

  /// <summary>
  /// How many ticks it will take to reach this waypoint from the previous one.
  /// </summary>
  [FactorioRconAttribute("transition_time")]
  public uint TransitionTime { get; set; }

  /// <summary>
  /// Time in ticks to wait before moving to the next waypoint.
  /// </summary>
  [FactorioRconAttribute("time_to_wait")]
  public uint TimeToWait { get; set; }

  /// <summary>
  /// Zoom level to be set when the waypoint is reached. When not specified, the previous waypoint's zoom is used.
  /// </summary>
  [FactorioRconAttribute("zoom")]
  public double Zoom { get; set; }

}

[GenerateOneOf]
public abstract partial class Union58648462: OneOfBase<LuaEntity, LuaUnitGroup>
{
}

