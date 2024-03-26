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
/// Collection of settings for overriding default ai behavior.
/// </summary>
[FactorioRconClass("LuaAISettings")]
public abstract class LuaAISettings: LuaObject
{
  /// <summary>
  /// If enabled, units that repeatedly fail to succeed at commands will be destroyed.
  /// </summary>
  [FactorioRconAttribute("allow_destroy_when_commands_fail")]
  public bool AllowDestroyWhenCommandsFail { get; set; }

  /// <summary>
  /// If enabled, units that have nothing else to do will attempt to return to a spawner.
  /// </summary>
  [FactorioRconAttribute("allow_try_return_to_spawner")]
  public bool AllowTryReturnToSpawner { get; set; }

  /// <summary>
  /// If enabled, units will try to separate themselves from nearby friendly units.
  /// </summary>
  [FactorioRconAttribute("do_separation")]
  public bool DoSeparation { get; set; }

  /// <summary>
  /// Defines how coarse the pathfinder's grid is, where smaller values mean a coarser grid. Defaults to `0`, which equals a resolution of `1x1` tiles, centered on tile centers. Values range from `-8` to `8` inclusive, where each integer increment doubles/halves the resolution. So, a resolution of `-8` equals a grid of `256x256` tiles, and a resolution of `8` equals `1/256` of a tile.
  /// </summary>
  [FactorioRconAttribute("path_resolution_modifier")]
  public sbyte PathResolutionModifier { get; set; }

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

