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
/// Main toplevel type, provides access to most of the API though its members. An instance of LuaGameScript is available as the global object named `game`.
/// </summary>
[FactorioRconClass("LuaGameScript")]
public abstract class LuaGameScript: LuaObject
{
  /// <summary>
  /// This object's name.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// This property is only populated inside <see cref="LuaCommandProcessor)HandlersAndWhenWriting[LuaConsoleCommands](Https://Wiki.Factorio.Com/Console#ScriptingAndCheatCommands" />. Returns the player that is typing the command, `nil` in all other instances.
  /// 
  /// See <see cref="LuaGameScript.Players" /> for accessing all players.
  /// </summary>
  [FactorioRconAttribute("player")]
  public LuaPlayer Player { get; private set; }

  /// <summary>
  /// Get a table of all the players that currently exist. This sparse table allows you to find players by indexing it with either their `name` or `index`. Iterating this table with `pairs()` will only iterate the array part of the table. Iterating with `ipairs()` will not work at all.
  /// 
  /// If only a single player is required, <see cref="LuaGameScript.GetPlayer" /> should be used instead, as it avoids the unnecessary overhead of passing the whole table to Lua.
  /// </summary>
  [FactorioRconAttribute("players")]
  public LuaCustomTable<Union244833755, LuaPlayer> Players { get; private set; }

  /// <summary>
  /// The currently active set of map settings. Even though this property is marked as read-only, the members of the dictionary that is returned can be modified mid-game.
  /// </summary>
  [FactorioRconAttribute("map_settings")]
  public MapSettings MapSettings { get; private set; }

  /// <summary>
  /// The currently active set of difficulty settings. Even though this property is marked as read-only, the members of the dictionary that is returned can be modified mid-game. This is however not recommended as different difficulties can have differing technology and recipe trees, which can cause problems for players.
  /// </summary>
  [FactorioRconAttribute("difficulty_settings")]
  public DifficultySettings DifficultySettings { get; private set; }

  /// <summary>
  /// Current scenario difficulty.
  /// </summary>
  [FactorioRconAttribute("difficulty")]
  public DifficultyEnum Difficulty { get; private set; }

  /// <summary>
  /// Get a table of all the forces that currently exist. This sparse table allows you to find forces by indexing it with either their `name` or `index`. Iterating this table with `pairs()` will only iterate the hash part of the table. Iterating with `ipairs()` will not work at all.
  /// </summary>
  [FactorioRconAttribute("forces")]
  public LuaCustomTable<Union244833755, LuaForce> Forces { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaEntityPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("entity_prototypes")]
  public LuaCustomTable<string, LuaEntityPrototype> EntityPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaItemPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("item_prototypes")]
  public LuaCustomTable<string, LuaItemPrototype> ItemPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaFluidPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("fluid_prototypes")]
  public LuaCustomTable<string, LuaFluidPrototype> FluidPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaTilePrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("tile_prototypes")]
  public LuaCustomTable<string, LuaTilePrototype> TilePrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaEquipmentPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("equipment_prototypes")]
  public LuaCustomTable<string, LuaEquipmentPrototype> EquipmentPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaDamagePrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("damage_prototypes")]
  public LuaCustomTable<string, LuaDamagePrototype> DamagePrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaVirtualSignalPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("virtual_signal_prototypes")]
  public LuaCustomTable<string, LuaVirtualSignalPrototype> VirtualSignalPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaEquipmentGridPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("equipment_grid_prototypes")]
  public LuaCustomTable<string, LuaEquipmentGridPrototype> EquipmentGridPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaRecipePrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("recipe_prototypes")]
  public LuaCustomTable<string, LuaRecipePrototype> RecipePrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every <see cref="LuaTechnologyPrototype" /> indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("technology_prototypes")]
  public LuaCustomTable<string, LuaTechnologyPrototype> TechnologyPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaDecorativePrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("decorative_prototypes")]
  public LuaCustomTable<string, LuaDecorativePrototype> DecorativePrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaParticlePrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("particle_prototypes")]
  public LuaCustomTable<string, LuaParticlePrototype> ParticlePrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaAutoplaceControlPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("autoplace_control_prototypes")]
  public LuaCustomTable<string, LuaAutoplaceControlPrototype> AutoplaceControlPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaNoiseLayerPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("noise_layer_prototypes")]
  public LuaCustomTable<string, LuaNoiseLayerPrototype> NoiseLayerPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaModSettingPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("mod_setting_prototypes")]
  public LuaCustomTable<string, LuaModSettingPrototype> ModSettingPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaCustomInputPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("custom_input_prototypes")]
  public LuaCustomTable<string, LuaCustomInputPrototype> CustomInputPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaAmmoCategoryPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("ammo_category_prototypes")]
  public LuaCustomTable<string, LuaAmmoCategoryPrototype> AmmoCategoryPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaNamedNoiseExpression indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("named_noise_expressions")]
  public LuaCustomTable<string, LuaNamedNoiseExpression> NamedNoiseExpressions { get; private set; }

  /// <summary>
  /// A dictionary containing every ItemSubgroup indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("item_subgroup_prototypes")]
  public LuaCustomTable<string, LuaGroup> ItemSubgroupPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every ItemGroup indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("item_group_prototypes")]
  public LuaCustomTable<string, LuaGroup> ItemGroupPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaFuelCategoryPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("fuel_category_prototypes")]
  public LuaCustomTable<string, LuaFuelCategoryPrototype> FuelCategoryPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaResourceCategoryPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("resource_category_prototypes")]
  public LuaCustomTable<string, LuaResourceCategoryPrototype> ResourceCategoryPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaAchievementPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("achievement_prototypes")]
  public LuaCustomTable<string, LuaAchievementPrototype> AchievementPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaModuleCategoryPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("module_category_prototypes")]
  public LuaCustomTable<string, LuaModuleCategoryPrototype> ModuleCategoryPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaEquipmentCategoryPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("equipment_category_prototypes")]
  public LuaCustomTable<string, LuaEquipmentCategoryPrototype> EquipmentCategoryPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaTrivialSmokePrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("trivial_smoke_prototypes")]
  public LuaCustomTable<string, LuaTrivialSmokePrototype> TrivialSmokePrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaShortcutPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("shortcut_prototypes")]
  public LuaCustomTable<string, LuaShortcutPrototype> ShortcutPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaRecipeCategoryPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("recipe_category_prototypes")]
  public LuaCustomTable<string, LuaRecipeCategoryPrototype> RecipeCategoryPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every LuaFontPrototype indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("font_prototypes")]
  public LuaCustomTable<string, LuaFontPrototype> FontPrototypes { get; private set; }

  /// <summary>
  /// A dictionary containing every MapGenPreset indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("map_gen_presets")]
  public LuaCustomTable<string, MapGenPreset> MapGenPresets { get; private set; }

  /// <summary>
  /// Whether a console command has been used.
  /// </summary>
  [FactorioRconAttribute("console_command_used")]
  public bool ConsoleCommandUsed { get; private set; }

  /// <summary>
  /// The styles that <see cref="LuaGuiElement" /> can use, indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("styles")]
  public LuaCustomTable<string, string> Styles { get; private set; }

  /// <summary>
  /// Current map tick.
  /// </summary>
  [FactorioRconAttribute("tick")]
  public uint Tick { get; private set; }

  /// <summary>
  /// The number of ticks since this game was created using either "new game" or "new game from scenario". Notably, this number progresses even when the game is <see cref="LuaGameScript.TickPaused" />.
  /// 
  /// This differs from <see cref="LuaGameScript.Tick" /> in that creating a game from a scenario always starts with this value at `0`, even if the scenario has its own level data where the `tick` has progressed past `0`.
  /// </summary>
  [FactorioRconAttribute("ticks_played")]
  public uint TicksPlayed { get; private set; }

  /// <summary>
  /// If the tick has been paused. This means that entity update has been paused.
  /// </summary>
  [FactorioRconAttribute("tick_paused")]
  public bool TickPaused { get; set; }

  /// <summary>
  /// The number of ticks to be run while the tick is paused. When <see cref="LuaGameScript.TickPaused" /> is true, ticks_to_run behaves the following way: While this is > 0, the entity update is running normally and this value is decremented every tick. When this reaches 0, the game will pause again.
  /// </summary>
  [FactorioRconAttribute("ticks_to_run")]
  public uint TicksToRun { get; set; }

  /// <summary>
  /// True while the victory screen is shown.
  /// </summary>
  [FactorioRconAttribute("finished")]
  public bool Finished { get; private set; }

  /// <summary>
  /// True after players finished the game and clicked "continue".
  /// </summary>
  [FactorioRconAttribute("finished_but_continuing")]
  public bool FinishedButContinuing { get; private set; }

  /// <summary>
  /// Speed to update the map at. 1.0 is normal speed -- 60 UPS.
  /// </summary>
  [FactorioRconAttribute("speed")]
  public float Speed { get; set; }

  /// <summary>
  /// Get a table of all the surfaces that currently exist. This sparse table allows you to find surfaces by indexing it with either their `name` or `index`. Iterating this table with `pairs()` will only iterate the hash part of the table. Iterating with `ipairs()` will not work at all.
  /// </summary>
  [FactorioRconAttribute("surfaces")]
  public LuaCustomTable<Union244833755, LuaSurface> Surfaces { get; private set; }

  /// <summary>
  /// The active mods versions. The keys are mod names, the values are the versions.
  /// </summary>
  [FactorioRconAttribute("active_mods")]
  public Dictionary<string, string> ActiveMods { get; private set; }

  /// <summary>
  /// The players that are currently online.
  /// 
  /// This is primarily useful when you want to do some action against all online players.
  /// </summary>
  [FactorioRconAttribute("connected_players")]
  public List<LuaPlayer> ConnectedPlayers { get; private set; }

  [FactorioRconAttribute("permissions")]
  public LuaPermissionGroups Permissions { get; private set; }

  /// <summary>
  /// Array of the names of all the backers that supported the game development early on. These are used as names for labs, locomotives, radars, roboports, and train stops.
  /// </summary>
  [FactorioRconAttribute("backer_names")]
  public LuaCustomTable<uint, string> BackerNames { get; private set; }

  /// <summary>
  /// The default map gen settings for this save.
  /// </summary>
  [FactorioRconAttribute("default_map_gen_settings")]
  public MapGenSettings DefaultMapGenSettings { get; private set; }

  /// <summary>
  /// Determines if enemy land mines are completely invisible or not.
  /// </summary>
  [FactorioRconAttribute("enemy_has_vision_on_land_mines")]
  public bool EnemyHasVisionOnLandMines { get; set; }

  /// <summary>
  /// True by default. Can be used to disable autosaving. Make sure to turn it back on soon after.
  /// </summary>
  [FactorioRconAttribute("autosave_enabled")]
  public bool AutosaveEnabled { get; set; }

  /// <summary>
  /// True by default. Can be used to disable the highlighting of resource patches when they are hovered on the map.
  /// </summary>
  [FactorioRconAttribute("draw_resource_selection")]
  public bool DrawResourceSelection { get; set; }

  /// <summary>
  /// The pollution statistics for this map.
  /// </summary>
  [FactorioRconAttribute("pollution_statistics")]
  public LuaFlowStatistics PollutionStatistics { get; private set; }

  [FactorioRconAttribute("max_force_distraction_distance")]
  public double MaxForceDistractionDistance { get; private set; }

  [FactorioRconAttribute("max_force_distraction_chunk_distance")]
  public uint MaxForceDistractionChunkDistance { get; private set; }

  [FactorioRconAttribute("max_electric_pole_supply_area_distance")]
  public float MaxElectricPoleSupplyAreaDistance { get; private set; }

  [FactorioRconAttribute("max_electric_pole_connection_distance")]
  public double MaxElectricPoleConnectionDistance { get; private set; }

  [FactorioRconAttribute("max_beacon_supply_area_distance")]
  public double MaxBeaconSupplyAreaDistance { get; private set; }

  [FactorioRconAttribute("max_gate_activation_distance")]
  public double MaxGateActivationDistance { get; private set; }

  [FactorioRconAttribute("max_inserter_reach_distance")]
  public double MaxInserterReachDistance { get; private set; }

  [FactorioRconAttribute("max_pipe_to_ground_distance")]
  public byte MaxPipeToGroundDistance { get; private set; }

  [FactorioRconAttribute("max_underground_belt_distance")]
  public byte MaxUndergroundBeltDistance { get; private set; }

  /// <summary>
  /// Set scenario state. Any parameters not provided do not change the current state.
  /// </summary>
  /// <param name="gameFinished">Lua name: game_finished</param>
  /// <param name="playerWon">Lua name: player_won</param>
  /// <param name="nextLevel">Lua name: next_level</param>
  /// <param name="canContinue">Lua name: can_continue</param>
  /// <param name="victoriousForce">Lua name: victorious_force</param>
  [FactorioRconMethod("set_game_state")]
  public abstract void SetGameState(bool? gameFinished = null, bool? playerWon = null, string? nextLevel = null, bool? canContinue = null, ForceIdentification? victoriousForce = null);

  /// <summary>
  /// Reset scenario state (game_finished, player_won, etc.).
  /// </summary>
  [FactorioRconMethod("reset_game_state")]
  public abstract void ResetGameState();

  /// <summary>
  /// Gets an entity by its name tag. Entity name tags can be set in the entity "extra settings" GUI in the map editor.
  /// </summary>
  /// <param name="tag">Lua name: tag</param>
  [FactorioRconMethod("get_entity_by_tag")]
  public abstract LuaEntity? GetEntityByTag(string tag);

  /// <summary>
  /// Show an in-game message dialog.
  /// </summary>
  /// <remarks>
  /// Can only be used when the map contains exactly one player.
  /// </remarks>
  /// <param name="text">Lua name: text</param>
  /// <param name="image">Lua name: image</param>
  /// <param name="pointTo">Lua name: point_to</param>
  /// <param name="style">Lua name: style</param>
  /// <param name="wrapperFrameStyle">Lua name: wrapper_frame_style</param>
  [FactorioRconMethod("show_message_dialog")]
  public abstract void ShowMessageDialog(LocalisedString text, string? image = null, GuiArrowSpecification? pointTo = null, string? style = null, string? wrapperFrameStyle = null);

  /// <summary>
  /// Is this the demo version of Factorio?
  /// </summary>
  [FactorioRconMethod("is_demo")]
  public abstract bool IsDemo();

  /// <summary>
  /// Forces a reload of the scenario script from the original scenario location.
  /// </summary>
  /// <remarks>
  /// This disables the replay if replay is enabled.
  /// </remarks>
  [FactorioRconMethod("reload_script")]
  public abstract void ReloadScript();

  /// <summary>
  /// Forces a reload of all mods.
  /// </summary>
  /// <remarks>
  /// This will act like saving and loading from the mod(s) perspective.
  /// This will do nothing if run in multiplayer.
  /// This disables the replay if replay is enabled.
  /// </remarks>
  [FactorioRconMethod("reload_mods")]
  public abstract void ReloadMods();

  /// <summary>
  /// Saves the current configuration of Atlas to a file. This will result in huge file containing all of the game graphics moved to as small space as possible.
  /// </summary>
  /// <remarks>
  /// Exists mainly for debugging reasons.
  /// </remarks>
  [FactorioRconMethod("save_atlas")]
  public abstract void SaveAtlas();

  /// <summary>
  /// Run internal consistency checks. Allegedly prints any errors it finds.
  /// </summary>
  /// <remarks>
  /// Exists mainly for debugging reasons.
  /// </remarks>
  [FactorioRconMethod("check_consistency")]
  public abstract void CheckConsistency();

  /// <summary>
  /// Regenerate autoplacement of some entities on all surfaces. This can be used to autoplace newly-added entities.
  /// </summary>
  /// <remarks>
  /// All specified entity prototypes must be autoplacable.
  /// </remarks>
  /// <param name="entities">Lua name: entities</param>
  [FactorioRconMethod("regenerate_entity")]
  public abstract void RegenerateEntity(Union1369834877 entities);

  /// <summary>
  /// Take a screenshot of the game and save it to the `script-output` folder, located in the game's [user data directory](https://wiki.factorio.com/User_data_directory). The name of the image file can be specified via the `path` parameter.
  /// </summary>
  /// <remarks>
  /// If Factorio is running headless, this function will do nothing.
  /// </remarks>
  /// <param name="player">Lua name: player</param>
  /// <param name="byPlayer">Lua name: by_player</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="resolution">Lua name: resolution</param>
  /// <param name="zoom">Lua name: zoom</param>
  /// <param name="path">Lua name: path</param>
  /// <param name="showGui">Lua name: show_gui</param>
  /// <param name="showEntityInfo">Lua name: show_entity_info</param>
  /// <param name="showCursorBuildingPreview">Lua name: show_cursor_building_preview</param>
  /// <param name="antiAlias">Lua name: anti_alias</param>
  /// <param name="quality">Lua name: quality</param>
  /// <param name="allowInReplay">Lua name: allow_in_replay</param>
  /// <param name="daytime">Lua name: daytime</param>
  /// <param name="waterTick">Lua name: water_tick</param>
  /// <param name="forceRender">Lua name: force_render</param>
  [FactorioRconMethod("take_screenshot")]
  public abstract void TakeScreenshot(PlayerIdentification? player = null, PlayerIdentification? byPlayer = null, SurfaceIdentification? surface = null, MapPosition? position = null, TilePosition? resolution = null, double? zoom = null, string? path = null, bool? showGui = null, bool? showEntityInfo = null, bool? showCursorBuildingPreview = null, bool? antiAlias = null, int? quality = null, bool? allowInReplay = null, double? daytime = null, uint? waterTick = null, bool? forceRender = null);

  /// <summary>
  /// Forces the screenshot saving system to wait until all queued screenshots have been written to disk.
  /// </summary>
  [FactorioRconMethod("set_wait_for_screenshots_to_finish")]
  public abstract void SetWaitForScreenshotsToFinish();

  /// <summary>
  /// Take a screenshot of the technology screen and save it to the `script-output` folder, located in the game's [user data directory](https://wiki.factorio.com/User_data_directory). The name of the image file can be specified via the `path` parameter.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  /// <param name="path">Lua name: path</param>
  /// <param name="byPlayer">Lua name: by_player</param>
  /// <param name="selectedTechnology">Lua name: selected_technology</param>
  /// <param name="skipDisabled">Lua name: skip_disabled</param>
  /// <param name="quality">Lua name: quality</param>
  [FactorioRconMethod("take_technology_screenshot")]
  public abstract void TakeTechnologyScreenshot(ForceIdentification? force = null, string? path = null, PlayerIdentification? byPlayer = null, TechnologyIdentification? selectedTechnology = null, bool? skipDisabled = null, int? quality = null);

  /// <summary>
  /// Convert a table to a JSON string
  /// </summary>
  /// <param name="data">Lua name: data</param>
  [FactorioRconMethod("table_to_json")]
  public abstract string TableToJson(LuaTable data);

  /// <summary>
  /// Convert a JSON string to a table.
  /// </summary>
  /// <param name="json">Lua name: json</param>
  [FactorioRconMethod("json_to_table")]
  public abstract AnyBasic? JsonToTable(string json);

  /// <summary>
  /// Write a file to the `script-output` folder, located in the game's [user data directory](https://wiki.factorio.com/User_data_directory). The name and file extension of the file can be specified via the `filename` parameter.
  /// </summary>
  /// <param name="filename">Lua name: filename</param>
  /// <param name="data">Lua name: data</param>
  /// <param name="append">Lua name: append</param>
  /// <param name="forPlayer">Lua name: for_player</param>
  [FactorioRconMethod("write_file")]
  public abstract void WriteFile(string filename, LocalisedString data, bool? append = null, uint? forPlayer = null);

  /// <summary>
  /// Remove a file or directory in the `script-output` folder, located in the game's <see cref="LuaGameScript.WriteFile" />.
  /// </summary>
  /// <param name="path">Lua name: path</param>
  [FactorioRconMethod("remove_path")]
  public abstract void RemovePath(string path);

  /// <summary>
  /// Remove players who are currently not connected from the map.
  /// </summary>
  /// <param name="players">Lua name: players</param>
  [FactorioRconMethod("remove_offline_players")]
  public abstract void RemoveOfflinePlayers(List<PlayerIdentification>? players = null);

  /// <summary>
  /// Force a CRC check. Tells all peers to calculate their current CRC, which are then compared to each other. If a mismatch is detected, the game desyncs and some peers are forced to reconnect.
  /// </summary>
  [FactorioRconMethod("force_crc")]
  public abstract void ForceCrc();

  /// <summary>
  /// Create a new force.
  /// </summary>
  /// <remarks>
  /// The game currently supports a maximum of 64 forces, including the three built-in forces. This means that a maximum of 61 new forces may be created.
  /// Force names must be unique.
  /// </remarks>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("create_force")]
  public abstract LuaForce CreateForce(string force);

  /// <summary>
  /// Marks two forces to be merged together. All players and entities in the source force will be reassigned to the target force. The source force will then be destroyed. Importantly, this does not merge technologies or bonuses, which are instead retained from the target force.
  /// </summary>
  /// <remarks>
  /// The three built-in forces (player, enemy and neutral) can't be destroyed, meaning they can't be used as the source argument to this function.
  /// The source force is not removed until the end of the current tick, or if called during the <see cref="OnForcesMerged" /> event, the end of the next tick.
  /// </remarks>
  /// <param name="source">Lua name: source</param>
  /// <param name="destination">Lua name: destination</param>
  [FactorioRconMethod("merge_forces")]
  public abstract void MergeForces(ForceIdentification source, ForceIdentification destination);

  /// <summary>
  /// Create a new surface.
  /// </summary>
  /// <remarks>
  /// The game currently supports a maximum of 4 294 967 295 surfaces, including the default surface.
  /// Surface names must be unique.
  /// </remarks>
  /// <param name="name">Lua name: name</param>
  /// <param name="settings">Lua name: settings</param>
  [FactorioRconMethod("create_surface")]
  public abstract LuaSurface CreateSurface(string name, MapGenSettings? settings = null);

  /// <summary>
  /// Instruct the server to save the map. Only actually saves when in multiplayer.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("server_save")]
  public abstract void ServerSave(string? name = null);

  /// <summary>
  /// Instruct the game to perform an auto-save.
  /// </summary>
  /// <remarks>
  /// Only the server will save in multiplayer. In single player a standard auto-save is triggered.
  /// </remarks>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("auto_save")]
  public abstract void AutoSave(string? name = null);

  /// <summary>
  /// Deletes the given surface and all entities on it.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("delete_surface")]
  public abstract void DeleteSurface(SurfaceIdentification surface);

  /// <summary>
  /// Disables replay saving for the current save file. Once done there's no way to re-enable replay saving for the save file without loading an old save.
  /// </summary>
  [FactorioRconMethod("disable_replay")]
  public abstract void DisableReplay();

  /// <summary>
  /// Disables tutorial triggers, that unlock new tutorials and show notices about unlocked tutorials.
  /// </summary>
  [FactorioRconMethod("disable_tutorial_triggers")]
  public abstract void DisableTutorialTriggers();

  /// <summary>
  /// Converts the given direction into the string version of the direction.
  /// </summary>
  /// <param name="direction">Lua name: direction</param>
  [FactorioRconMethod("direction_to_string")]
  public abstract void DirectionToString(DirectionEnum direction);

  /// <summary>
  /// Print text to the chat console all players.
  /// </summary>
  /// <remarks>
  /// By default, messages that are identical to a message sent in the last 60 ticks are not printed again.
  /// </remarks>
  /// <param name="message">Lua name: message</param>
  /// <param name="printSettings">Lua name: print_settings</param>
  [FactorioRconMethod("print")]
  public abstract void Print(LocalisedString message, Union419671075? printSettings = null);

  /// <summary>
  /// Creates a deterministic standalone random generator with the given seed or if a seed is not provided the initial map seed is used.
  /// </summary>
  /// <remarks>
  /// *Make sure* you actually want to use this over math.random(...) as this provides entirely different functionality over math.random(...).
  /// </remarks>
  /// <param name="seed">Lua name: seed</param>
  [FactorioRconMethod("create_random_generator")]
  public abstract LuaRandomGenerator CreateRandomGenerator(uint? seed = null);

  /// <summary>
  /// Goes over all items, entities, tiles, recipes, technologies among other things and logs if the locale is incorrect.
  /// </summary>
  /// <remarks>
  /// Also prints true/false if called from the console.
  /// </remarks>
  [FactorioRconMethod("check_prototype_translations")]
  public abstract void CheckPrototypeTranslations();

  /// <summary>
  /// Play a sound for every player in the game.
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
  /// Checks if the given SoundPath is valid.
  /// </summary>
  /// <param name="soundPath">Lua name: sound_path</param>
  [FactorioRconMethod("is_valid_sound_path")]
  public abstract bool IsValidSoundPath(SoundPath soundPath);

  /// <summary>
  /// Checks if the given SpritePath is valid and contains a loaded sprite. The existence of the image is not checked for paths of type `file`.
  /// </summary>
  /// <param name="spritePath">Lua name: sprite_path</param>
  [FactorioRconMethod("is_valid_sprite_path")]
  public abstract bool IsValidSpritePath(SpritePath spritePath);

  /// <summary>
  /// Kicks the given player from this multiplayer game. Does nothing if this is a single player game or if the player running this isn't an admin.
  /// </summary>
  /// <param name="player">Lua name: player</param>
  /// <param name="reason">Lua name: reason</param>
  [FactorioRconMethod("kick_player")]
  public abstract void KickPlayer(PlayerIdentification player, string? reason = null);

  /// <summary>
  /// Bans the given player from this multiplayer game. Does nothing if this is a single player game of if the player running this isn't an admin.
  /// </summary>
  /// <param name="player">Lua name: player</param>
  /// <param name="reason">Lua name: reason</param>
  [FactorioRconMethod("ban_player")]
  public abstract void BanPlayer(PlayerIdentification player, string? reason = null);

  /// <summary>
  /// Unbans the given player from this multiplayer game. Does nothing if this is a single player game of if the player running this isn't an admin.
  /// </summary>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("unban_player")]
  public abstract void UnbanPlayer(PlayerIdentification player);

  /// <summary>
  /// Purges the given players messages from the game. Does nothing if the player running this isn't an admin.
  /// </summary>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("purge_player")]
  public abstract void PurgePlayer(PlayerIdentification player);

  /// <summary>
  /// Mutes the given player. Does nothing if the player running this isn't an admin.
  /// </summary>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("mute_player")]
  public abstract void MutePlayer(PlayerIdentification player);

  /// <summary>
  /// Unmutes the given player. Does nothing if the player running this isn't an admin.
  /// </summary>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("unmute_player")]
  public abstract void UnmutePlayer(PlayerIdentification player);

  /// <summary>
  /// Counts how many distinct groups of pipes exist in the world.
  /// </summary>
  [FactorioRconMethod("count_pipe_groups")]
  public abstract void CountPipeGroups();

  /// <summary>
  /// Whether the save is loaded as a multiplayer map.
  /// </summary>
  [FactorioRconMethod("is_multiplayer")]
  public abstract bool IsMultiplayer();

  /// <summary>
  /// Gets the number of entities that are active (updated each tick).
  /// </summary>
  /// <remarks>
  /// This is very expensive to determine.
  /// </remarks>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("get_active_entities_count")]
  public abstract uint GetActiveEntitiesCount(SurfaceIdentification? surface = null);

  /// <summary>
  /// Gets the map exchange string for the map generation settings that were used to create this map.
  /// </summary>
  [FactorioRconMethod("get_map_exchange_string")]
  public abstract string GetMapExchangeString();

  /// <summary>
  /// Convert a map exchange string to map gen settings and map settings.
  /// </summary>
  /// <param name="mapExchangeString">Lua name: map_exchange_string</param>
  [FactorioRconMethod("parse_map_exchange_string")]
  public abstract MapExchangeStringData ParseMapExchangeString(string mapExchangeString);

  /// <summary>
  /// Gets train stops matching the given filters.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("get_train_stops")]
  public abstract List<LuaEntity> GetTrainStops(Union1369834877? name = null, SurfaceIdentification? surface = null, ForceIdentification? force = null);

  /// <summary>
  /// Gets the given player or returns `nil` if no player is found.
  /// </summary>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("get_player")]
  public abstract LuaPlayer? GetPlayer(Union244833755 player);

  /// <summary>
  /// Gets the given surface or returns `nil` if no surface is found.
  /// </summary>
  /// <remarks>
  /// This is a shortcut for game.surfaces[...]
  /// </remarks>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("get_surface")]
  public abstract LuaSurface? GetSurface(Union244833755 surface);

  /// <summary>
  /// Creates a <see cref="LuaProfiler" />, which is used for measuring script performance.
  /// </summary>
  /// <remarks>
  /// LuaProfiler cannot be serialized.
  /// </remarks>
  /// <param name="stopped">Lua name: stopped</param>
  [FactorioRconMethod("create_profiler")]
  public abstract LuaProfiler CreateProfiler(bool? stopped = null);

  /// <summary>
  /// Evaluate an expression, substituting variables as provided. For details on the formula, see [TechnologyPrototype::unit](prototype:TechnologyPrototype::unit).
  /// </summary>
  /// <param name="expression">Lua name: expression</param>
  /// <param name="variables">Lua name: variables</param>
  [FactorioRconMethod("evaluate_expression")]
  public abstract double EvaluateExpression(string expression, Dictionary<string, double>? variables = null);

  /// <summary>
  /// Returns a dictionary of all LuaEntityPrototypes that fit the given filters. The prototypes are indexed by `name`.
  /// </summary>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("get_filtered_entity_prototypes")]
  public abstract LuaCustomTable<string, LuaEntityPrototype> GetFilteredEntityPrototypes(List<EntityPrototypeFilter> filters);

  /// <summary>
  /// Returns a dictionary of all LuaItemPrototypes that fit the given filters. The prototypes are indexed by `name`.
  /// </summary>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("get_filtered_item_prototypes")]
  public abstract LuaCustomTable<string, LuaItemPrototype> GetFilteredItemPrototypes(List<ItemPrototypeFilter> filters);

  /// <summary>
  /// Returns a dictionary of all LuaEquipmentPrototypes that fit the given filters. The prototypes are indexed by `name`.
  /// </summary>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("get_filtered_equipment_prototypes")]
  public abstract LuaCustomTable<string, LuaEquipmentPrototype> GetFilteredEquipmentPrototypes(List<EquipmentPrototypeFilter> filters);

  /// <summary>
  /// Returns a dictionary of all LuaModSettingPrototypes that fit the given filters. The prototypes are indexed by `name`.
  /// </summary>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("get_filtered_mod_setting_prototypes")]
  public abstract LuaCustomTable<string, LuaModSettingPrototype> GetFilteredModSettingPrototypes(List<ModSettingPrototypeFilter> filters);

  /// <summary>
  /// Returns a dictionary of all LuaAchievementPrototypes that fit the given filters. The prototypes are indexed by `name`.
  /// </summary>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("get_filtered_achievement_prototypes")]
  public abstract LuaCustomTable<string, LuaAchievementPrototype> GetFilteredAchievementPrototypes(List<AchievementPrototypeFilter> filters);

  /// <summary>
  /// Returns a dictionary of all LuaTilePrototypes that fit the given filters. The prototypes are indexed by `name`.
  /// </summary>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("get_filtered_tile_prototypes")]
  public abstract LuaCustomTable<string, LuaTilePrototype> GetFilteredTilePrototypes(List<TilePrototypeFilter> filters);

  /// <summary>
  /// Returns a dictionary of all LuaDecorativePrototypes that fit the given filters. The prototypes are indexed by `name`.
  /// </summary>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("get_filtered_decorative_prototypes")]
  public abstract LuaCustomTable<string, LuaDecorativePrototype> GetFilteredDecorativePrototypes(List<DecorativePrototypeFilter> filters);

  /// <summary>
  /// Returns a dictionary of all LuaFluidPrototypes that fit the given filters. The prototypes are indexed by `name`.
  /// </summary>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("get_filtered_fluid_prototypes")]
  public abstract LuaCustomTable<string, LuaFluidPrototype> GetFilteredFluidPrototypes(List<FluidPrototypeFilter> filters);

  /// <summary>
  /// Returns a dictionary of all LuaRecipePrototypes that fit the given filters. The prototypes are indexed by `name`.
  /// </summary>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("get_filtered_recipe_prototypes")]
  public abstract LuaCustomTable<string, LuaRecipePrototype> GetFilteredRecipePrototypes(List<RecipePrototypeFilter> filters);

  /// <summary>
  /// Returns a dictionary of all LuaTechnologyPrototypes that fit the given filters. The prototypes are indexed by `name`.
  /// </summary>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("get_filtered_technology_prototypes")]
  public abstract LuaCustomTable<string, LuaTechnologyPrototype> GetFilteredTechnologyPrototypes(List<TechnologyPrototypeFilter> filters);

  /// <summary>
  /// Creates an inventory that is not owned by any game object. It can be resized later with <see cref="LuaInventory.Resize" />.
  /// </summary>
  /// <remarks>
  /// Make sure to destroy it when you are done with it using <see cref="LuaInventory.Destroy" />.
  /// </remarks>
  /// <param name="size">Lua name: size</param>
  [FactorioRconMethod("create_inventory")]
  public abstract LuaInventory CreateInventory(ushort size);

  /// <summary>
  /// Gets the inventories created through <see cref="LuaGameScript.CreateInventory" />
  /// </summary>
  /// <remarks>
  /// Inventories created through console commands will be owned by `"core"`.
  /// </remarks>
  /// <param name="mod">Lua name: mod</param>
  [FactorioRconMethod("get_script_inventories")]
  public abstract Dictionary<string, List<LuaInventory>> GetScriptInventories(string? mod = null);

  /// <summary>
  /// Resets the amount of time played for this map.
  /// </summary>
  [FactorioRconMethod("reset_time_played")]
  public abstract void ResetTimePlayed();

  /// <summary>
  /// Deflates and base64 encodes the given string.
  /// </summary>
  /// <param name="@string">Lua name: string</param>
  [FactorioRconMethod("encode_string")]
  public abstract string? EncodeString(string @string);

  /// <summary>
  /// Base64 decodes and inflates the given string.
  /// </summary>
  /// <param name="@string">Lua name: string</param>
  [FactorioRconMethod("decode_string")]
  public abstract string? DecodeString(string @string);

  /// <summary>
  /// Searches for a train with given ID.
  /// </summary>
  /// <param name="trainId">Lua name: train_id</param>
  [FactorioRconMethod("get_train_by_id")]
  public abstract LuaTrain? GetTrainById(uint trainId);

  /// <summary>
  /// Direct access to Trains Pathfinder. Allows to search rail paths or querying which stops are accessible
  /// </summary>
  /// <param name="goals">Lua name: goals</param>
  /// <param name="inChainSignalSection">Lua name: in_chain_signal_section</param>
  /// <param name="train">Lua name: train</param>
  /// <param name="type">Lua name: type</param>
  /// <param name="returnPath">Lua name: return_path</param>
  /// <param name="fromFront">Lua name: from_front</param>
  /// <param name="allowPathWithinSegmentFront">Lua name: allow_path_within_segment_front</param>
  /// <param name="fromBack">Lua name: from_back</param>
  /// <param name="allowPathWithinSegmentBack">Lua name: allow_path_within_segment_back</param>
  /// <param name="searchDirection">Lua name: search_direction</param>
  /// <param name="stepsLimit">Lua name: steps_limit</param>
  [FactorioRconMethod("request_train_path")]
  public abstract Union949212638 RequestTrainPath(List<Union459236940> goals, bool? inChainSignalSection = null, LuaTrain? train = null, TrainPathRequestType? type = null, bool? returnPath = null, RailEnd? fromFront = null, bool? allowPathWithinSegmentFront = null, RailEnd? fromBack = null, bool? allowPathWithinSegmentBack = null, Literals1800004990? searchDirection = null, uint? stepsLimit = null);

}

