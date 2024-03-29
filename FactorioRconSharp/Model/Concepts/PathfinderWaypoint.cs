#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("PathfinderWaypoint")]
public class PathfinderWaypoint
{
  /// <summary>
  /// The position of the waypoint on its surface.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  /// <summary>
  /// `true` if the path from the previous waypoint to this one goes through an entity that must be destroyed.
  /// </summary>
  [FactorioRconAttribute("needs_destroy_to_reach")]
  public bool NeedsDestroyToReach { get; set; }

}

