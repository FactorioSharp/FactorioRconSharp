#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Builtins;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
///     Control behavior for container entities.
/// </summary>
[FactorioRconClass("LuaContainerControlBehavior")]
public abstract class LuaContainerControlBehavior : LuaObject
{
  /// <summary>
  ///     Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the
  ///     corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the
  ///     game state might have occurred between the creation of the Lua object and its access.
  /// </summary>
  [FactorioRconAttribute("valid")]
    public bool Valid { get; private set; }

  /// <summary>
  ///     The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
  /// </summary>
  [FactorioRconAttribute("object_name")]
    public string ObjectName { get; private set; }

  /// <summary>
  ///     All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
    public abstract string Help();
}
