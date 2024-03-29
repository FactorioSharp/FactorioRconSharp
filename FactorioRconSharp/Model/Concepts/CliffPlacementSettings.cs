#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CliffPlacementSettings")]
public class CliffPlacementSettings
{
  /// <summary>
  /// Name of the cliff prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// Elevation at which the first row of cliffs is placed. The default is `10`, and this cannot be set from the map generation GUI.
  /// </summary>
  [FactorioRconAttribute("cliff_elevation_0")]
  public float CliffElevation0 { get; set; }

  /// <summary>
  /// Elevation difference between successive rows of cliffs. This is inversely proportional to 'frequency' in the map generation GUI. Specifically, when set from the GUI the value is `40 / frequency`.
  /// </summary>
  [FactorioRconAttribute("cliff_elevation_interval")]
  public float CliffElevationInterval { get; set; }

  /// <summary>
  /// Corresponds to 'continuity' in the GUI. This value is not used directly, but is used by the 'cliffiness' noise expression, which in combination with elevation and the two cliff elevation properties drives cliff placement (cliffs are placed when elevation crosses the elevation contours defined by `cliff_elevation_0` and `cliff_elevation_interval` when 'cliffiness' is greater than `0.5`). The default 'cliffiness' expression interprets this value such that larger values result in longer unbroken walls of cliffs, and smaller values (between `0` and `1`) result in larger gaps in cliff walls.
  /// </summary>
  [FactorioRconAttribute("richness")]
  public MapGenSize Richness { get; set; }

}

