#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
/// Item group or subgroup.
/// </summary>
[FactorioRconClass("LuaGroup")]
public abstract class LuaGroup: LuaObject
{
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// Localised name of the group.
  /// </summary>
  [FactorioRconAttribute("localised_name")]
  public LocalisedString LocalisedName { get; private set; }

  [FactorioRconAttribute("type")]
  public string Type { get; private set; }

  /// <summary>
  /// The parent group.
  /// </summary>
  [FactorioRconAttribute("group")]
  public LuaGroup Group { get; private set; }

  /// <summary>
  /// Subgroups of this group.
  /// </summary>
  [FactorioRconAttribute("subgroups")]
  public List<LuaGroup> Subgroups { get; private set; }

  /// <summary>
  /// The additional order value used in recipe ordering.
  /// </summary>
  [FactorioRconAttribute("order_in_recipe")]
  public string OrderInRecipe { get; private set; }

  /// <summary>
  /// The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
  public string Order { get; private set; }

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

