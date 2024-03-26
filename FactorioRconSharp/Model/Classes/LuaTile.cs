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
/// A single "square" on the map.
/// </summary>
[FactorioRconClass("LuaTile")]
public abstract class LuaTile: LuaObject
{
  /// <summary>
  /// Prototype name of this tile. E.g. `"sand-3"` or `"grass-2"`.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  [FactorioRconAttribute("prototype")]
  public LuaTilePrototype Prototype { get; private set; }

  /// <summary>
  /// The position this tile references.
  /// </summary>
  [FactorioRconAttribute("position")]
  public TilePosition Position { get; private set; }

  /// <summary>
  /// The name of the <see cref="LuaSurface.SetHiddenTile" />.
  /// </summary>
  [FactorioRconAttribute("hidden_tile")]
  public string HiddenTile { get; private set; }

  /// <summary>
  /// The surface this tile is on.
  /// </summary>
  [FactorioRconAttribute("surface")]
  public LuaSurface Surface { get; private set; }

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
  /// What type of things can collide with this tile?
  /// </summary>
  /// <param name="layer">Lua name: layer</param>
  [FactorioRconMethod("collides_with")]
  public abstract bool CollidesWith(CollisionMaskLayer layer);

  /// <summary>
  /// Is this tile marked for deconstruction?
  /// </summary>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("to_be_deconstructed")]
  public abstract bool ToBeDeconstructed(ForceIdentification? force = null);

  /// <summary>
  /// Orders deconstruction of this tile by the given force.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("order_deconstruction")]
  public abstract LuaEntity? OrderDeconstruction(ForceIdentification force, PlayerIdentification? player = null);

  /// <summary>
  /// Cancels deconstruction if it is scheduled, does nothing otherwise.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("cancel_deconstruction")]
  public abstract void CancelDeconstruction(ForceIdentification force, PlayerIdentification? player = null);

  /// <summary>
  /// Does this tile have any tile ghosts on it.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("has_tile_ghost")]
  public abstract bool HasTileGhost(ForceIdentification? force = null);

  /// <summary>
  /// Gets all tile ghosts on this tile.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("get_tile_ghosts")]
  public abstract List<LuaTile> GetTileGhosts(ForceIdentification? force = null);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

