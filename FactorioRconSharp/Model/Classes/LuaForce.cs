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
/// `LuaForce` encapsulates data local to each "force" or "faction" of the game. Default forces are player, enemy and neutral. Players and mods can create additional forces (up to 64 total).
/// </summary>
[FactorioRconClass("LuaForce")]
public abstract class LuaForce: LuaObject
{
  /// <summary>
  /// Name of the force.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// Technologies owned by this force, indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("technologies")]
  public LuaCustomTable<string, LuaTechnology> Technologies { get; private set; }

  /// <summary>
  /// Recipes available to this force, indexed by `name`.
  /// </summary>
  [FactorioRconAttribute("recipes")]
  public LuaCustomTable<string, LuaRecipe> Recipes { get; private set; }

  /// <summary>
  /// Multiplier of the manual mining speed. Default value is `0`. The actual mining speed will be multiplied by `1 + manual_mining_speed_modifier`.
  /// </summary>
  [FactorioRconAttribute("manual_mining_speed_modifier")]
  public double ManualMiningSpeedModifier { get; set; }

  /// <summary>
  /// Multiplier of the manual crafting speed. Default value is `0`. The actual crafting speed will be multiplied by `1 + manual_crafting_speed_modifier`.
  /// </summary>
  [FactorioRconAttribute("manual_crafting_speed_modifier")]
  public double ManualCraftingSpeedModifier { get; set; }

  [FactorioRconAttribute("laboratory_speed_modifier")]
  public double LaboratorySpeedModifier { get; set; }

  [FactorioRconAttribute("laboratory_productivity_bonus")]
  public double LaboratoryProductivityBonus { get; set; }

  [FactorioRconAttribute("worker_robots_speed_modifier")]
  public double WorkerRobotsSpeedModifier { get; set; }

  [FactorioRconAttribute("worker_robots_battery_modifier")]
  public double WorkerRobotsBatteryModifier { get; set; }

  [FactorioRconAttribute("worker_robots_storage_bonus")]
  public double WorkerRobotsStorageBonus { get; set; }

  /// <summary>
  /// The currently ongoing technology research, if any.
  /// </summary>
  [FactorioRconAttribute("current_research")]
  public LuaTechnology CurrentResearch { get; private set; }

  /// <summary>
  /// Progress of current research, as a number in range [0, 1].
  /// </summary>
  [FactorioRconAttribute("research_progress")]
  public double ResearchProgress { get; set; }

  /// <summary>
  /// The previous research, if any.
  /// </summary>
  [FactorioRconAttribute("previous_research")]
  public LuaTechnology PreviousResearch { get; set; }

  /// <summary>
  /// The inserter stack size bonus for non stack inserters
  /// </summary>
  [FactorioRconAttribute("inserter_stack_size_bonus")]
  public double InserterStackSizeBonus { get; set; }

  /// <summary>
  /// Number of items that can be transferred by stack inserters. When writing to this value, it must be >= 0 and <= 254.
  /// </summary>
  [FactorioRconAttribute("stack_inserter_capacity_bonus")]
  public uint StackInserterCapacityBonus { get; set; }

  /// <summary>
  /// Number of character trash slots.
  /// </summary>
  [FactorioRconAttribute("character_trash_slot_count")]
  public double CharacterTrashSlotCount { get; set; }

  /// <summary>
  /// Maximum number of follower robots.
  /// </summary>
  [FactorioRconAttribute("maximum_following_robot_count")]
  public uint MaximumFollowingRobotCount { get; set; }

  /// <summary>
  /// Additional lifetime for following robots.
  /// </summary>
  [FactorioRconAttribute("following_robots_lifetime_modifier")]
  public double FollowingRobotsLifetimeModifier { get; set; }

  /// <summary>
  /// The time, in ticks, before a placed ghost disappears.
  /// </summary>
  [FactorioRconAttribute("ghost_time_to_live")]
  public uint GhostTimeToLive { get; set; }

  /// <summary>
  /// Players belonging to this force.
  /// </summary>
  [FactorioRconAttribute("players")]
  public List<LuaPlayer> Players { get; private set; }

  /// <summary>
  /// Enables some higher-level AI behaviour for this force. When set to `true`, biters belonging to this force will automatically expand into new territories, build new spawners, and form unit groups. By default, this value is `true` for the enemy force and `false` for all others.
  /// </summary>
  [FactorioRconAttribute("ai_controllable")]
  public bool AiControllable { get; set; }

  /// <summary>
  /// List of logistic networks, grouped by surface.
  /// </summary>
  [FactorioRconAttribute("logistic_networks")]
  public Dictionary<string, List<LuaLogisticNetwork>> LogisticNetworks { get; private set; }

  /// <summary>
  /// The item production statistics for this force.
  /// </summary>
  [FactorioRconAttribute("item_production_statistics")]
  public LuaFlowStatistics ItemProductionStatistics { get; private set; }

  /// <summary>
  /// The fluid production statistics for this force.
  /// </summary>
  [FactorioRconAttribute("fluid_production_statistics")]
  public LuaFlowStatistics FluidProductionStatistics { get; private set; }

  /// <summary>
  /// The kill counter statistics for this force.
  /// </summary>
  [FactorioRconAttribute("kill_count_statistics")]
  public LuaFlowStatistics KillCountStatistics { get; private set; }

  /// <summary>
  /// The entity build statistics for this force (built and mined)
  /// </summary>
  [FactorioRconAttribute("entity_build_count_statistics")]
  public LuaFlowStatistics EntityBuildCountStatistics { get; private set; }

  /// <summary>
  /// Modifies the running speed of all characters in this force by the given value as a percentage. Setting the running modifier to `0.5` makes the character run 50% faster. The minimum value of `-1` reduces the movement speed by 100%, resulting in a speed of `0`.
  /// </summary>
  [FactorioRconAttribute("character_running_speed_modifier")]
  public double CharacterRunningSpeedModifier { get; set; }

  [FactorioRconAttribute("artillery_range_modifier")]
  public double ArtilleryRangeModifier { get; set; }

  [FactorioRconAttribute("character_build_distance_bonus")]
  public uint CharacterBuildDistanceBonus { get; set; }

  [FactorioRconAttribute("character_item_drop_distance_bonus")]
  public uint CharacterItemDropDistanceBonus { get; set; }

  [FactorioRconAttribute("character_reach_distance_bonus")]
  public uint CharacterReachDistanceBonus { get; set; }

  [FactorioRconAttribute("character_resource_reach_distance_bonus")]
  public double CharacterResourceReachDistanceBonus { get; set; }

  [FactorioRconAttribute("character_item_pickup_distance_bonus")]
  public double CharacterItemPickupDistanceBonus { get; set; }

  [FactorioRconAttribute("character_loot_pickup_distance_bonus")]
  public double CharacterLootPickupDistanceBonus { get; set; }

  /// <summary>
  /// the number of additional inventory slots the character main inventory has.
  /// </summary>
  [FactorioRconAttribute("character_inventory_slots_bonus")]
  public uint CharacterInventorySlotsBonus { get; set; }

  /// <summary>
  /// The time, in ticks, before a deconstruction order is removed.
  /// </summary>
  [FactorioRconAttribute("deconstruction_time_to_live")]
  public uint DeconstructionTimeToLive { get; set; }

  [FactorioRconAttribute("character_health_bonus")]
  public double CharacterHealthBonus { get; set; }

  [FactorioRconAttribute("max_successful_attempts_per_tick_per_construction_queue")]
  public uint MaxSuccessfulAttemptsPerTickPerConstructionQueue { get; set; }

  [FactorioRconAttribute("max_failed_attempts_per_tick_per_construction_queue")]
  public uint MaxFailedAttemptsPerTickPerConstructionQueue { get; set; }

  /// <summary>
  /// Ability to use zoom-to-world on map.
  /// </summary>
  [FactorioRconAttribute("zoom_to_world_enabled")]
  public bool ZoomToWorldEnabled { get; set; }

  /// <summary>
  /// Ability to build ghosts through blueprint or direct ghost placement, or "mine" ghosts when using zoom-to-world.
  /// </summary>
  [FactorioRconAttribute("zoom_to_world_ghost_building_enabled")]
  public bool ZoomToWorldGhostBuildingEnabled { get; set; }

  /// <summary>
  /// Ability to create new blueprints using empty blueprint item when using zoom-to-world.
  /// </summary>
  [FactorioRconAttribute("zoom_to_world_blueprint_enabled")]
  public bool ZoomToWorldBlueprintEnabled { get; set; }

  /// <summary>
  /// Ability to use deconstruction planner when using zoom-to-world.
  /// </summary>
  [FactorioRconAttribute("zoom_to_world_deconstruction_planner_enabled")]
  public bool ZoomToWorldDeconstructionPlannerEnabled { get; set; }

  /// <summary>
  /// Ability to use custom selection tools when using zoom-to-world.
  /// </summary>
  [FactorioRconAttribute("zoom_to_world_selection_tool_enabled")]
  public bool ZoomToWorldSelectionToolEnabled { get; set; }

  /// <summary>
  /// `true` if character requester logistics is enabled.
  /// </summary>
  [FactorioRconAttribute("character_logistic_requests")]
  public bool CharacterLogisticRequests { get; set; }

  /// <summary>
  /// The number of rockets launched.
  /// </summary>
  [FactorioRconAttribute("rockets_launched")]
  public uint RocketsLaunched { get; set; }

  /// <summary>
  /// All of the items that have been launched in rockets. The attribute is a dictionary mapping the item prototype names to the launched amounts.
  /// </summary>
  [FactorioRconAttribute("items_launched")]
  public Dictionary<string, uint> ItemsLaunched { get; private set; }

  /// <summary>
  /// The connected players belonging to this force.
  /// 
  /// This is primarily useful when you want to do some action against all online players of this force.
  /// </summary>
  [FactorioRconAttribute("connected_players")]
  public List<LuaPlayer> ConnectedPlayers { get; private set; }

  [FactorioRconAttribute("mining_drill_productivity_bonus")]
  public double MiningDrillProductivityBonus { get; set; }

  [FactorioRconAttribute("train_braking_force_bonus")]
  public double TrainBrakingForceBonus { get; set; }

  /// <summary>
  /// Evolution factor of this force.
  /// </summary>
  [FactorioRconAttribute("evolution_factor")]
  public double EvolutionFactor { get; set; }

  [FactorioRconAttribute("evolution_factor_by_pollution")]
  public double EvolutionFactorByPollution { get; set; }

  [FactorioRconAttribute("evolution_factor_by_time")]
  public double EvolutionFactorByTime { get; set; }

  [FactorioRconAttribute("evolution_factor_by_killing_spawners")]
  public double EvolutionFactorByKillingSpawners { get; set; }

  /// <summary>
  /// If friendly fire is enabled for this force.
  /// </summary>
  [FactorioRconAttribute("friendly_fire")]
  public bool FriendlyFire { get; set; }

  /// <summary>
  /// If sharing chart data is enabled for this force.
  /// </summary>
  [FactorioRconAttribute("share_chart")]
  public bool ShareChart { get; set; }

  /// <summary>
  /// Whether the research queue is available for this force.
  /// </summary>
  [FactorioRconAttribute("research_queue_enabled")]
  public bool ResearchQueueEnabled { get; set; }

  /// <summary>
  /// This force's index in <see cref="OnForcesMerged)(Ie.Deleted" />. Indexes of merged forces can be reused.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; private set; }

  /// <summary>
  /// The research queue of this force. The first technology in the array is the currently active one. Reading this attribute gives an array of <see cref="LuaTechnology" />.
  /// 
  /// To write to this, the entire table must be written. Providing an empty table or `nil` will empty the research queue and cancel the current research. Writing to this when the research queue is disabled will simply set the last research in the table as the current research.
  /// </summary>
  [FactorioRconAttribute("research_queue")]
  public List<TechnologyIdentification> ResearchQueue { get; set; }

  /// <summary>
  /// Whether research is enabled for this force, see <see cref="LuaForce.DisableResearch" />
  /// </summary>
  [FactorioRconAttribute("research_enabled")]
  public bool ResearchEnabled { get; private set; }

  /// <summary>
  /// Custom color for this force. If specified, will take priority over other sources of the force color. Writing nil clears custom color. Will return nil if it was not specified or if was set to {0,0,0,0}
  /// </summary>
  [FactorioRconAttribute("custom_color")]
  public Color CustomColor { get; set; }

  /// <summary>
  /// Effective color of this force.
  /// </summary>
  [FactorioRconAttribute("color")]
  public Color Color { get; private set; }

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
  /// Count entities of given type.
  /// </summary>
  /// <remarks>
  /// This function has O(1) time complexity as entity counts are kept and maintained in the game engine.
  /// </remarks>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("get_entity_count")]
  public abstract uint GetEntityCount(string name);

  /// <summary>
  /// Disable research for this force.
  /// </summary>
  [FactorioRconMethod("disable_research")]
  public abstract void DisableResearch();

  /// <summary>
  /// Enable research for this force.
  /// </summary>
  [FactorioRconMethod("enable_research")]
  public abstract void EnableResearch();

  /// <summary>
  /// Disable all recipes and technologies. Only recipes and technologies enabled explicitly will be useable from this point.
  /// </summary>
  [FactorioRconMethod("disable_all_prototypes")]
  public abstract void DisableAllPrototypes();

  /// <summary>
  /// Enables all recipes and technologies. The opposite of <see cref="LuaForce.DisableAllPrototypes" />
  /// </summary>
  [FactorioRconMethod("enable_all_prototypes")]
  public abstract void EnableAllPrototypes();

  /// <summary>
  /// Load the original version of all recipes from the prototypes.
  /// </summary>
  [FactorioRconMethod("reset_recipes")]
  public abstract void ResetRecipes();

  /// <summary>
  /// Unlock all recipes.
  /// </summary>
  [FactorioRconMethod("enable_all_recipes")]
  public abstract void EnableAllRecipes();

  /// <summary>
  /// Unlock all technologies.
  /// </summary>
  [FactorioRconMethod("enable_all_technologies")]
  public abstract void EnableAllTechnologies();

  /// <summary>
  /// Research all technologies.
  /// </summary>
  /// <param name="includeDisabledPrototypes">Lua name: include_disabled_prototypes</param>
  [FactorioRconMethod("research_all_technologies")]
  public abstract void ResearchAllTechnologies(bool? includeDisabledPrototypes = null);

  /// <summary>
  /// Load the original versions of technologies from prototypes. Preserves research state of technologies.
  /// </summary>
  [FactorioRconMethod("reset_technologies")]
  public abstract void ResetTechnologies();

  /// <summary>
  /// Reset everything. All technologies are set to not researched, all modifiers are set to default values.
  /// </summary>
  [FactorioRconMethod("reset")]
  public abstract void Reset();

  /// <summary>
  /// Reapplies all possible research effects, including unlocked recipes. Any custom changes are lost. Preserves research state of technologies.
  /// </summary>
  [FactorioRconMethod("reset_technology_effects")]
  public abstract void ResetTechnologyEffects();

  /// <summary>
  /// Chart a portion of the map. The chart for the given area is refreshed; it creates chart for any parts of the given area that haven't been charted yet.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="area">Lua name: area</param>
  [FactorioRconMethod("chart")]
  public abstract void Chart(SurfaceIdentification surface, BoundingBox area);

  /// <summary>
  /// Erases chart data for this force.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("clear_chart")]
  public abstract void ClearChart(SurfaceIdentification? surface = null);

  /// <summary>
  /// Force a rechart of the whole chart.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("rechart")]
  public abstract void Rechart(SurfaceIdentification? surface = null);

  /// <summary>
  /// Chart all generated chunks.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("chart_all")]
  public abstract void ChartAll(SurfaceIdentification? surface = null);

  /// <summary>
  /// Has a chunk been charted?
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("is_chunk_charted")]
  public abstract bool IsChunkCharted(SurfaceIdentification surface, ChunkPosition position);

  /// <summary>
  /// Is the given chunk currently charted and visible (not covered by fog of war) on the map.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("is_chunk_visible")]
  public abstract bool IsChunkVisible(SurfaceIdentification surface, ChunkPosition position);

  /// <summary>
  /// Has a chunk been requested for charting?
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("is_chunk_requested_for_charting")]
  public abstract bool IsChunkRequestedForCharting(SurfaceIdentification surface, ChunkPosition position);

  /// <summary>
  /// Cancels pending chart requests for the given surface or all surfaces.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("cancel_charting")]
  public abstract void CancelCharting(SurfaceIdentification? surface = null);

  /// <param name="ammo">Lua name: ammo</param>
  [FactorioRconMethod("get_ammo_damage_modifier")]
  public abstract double GetAmmoDamageModifier(string ammo);

  /// <param name="ammo">Lua name: ammo</param>
  /// <param name="modifier">Lua name: modifier</param>
  [FactorioRconMethod("set_ammo_damage_modifier")]
  public abstract void SetAmmoDamageModifier(string ammo, double modifier);

  /// <param name="ammo">Lua name: ammo</param>
  [FactorioRconMethod("get_gun_speed_modifier")]
  public abstract double GetGunSpeedModifier(string ammo);

  /// <param name="ammo">Lua name: ammo</param>
  /// <param name="modifier">Lua name: modifier</param>
  [FactorioRconMethod("set_gun_speed_modifier")]
  public abstract void SetGunSpeedModifier(string ammo, double modifier);

  /// <param name="turret">Lua name: turret</param>
  [FactorioRconMethod("get_turret_attack_modifier")]
  public abstract double GetTurretAttackModifier(string turret);

  /// <param name="turret">Lua name: turret</param>
  /// <param name="modifier">Lua name: modifier</param>
  [FactorioRconMethod("set_turret_attack_modifier")]
  public abstract void SetTurretAttackModifier(string turret, double modifier);

  /// <summary>
  /// Add `other` force to this force's cease fire list. Forces on the cease fire list won't be targeted for attack.
  /// </summary>
  /// <param name="other">Lua name: other</param>
  /// <param name="ceaseFire">Lua name: cease_fire</param>
  [FactorioRconMethod("set_cease_fire")]
  public abstract void SetCeaseFire(ForceIdentification other, bool ceaseFire);

  /// <summary>
  /// Is `other` force in this force's cease fire list?
  /// </summary>
  /// <param name="other">Lua name: other</param>
  [FactorioRconMethod("get_cease_fire")]
  public abstract bool GetCeaseFire(ForceIdentification other);

  /// <summary>
  /// Add `other` force to this force's friends list. Friends have unrestricted access to buildings and turrets won't fire at them.
  /// </summary>
  /// <param name="other">Lua name: other</param>
  /// <param name="friend">Lua name: friend</param>
  [FactorioRconMethod("set_friend")]
  public abstract void SetFriend(ForceIdentification other, bool friend);

  /// <summary>
  /// Is `other` force in this force's friends list.
  /// </summary>
  /// <param name="other">Lua name: other</param>
  [FactorioRconMethod("get_friend")]
  public abstract bool GetFriend(ForceIdentification other);

  /// <summary>
  /// Is pathfinder busy? When the pathfinder is busy, it won't accept any more pathfinding requests.
  /// </summary>
  [FactorioRconMethod("is_pathfinder_busy")]
  public abstract bool IsPathfinderBusy();

  /// <summary>
  /// Kill all units and flush the pathfinder.
  /// </summary>
  [FactorioRconMethod("kill_all_units")]
  public abstract void KillAllUnits();

  /// <param name="position">Lua name: position</param>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("find_logistic_network_by_position")]
  public abstract LuaLogisticNetwork? FindLogisticNetworkByPosition(MapPosition position, SurfaceIdentification surface);

  /// <param name="position">Lua name: position</param>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("set_spawn_position")]
  public abstract void SetSpawnPosition(MapPosition position, SurfaceIdentification surface);

  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("get_spawn_position")]
  public abstract MapPosition GetSpawnPosition(SurfaceIdentification surface);

  /// <param name="position">Lua name: position</param>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("unchart_chunk")]
  public abstract void UnchartChunk(ChunkPosition position, SurfaceIdentification surface);

  /// <summary>
  /// Gets the count of a given item launched in rockets.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_item_launched")]
  public abstract uint GetItemLaunched(string item);

  /// <summary>
  /// Sets the count of a given item launched in rockets.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  /// <param name="count">Lua name: count</param>
  [FactorioRconMethod("set_item_launched")]
  public abstract void SetItemLaunched(string item, uint count);

  /// <summary>
  /// Print text to the chat console of all players on this force.
  /// </summary>
  /// <remarks>
  /// By default, messages that are identical to a message sent in the last 60 ticks are not printed again.
  /// </remarks>
  /// <param name="message">Lua name: message</param>
  /// <param name="printSettings">Lua name: print_settings</param>
  [FactorioRconMethod("print")]
  public abstract void Print(LocalisedString message, Union478526905? printSettings = null);

  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("get_trains")]
  public abstract List<LuaTrain> GetTrains(SurfaceIdentification? surface = null);

  /// <summary>
  /// Adds a custom chart tag to the given surface and returns the new tag or `nil` if the given position isn't valid for a chart tag.
  /// </summary>
  /// <remarks>
  /// The chunk must be charted for a tag to be valid at that location.
  /// </remarks>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="tag">Lua name: tag</param>
  [FactorioRconMethod("add_chart_tag")]
  public abstract LuaCustomChartTag? AddChartTag(SurfaceIdentification surface, ChartTagSpec tag);

  /// <summary>
  /// Finds all custom chart tags within the given bounding box on the given surface.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="area">Lua name: area</param>
  [FactorioRconMethod("find_chart_tags")]
  public abstract List<LuaCustomChartTag> FindChartTags(SurfaceIdentification surface, BoundingBox? area = null);

  /// <summary>
  /// Gets the saved progress for the given technology or `nil` if there is no saved progress.
  /// </summary>
  /// <param name="technology">Lua name: technology</param>
  [FactorioRconMethod("get_saved_technology_progress")]
  public abstract double? GetSavedTechnologyProgress(TechnologyIdentification technology);

  /// <summary>
  /// Sets the saved progress for the given technology. The technology must not be in progress, must not be completed, and the new progress must be < 100%.
  /// </summary>
  /// <param name="technology">Lua name: technology</param>
  /// <param name="progress">Lua name: progress</param>
  [FactorioRconMethod("set_saved_technology_progress")]
  public abstract void SetSavedTechnologyProgress(TechnologyIdentification technology, double progress);

  /// <summary>
  /// Resets evolution for this force to zero.
  /// </summary>
  [FactorioRconMethod("reset_evolution")]
  public abstract void ResetEvolution();

  /// <summary>
  /// Play a sound for every player in this force.
  /// </summary>
  /// <remarks>
  /// The sound is not played if its location is not <see cref="LuaForce.Chart" /> for this force.
  /// </remarks>
  /// <param name="path">Lua name: path</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="volumeModifier">Lua name: volume_modifier</param>
  /// <param name="overrideSoundType">Lua name: override_sound_type</param>
  [FactorioRconMethod("play_sound")]
  public abstract void PlaySound(SoundPath path, MapPosition? position = null, double? volumeModifier = null, SoundType? overrideSoundType = null);

  /// <summary>
  /// Gets train stops matching the given filters.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="surface">Lua name: surface</param>
  [FactorioRconMethod("get_train_stops")]
  public abstract List<LuaEntity> GetTrainStops(Union788293329? name = null, SurfaceIdentification? surface = null);

  /// <summary>
  /// Gets if the given recipe is explicitly disabled from being hand crafted.
  /// </summary>
  /// <param name="recipe">Lua name: recipe</param>
  [FactorioRconMethod("get_hand_crafting_disabled_for_recipe")]
  public abstract bool GetHandCraftingDisabledForRecipe(Union959413196 recipe);

  /// <summary>
  /// Sets if the given recipe can be hand-crafted. This is used to explicitly disable hand crafting a recipe - it won't allow hand-crafting otherwise not hand-craftable recipes.
  /// </summary>
  /// <param name="recipe">Lua name: recipe</param>
  /// <param name="handCraftingDisabled">Lua name: hand_crafting_disabled</param>
  [FactorioRconMethod("set_hand_crafting_disabled_for_recipe")]
  public abstract void SetHandCraftingDisabledForRecipe(Union959413196 recipe, bool handCraftingDisabled);

  /// <summary>
  /// Add this technology to the back of the research queue if the queue is enabled. Otherwise, set this technology to be researched now.
  /// </summary>
  /// <param name="technology">Lua name: technology</param>
  [FactorioRconMethod("add_research")]
  public abstract bool AddResearch(TechnologyIdentification technology);

  /// <summary>
  /// Stop the research currently in progress. This will remove any dependent technologies from the research queue.
  /// </summary>
  [FactorioRconMethod("cancel_current_research")]
  public abstract void CancelCurrentResearch();

  /// <summary>
  /// Gets the linked inventory for the given prototype and link ID if it exists or `nil`.
  /// </summary>
  /// <param name="prototype">Lua name: prototype</param>
  /// <param name="linkId">Lua name: link_id</param>
  [FactorioRconMethod("get_linked_inventory")]
  public abstract LuaInventory? GetLinkedInventory(EntityPrototypeIdentification prototype, uint linkId);

  /// <summary>
  /// Is this force a friend? This differs from `get_friend` in that it is always true for neutral force. This is equivalent to checking the `friend` ForceCondition.
  /// </summary>
  /// <param name="other">Lua name: other</param>
  [FactorioRconMethod("is_friend")]
  public abstract bool IsFriend(ForceIdentification other);

  /// <summary>
  /// Is this force an enemy? This differs from `get_cease_fire` in that it is always false for neutral force. This is equivalent to checking the `enemy` ForceCondition.
  /// </summary>
  /// <param name="other">Lua name: other</param>
  [FactorioRconMethod("is_enemy")]
  public abstract bool IsEnemy(ForceIdentification other);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

