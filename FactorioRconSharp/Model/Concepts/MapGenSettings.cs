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
/// The 'map type' dropdown in the map generation GUI is actually a selector for elevation generator. The base game sets `property_expression_names.elevation` to `"0_16-elevation"` to reproduce terrain from 0.16 or to `"0_17-island"` for the island preset. If generators are available for other properties, the 'map type' dropdown in the GUI will be renamed to 'elevation' and shown along with selectors for the other selectable properties.
/// </summary>
[FactorioRconConcept("MapGenSettings")]
public abstract class MapGenSettings
{
  /// <summary>
  /// The inverse of 'water scale' in the map generator GUI. Lower `terrain_segmentation` increases the scale of elevation features (lakes, continents, etc). This behavior can be overridden with alternate elevation generators (see `property_expression_names`, below).
  /// </summary>
  [FactorioRconAttribute("terrain_segmentation")]
  public MapGenSize TerrainSegmentation { get; set; }

  /// <summary>
  /// The equivalent to 'water coverage' in the map generator GUI. Specifically, when this value is non-zero, `water_level = 10 * log2` (the value of this field), and the elevation generator subtracts water level from elevation before adding starting lakes. If water is set to 'none', elevation is clamped to a small positive value before adding starting lakes. This behavior can be overridden with alternate elevation generators (see `property_expression_names`, below).
  /// </summary>
  [FactorioRconAttribute("water")]
  public MapGenSize Water { get; set; }

  /// <summary>
  /// Indexed by autoplace control prototype name.
  /// </summary>
  [FactorioRconAttribute("autoplace_controls")]
  public Dictionary<string, AutoplaceControl> AutoplaceControls { get; set; }

  /// <summary>
  /// Whether undefined `autoplace_controls` should fall back to the default controls or not. Defaults to `true`.
  /// </summary>
  [FactorioRconAttribute("default_enable_all_autoplace_controls")]
  public bool DefaultEnableAllAutoplaceControls { get; set; }

  /// <summary>
  /// Each setting in this dictionary maps the string type to the settings for that type.
  /// </summary>
  [FactorioRconAttribute("autoplace_settings")]
  public Dictionary<Union23558896, AutoplaceSettings> AutoplaceSettings { get; set; }

  /// <summary>
  /// Map generation settings for entities of the type "cliff".
  /// </summary>
  [FactorioRconAttribute("cliff_settings")]
  public CliffPlacementSettings CliffSettings { get; set; }

  /// <summary>
  /// The random seed used to generated this map.
  /// </summary>
  [FactorioRconAttribute("seed")]
  public uint Seed { get; set; }

  /// <summary>
  /// Width in tiles. If `0`, the map has 'infinite' width, with the actual limitation being one million tiles in each direction from the center.
  /// </summary>
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  /// <summary>
  /// Height in tiles. If `0`, the map has 'infinite' height, with the actual limitation being one million tiles in each direction from the center.
  /// </summary>
  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

  /// <summary>
  /// Size of the starting area.
  /// </summary>
  [FactorioRconAttribute("starting_area")]
  public MapGenSize StartingArea { get; set; }

  /// <summary>
  /// Positions of the starting areas.
  /// </summary>
  [FactorioRconAttribute("starting_points")]
  public List<MapPosition> StartingPoints { get; set; }

  /// <summary>
  /// Whether peaceful mode is enabled for this map.
  /// </summary>
  [FactorioRconAttribute("peaceful_mode")]
  public bool PeacefulMode { get; set; }

  /// <summary>
  /// Overrides for tile property value generators. Values either name a NamedNoiseExpression or can be literal numbers, stored as strings (e.g. `"5"`). All other controls can be overridden by a property expression names. Notable properties: 
  /// - `moisture` - a value between 0 and 1 that determines whether a tile becomes sandy (low moisture) or grassy (high moisture).
  /// - `aux` - a value between 0 and 1 that determines whether low-moisture tiles become sand or red desert.
  /// - `temperature` - provides a value (vaguely representing degrees Celsius, varying between -20 and 50) that is used (together with moisture and aux) as part of tree and decorative placement.
  /// - `elevation` - tiles values less than zero become water. Cliffs are placed along certain contours according to <see cref="CliffPlacementSettings" />.
  /// - `cliffiness` - determines whether (when >0.5) or not (when <0.5) a cliff will be placed at an otherwise suitable (according to <see cref="CliffPlacementSettings" />) location.
  /// - `enemy-base-intensity` - a number that is referenced by both `enemy-base-frequency` and `enemy-base-radius`. i.e. if this is overridden, enemy base frequency and size will both be affected and do something reasonable. By default, this expression returns a value proportional to distance from any starting point, clamped at about 7.
  /// - `enemy-base-frequency` - a number representing average number of enemy bases per tile for a region, by default in terms of `enemy-base-intensity`.
  /// - `enemy-base-radius` - a number representing the radius of an enemy base, if one were to be placed on the given tile, by default proportional to a constant plus `enemy-base-intensity`. Climate controls ('Moisture' and 'Terrain type' at the bottom of the Terrain tab in the map generator GUI) don't have their own dedicated structures in MapGenSettings. Instead, their values are stored as property expression overrides with long names: 
  /// - `control-setting:moisture:frequency:multiplier` - frequency (inverse of scale) multiplier for moisture noise. Default is 1.
  /// - `control-setting:moisture:bias` - global bias for moisture (which normally varies between 0 and 1). Default is 0.
  /// - `control-setting:aux:frequency:multiplier` - frequency (inverse of scale) multiplier for aux (called 'terrain type' in the GUI) noise. Default is 1.
  /// - `control-setting:aux:bias` - global bias for aux/terrain type (which normally varies between 0 and 1). Default is 0. All other MapGenSettings feed into named noise expressions, and therefore placement can be overridden by including the name of a property in this dictionary. The probability and richness functions for placing specific tiles, entities, and decoratives can be overridden by including an entry named `{tile|entity|decorative}:(prototype name):{probability|richness}`.
  /// </summary>
  [FactorioRconAttribute("property_expression_names")]
  public Dictionary<string, string> PropertyExpressionNames { get; set; }

}

public abstract class Table45861094
{
  /// <summary>
  /// The inverse of 'water scale' in the map generator GUI. Lower `terrain_segmentation` increases the scale of elevation features (lakes, continents, etc). This behavior can be overridden with alternate elevation generators (see `property_expression_names`, below).
  /// </summary>
  [FactorioRconAttribute("terrain_segmentation")]
  public MapGenSize TerrainSegmentation { get; set; }

  /// <summary>
  /// The equivalent to 'water coverage' in the map generator GUI. Specifically, when this value is non-zero, `water_level = 10 * log2` (the value of this field), and the elevation generator subtracts water level from elevation before adding starting lakes. If water is set to 'none', elevation is clamped to a small positive value before adding starting lakes. This behavior can be overridden with alternate elevation generators (see `property_expression_names`, below).
  /// </summary>
  [FactorioRconAttribute("water")]
  public MapGenSize Water { get; set; }

  /// <summary>
  /// Indexed by autoplace control prototype name.
  /// </summary>
  [FactorioRconAttribute("autoplace_controls")]
  public Dictionary<string, AutoplaceControl> AutoplaceControls { get; set; }

  /// <summary>
  /// Whether undefined `autoplace_controls` should fall back to the default controls or not. Defaults to `true`.
  /// </summary>
  [FactorioRconAttribute("default_enable_all_autoplace_controls")]
  public bool DefaultEnableAllAutoplaceControls { get; set; }

  /// <summary>
  /// Each setting in this dictionary maps the string type to the settings for that type.
  /// </summary>
  [FactorioRconAttribute("autoplace_settings")]
  public Dictionary<Union23558896, AutoplaceSettings> AutoplaceSettings { get; set; }

  /// <summary>
  /// Map generation settings for entities of the type "cliff".
  /// </summary>
  [FactorioRconAttribute("cliff_settings")]
  public CliffPlacementSettings CliffSettings { get; set; }

  /// <summary>
  /// The random seed used to generated this map.
  /// </summary>
  [FactorioRconAttribute("seed")]
  public uint Seed { get; set; }

  /// <summary>
  /// Width in tiles. If `0`, the map has 'infinite' width, with the actual limitation being one million tiles in each direction from the center.
  /// </summary>
  [FactorioRconAttribute("width")]
  public uint Width { get; set; }

  /// <summary>
  /// Height in tiles. If `0`, the map has 'infinite' height, with the actual limitation being one million tiles in each direction from the center.
  /// </summary>
  [FactorioRconAttribute("height")]
  public uint Height { get; set; }

  /// <summary>
  /// Size of the starting area.
  /// </summary>
  [FactorioRconAttribute("starting_area")]
  public MapGenSize StartingArea { get; set; }

  /// <summary>
  /// Positions of the starting areas.
  /// </summary>
  [FactorioRconAttribute("starting_points")]
  public List<MapPosition> StartingPoints { get; set; }

  /// <summary>
  /// Whether peaceful mode is enabled for this map.
  /// </summary>
  [FactorioRconAttribute("peaceful_mode")]
  public bool PeacefulMode { get; set; }

  /// <summary>
  /// Overrides for tile property value generators. Values either name a NamedNoiseExpression or can be literal numbers, stored as strings (e.g. `"5"`). All other controls can be overridden by a property expression names. Notable properties: 
  /// - `moisture` - a value between 0 and 1 that determines whether a tile becomes sandy (low moisture) or grassy (high moisture).
  /// - `aux` - a value between 0 and 1 that determines whether low-moisture tiles become sand or red desert.
  /// - `temperature` - provides a value (vaguely representing degrees Celsius, varying between -20 and 50) that is used (together with moisture and aux) as part of tree and decorative placement.
  /// - `elevation` - tiles values less than zero become water. Cliffs are placed along certain contours according to <see cref="CliffPlacementSettings" />.
  /// - `cliffiness` - determines whether (when >0.5) or not (when <0.5) a cliff will be placed at an otherwise suitable (according to <see cref="CliffPlacementSettings" />) location.
  /// - `enemy-base-intensity` - a number that is referenced by both `enemy-base-frequency` and `enemy-base-radius`. i.e. if this is overridden, enemy base frequency and size will both be affected and do something reasonable. By default, this expression returns a value proportional to distance from any starting point, clamped at about 7.
  /// - `enemy-base-frequency` - a number representing average number of enemy bases per tile for a region, by default in terms of `enemy-base-intensity`.
  /// - `enemy-base-radius` - a number representing the radius of an enemy base, if one were to be placed on the given tile, by default proportional to a constant plus `enemy-base-intensity`. Climate controls ('Moisture' and 'Terrain type' at the bottom of the Terrain tab in the map generator GUI) don't have their own dedicated structures in MapGenSettings. Instead, their values are stored as property expression overrides with long names: 
  /// - `control-setting:moisture:frequency:multiplier` - frequency (inverse of scale) multiplier for moisture noise. Default is 1.
  /// - `control-setting:moisture:bias` - global bias for moisture (which normally varies between 0 and 1). Default is 0.
  /// - `control-setting:aux:frequency:multiplier` - frequency (inverse of scale) multiplier for aux (called 'terrain type' in the GUI) noise. Default is 1.
  /// - `control-setting:aux:bias` - global bias for aux/terrain type (which normally varies between 0 and 1). Default is 0. All other MapGenSettings feed into named noise expressions, and therefore placement can be overridden by including the name of a property in this dictionary. The probability and richness functions for placing specific tiles, entities, and decoratives can be overridden by including an entry named `{tile|entity|decorative}:(prototype name):{probability|richness}`.
  /// </summary>
  [FactorioRconAttribute("property_expression_names")]
  public Dictionary<string, string> PropertyExpressionNames { get; set; }

}

[GenerateOneOf]
public abstract partial class Union23558896: OneOfBase<Literal24974776, Literal54708252, Literal8022616>
{
}

/// <summary>
/// Literal value: entity
/// </summary>
public enum Literal24974776
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
  Entity,

}

/// <summary>
/// Literal value: tile
/// </summary>
public enum Literal54708252
{
  /// <summary>
  /// Literal value: tile
  /// </summary>
  [FactorioRconDefinitionValue("tile")]
  Tile,

}

/// <summary>
/// Literal value: decorative
/// </summary>
public enum Literal8022616
{
  /// <summary>
  /// Literal value: decorative
  /// </summary>
  [FactorioRconDefinitionValue("decorative")]
  Decorative,

}

