#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// A permission group that defines what players in this group are allowed to do.
/// </summary>
[FactorioRconClass("LuaPermissionGroup")]
public abstract class LuaPermissionGroup: LuaObject
{
  /// <summary>
  /// The name of this group.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The players in this group.
  /// </summary>
  [FactorioRconAttribute("players")]
  public List<LuaPlayer> Players { get; private set; }

  /// <summary>
  /// The group ID
  /// </summary>
  [FactorioRconAttribute("group_id")]
  public uint GroupId { get; private set; }

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
  /// Adds the given player to this group.
  /// </summary>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("add_player")]
  public abstract bool AddPlayer(PlayerIdentification player);

  /// <summary>
  /// Removes the given player from this group.
  /// </summary>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("remove_player")]
  public abstract bool RemovePlayer(PlayerIdentification player);

  /// <summary>
  /// Whether this group allows the given action.
  /// </summary>
  /// <param name="action">Lua name: action</param>
  [FactorioRconMethod("allows_action")]
  public abstract bool AllowsAction(InputActionEnum action);

  /// <summary>
  /// Sets whether this group allows the performance the given action.
  /// </summary>
  /// <param name="action">Lua name: action</param>
  /// <param name="allowAction">Lua name: allow_action</param>
  [FactorioRconMethod("set_allows_action")]
  public abstract bool SetAllowsAction(InputActionEnum action, bool allowAction);

  /// <summary>
  /// Destroys this group.
  /// </summary>
  [FactorioRconMethod("destroy")]
  public abstract bool Destroy();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

