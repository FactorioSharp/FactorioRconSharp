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
/// A chunk iterator can be used for iterating chunks coordinates of a surface.
/// 
/// The returned type is a <see cref="ChunkPositionAndArea" /> containing the chunk coordinates and its area.
/// </summary>
/// <examples>
/// ```
/// for chunk in some_surface.get_chunks() do
///   game.player.print("x: " .. chunk.x .. ", y: " .. chunk.y)
///   game.player.print("area: " .. serpent.line(chunk.area))
/// end
/// ```
/// </examples>
[FactorioRconClass("LuaChunkIterator")]
public abstract class LuaChunkIterator: LuaObject
{
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

  // Attribute Call skipped because both getter and setter are inaccessible

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

