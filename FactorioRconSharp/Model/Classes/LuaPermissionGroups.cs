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
/// All permission groups.
/// </summary>
[FactorioRconClass("LuaPermissionGroups")]
public abstract class LuaPermissionGroups: LuaObject
{
  /// <summary>
  /// All of the permission groups.
  /// </summary>
  [FactorioRconAttribute("groups")]
  public List<LuaPermissionGroup> Groups { get; private set; }

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
  /// Creates a new permission group.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("create_group")]
  public abstract LuaPermissionGroup? CreateGroup(string? name = null);

  /// <summary>
  /// Gets the permission group with the given name or group ID.
  /// </summary>
  /// <param name="group">Lua name: group</param>
  [FactorioRconMethod("get_group")]
  public abstract LuaPermissionGroup? GetGroup(Union_2ca2a1b7257c41fdbdb085b9c6516f56 group);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

