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
/// A "domain" of the world. Surfaces can only be created and deleted through the API. Surfaces are uniquely identified by their name. Every game contains at least the surface "nauvis".
/// </summary>
[FactorioRconClass("LuaSurface")]
public abstract class LuaSurface: LuaObject
{
  /// <summary>
  /// The name of this surface. Names are unique among surfaces.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// This surface's index in <see cref="OnSurfaceDeleted" />. Indexes of deleted surfaces can be reused.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; private set; }

  /// <summary>
  /// The generation settings for this surface. These can be modified after surface generation, but note that this will not retroactively update the surface. To manually regenerate it, <see cref="LuaSurface.DeleteChunk" /> can be used.
  /// </summary>
  [FactorioRconAttribute("map_gen_settings")]
  public MapGenSettings MapGenSettings { get; set; }

  /// <summary>
  /// When set to true, new chunks will be generated with lab tiles, instead of using the surface's map generation settings.
  /// </summary>
  [FactorioRconAttribute("generate_with_lab_tiles")]
  public bool GenerateWithLabTiles { get; set; }

  /// <summary>
  /// When set to true, the sun will always shine.
  /// </summary>
  [FactorioRconAttribute("always_day")]
  public bool AlwaysDay { get; set; }

  /// <summary>
  /// Current time of day, as a number in range [0, 1).
  /// </summary>
  [FactorioRconAttribute("daytime")]
  public double Daytime { get; set; }

  /// <summary>
  /// Amount of darkness at the current time, as a number in range [0, 1].
  /// </summary>
  [FactorioRconAttribute("darkness")]
  public float Darkness { get; private set; }

  /// <summary>
  /// Current wind speed in tiles per tick.
  /// </summary>
  [FactorioRconAttribute("wind_speed")]
  public double WindSpeed { get; set; }

  /// <summary>
  /// Current wind direction.
  /// </summary>
  [FactorioRconAttribute("wind_orientation")]
  public RealOrientation WindOrientation { get; set; }

  /// <summary>
  /// Change in wind orientation per tick.
  /// </summary>
  [FactorioRconAttribute("wind_orientation_change")]
  public double WindOrientationChange { get; set; }

  /// <summary>
  /// Is peaceful mode enabled on this surface?
  /// </summary>
  [FactorioRconAttribute("peaceful_mode")]
  public bool PeacefulMode { get; set; }

  /// <summary>
  /// True if daytime is currently frozen.
  /// </summary>
  [FactorioRconAttribute("freeze_daytime")]
  public bool FreezeDaytime { get; set; }

  /// <summary>
  /// The number of ticks per day for this surface.
  /// </summary>
  [FactorioRconAttribute("ticks_per_day")]
  public uint TicksPerDay { get; set; }

  /// <summary>
  /// The daytime when dusk starts.
  /// </summary>
  [FactorioRconAttribute("dusk")]
  public double Dusk { get; set; }

  /// <summary>
  /// The daytime when dawn starts.
  /// </summary>
  [FactorioRconAttribute("dawn")]
  public double Dawn { get; set; }

  /// <summary>
  /// The daytime when evening starts.
  /// </summary>
  [FactorioRconAttribute("evening")]
  public double Evening { get; set; }

  /// <summary>
  /// The daytime when morning starts.
  /// </summary>
  [FactorioRconAttribute("morning")]
  public double Morning { get; set; }

  /// <summary>
  /// The multiplier of solar power on this surface. Cannot be less than 0.
  /// </summary>
  [FactorioRconAttribute("solar_power_multiplier")]
  public double SolarPowerMultiplier { get; set; }

  /// <summary>
  /// The minimal brightness during the night. Defaults to `0.15`. This has an effect on both rendering and game mechanics such as biter spawns and solar power.
  /// </summary>
  [FactorioRconAttribute("min_brightness")]
  public double MinBrightness { get; set; }

  /// <summary>
  /// Defines how surface daytime brightness influences each color channel of the current color lookup table (LUT).
  /// 
  /// The LUT is multiplied by `((1 - weight) + brightness * weight)` and result is clamped to range [0, 1].
  /// 
  /// Default is `{0, 0, 0}`, which means no influence.
  /// </summary>
  [FactorioRconAttribute("brightness_visual_weights")]
  public ColorModifier BrightnessVisualWeights { get; set; }

  /// <summary>
  /// If clouds are shown on this surface.
  /// </summary>
  [FactorioRconAttribute("show_clouds")]
  public bool ShowClouds { get; set; }

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
  /// Get the pollution for a given position.
  /// </summary>
  /// <remarks>
  /// Pollution is stored per chunk, so this will return the same value for all positions in one chunk.
  /// </remarks>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("get_pollution")]
  public abstract double GetPollution(MapPosition position);

  /// <summary>
  /// Check for collisions with terrain or other entities.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="direction">Lua name: direction</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="buildCheckType">Lua name: build_check_type</param>
  /// <param name="forced">Lua name: forced</param>
  /// <param name="innerName">Lua name: inner_name</param>
  [FactorioRconMethod("can_place_entity")]
  public abstract bool CanPlaceEntity(string name, MapPosition position, DirectionEnum? direction = null, ForceIdentification? force = null, BuildCheckTypeEnum? buildCheckType = null, bool? forced = null, string? innerName = null);

  /// <summary>
  /// If there exists an entity at the given location that can be fast-replaced with the given entity parameters.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="direction">Lua name: direction</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("can_fast_replace")]
  public abstract bool CanFastReplace(string name, MapPosition position, DirectionEnum? direction = null, ForceIdentification? force = null);

  /// <summary>
  /// Find an entity of the given name at the given position. This checks both the exact position and the bounding box of the entity.
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("find_entity")]
  public abstract LuaEntity? FindEntity(string entity, MapPosition position);

  /// <summary>
  /// Find entities in a given area.
  /// 
  /// If no area is given all entities on the surface are returned.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  [FactorioRconMethod("find_entities")]
  public abstract List<LuaEntity> FindEntities(BoundingBox? area = null);

  /// <summary>
  /// Find all entities of the given type or name in the given area.
  /// 
  /// If no filters (`name`, `type`, `force`, etc.) are given, this returns all entities in the search area. If multiple filters are specified, only entities matching all given filters are returned.
  /// 
  /// - If no `area` or `position` are given, the entire surface is searched.
  /// - If `position` is given, this returns the entities colliding with that position (i.e the given position is within the entity's collision box).
  /// - If `position` and `radius` are given, this returns the entities within the radius of the position. Looks for the center of entities.
  /// - If `area` is specified, this returns the entities colliding with that area.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="radius">Lua name: radius</param>
  /// <param name="name">Lua name: name</param>
  /// <param name="type">Lua name: type</param>
  /// <param name="ghostName">Lua name: ghost_name</param>
  /// <param name="ghostType">Lua name: ghost_type</param>
  /// <param name="direction">Lua name: direction</param>
  /// <param name="collisionMask">Lua name: collision_mask</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="toBeDeconstructed">Lua name: to_be_deconstructed</param>
  /// <param name="toBeUpgraded">Lua name: to_be_upgraded</param>
  /// <param name="limit">Lua name: limit</param>
  /// <param name="isMilitaryTarget">Lua name: is_military_target</param>
  /// <param name="hasItemInside">Lua name: has_item_inside</param>
  /// <param name="invert">Lua name: invert</param>
  [FactorioRconMethod("find_entities_filtered")]
  public abstract List<LuaEntity> FindEntitiesFiltered(BoundingBox? area = null, MapPosition? position = null, double? radius = null, Union988206018? name = null, Union988206018? type = null, Union988206018? ghostName = null, Union988206018? ghostType = null, Union282100140? direction = null, Union160503673? collisionMask = null, Union1452203094? force = null, bool? toBeDeconstructed = null, bool? toBeUpgraded = null, uint? limit = null, bool? isMilitaryTarget = null, LuaItemPrototype? hasItemInside = null, bool? invert = null);

  /// <summary>
  /// Find all tiles of the given name in the given area.
  /// 
  /// If no filters are given, this returns all tiles in the search area.
  /// 
  /// If no `area` or `position` and `radius` is given, the entire surface is searched. If `position` and `radius` are given, only tiles within the radius of the position are included.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="radius">Lua name: radius</param>
  /// <param name="name">Lua name: name</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="limit">Lua name: limit</param>
  /// <param name="hasHiddenTile">Lua name: has_hidden_tile</param>
  /// <param name="hasTileGhost">Lua name: has_tile_ghost</param>
  /// <param name="toBeDeconstructed">Lua name: to_be_deconstructed</param>
  /// <param name="collisionMask">Lua name: collision_mask</param>
  /// <param name="invert">Lua name: invert</param>
  [FactorioRconMethod("find_tiles_filtered")]
  public abstract List<LuaTile> FindTilesFiltered(BoundingBox? area = null, MapPosition? position = null, double? radius = null, Union988206018? name = null, Union1452203094? force = null, uint? limit = null, bool? hasHiddenTile = null, bool? hasTileGhost = null, bool? toBeDeconstructed = null, Union160503673? collisionMask = null, bool? invert = null);

  /// <summary>
  /// Count entities of given type or name in a given area. Works just like <see cref="LuaSurface.FindEntitiesFiltered" />, except this only returns the count. As it doesn't construct all the wrapper objects, this is more efficient if one is only interested in the number of entities.
  /// 
  /// If no `area` or `position` are given, the entire surface is searched. If `position` is given, this returns the entities colliding with that position (i.e the given position is within the entity's collision box). If `position` and `radius` are given, this returns entities in the radius of the position. If `area` is specified, this returns entities colliding with that area.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="radius">Lua name: radius</param>
  /// <param name="name">Lua name: name</param>
  /// <param name="type">Lua name: type</param>
  /// <param name="ghostName">Lua name: ghost_name</param>
  /// <param name="ghostType">Lua name: ghost_type</param>
  /// <param name="direction">Lua name: direction</param>
  /// <param name="collisionMask">Lua name: collision_mask</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="toBeDeconstructed">Lua name: to_be_deconstructed</param>
  /// <param name="toBeUpgraded">Lua name: to_be_upgraded</param>
  /// <param name="limit">Lua name: limit</param>
  /// <param name="isMilitaryTarget">Lua name: is_military_target</param>
  /// <param name="invert">Lua name: invert</param>
  [FactorioRconMethod("count_entities_filtered")]
  public abstract uint CountEntitiesFiltered(BoundingBox? area = null, MapPosition? position = null, double? radius = null, Union988206018? name = null, Union988206018? type = null, Union988206018? ghostName = null, Union988206018? ghostType = null, Union282100140? direction = null, Union160503673? collisionMask = null, Union1452203094? force = null, bool? toBeDeconstructed = null, bool? toBeUpgraded = null, uint? limit = null, bool? isMilitaryTarget = null, bool? invert = null);

  /// <summary>
  /// Count tiles of a given name in a given area. Works just like <see cref="LuaSurface.FindTilesFiltered" />, except this only returns the count. As it doesn't construct all the wrapper objects, this is more efficient if one is only interested in the number of tiles.
  /// 
  /// If no `area` or `position` and `radius` is given, the entire surface is searched. If `position` and `radius` are given, only tiles within the radius of the position are included.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="radius">Lua name: radius</param>
  /// <param name="name">Lua name: name</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="limit">Lua name: limit</param>
  /// <param name="hasHiddenTile">Lua name: has_hidden_tile</param>
  /// <param name="hasTileGhost">Lua name: has_tile_ghost</param>
  /// <param name="toBeDeconstructed">Lua name: to_be_deconstructed</param>
  /// <param name="collisionMask">Lua name: collision_mask</param>
  /// <param name="invert">Lua name: invert</param>
  [FactorioRconMethod("count_tiles_filtered")]
  public abstract uint CountTilesFiltered(BoundingBox? area = null, MapPosition? position = null, double? radius = null, Union988206018? name = null, Union1452203094? force = null, uint? limit = null, bool? hasHiddenTile = null, bool? hasTileGhost = null, bool? toBeDeconstructed = null, Union160503673? collisionMask = null, bool? invert = null);

  /// <summary>
  /// Find a non-colliding position within a given radius.
  /// </summary>
  /// <remarks>
  /// Special care needs to be taken when using a radius of `0`. The game will not stop searching until it finds a suitable position, so it is important to make sure such a position exists. One particular case where it would not be able to find a solution is running it before any chunks have been generated.
  /// </remarks>
  /// <param name="name">Lua name: name</param>
  /// <param name="center">Lua name: center</param>
  /// <param name="radius">Lua name: radius</param>
  /// <param name="precision">Lua name: precision</param>
  /// <param name="forceToTileCenter">Lua name: force_to_tile_center</param>
  [FactorioRconMethod("find_non_colliding_position")]
  public abstract MapPosition? FindNonCollidingPosition(string name, MapPosition center, double radius, double precision, bool? forceToTileCenter = null);

  /// <summary>
  /// Find a non-colliding position within a given rectangle.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="searchSpace">Lua name: search_space</param>
  /// <param name="precision">Lua name: precision</param>
  /// <param name="forceToTileCenter">Lua name: force_to_tile_center</param>
  [FactorioRconMethod("find_non_colliding_position_in_box")]
  public abstract MapPosition? FindNonCollidingPositionInBox(string name, BoundingBox searchSpace, double precision, bool? forceToTileCenter = null);

  /// <summary>
  /// Spill items on the ground centered at a given location.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="items">Lua name: items</param>
  /// <param name="enableLooted">Lua name: enable_looted</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="allowBelts">Lua name: allow_belts</param>
  [FactorioRconMethod("spill_item_stack")]
  public abstract List<LuaEntity> SpillItemStack(MapPosition position, ItemStackIdentification items, bool? enableLooted = null, ForceIdentification? force = null, bool? allowBelts = null);

  /// <summary>
  /// Find enemy units (entities with type "unit") of a given force within an area.
  /// </summary>
  /// <remarks>
  /// This is more efficient than <see cref="LuaSurface.FindEntities" />.
  /// </remarks>
  /// <param name="center">Lua name: center</param>
  /// <param name="radius">Lua name: radius</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("find_enemy_units")]
  public abstract List<LuaEntity> FindEnemyUnits(MapPosition center, double radius, ForceIdentification? force = null);

  /// <summary>
  /// Find units (entities with type "unit") of a given force and force condition within a given area.
  /// </summary>
  /// <remarks>
  /// This is more efficient than <see cref="LuaSurface.FindEntities" />.
  /// </remarks>
  /// <param name="area">Lua name: area</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="condition">Lua name: condition</param>
  [FactorioRconMethod("find_units")]
  public abstract List<LuaEntity> FindUnits(BoundingBox area, ForceIdentification force, ForceCondition condition);

  /// <summary>
  /// Find the enemy military target ([military entity](https://wiki.factorio.com/Military_units_and_structures)) closest to the given position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="maxDistance">Lua name: max_distance</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("find_nearest_enemy")]
  public abstract LuaEntity? FindNearestEnemy(MapPosition position, double maxDistance, ForceIdentification? force = null);

  /// <summary>
  /// Find the enemy entity-with-owner closest to the given position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="maxDistance">Lua name: max_distance</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("find_nearest_enemy_entity_with_owner")]
  public abstract LuaEntity FindNearestEnemyEntityWithOwner(MapPosition position, double maxDistance, ForceIdentification? force = null);

  /// <summary>
  /// Give a command to multiple units. This will automatically select suitable units for the task.
  /// </summary>
  /// <param name="command">Lua name: command</param>
  /// <param name="unitCount">Lua name: unit_count</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="unitSearchDistance">Lua name: unit_search_distance</param>
  [FactorioRconMethod("set_multi_command")]
  public abstract uint SetMultiCommand(Command command, uint unitCount, ForceIdentification? force = null, uint? unitSearchDistance = null);

  /// <summary>
  /// Create an entity on this surface.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="direction">Lua name: direction</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="source">Lua name: source</param>
  /// <param name="fastReplace">Lua name: fast_replace</param>
  /// <param name="player">Lua name: player</param>
  /// <param name="character">Lua name: character</param>
  /// <param name="spill">Lua name: spill</param>
  /// <param name="raiseBuilt">Lua name: raise_built</param>
  /// <param name="createBuildEffectSmoke">Lua name: create_build_effect_smoke</param>
  /// <param name="spawnDecorations">Lua name: spawn_decorations</param>
  /// <param name="moveStuckPlayers">Lua name: move_stuck_players</param>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("create_entity")]
  public abstract LuaEntity? CreateEntity(string name, MapPosition position, DirectionEnum? direction = null, ForceIdentification? force = null, Union1110304388? target = null, Union1110304388? source = null, bool? fastReplace = null, PlayerIdentification? player = null, LuaEntity? character = null, bool? spill = null, bool? raiseBuilt = null, bool? createBuildEffectSmoke = null, bool? spawnDecorations = null, bool? moveStuckPlayers = null, LuaItemStack? item = null);

  /// <param name="name">Lua name: name</param>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("create_trivial_smoke")]
  public abstract void CreateTrivialSmoke(string name, MapPosition position);

  /// <summary>
  /// Creates a particle at the given location
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="movement">Lua name: movement</param>
  /// <param name="height">Lua name: height</param>
  /// <param name="verticalSpeed">Lua name: vertical_speed</param>
  /// <param name="frameSpeed">Lua name: frame_speed</param>
  [FactorioRconMethod("create_particle")]
  public abstract void CreateParticle(string name, MapPosition position, Vector movement, float height, float verticalSpeed, float frameSpeed);

  /// <summary>
  /// Create a new unit group at a given position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("create_unit_group")]
  public abstract LuaUnitGroup CreateUnitGroup(MapPosition position, ForceIdentification? force = null);

  /// <summary>
  /// Send a group to build a new base.
  /// </summary>
  /// <remarks>
  /// The specified force must be AI-controlled; i.e. `force.ai_controllable` must be `true`.
  /// </remarks>
  /// <param name="position">Lua name: position</param>
  /// <param name="unitCount">Lua name: unit_count</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("build_enemy_base")]
  public abstract void BuildEnemyBase(MapPosition position, uint unitCount, ForceIdentification? force = null);

  /// <summary>
  /// Get the tile at a given position. An alternative call signature for this method is passing it a single <see cref="TilePosition" />.
  /// </summary>
  /// <remarks>
  /// Non-integer values will result in them being rounded down.
  /// </remarks>
  /// <param name="x">Lua name: x</param>
  /// <param name="y">Lua name: y</param>
  [FactorioRconMethod("get_tile")]
  public abstract LuaTile GetTile(int x, int y);

  /// <summary>
  /// Set tiles at specified locations. Can automatically correct the edges around modified tiles.
  /// 
  /// Placing a <see cref="LuaSurface.SetHiddenTile" />.
  /// </summary>
  /// <remarks>
  /// It is recommended to call this method once for all the tiles you want to change rather than calling it individually for every tile. As the tile correction is used after every step, calling it one by one could cause the tile correction logic to redo some of the changes. Also, many small API calls are generally more performance intensive than one big one.
  /// </remarks>
  /// <param name="tiles">Lua name: tiles</param>
  /// <param name="correctTiles">Lua name: correct_tiles</param>
  /// <param name="removeCollidingEntities">Lua name: remove_colliding_entities</param>
  /// <param name="removeCollidingDecoratives">Lua name: remove_colliding_decoratives</param>
  /// <param name="raiseEvent">Lua name: raise_event</param>
  [FactorioRconMethod("set_tiles")]
  public abstract void SetTiles(List<Tile> tiles, bool? correctTiles = null, Union1144330560? removeCollidingEntities = null, bool? removeCollidingDecoratives = null, bool? raiseEvent = null);

  /// <summary>
  /// Spawn pollution at the given position.
  /// </summary>
  /// <param name="source">Lua name: source</param>
  /// <param name="amount">Lua name: amount</param>
  [FactorioRconMethod("pollute")]
  public abstract void Pollute(MapPosition source, double amount);

  /// <summary>
  /// Get an iterator going over every chunk on this surface.
  /// </summary>
  [FactorioRconMethod("get_chunks")]
  public abstract LuaChunkIterator GetChunks();

  /// <summary>
  /// Is a given chunk generated?
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("is_chunk_generated")]
  public abstract bool IsChunkGenerated(ChunkPosition position);

  /// <summary>
  /// Request that the game's map generator generate chunks at the given position for the given radius on this surface. If the radius is `0`, then only the chunk at the given position is generated.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="radius">Lua name: radius</param>
  [FactorioRconMethod("request_to_generate_chunks")]
  public abstract void RequestToGenerateChunks(MapPosition position, uint? radius = null);

  /// <summary>
  /// Blocks and generates all chunks that have been requested using all available threads.
  /// </summary>
  [FactorioRconMethod("force_generate_chunk_requests")]
  public abstract void ForceGenerateChunkRequests();

  /// <summary>
  /// Set generated status of a chunk. Useful when copying chunks.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="status">Lua name: status</param>
  [FactorioRconMethod("set_chunk_generated_status")]
  public abstract void SetChunkGeneratedStatus(ChunkPosition position, ChunkGeneratedStatusEnum status);

  /// <summary>
  /// Find the logistic network that covers a given position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("find_logistic_network_by_position")]
  public abstract LuaLogisticNetwork? FindLogisticNetworkByPosition(MapPosition position, ForceIdentification force);

  /// <summary>
  /// Find the logistic network with a cell closest to a given position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("find_closest_logistic_network_by_position")]
  public abstract LuaLogisticNetwork? FindClosestLogisticNetworkByPosition(MapPosition position, ForceIdentification force);

  /// <summary>
  /// Finds all of the logistics networks whose construction area intersects with the given position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("find_logistic_networks_by_construction_area")]
  public abstract List<LuaLogisticNetwork> FindLogisticNetworksByConstructionArea(MapPosition position, ForceIdentification force);

  /// <summary>
  /// Place a deconstruction request.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="player">Lua name: player</param>
  /// <param name="skipFogOfWar">Lua name: skip_fog_of_war</param>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("deconstruct_area")]
  public abstract void DeconstructArea(BoundingBox area, ForceIdentification force, PlayerIdentification? player = null, bool? skipFogOfWar = null, LuaItemStack? item = null);

  /// <summary>
  /// Cancel a deconstruction order.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="player">Lua name: player</param>
  /// <param name="skipFogOfWar">Lua name: skip_fog_of_war</param>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("cancel_deconstruct_area")]
  public abstract void CancelDeconstructArea(BoundingBox area, ForceIdentification force, PlayerIdentification? player = null, bool? skipFogOfWar = null, LuaItemStack? item = null);

  /// <summary>
  /// Place an upgrade request.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="player">Lua name: player</param>
  /// <param name="skipFogOfWar">Lua name: skip_fog_of_war</param>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("upgrade_area")]
  public abstract void UpgradeArea(BoundingBox area, ForceIdentification force, LuaItemStack item, PlayerIdentification? player = null, bool? skipFogOfWar = null);

  /// <summary>
  /// Cancel a upgrade order.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="player">Lua name: player</param>
  /// <param name="skipFogOfWar">Lua name: skip_fog_of_war</param>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("cancel_upgrade_area")]
  public abstract void CancelUpgradeArea(BoundingBox area, ForceIdentification force, PlayerIdentification? player = null, bool? skipFogOfWar = null, LuaItemStack? item = null);

  /// <summary>
  /// The hidden tile name.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("get_hidden_tile")]
  public abstract string? GetHiddenTile(TilePosition position);

  /// <summary>
  /// Set the hidden tile for the specified position. While during normal gameplay only <see cref="LuaTilePrototype.MineableProperties" /> tiles can become hidden, this method allows any kind of tile to be set as the hidden one.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="tile">Lua name: tile</param>
  [FactorioRconMethod("set_hidden_tile")]
  public abstract void SetHiddenTile(TilePosition position, Union1998230744 tile);

  /// <summary>
  /// Gets all tiles of the given types that are connected horizontally or vertically to the given tile position including the given tile position.
  /// </summary>
  /// <remarks>
  /// This won't find tiles in non-generated chunks.
  /// </remarks>
  /// <param name="position">Lua name: position</param>
  /// <param name="tiles">Lua name: tiles</param>
  /// <param name="includeDiagonal">Lua name: include_diagonal</param>
  /// <param name="area">Lua name: area</param>
  [FactorioRconMethod("get_connected_tiles")]
  public abstract List<TilePosition> GetConnectedTiles(TilePosition position, List<string> tiles, bool? includeDiagonal = null, BoundingBox? area = null);

  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("delete_chunk")]
  public abstract void DeleteChunk(ChunkPosition position);

  /// <summary>
  /// Regenerate autoplacement of some entities on this surface. This can be used to autoplace newly-added entities.
  /// </summary>
  /// <remarks>
  /// All specified entity prototypes must be autoplacable. If nothing is given all entities are generated on all chunks.
  /// </remarks>
  /// <param name="entities">Lua name: entities</param>
  /// <param name="chunks">Lua name: chunks</param>
  [FactorioRconMethod("regenerate_entity")]
  public abstract void RegenerateEntity(Union988206018? entities = null, List<ChunkPosition>? chunks = null);

  /// <summary>
  /// Regenerate autoplacement of some decoratives on this surface. This can be used to autoplace newly-added decoratives.
  /// </summary>
  /// <remarks>
  /// All specified decorative prototypes must be autoplacable. If nothing is given all decoratives are generated on all chunks.
  /// </remarks>
  /// <param name="decoratives">Lua name: decoratives</param>
  /// <param name="chunks">Lua name: chunks</param>
  [FactorioRconMethod("regenerate_decorative")]
  public abstract void RegenerateDecorative(Union988206018? decoratives = null, List<ChunkPosition>? chunks = null);

  /// <summary>
  /// Print text to the chat console of all players on this surface.
  /// </summary>
  /// <remarks>
  /// By default, messages that are identical to a message sent in the last 60 ticks are not printed again.
  /// </remarks>
  /// <param name="message">Lua name: message</param>
  /// <param name="printSettings">Lua name: print_settings</param>
  [FactorioRconMethod("print")]
  public abstract void Print(LocalisedString message, Union1265402923? printSettings = null);

  /// <summary>
  /// Removes all decoratives from the given area. If no area and no position are given, then the entire surface is searched.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="name">Lua name: name</param>
  /// <param name="collisionMask">Lua name: collision_mask</param>
  /// <param name="fromLayer">Lua name: from_layer</param>
  /// <param name="toLayer">Lua name: to_layer</param>
  /// <param name="excludeSoft">Lua name: exclude_soft</param>
  /// <param name="limit">Lua name: limit</param>
  /// <param name="invert">Lua name: invert</param>
  [FactorioRconMethod("destroy_decoratives")]
  public abstract void DestroyDecoratives(BoundingBox? area = null, TilePosition? position = null, Union390994844? name = null, Union160503673? collisionMask = null, string? fromLayer = null, string? toLayer = null, bool? excludeSoft = null, uint? limit = null, bool? invert = null);

  /// <summary>
  /// Adds the given decoratives to the surface.
  /// </summary>
  /// <remarks>
  /// This will merge decoratives of the same type that already exist effectively increasing the "amount" field.
  /// </remarks>
  /// <param name="checkCollision">Lua name: check_collision</param>
  /// <param name="decoratives">Lua name: decoratives</param>
  [FactorioRconMethod("create_decoratives")]
  public abstract void CreateDecoratives(List<Decorative> decoratives, bool? checkCollision = null);

  /// <summary>
  /// Find decoratives of a given name in a given area.
  /// 
  /// If no filters are given, returns all decoratives in the search area. If multiple filters are specified, returns only decoratives matching every given filter. If no area and no position are given, the entire surface is searched.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="name">Lua name: name</param>
  /// <param name="collisionMask">Lua name: collision_mask</param>
  /// <param name="fromLayer">Lua name: from_layer</param>
  /// <param name="toLayer">Lua name: to_layer</param>
  /// <param name="excludeSoft">Lua name: exclude_soft</param>
  /// <param name="limit">Lua name: limit</param>
  /// <param name="invert">Lua name: invert</param>
  [FactorioRconMethod("find_decoratives_filtered")]
  public abstract List<DecorativeResult> FindDecorativesFiltered(BoundingBox? area = null, TilePosition? position = null, Union390994844? name = null, Union160503673? collisionMask = null, string? fromLayer = null, string? toLayer = null, bool? excludeSoft = null, uint? limit = null, bool? invert = null);

  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("get_trains")]
  public abstract List<LuaTrain> GetTrains(ForceIdentification? force = null);

  /// <summary>
  /// Clears all pollution on this surface.
  /// </summary>
  [FactorioRconMethod("clear_pollution")]
  public abstract void ClearPollution();

  /// <summary>
  /// Play a sound for every player on this surface.
  /// </summary>
  /// <remarks>
  /// The sound is not played if its location is not <see cref="LuaForce.Chart" /> for that player.
  /// </remarks>
  /// <param name="path">Lua name: path</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="volumeModifier">Lua name: volume_modifier</param>
  /// <param name="overrideSoundType">Lua name: override_sound_type</param>
  [FactorioRconMethod("play_sound")]
  public abstract void PlaySound(SoundPath path, MapPosition? position = null, double? volumeModifier = null, SoundType? overrideSoundType = null);

  /// <summary>
  /// Gets the resource amount of all resources on this surface
  /// </summary>
  [FactorioRconMethod("get_resource_counts")]
  public abstract Dictionary<string, uint> GetResourceCounts();

  /// <summary>
  /// Gets a random generated chunk position or 0,0 if no chunks have been generated on this surface.
  /// </summary>
  [FactorioRconMethod("get_random_chunk")]
  public abstract ChunkPosition GetRandomChunk();

  /// <summary>
  /// Clones the given area.
  /// </summary>
  /// <remarks>
  /// Entities are cloned in an order such that they can always be created, eg rails before trains.
  /// </remarks>
  /// <param name="sourceArea">Lua name: source_area</param>
  /// <param name="destinationArea">Lua name: destination_area</param>
  /// <param name="destinationSurface">Lua name: destination_surface</param>
  /// <param name="destinationForce">Lua name: destination_force</param>
  /// <param name="cloneTiles">Lua name: clone_tiles</param>
  /// <param name="cloneEntities">Lua name: clone_entities</param>
  /// <param name="cloneDecoratives">Lua name: clone_decoratives</param>
  /// <param name="clearDestinationEntities">Lua name: clear_destination_entities</param>
  /// <param name="clearDestinationDecoratives">Lua name: clear_destination_decoratives</param>
  /// <param name="expandMap">Lua name: expand_map</param>
  /// <param name="createBuildEffectSmoke">Lua name: create_build_effect_smoke</param>
  [FactorioRconMethod("clone_area")]
  public abstract void CloneArea(BoundingBox sourceArea, BoundingBox destinationArea, SurfaceIdentification? destinationSurface = null, ForceIdentification? destinationForce = null, bool? cloneTiles = null, bool? cloneEntities = null, bool? cloneDecoratives = null, bool? clearDestinationEntities = null, bool? clearDestinationDecoratives = null, bool? expandMap = null, bool? createBuildEffectSmoke = null);

  /// <summary>
  /// Clones the given area.
  /// </summary>
  /// <remarks>
  /// <see cref="Defines.Events.OnAreaCloned" /> is raised.
  /// Entities are cloned in an order such that they can always be created, eg rails before trains.
  /// </remarks>
  /// <param name="sourceOffset">Lua name: source_offset</param>
  /// <param name="destinationOffset">Lua name: destination_offset</param>
  /// <param name="sourcePositions">Lua name: source_positions</param>
  /// <param name="destinationSurface">Lua name: destination_surface</param>
  /// <param name="destinationForce">Lua name: destination_force</param>
  /// <param name="cloneTiles">Lua name: clone_tiles</param>
  /// <param name="cloneEntities">Lua name: clone_entities</param>
  /// <param name="cloneDecoratives">Lua name: clone_decoratives</param>
  /// <param name="clearDestinationEntities">Lua name: clear_destination_entities</param>
  /// <param name="clearDestinationDecoratives">Lua name: clear_destination_decoratives</param>
  /// <param name="expandMap">Lua name: expand_map</param>
  /// <param name="manualCollisionMode">Lua name: manual_collision_mode</param>
  /// <param name="createBuildEffectSmoke">Lua name: create_build_effect_smoke</param>
  [FactorioRconMethod("clone_brush")]
  public abstract void CloneBrush(TilePosition sourceOffset, TilePosition destinationOffset, List<TilePosition> sourcePositions, SurfaceIdentification? destinationSurface = null, Union1325717039? destinationForce = null, bool? cloneTiles = null, bool? cloneEntities = null, bool? cloneDecoratives = null, bool? clearDestinationEntities = null, bool? clearDestinationDecoratives = null, bool? expandMap = null, bool? manualCollisionMode = null, bool? createBuildEffectSmoke = null);

  /// <summary>
  /// Clones the given entities.
  /// </summary>
  /// <remarks>
  /// Entities are cloned in an order such that they can always be created, eg rails before trains.
  /// </remarks>
  /// <param name="entities">Lua name: entities</param>
  /// <param name="destinationOffset">Lua name: destination_offset</param>
  /// <param name="destinationSurface">Lua name: destination_surface</param>
  /// <param name="destinationForce">Lua name: destination_force</param>
  /// <param name="snapToGrid">Lua name: snap_to_grid</param>
  /// <param name="createBuildEffectSmoke">Lua name: create_build_effect_smoke</param>
  [FactorioRconMethod("clone_entities")]
  public abstract void CloneEntities(List<LuaEntity> entities, Vector destinationOffset, SurfaceIdentification? destinationSurface = null, ForceIdentification? destinationForce = null, bool? snapToGrid = null, bool? createBuildEffectSmoke = null);

  /// <summary>
  /// Clears this surface deleting all entities and chunks on it.
  /// </summary>
  /// <param name="ignoreCharacters">Lua name: ignore_characters</param>
  [FactorioRconMethod("clear")]
  public abstract void Clear(bool? ignoreCharacters = null);

  /// <summary>
  /// Generates a path with the specified constraints (as an array of <see cref="LuaEntity.SetCommand" /> instead.
  /// 
  /// The resulting path is ultimately returned asynchronously via <see cref="OnScriptPathRequestFinished" />.
  /// </summary>
  /// <param name="boundingBox">Lua name: bounding_box</param>
  /// <param name="collisionMask">Lua name: collision_mask</param>
  /// <param name="start">Lua name: start</param>
  /// <param name="goal">Lua name: goal</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="radius">Lua name: radius</param>
  /// <param name="pathfindFlags">Lua name: pathfind_flags</param>
  /// <param name="canOpenGates">Lua name: can_open_gates</param>
  /// <param name="pathResolutionModifier">Lua name: path_resolution_modifier</param>
  /// <param name="entityToIgnore">Lua name: entity_to_ignore</param>
  [FactorioRconMethod("request_path")]
  public abstract uint RequestPath(BoundingBox boundingBox, Union129145693 collisionMask, MapPosition start, MapPosition goal, ForceIdentification force, double? radius = null, PathfinderFlags? pathfindFlags = null, bool? canOpenGates = null, int? pathResolutionModifier = null, LuaEntity? entityToIgnore = null);

  /// <summary>
  /// Gets the script areas that match the given name or if no name is given all areas are returned.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("get_script_areas")]
  public abstract List<ScriptArea> GetScriptAreas(string? name = null);

  /// <summary>
  /// Gets the first script area by name or id.
  /// </summary>
  /// <param name="key">Lua name: key</param>
  [FactorioRconMethod("get_script_area")]
  public abstract ScriptArea? GetScriptArea(Union19664263? key = null);

  /// <summary>
  /// Sets the given script area to the new values.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="area">Lua name: area</param>
  [FactorioRconMethod("edit_script_area")]
  public abstract void EditScriptArea(uint id, ScriptArea area);

  /// <summary>
  /// Adds the given script area.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  [FactorioRconMethod("add_script_area")]
  public abstract uint AddScriptArea(ScriptArea area);

  /// <summary>
  /// Removes the given script area.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("remove_script_area")]
  public abstract bool RemoveScriptArea(uint id);

  /// <summary>
  /// Gets the script positions that match the given name or if no name is given all positions are returned.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("get_script_positions")]
  public abstract List<ScriptPosition> GetScriptPositions(string? name = null);

  /// <summary>
  /// Gets the first script position by name or id.
  /// </summary>
  /// <param name="key">Lua name: key</param>
  [FactorioRconMethod("get_script_position")]
  public abstract ScriptPosition? GetScriptPosition(Union19664263? key = null);

  /// <summary>
  /// Sets the given script position to the new values.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  /// <param name="area">Lua name: area</param>
  [FactorioRconMethod("edit_script_position")]
  public abstract void EditScriptPosition(uint id, ScriptPosition area);

  /// <summary>
  /// Adds the given script position.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  [FactorioRconMethod("add_script_position")]
  public abstract uint AddScriptPosition(ScriptPosition area);

  /// <summary>
  /// Removes the given script position.
  /// </summary>
  /// <param name="id">Lua name: id</param>
  [FactorioRconMethod("remove_script_position")]
  public abstract bool RemoveScriptPosition(uint id);

  /// <summary>
  /// Gets the map exchange string for the current map generation settings of this surface.
  /// </summary>
  [FactorioRconMethod("get_map_exchange_string")]
  public abstract string GetMapExchangeString();

  /// <summary>
  /// Gets the starting area radius of this surface.
  /// </summary>
  [FactorioRconMethod("get_starting_area_radius")]
  public abstract double GetStartingAreaRadius();

  /// <summary>
  /// Gets the closest entity in the list to this position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="entities">Lua name: entities</param>
  [FactorioRconMethod("get_closest")]
  public abstract LuaEntity? GetClosest(MapPosition position, List<LuaEntity> entities);

  /// <summary>
  /// Gets train stops matching the given filters.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("get_train_stops")]
  public abstract List<LuaEntity> GetTrainStops(Union988206018? name = null, ForceIdentification? force = null);

  /// <summary>
  /// Gets the total amount of pollution on the surface by iterating over all of the chunks containing pollution.
  /// </summary>
  [FactorioRconMethod("get_total_pollution")]
  public abstract double GetTotalPollution();

  /// <summary>
  /// Whether the given entity prototype collides at the given position and direction.
  /// </summary>
  /// <param name="prototype">Lua name: prototype</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="useMapGenerationBoundingBox">Lua name: use_map_generation_bounding_box</param>
  /// <param name="direction">Lua name: direction</param>
  [FactorioRconMethod("entity_prototype_collides")]
  public abstract bool EntityPrototypeCollides(EntityPrototypeIdentification prototype, MapPosition position, bool useMapGenerationBoundingBox, DirectionEnum? direction = null);

  /// <summary>
  /// Whether the given decorative prototype collides at the given position and direction.
  /// </summary>
  /// <param name="prototype">Lua name: prototype</param>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("decorative_prototype_collides")]
  public abstract bool DecorativePrototypeCollides(string prototype, MapPosition position);

  /// <param name="propertyNames">Lua name: property_names</param>
  /// <param name="positions">Lua name: positions</param>
  [FactorioRconMethod("calculate_tile_properties")]
  public abstract Dictionary<string, List<double>> CalculateTileProperties(List<string> propertyNames, List<MapPosition> positions);

  /// <summary>
  /// Returns all the military targets (entities with force) on this chunk for the given force.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("get_entities_with_force")]
  public abstract List<LuaEntity> GetEntitiesWithForce(ChunkPosition position, ForceIdentification force);

  /// <summary>
  /// Sets the given area to the checkerboard lab tiles.
  /// </summary>
  /// <param name="area">Lua name: area</param>
  [FactorioRconMethod("build_checkerboard")]
  public abstract void BuildCheckerboard(BoundingBox area);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

