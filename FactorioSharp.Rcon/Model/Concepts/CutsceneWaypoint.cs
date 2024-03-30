#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("CutsceneWaypoint")]
public class CutsceneWaypoint
{
  /// <summary>
  ///     Position to pan the camera to.
  /// </summary>
  [FactorioRconAttribute("position")]
    public MapPosition Position { get; set; }

  /// <summary>
  ///     Entity or unit group to pan the camera to.
  /// </summary>
  [FactorioRconAttribute("target")]
    public Union699767741 Target { get; set; }

  /// <summary>
  ///     How many ticks it will take to reach this waypoint from the previous one.
  /// </summary>
  [FactorioRconAttribute("transition_time")]
    public uint TransitionTime { get; set; }

  /// <summary>
  ///     Time in ticks to wait before moving to the next waypoint.
  /// </summary>
  [FactorioRconAttribute("time_to_wait")]
    public uint TimeToWait { get; set; }

  /// <summary>
  ///     Zoom level to be set when the waypoint is reached. When not specified, the previous waypoint's zoom is used.
  /// </summary>
  [FactorioRconAttribute("zoom")]
    public double Zoom { get; set; }
}
