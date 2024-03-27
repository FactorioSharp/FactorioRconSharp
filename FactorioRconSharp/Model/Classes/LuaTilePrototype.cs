#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// Prototype of a tile.
/// </summary>
[FactorioRconClass("LuaTilePrototype")]
public abstract class LuaTilePrototype: LuaObject
{
  /// <summary>
  /// Name of this prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
  public string Order { get; private set; }

  [FactorioRconAttribute("localised_name")]
  public LocalisedString LocalisedName { get; private set; }

  [FactorioRconAttribute("localised_description")]
  public LocalisedString LocalisedDescription { get; private set; }

  /// <summary>
  /// The collision mask this tile uses
  /// </summary>
  [FactorioRconAttribute("collision_mask")]
  public CollisionMask CollisionMask { get; private set; }

  [FactorioRconAttribute("collision_mask_with_flags")]
  public CollisionMaskWithFlags CollisionMaskWithFlags { get; private set; }

  [FactorioRconAttribute("layer")]
  public uint Layer { get; private set; }

  /// <summary>
  /// Autoplace specification for this prototype, if any.
  /// </summary>
  [FactorioRconAttribute("autoplace_specification")]
  public AutoplaceSpecification AutoplaceSpecification { get; private set; }

  [FactorioRconAttribute("walking_speed_modifier")]
  public float WalkingSpeedModifier { get; private set; }

  [FactorioRconAttribute("vehicle_friction_modifier")]
  public float VehicleFrictionModifier { get; private set; }

  [FactorioRconAttribute("map_color")]
  public Color MapColor { get; private set; }

  /// <summary>
  /// The probability that decorative entities will be removed from on top of this tile when this tile is generated.
  /// </summary>
  [FactorioRconAttribute("decorative_removal_probability")]
  public float DecorativeRemovalProbability { get; private set; }

  [FactorioRconAttribute("automatic_neighbors")]
  public bool AutomaticNeighbors { get; private set; }

  [FactorioRconAttribute("allowed_neighbors")]
  public Dictionary<string, LuaTilePrototype> AllowedNeighbors { get; private set; }

  /// <summary>
  /// If this tile needs correction logic applied when it's generated in the world.
  /// </summary>
  [FactorioRconAttribute("needs_correction")]
  public bool NeedsCorrection { get; private set; }

  [FactorioRconAttribute("mineable_properties")]
  public Type1421203362 MineableProperties { get; private set; }

  /// <summary>
  /// The next direction of this tile, if any. Used when a tile has multiple directions (such as hazard concrete)
  /// </summary>
  [FactorioRconAttribute("next_direction")]
  public LuaTilePrototype NextDirection { get; private set; }

  /// <summary>
  /// Items that when placed will produce this tile, if any. Construction bots will choose the first item in the list to build this tile.
  /// </summary>
  [FactorioRconAttribute("items_to_place_this")]
  public List<ItemStackDefinition> ItemsToPlaceThis { get; private set; }

  /// <summary>
  /// False if this tile is not allowed in blueprints regardless of the ability to build it.
  /// </summary>
  [FactorioRconAttribute("can_be_part_of_blueprint")]
  public bool CanBePartOfBlueprint { get; private set; }

  /// <summary>
  /// Amount of pollution emissions per second this tile will absorb.
  /// </summary>
  [FactorioRconAttribute("emissions_per_second")]
  public double EmissionsPerSecond { get; private set; }

  /// <summary>
  /// True if building this tile should check for colliding entities above and prevent building if such are found. Also during mining tiles above this tile checks for entities colliding with this tile and prevents mining if such are found.
  /// </summary>
  [FactorioRconAttribute("check_collision_with_entities")]
  public bool CheckCollisionWithEntities { get; private set; }

  /// <summary>
  /// Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the game state might have occurred between the creation of the Lua object and its access.
  /// </summary>
  [FactorioRconAttribute("valid")]
  public bool Valid { get; private set; }

  /// <summary>
  /// The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

