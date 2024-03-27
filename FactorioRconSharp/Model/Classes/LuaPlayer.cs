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
/// A player in the game. Pay attention that a player may or may not have a character, which is the <see cref="LuaEntity" /> of the little guy running around the world doing things.
/// </summary>
[FactorioRconClass("LuaPlayer")]
public abstract class LuaPlayer: LuaObject
{
  /// <summary>
  /// The character attached to this player, if any. Returns `nil` when the player is disconnected (see <see cref="LuaPlayer.Connected)" />.
  /// </summary>
  [FactorioRconAttribute("character")]
  public LuaEntity Character { get; set; }

  /// <summary>
  /// When in a cutscene; the character this player would be using once the cutscene is over, if any. Returns `nil` when the player is disconnected (see <see cref="LuaPlayer.Connected)" />.
  /// </summary>
  [FactorioRconAttribute("cutscene_character")]
  public LuaEntity CutsceneCharacter { get; private set; }

  /// <summary>
  /// This player's index in <see cref="OnPlayerRemoved" />. Indexes of removed players can be reused.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; private set; }

  [FactorioRconAttribute("gui")]
  public LuaGui Gui { get; private set; }

  /// <summary>
  /// `true` if the player opened itself. I.e. if they opened the character or god-controller GUI.
  /// </summary>
  [FactorioRconAttribute("opened_self")]
  public bool OpenedSelf { get; private set; }

  [FactorioRconAttribute("controller_type")]
  public ControllersEnum ControllerType { get; private set; }

  /// <summary>
  /// The stashed controller type, if any.
  /// </summary>
  [FactorioRconAttribute("stashed_controller_type")]
  public ControllersEnum StashedControllerType { get; private set; }

  /// <summary>
  /// The player's game view settings.
  /// </summary>
  [FactorioRconAttribute("game_view_settings")]
  public GameViewSettings GameViewSettings { get; set; }

  /// <summary>
  /// `true` if the minimap is visible.
  /// </summary>
  [FactorioRconAttribute("minimap_enabled")]
  public bool MinimapEnabled { get; set; }

  /// <summary>
  /// The color associated with the player. This will be used to tint the player's character as well as their buildings and vehicles.
  /// </summary>
  [FactorioRconAttribute("color")]
  public Color Color { get; set; }

  /// <summary>
  /// The color used when this player talks in game.
  /// </summary>
  [FactorioRconAttribute("chat_color")]
  public Color ChatColor { get; set; }

  /// <summary>
  /// The player's username.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// The tag that is shown after the player in chat and on the map.
  /// </summary>
  [FactorioRconAttribute("tag")]
  public string Tag { get; set; }

  /// <summary>
  /// `true` if the player is currently connected to the game.
  /// </summary>
  [FactorioRconAttribute("connected")]
  public bool Connected { get; private set; }

  /// <summary>
  /// `true` if the player is an admin.
  /// </summary>
  [FactorioRconAttribute("admin")]
  public bool Admin { get; set; }

  /// <summary>
  /// The source entity used during entity settings copy-paste, if any.
  /// </summary>
  [FactorioRconAttribute("entity_copy_source")]
  public LuaEntity EntityCopySource { get; private set; }

  /// <summary>
  /// How many ticks since the last action of this player
  /// </summary>
  [FactorioRconAttribute("afk_time")]
  public uint AfkTime { get; private set; }

  /// <summary>
  /// How many ticks did this player spend playing this save (all sessions combined)
  /// </summary>
  [FactorioRconAttribute("online_time")]
  public uint OnlineTime { get; private set; }

  /// <summary>
  /// At what tick this player was last online.
  /// </summary>
  [FactorioRconAttribute("last_online")]
  public uint LastOnline { get; private set; }

  /// <summary>
  /// The permission group this player is part of, if any.
  /// </summary>
  [FactorioRconAttribute("permission_group")]
  public LuaPermissionGroup PermissionGroup { get; set; }

  /// <summary>
  /// The current per-player settings for the this player, indexed by prototype name. Returns the same structure as <see cref="LuaSettings.GetPlayerSettings" />. This table becomes invalid if its associated player does.
  /// 
  /// Even though this attribute is marked as read-only, individual settings can be changed by overwriting their <see cref="ModSetting" /> table. Mods can only change their own settings. Using the in-game console, all player settings can be changed.
  /// </summary>
  [FactorioRconAttribute("mod_settings")]
  public LuaCustomTable<string, ModSetting> ModSettings { get; private set; }

  /// <summary>
  /// The number of ticks until this player will respawn. `nil` if this player is not waiting to respawn.
  /// 
  /// Set to `nil` to immediately respawn the player.
  /// </summary>
  [FactorioRconAttribute("ticks_to_respawn")]
  public uint TicksToRespawn { get; set; }

  /// <summary>
  /// The display resolution for this player.
  /// </summary>
  [FactorioRconAttribute("display_resolution")]
  public DisplayResolution DisplayResolution { get; private set; }

  /// <summary>
  /// The display scale for this player.
  /// </summary>
  [FactorioRconAttribute("display_scale")]
  public double DisplayScale { get; private set; }

  /// <summary>
  /// The item stack containing a blueprint to be setup.
  /// </summary>
  [FactorioRconAttribute("blueprint_to_setup")]
  public LuaItemStack BlueprintToSetup { get; private set; }

  /// <summary>
  /// The render mode of the player, like map or zoom to world. The render mode can be set using <see cref="LuaPlayer.CloseMap" />.
  /// </summary>
  [FactorioRconAttribute("render_mode")]
  public RenderModeEnum RenderMode { get; private set; }

  /// <summary>
  /// The input method of the player, mouse and keyboard or game controller
  /// </summary>
  [FactorioRconAttribute("input_method")]
  public InputMethodEnum InputMethod { get; private set; }

  /// <summary>
  /// If `true`, zoom-to-world noise effect will be disabled and environmental sounds will be based on zoom-to-world view instead of position of player's character.
  /// </summary>
  [FactorioRconAttribute("spectator")]
  public bool Spectator { get; set; }

  /// <summary>
  /// If `true`, circle and name of given player is rendered on the map/chart.
  /// </summary>
  [FactorioRconAttribute("show_on_map")]
  public bool ShowOnMap { get; set; }

  /// <summary>
  /// If items not included in this map editor infinity inventory filters should be removed.
  /// </summary>
  [FactorioRconAttribute("remove_unfiltered_items")]
  public bool RemoveUnfilteredItems { get; set; }

  /// <summary>
  /// The filters for this map editor infinity inventory settings.
  /// </summary>
  [FactorioRconAttribute("infinity_inventory_filters")]
  public List<InfinityInventoryFilter> InfinityInventoryFilters { get; set; }

  /// <summary>
  /// If the main inventory will be auto sorted.
  /// </summary>
  [FactorioRconAttribute("auto_sort_main_inventory")]
  public bool AutoSortMainInventory { get; private set; }

  /// <summary>
  /// The original location of the item in the cursor, marked with a hand. `nil` if the cursor stack is empty. When writing, the specified inventory slot must be empty and the cursor stack must not be empty.
  /// </summary>
  [FactorioRconAttribute("hand_location")]
  public ItemStackLocation HandLocation { get; set; }

  /// <summary>
  /// Returns true if the current item stack in cursor will be destroyed after clearing the cursor. Manually putting it into inventory still preserves the item. If the cursor stack is not one of the supported types (blueprint, blueprint-book, deconstruction-planner, upgrade-planner), write operation will be silently ignored.
  /// </summary>
  [FactorioRconAttribute("cursor_stack_temporary")]
  public bool CursorStackTemporary { get; set; }

  /// <summary>
  /// The wire drag target for this player, if any.
  /// </summary>
  [FactorioRconAttribute("drag_target")]
  public DragTarget DragTarget { get; private set; }

  /// <summary>
  /// The player's zoom-level.
  /// </summary>
  [FactorioRconAttribute("zoom")]
  public double Zoom { private get; set; }

  /// <summary>
  /// The player's map view settings. To write to this, use a table containing the fields that should be changed.
  /// </summary>
  [FactorioRconAttribute("map_view_settings")]
  public MapViewSettings MapViewSettings { private get; set; }

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
  /// Setup the screen to be shown when the game is finished.
  /// </summary>
  /// <param name="message">Lua name: message</param>
  /// <param name="file">Lua name: file</param>
  [FactorioRconMethod("set_ending_screen_data")]
  public abstract void SetEndingScreenData(LocalisedString message, string? file = null);

  /// <summary>
  /// Print text to the chat console.
  /// </summary>
  /// <remarks>
  /// By default, messages that are identical to a message sent in the last 60 ticks are not printed again.
  /// </remarks>
  /// <param name="message">Lua name: message</param>
  /// <param name="printSettings">Lua name: print_settings</param>
  [FactorioRconMethod("print")]
  public abstract void Print(LocalisedString message, Union_edd565b708da43f1b33f84dcc346d9b4? printSettings = null);

  /// <summary>
  /// Clear the chat console.
  /// </summary>
  [FactorioRconMethod("clear_console")]
  public abstract void ClearConsole();

  /// <summary>
  /// Get the current goal description, as a localised string.
  /// </summary>
  [FactorioRconMethod("get_goal_description")]
  public abstract LocalisedString GetGoalDescription();

  /// <summary>
  /// Set the text in the goal window (top left).
  /// </summary>
  /// <param name="text">Lua name: text</param>
  /// <param name="onlyUpdate">Lua name: only_update</param>
  [FactorioRconMethod("set_goal_description")]
  public abstract void SetGoalDescription(LocalisedString? text = null, bool? onlyUpdate = null);

  /// <summary>
  /// Set the controller type of the player.
  /// </summary>
  /// <remarks>
  /// Setting a player to <see cref="Defines.Controllers.Editor" /> auto promotes the player to admin and enables cheat mode.
  /// Setting a player to <see cref="Defines.Controllers.Editor" /> also requires the calling player be an admin.
  /// </remarks>
  /// <param name="type">Lua name: type</param>
  /// <param name="character">Lua name: character</param>
  /// <param name="waypoints">Lua name: waypoints</param>
  /// <param name="startPosition">Lua name: start_position</param>
  /// <param name="startZoom">Lua name: start_zoom</param>
  /// <param name="finalTransitionTime">Lua name: final_transition_time</param>
  /// <param name="chartModeCutoff">Lua name: chart_mode_cutoff</param>
  [FactorioRconMethod("set_controller")]
  public abstract void SetController(ControllersEnum type, LuaEntity? character = null, CutsceneWaypoint? waypoints = null, MapPosition? startPosition = null, double? startZoom = null, uint? finalTransitionTime = null, double? chartModeCutoff = null);

  /// <summary>
  /// Start/end wire dragging at the specified location, wire type is based on the cursor contents
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("drag_wire")]
  public abstract bool DragWire(MapPosition position);

  /// <summary>
  /// Disable recipe groups.
  /// </summary>
  [FactorioRconMethod("disable_recipe_groups")]
  public abstract void DisableRecipeGroups();

  /// <summary>
  /// Enable recipe groups.
  /// </summary>
  [FactorioRconMethod("enable_recipe_groups")]
  public abstract void EnableRecipeGroups();

  /// <summary>
  /// Disable recipe subgroups.
  /// </summary>
  [FactorioRconMethod("disable_recipe_subgroups")]
  public abstract void DisableRecipeSubgroups();

  /// <summary>
  /// Enable recipe subgroups.
  /// </summary>
  [FactorioRconMethod("enable_recipe_subgroups")]
  public abstract void EnableRecipeSubgroups();

  /// <summary>
  /// Print entity statistics to the player's console.
  /// </summary>
  /// <param name="entities">Lua name: entities</param>
  [FactorioRconMethod("print_entity_statistics")]
  public abstract void PrintEntityStatistics(List<string>? entities = null);

  /// <summary>
  /// Print construction robot job counts to the players console.
  /// </summary>
  [FactorioRconMethod("print_robot_jobs")]
  public abstract void PrintRobotJobs();

  /// <summary>
  /// Print LuaObject counts per mod.
  /// </summary>
  [FactorioRconMethod("print_lua_object_statistics")]
  public abstract void PrintLuaObjectStatistics();

  /// <summary>
  /// Logs a dictionary of chunks -> active entities for the surface this player is on.
  /// </summary>
  [FactorioRconMethod("log_active_entity_chunk_counts")]
  public abstract void LogActiveEntityChunkCounts();

  /// <summary>
  /// Logs a dictionary of active entities -> count for the surface this player is on.
  /// </summary>
  [FactorioRconMethod("log_active_entity_counts")]
  public abstract void LogActiveEntityCounts();

  /// <summary>
  /// Unlock the achievements of the given player. This has any effect only when this is the local player, the achievement isn't unlocked so far and the achievement is of the type "achievement".
  /// </summary>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("unlock_achievement")]
  public abstract void UnlockAchievement(string name);

  /// <summary>
  /// Invokes the "clear cursor" action on the player as if the user pressed it.
  /// </summary>
  [FactorioRconMethod("clear_cursor")]
  public abstract bool ClearCursor();

  /// <summary>
  /// Creates and attaches a character entity to this player.
  /// </summary>
  /// <remarks>
  /// The player must not have a character already connected and must be online (see <see cref="LuaPlayer.Connected)" />.
  /// </remarks>
  /// <param name="character">Lua name: character</param>
  [FactorioRconMethod("create_character")]
  public abstract bool CreateCharacter(string? character = null);

  /// <summary>
  /// Adds an alert to this player for the given entity of the given alert type.
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  /// <param name="type">Lua name: type</param>
  [FactorioRconMethod("add_alert")]
  public abstract void AddAlert(LuaEntity entity, AlertTypeEnum type);

  /// <summary>
  /// Adds a custom alert to this player.
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  /// <param name="icon">Lua name: icon</param>
  /// <param name="message">Lua name: message</param>
  /// <param name="showOnMap">Lua name: show_on_map</param>
  [FactorioRconMethod("add_custom_alert")]
  public abstract void AddCustomAlert(LuaEntity entity, SignalID icon, LocalisedString message, bool showOnMap);

  /// <summary>
  /// Removes all alerts matching the given filters or if an empty filters table is given all alerts are removed.
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  /// <param name="prototype">Lua name: prototype</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="type">Lua name: type</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="icon">Lua name: icon</param>
  /// <param name="message">Lua name: message</param>
  [FactorioRconMethod("remove_alert")]
  public abstract void RemoveAlert(LuaEntity? entity = null, Union_30152a93cf904d9eaf23d0fcf7791f76? prototype = null, MapPosition? position = null, AlertTypeEnum? type = null, SurfaceIdentification? surface = null, SignalID? icon = null, LocalisedString? message = null);

  /// <summary>
  /// Get all alerts matching the given filters, or all alerts if no filters are given.
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  /// <param name="prototype">Lua name: prototype</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="type">Lua name: type</param>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("get_alerts")]
  public abstract Dictionary<uint, Dictionary<AlertTypeEnum, List<Alert>>> GetAlerts(LuaEntity? entity = null, LuaEntityPrototype? prototype = null, MapPosition? position = null, AlertTypeEnum? type = null, SurfaceIdentification? surface = null);

  /// <summary>
  /// Mutes alerts for the given alert category.
  /// </summary>
  /// <param name="alertType">Lua name: alert_type</param>
  [FactorioRconMethod("mute_alert")]
  public abstract bool MuteAlert(AlertTypeEnum alertType);

  /// <summary>
  /// Unmutes alerts for the given alert category.
  /// </summary>
  /// <param name="alertType">Lua name: alert_type</param>
  [FactorioRconMethod("unmute_alert")]
  public abstract bool UnmuteAlert(AlertTypeEnum alertType);

  /// <summary>
  /// If the given alert type is currently muted.
  /// </summary>
  /// <param name="alertType">Lua name: alert_type</param>
  [FactorioRconMethod("is_alert_muted")]
  public abstract bool IsAlertMuted(AlertTypeEnum alertType);

  /// <summary>
  /// Enables alerts for the given alert category.
  /// </summary>
  /// <param name="alertType">Lua name: alert_type</param>
  [FactorioRconMethod("enable_alert")]
  public abstract bool EnableAlert(AlertTypeEnum alertType);

  /// <summary>
  /// Disables alerts for the given alert category.
  /// </summary>
  /// <param name="alertType">Lua name: alert_type</param>
  [FactorioRconMethod("disable_alert")]
  public abstract bool DisableAlert(AlertTypeEnum alertType);

  /// <summary>
  /// If the given alert type is currently enabled.
  /// </summary>
  /// <param name="alertType">Lua name: alert_type</param>
  [FactorioRconMethod("is_alert_enabled")]
  public abstract bool IsAlertEnabled(AlertTypeEnum alertType);

  /// <summary>
  /// Invokes the "smart pipette" action on the player as if the user pressed it.
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  [FactorioRconMethod("pipette_entity")]
  public abstract bool PipetteEntity(Union_d36869b73b3e4cbc92cbf5d0af54be06 entity);

  /// <summary>
  /// Checks if this player can build the given entity at the given location on the surface the player is on.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="direction">Lua name: direction</param>
  [FactorioRconMethod("can_place_entity")]
  public abstract bool CanPlaceEntity(string name, MapPosition position, DirectionEnum? direction = null);

  /// <summary>
  /// Checks if this player can build what ever is in the cursor on the surface the player is on.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="direction">Lua name: direction</param>
  /// <param name="alt">Lua name: alt</param>
  /// <param name="terrainBuildingSize">Lua name: terrain_building_size</param>
  /// <param name="skipFogOfWar">Lua name: skip_fog_of_war</param>
  [FactorioRconMethod("can_build_from_cursor")]
  public abstract bool CanBuildFromCursor(MapPosition position, DirectionEnum? direction = null, bool? alt = null, uint? terrainBuildingSize = null, bool? skipFogOfWar = null);

  /// <summary>
  /// Builds whatever is in the cursor on the surface the player is on. The cursor stack will automatically be reduced as if the player built normally.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="direction">Lua name: direction</param>
  /// <param name="alt">Lua name: alt</param>
  /// <param name="terrainBuildingSize">Lua name: terrain_building_size</param>
  /// <param name="skipFogOfWar">Lua name: skip_fog_of_war</param>
  [FactorioRconMethod("build_from_cursor")]
  public abstract void BuildFromCursor(MapPosition position, DirectionEnum? direction = null, bool? alt = null, uint? terrainBuildingSize = null, bool? skipFogOfWar = null);

  /// <summary>
  /// Uses the current item in the cursor if it's a capsule or does nothing if not.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("use_from_cursor")]
  public abstract void UseFromCursor(MapPosition position);

  /// <summary>
  /// Play a sound for this player.
  /// </summary>
  /// <remarks>
  /// The sound is not played if its location is not <see cref="LuaForce.Chart" /> for this player.
  /// </remarks>
  /// <param name="path">Lua name: path</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="volumeModifier">Lua name: volume_modifier</param>
  /// <param name="overrideSoundType">Lua name: override_sound_type</param>
  [FactorioRconMethod("play_sound")]
  public abstract void PlaySound(SoundPath path, MapPosition? position = null, double? volumeModifier = null, SoundType? overrideSoundType = null);

  /// <summary>
  /// The characters associated with this player.
  /// </summary>
  /// <remarks>
  /// The array will always be empty when the player is disconnected (see <see cref="LuaPlayer.Connected)" /> regardless of there being associated characters.
  /// Characters associated with this player will be logged off when this player disconnects but are not controlled by any player.
  /// </remarks>
  [FactorioRconMethod("get_associated_characters")]
  public abstract List<LuaEntity> GetAssociatedCharacters();

  /// <summary>
  /// Associates a character with this player.
  /// </summary>
  /// <remarks>
  /// The character must not be connected to any controller.
  /// If this player is currently disconnected (see <see cref="LuaPlayer.Connected)" /> the character will be immediately "logged off".
  /// See <see cref="LuaPlayer.GetAssociatedCharacters" /> for more information.
  /// </remarks>
  /// <param name="character">Lua name: character</param>
  [FactorioRconMethod("associate_character")]
  public abstract void AssociateCharacter(LuaEntity character);

  /// <summary>
  /// Disassociates a character from this player. This is functionally the same as setting <see cref="LuaEntity.AssociatedPlayer" /> to `nil`.
  /// </summary>
  /// <remarks>
  /// See <see cref="LuaPlayer.GetAssociatedCharacters" /> for more information.
  /// </remarks>
  /// <param name="character">Lua name: character</param>
  [FactorioRconMethod("disassociate_character")]
  public abstract void DisassociateCharacter(LuaEntity character);

  /// <summary>
  /// Spawn flying text that is only visible to this player. Either `position` or `create_at_cursor` are required. When `create_at_cursor` is `true`, all parameters other than `text` are ignored.
  /// </summary>
  /// <remarks>
  /// If no custom `speed` is set and the text is longer than 25 characters, its `time_to_live` and `speed` are dynamically adjusted to give players more time to read it.
  /// Local flying text is not saved, which means it will disappear after a save/load-cycle.
  /// </remarks>
  /// <param name="text">Lua name: text</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="createAtCursor">Lua name: create_at_cursor</param>
  /// <param name="color">Lua name: color</param>
  /// <param name="timeToLive">Lua name: time_to_live</param>
  /// <param name="speed">Lua name: speed</param>
  [FactorioRconMethod("create_local_flying_text")]
  public abstract void CreateLocalFlyingText(LocalisedString text, MapPosition? position = null, bool? createAtCursor = null, Color? color = null, uint? timeToLive = null, double? speed = null);

  /// <summary>
  /// Gets the quick bar filter for the given slot or `nil`.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_quick_bar_slot")]
  public abstract LuaItemPrototype? GetQuickBarSlot(uint index);

  /// <summary>
  /// Sets the quick bar filter for the given slot.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("set_quick_bar_slot")]
  public abstract void SetQuickBarSlot(uint index, Union_92ffa47184d947ac8b4c9c209da80889 filter);

  /// <summary>
  /// Gets which quick bar page is being used for the given screen page or `nil` if not known.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_active_quick_bar_page")]
  public abstract byte? GetActiveQuickBarPage(uint index);

  /// <summary>
  /// Sets which quick bar page is being used for the given screen page.
  /// </summary>
  /// <param name="screenIndex">Lua name: screen_index</param>
  /// <param name="pageIndex">Lua name: page_index</param>
  [FactorioRconMethod("set_active_quick_bar_page")]
  public abstract void SetActiveQuickBarPage(uint screenIndex, uint pageIndex);

  /// <summary>
  /// Jump to the specified cutscene waypoint. Only works when the player is viewing a cutscene.
  /// </summary>
  /// <param name="waypointIndex">Lua name: waypoint_index</param>
  [FactorioRconMethod("jump_to_cutscene_waypoint")]
  public abstract void JumpToCutsceneWaypoint(uint waypointIndex);

  /// <summary>
  /// Exit the current cutscene. Errors if not in a cutscene.
  /// </summary>
  [FactorioRconMethod("exit_cutscene")]
  public abstract void ExitCutscene();

  /// <summary>
  /// Queues a request to open the map at the specified position. If the map is already opened, the request will simply set the position, scale, and entity to follow. Render mode change requests are processed before rendering of the next frame.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="scale">Lua name: scale</param>
  /// <param name="entity">Lua name: entity</param>
  [FactorioRconMethod("open_map")]
  public abstract void OpenMap(MapPosition position, double? scale = null, LuaEntity? entity = null);

  /// <summary>
  /// Queues a request to zoom to world at the specified position. If the player is already zooming to world, the request will simply set the position, scale, and entity to follow. Render mode change requests are processed before rendering of the next frame.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="scale">Lua name: scale</param>
  /// <param name="entity">Lua name: entity</param>
  [FactorioRconMethod("zoom_to_world")]
  public abstract void ZoomToWorld(MapPosition position, double? scale = null, LuaEntity? entity = null);

  /// <summary>
  /// Queues request to switch to the normal game view from the map or zoom to world view. Render mode change requests are processed before rendering of the next frame.
  /// </summary>
  [FactorioRconMethod("close_map")]
  public abstract void CloseMap();

  /// <summary>
  /// Is a custom Lua shortcut currently toggled?
  /// </summary>
  /// <param name="prototypeName">Lua name: prototype_name</param>
  [FactorioRconMethod("is_shortcut_toggled")]
  public abstract bool IsShortcutToggled(string prototypeName);

  /// <summary>
  /// Is a custom Lua shortcut currently available?
  /// </summary>
  /// <param name="prototypeName">Lua name: prototype_name</param>
  [FactorioRconMethod("is_shortcut_available")]
  public abstract bool IsShortcutAvailable(string prototypeName);

  /// <summary>
  /// Toggle or untoggle a custom Lua shortcut
  /// </summary>
  /// <param name="prototypeName">Lua name: prototype_name</param>
  /// <param name="toggled">Lua name: toggled</param>
  [FactorioRconMethod("set_shortcut_toggled")]
  public abstract void SetShortcutToggled(string prototypeName, bool toggled);

  /// <summary>
  /// Make a custom Lua shortcut available or unavailable.
  /// </summary>
  /// <param name="prototypeName">Lua name: prototype_name</param>
  /// <param name="available">Lua name: available</param>
  [FactorioRconMethod("set_shortcut_available")]
  public abstract void SetShortcutAvailable(string prototypeName, bool available);

  /// <summary>
  /// Asks the player if they would like to connect to the given server.
  /// </summary>
  /// <remarks>
  /// This only does anything when used on a multiplayer peer. Single player and server hosts will ignore the prompt.
  /// </remarks>
  /// <param name="address">Lua name: address</param>
  /// <param name="name">Lua name: name</param>
  /// <param name="description">Lua name: description</param>
  /// <param name="password">Lua name: password</param>
  [FactorioRconMethod("connect_to_server")]
  public abstract void ConnectToServer(string address, LocalisedString? name = null, LocalisedString? description = null, string? password = null);

  /// <summary>
  /// Toggles this player into or out of the map editor. Does nothing if this player isn't an admin or if the player doesn't have permission to use the map editor.
  /// </summary>
  [FactorioRconMethod("toggle_map_editor")]
  public abstract void ToggleMapEditor();

  /// <summary>
  /// Requests a translation for the given localised string. If the request is successful, the <see cref="OnStringTranslated" /> event will be fired with the results.
  /// </summary>
  /// <remarks>
  /// Does nothing if this player is not connected (see <see cref="LuaPlayer.Connected)" />.
  /// </remarks>
  /// <param name="localisedString">Lua name: localised_string</param>
  [FactorioRconMethod("request_translation")]
  public abstract uint? RequestTranslation(LocalisedString localisedString);

  /// <summary>
  /// Requests translation for the given set of localised strings. If the request is successful, a <see cref="OnStringTranslated" /> event will be fired for each string with the results.
  /// </summary>
  /// <remarks>
  /// Does nothing if this player is not connected (see <see cref="LuaPlayer.Connected)" />.
  /// </remarks>
  /// <param name="localisedStrings">Lua name: localised_strings</param>
  [FactorioRconMethod("request_translations")]
  public abstract List<uint>? RequestTranslations(List<LocalisedString> localisedStrings);

  /// <summary>
  /// Gets the filter for this map editor infinity filters at the given index or `nil` if the filter index doesn't exist or is empty.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_infinity_inventory_filter")]
  public abstract InfinityInventoryFilter? GetInfinityInventoryFilter(uint index);

  /// <summary>
  /// Sets the filter for this map editor infinity filters at the given index.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("set_infinity_inventory_filter")]
  public abstract void SetInfinityInventoryFilter(uint index, Union_6d48cd2804bc4ddab1f9992a7df73403 filter);

  /// <summary>
  /// Clears all recipe notifications for this player.
  /// </summary>
  [FactorioRconMethod("clear_recipe_notifications")]
  public abstract void ClearRecipeNotifications();

  /// <summary>
  /// Adds the given recipe to the list of recipe notifications for this player.
  /// </summary>
  /// <param name="recipe">Lua name: recipe</param>
  [FactorioRconMethod("add_recipe_notification")]
  public abstract void AddRecipeNotification(string recipe);

  /// <summary>
  /// Adds the given blueprint to this player's clipboard queue.
  /// </summary>
  /// <param name="blueprint">Lua name: blueprint</param>
  [FactorioRconMethod("add_to_clipboard")]
  public abstract void AddToClipboard(LuaItemStack blueprint);

  /// <summary>
  /// Gets a copy of the currently selected blueprint in the clipboard queue into the player's cursor, as if the player activated Paste.
  /// </summary>
  [FactorioRconMethod("activate_paste")]
  public abstract void ActivatePaste();

  /// <summary>
  /// Starts selection with selection tool from the specified position. Does nothing if the players cursor is not a selection tool.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="selectionMode">Lua name: selection_mode</param>
  [FactorioRconMethod("start_selection")]
  public abstract void StartSelection(MapPosition position, string selectionMode);

  /// <summary>
  /// Clears the players selection tool selection position.
  /// </summary>
  [FactorioRconMethod("clear_selection")]
  public abstract void ClearSelection();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

