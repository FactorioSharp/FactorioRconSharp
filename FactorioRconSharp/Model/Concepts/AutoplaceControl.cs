#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("AutoplaceControl")]
public abstract class AutoplaceControl
{
  /// <summary>
  /// For things that are placed as spots such as ores and enemy bases, frequency is generally proportional to number of spots placed per unit area. For continuous features such as forests, frequency is how compressed the probability function is over distance, i.e. the inverse of 'scale' (similar to terrain_segmentation). When the <see cref="LuaAutoplaceControlPrototype" /> is of the category `"terrain"`, then scale is shown in the map generator GUI instead of frequency.
  /// </summary>
  [FactorioRconAttribute("frequency")]
  public MapGenSize Frequency { get; set; }

  /// <summary>
  /// For things that are placed as spots, size is proportional to the area of each spot. For continuous features, size affects how much of the map is covered with the thing, and is called 'coverage' in the GUI.
  /// </summary>
  [FactorioRconAttribute("size")]
  public MapGenSize Size { get; set; }

  /// <summary>
  /// Has different effects for different things, but generally affects the 'health' or density of a thing that is placed without affecting where it is placed. For trees, richness affects tree health. For ores, richness multiplies the amount of ore at any given tile in a patch. Metadata about autoplace controls (such as whether or not 'richness' does anything for them) can be found in the <see cref="LuaAutoplaceControlPrototype)ByLookingUp`Game.AutoplaceControlPrototypes[(ControlPrototypeName" />]`, e.g. `game.autoplace_control_prototypes["enemy-base"].richness` is false, because enemy base autoplacement doesn't use richness.
  /// </summary>
  [FactorioRconAttribute("richness")]
  public MapGenSize Richness { get; set; }

}
