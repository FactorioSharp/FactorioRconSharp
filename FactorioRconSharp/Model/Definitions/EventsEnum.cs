#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

/// <summary>
/// See the <see cref="Events" /> for more info on what events contain and when they get raised.
/// </summary>
[FactorioRconDefinition("events")]
public enum EventsEnum
{
  [FactorioRconDefinitionValue("on_tick")]
  OnTick,

  [FactorioRconDefinitionValue("on_gui_click")]
  OnGuiClick,

  [FactorioRconDefinitionValue("on_gui_confirmed")]
  OnGuiConfirmed,

  [FactorioRconDefinitionValue("on_gui_text_changed")]
  OnGuiTextChanged,

  [FactorioRconDefinitionValue("on_gui_checked_state_changed")]
  OnGuiCheckedStateChanged,

  [FactorioRconDefinitionValue("on_entity_died")]
  OnEntityDied,

  [FactorioRconDefinitionValue("on_post_entity_died")]
  OnPostEntityDied,

  [FactorioRconDefinitionValue("on_entity_damaged")]
  OnEntityDamaged,

  [FactorioRconDefinitionValue("on_picked_up_item")]
  OnPickedUpItem,

  [FactorioRconDefinitionValue("on_built_entity")]
  OnBuiltEntity,

  [FactorioRconDefinitionValue("on_sector_scanned")]
  OnSectorScanned,

  [FactorioRconDefinitionValue("on_player_mined_item")]
  OnPlayerMinedItem,

  [FactorioRconDefinitionValue("on_pre_build")]
  OnPreBuild,

  [FactorioRconDefinitionValue("on_rocket_launched")]
  OnRocketLaunched,

  [FactorioRconDefinitionValue("on_pre_player_mined_item")]
  OnPrePlayerMinedItem,

  [FactorioRconDefinitionValue("on_chunk_generated")]
  OnChunkGenerated,

  [FactorioRconDefinitionValue("on_player_crafted_item")]
  OnPlayerCraftedItem,

  [FactorioRconDefinitionValue("on_robot_built_entity")]
  OnRobotBuiltEntity,

  [FactorioRconDefinitionValue("on_robot_pre_mined")]
  OnRobotPreMined,

  [FactorioRconDefinitionValue("on_robot_mined")]
  OnRobotMined,

  [FactorioRconDefinitionValue("on_research_started")]
  OnResearchStarted,

  [FactorioRconDefinitionValue("on_research_finished")]
  OnResearchFinished,

  [FactorioRconDefinitionValue("on_research_reversed")]
  OnResearchReversed,

  [FactorioRconDefinitionValue("on_research_cancelled")]
  OnResearchCancelled,

  [FactorioRconDefinitionValue("on_player_rotated_entity")]
  OnPlayerRotatedEntity,

  [FactorioRconDefinitionValue("on_marked_for_deconstruction")]
  OnMarkedForDeconstruction,

  [FactorioRconDefinitionValue("on_cancelled_deconstruction")]
  OnCancelledDeconstruction,

  [FactorioRconDefinitionValue("on_trigger_created_entity")]
  OnTriggerCreatedEntity,

  [FactorioRconDefinitionValue("on_trigger_fired_artillery")]
  OnTriggerFiredArtillery,

  [FactorioRconDefinitionValue("on_train_changed_state")]
  OnTrainChangedState,

  [FactorioRconDefinitionValue("on_player_created")]
  OnPlayerCreated,

  [FactorioRconDefinitionValue("on_resource_depleted")]
  OnResourceDepleted,

  [FactorioRconDefinitionValue("on_player_driving_changed_state")]
  OnPlayerDrivingChangedState,

  [FactorioRconDefinitionValue("on_force_created")]
  OnForceCreated,

  [FactorioRconDefinitionValue("on_forces_merging")]
  OnForcesMerging,

  [FactorioRconDefinitionValue("on_player_cursor_stack_changed")]
  OnPlayerCursorStackChanged,

  [FactorioRconDefinitionValue("on_pre_entity_settings_pasted")]
  OnPreEntitySettingsPasted,

  [FactorioRconDefinitionValue("on_entity_settings_pasted")]
  OnEntitySettingsPasted,

  [FactorioRconDefinitionValue("on_player_main_inventory_changed")]
  OnPlayerMainInventoryChanged,

  [FactorioRconDefinitionValue("on_player_armor_inventory_changed")]
  OnPlayerArmorInventoryChanged,

  [FactorioRconDefinitionValue("on_player_ammo_inventory_changed")]
  OnPlayerAmmoInventoryChanged,

  [FactorioRconDefinitionValue("on_player_gun_inventory_changed")]
  OnPlayerGunInventoryChanged,

  [FactorioRconDefinitionValue("on_player_placed_equipment")]
  OnPlayerPlacedEquipment,

  [FactorioRconDefinitionValue("on_player_removed_equipment")]
  OnPlayerRemovedEquipment,

  [FactorioRconDefinitionValue("on_pre_player_died")]
  OnPrePlayerDied,

  [FactorioRconDefinitionValue("on_player_died")]
  OnPlayerDied,

  [FactorioRconDefinitionValue("on_player_respawned")]
  OnPlayerRespawned,

  [FactorioRconDefinitionValue("on_player_joined_game")]
  OnPlayerJoinedGame,

  [FactorioRconDefinitionValue("on_player_left_game")]
  OnPlayerLeftGame,

  [FactorioRconDefinitionValue("on_player_built_tile")]
  OnPlayerBuiltTile,

  [FactorioRconDefinitionValue("on_player_mined_tile")]
  OnPlayerMinedTile,

  [FactorioRconDefinitionValue("on_robot_built_tile")]
  OnRobotBuiltTile,

  [FactorioRconDefinitionValue("on_robot_mined_tile")]
  OnRobotMinedTile,

  [FactorioRconDefinitionValue("on_player_selected_area")]
  OnPlayerSelectedArea,

  [FactorioRconDefinitionValue("on_player_alt_selected_area")]
  OnPlayerAltSelectedArea,

  [FactorioRconDefinitionValue("on_player_changed_surface")]
  OnPlayerChangedSurface,

  [FactorioRconDefinitionValue("on_selected_entity_changed")]
  OnSelectedEntityChanged,

  [FactorioRconDefinitionValue("on_market_item_purchased")]
  OnMarketItemPurchased,

  [FactorioRconDefinitionValue("on_player_dropped_item")]
  OnPlayerDroppedItem,

  [FactorioRconDefinitionValue("on_biter_base_built")]
  OnBiterBaseBuilt,

  [FactorioRconDefinitionValue("on_player_changed_force")]
  OnPlayerChangedForce,

  [FactorioRconDefinitionValue("on_entity_renamed")]
  OnEntityRenamed,

  [FactorioRconDefinitionValue("on_gui_selection_state_changed")]
  OnGuiSelectionStateChanged,

  [FactorioRconDefinitionValue("on_runtime_mod_setting_changed")]
  OnRuntimeModSettingChanged,

  [FactorioRconDefinitionValue("on_difficulty_settings_changed")]
  OnDifficultySettingsChanged,

  [FactorioRconDefinitionValue("on_surface_created")]
  OnSurfaceCreated,

  [FactorioRconDefinitionValue("on_surface_deleted")]
  OnSurfaceDeleted,

  [FactorioRconDefinitionValue("on_pre_surface_deleted")]
  OnPreSurfaceDeleted,

  [FactorioRconDefinitionValue("on_player_mined_entity")]
  OnPlayerMinedEntity,

  [FactorioRconDefinitionValue("on_robot_mined_entity")]
  OnRobotMinedEntity,

  [FactorioRconDefinitionValue("on_train_created")]
  OnTrainCreated,

  [FactorioRconDefinitionValue("on_gui_elem_changed")]
  OnGuiElemChanged,

  [FactorioRconDefinitionValue("on_player_setup_blueprint")]
  OnPlayerSetupBlueprint,

  [FactorioRconDefinitionValue("on_player_deconstructed_area")]
  OnPlayerDeconstructedArea,

  [FactorioRconDefinitionValue("on_player_configured_blueprint")]
  OnPlayerConfiguredBlueprint,

  [FactorioRconDefinitionValue("on_console_chat")]
  OnConsoleChat,

  [FactorioRconDefinitionValue("on_console_command")]
  OnConsoleCommand,

  [FactorioRconDefinitionValue("on_player_removed")]
  OnPlayerRemoved,

  [FactorioRconDefinitionValue("on_pre_player_removed")]
  OnPrePlayerRemoved,

  [FactorioRconDefinitionValue("on_player_used_capsule")]
  OnPlayerUsedCapsule,

  [FactorioRconDefinitionValue("script_raised_built")]
  ScriptRaisedBuilt,

  [FactorioRconDefinitionValue("script_raised_destroy")]
  ScriptRaisedDestroy,

  [FactorioRconDefinitionValue("script_raised_revive")]
  ScriptRaisedRevive,

  [FactorioRconDefinitionValue("script_raised_teleported")]
  ScriptRaisedTeleported,

  [FactorioRconDefinitionValue("script_raised_set_tiles")]
  ScriptRaisedSetTiles,

  [FactorioRconDefinitionValue("on_player_promoted")]
  OnPlayerPromoted,

  [FactorioRconDefinitionValue("on_player_demoted")]
  OnPlayerDemoted,

  [FactorioRconDefinitionValue("on_combat_robot_expired")]
  OnCombatRobotExpired,

  [FactorioRconDefinitionValue("on_worker_robot_expired")]
  OnWorkerRobotExpired,

  [FactorioRconDefinitionValue("on_player_changed_position")]
  OnPlayerChangedPosition,

  [FactorioRconDefinitionValue("on_mod_item_opened")]
  OnModItemOpened,

  [FactorioRconDefinitionValue("on_gui_opened")]
  OnGuiOpened,

  [FactorioRconDefinitionValue("on_gui_closed")]
  OnGuiClosed,

  [FactorioRconDefinitionValue("on_gui_value_changed")]
  OnGuiValueChanged,

  [FactorioRconDefinitionValue("on_player_muted")]
  OnPlayerMuted,

  [FactorioRconDefinitionValue("on_player_unmuted")]
  OnPlayerUnmuted,

  [FactorioRconDefinitionValue("on_player_cheat_mode_enabled")]
  OnPlayerCheatModeEnabled,

  [FactorioRconDefinitionValue("on_player_cheat_mode_disabled")]
  OnPlayerCheatModeDisabled,

  [FactorioRconDefinitionValue("on_character_corpse_expired")]
  OnCharacterCorpseExpired,

  [FactorioRconDefinitionValue("on_pre_ghost_deconstructed")]
  OnPreGhostDeconstructed,

  [FactorioRconDefinitionValue("on_pre_ghost_upgraded")]
  OnPreGhostUpgraded,

  [FactorioRconDefinitionValue("on_player_pipette")]
  OnPlayerPipette,

  [FactorioRconDefinitionValue("on_player_display_resolution_changed")]
  OnPlayerDisplayResolutionChanged,

  [FactorioRconDefinitionValue("on_player_display_scale_changed")]
  OnPlayerDisplayScaleChanged,

  [FactorioRconDefinitionValue("on_pre_player_crafted_item")]
  OnPrePlayerCraftedItem,

  [FactorioRconDefinitionValue("on_player_cancelled_crafting")]
  OnPlayerCancelledCrafting,

  [FactorioRconDefinitionValue("on_chunk_charted")]
  OnChunkCharted,

  [FactorioRconDefinitionValue("on_technology_effects_reset")]
  OnTechnologyEffectsReset,

  [FactorioRconDefinitionValue("on_force_reset")]
  OnForceReset,

  [FactorioRconDefinitionValue("on_land_mine_armed")]
  OnLandMineArmed,

  [FactorioRconDefinitionValue("on_forces_merged")]
  OnForcesMerged,

  [FactorioRconDefinitionValue("on_player_trash_inventory_changed")]
  OnPlayerTrashInventoryChanged,

  [FactorioRconDefinitionValue("on_pre_player_left_game")]
  OnPrePlayerLeftGame,

  [FactorioRconDefinitionValue("on_pre_surface_cleared")]
  OnPreSurfaceCleared,

  [FactorioRconDefinitionValue("on_surface_cleared")]
  OnSurfaceCleared,

  [FactorioRconDefinitionValue("on_chunk_deleted")]
  OnChunkDeleted,

  [FactorioRconDefinitionValue("on_pre_chunk_deleted")]
  OnPreChunkDeleted,

  [FactorioRconDefinitionValue("on_train_schedule_changed")]
  OnTrainScheduleChanged,

  [FactorioRconDefinitionValue("on_player_banned")]
  OnPlayerBanned,

  [FactorioRconDefinitionValue("on_player_kicked")]
  OnPlayerKicked,

  [FactorioRconDefinitionValue("on_player_unbanned")]
  OnPlayerUnbanned,

  [FactorioRconDefinitionValue("on_rocket_launch_ordered")]
  OnRocketLaunchOrdered,

  [FactorioRconDefinitionValue("on_script_path_request_finished")]
  OnScriptPathRequestFinished,

  [FactorioRconDefinitionValue("on_ai_command_completed")]
  OnAiCommandCompleted,

  [FactorioRconDefinitionValue("on_marked_for_upgrade")]
  OnMarkedForUpgrade,

  [FactorioRconDefinitionValue("on_cancelled_upgrade")]
  OnCancelledUpgrade,

  [FactorioRconDefinitionValue("on_player_toggled_map_editor")]
  OnPlayerToggledMapEditor,

  [FactorioRconDefinitionValue("on_entity_cloned")]
  OnEntityCloned,

  [FactorioRconDefinitionValue("on_area_cloned")]
  OnAreaCloned,

  [FactorioRconDefinitionValue("on_brush_cloned")]
  OnBrushCloned,

  [FactorioRconDefinitionValue("on_game_created_from_scenario")]
  OnGameCreatedFromScenario,

  [FactorioRconDefinitionValue("on_surface_imported")]
  OnSurfaceImported,

  [FactorioRconDefinitionValue("on_surface_renamed")]
  OnSurfaceRenamed,

  [FactorioRconDefinitionValue("on_player_toggled_alt_mode")]
  OnPlayerToggledAltMode,

  [FactorioRconDefinitionValue("on_player_repaired_entity")]
  OnPlayerRepairedEntity,

  [FactorioRconDefinitionValue("on_player_fast_transferred")]
  OnPlayerFastTransferred,

  [FactorioRconDefinitionValue("on_pre_robot_exploded_cliff")]
  OnPreRobotExplodedCliff,

  [FactorioRconDefinitionValue("on_robot_exploded_cliff")]
  OnRobotExplodedCliff,

  [FactorioRconDefinitionValue("on_entity_spawned")]
  OnEntitySpawned,

  [FactorioRconDefinitionValue("on_cutscene_waypoint_reached")]
  OnCutsceneWaypointReached,

  [FactorioRconDefinitionValue("on_unit_group_created")]
  OnUnitGroupCreated,

  [FactorioRconDefinitionValue("on_unit_added_to_group")]
  OnUnitAddedToGroup,

  [FactorioRconDefinitionValue("on_unit_removed_from_group")]
  OnUnitRemovedFromGroup,

  [FactorioRconDefinitionValue("on_unit_group_finished_gathering")]
  OnUnitGroupFinishedGathering,

  [FactorioRconDefinitionValue("on_build_base_arrived")]
  OnBuildBaseArrived,

  [FactorioRconDefinitionValue("on_chart_tag_added")]
  OnChartTagAdded,

  [FactorioRconDefinitionValue("on_chart_tag_modified")]
  OnChartTagModified,

  [FactorioRconDefinitionValue("on_chart_tag_removed")]
  OnChartTagRemoved,

  [FactorioRconDefinitionValue("on_lua_shortcut")]
  OnLuaShortcut,

  [FactorioRconDefinitionValue("on_gui_location_changed")]
  OnGuiLocationChanged,

  [FactorioRconDefinitionValue("on_gui_selected_tab_changed")]
  OnGuiSelectedTabChanged,

  [FactorioRconDefinitionValue("on_gui_switch_state_changed")]
  OnGuiSwitchStateChanged,

  [FactorioRconDefinitionValue("on_force_cease_fire_changed")]
  OnForceCeaseFireChanged,

  [FactorioRconDefinitionValue("on_force_friends_changed")]
  OnForceFriendsChanged,

  [FactorioRconDefinitionValue("on_string_translated")]
  OnStringTranslated,

  [FactorioRconDefinitionValue("on_script_trigger_effect")]
  OnScriptTriggerEffect,

  [FactorioRconDefinitionValue("on_player_set_quick_bar_slot")]
  OnPlayerSetQuickBarSlot,

  [FactorioRconDefinitionValue("on_pre_player_toggled_map_editor")]
  OnPrePlayerToggledMapEditor,

  [FactorioRconDefinitionValue("on_pre_script_inventory_resized")]
  OnPreScriptInventoryResized,

  [FactorioRconDefinitionValue("on_script_inventory_resized")]
  OnScriptInventoryResized,

  [FactorioRconDefinitionValue("on_entity_destroyed")]
  OnEntityDestroyed,

  [FactorioRconDefinitionValue("on_player_clicked_gps_tag")]
  OnPlayerClickedGpsTag,

  [FactorioRconDefinitionValue("on_player_flushed_fluid")]
  OnPlayerFlushedFluid,

  [FactorioRconDefinitionValue("on_permission_group_edited")]
  OnPermissionGroupEdited,

  [FactorioRconDefinitionValue("on_pre_permission_string_imported")]
  OnPrePermissionStringImported,

  [FactorioRconDefinitionValue("on_permission_string_imported")]
  OnPermissionStringImported,

  [FactorioRconDefinitionValue("on_pre_permission_group_deleted")]
  OnPrePermissionGroupDeleted,

  [FactorioRconDefinitionValue("on_permission_group_deleted")]
  OnPermissionGroupDeleted,

  [FactorioRconDefinitionValue("on_permission_group_added")]
  OnPermissionGroupAdded,

  [FactorioRconDefinitionValue("on_cutscene_cancelled")]
  OnCutsceneCancelled,

  [FactorioRconDefinitionValue("on_player_configured_spider_remote")]
  OnPlayerConfiguredSpiderRemote,

  [FactorioRconDefinitionValue("on_player_used_spider_remote")]
  OnPlayerUsedSpiderRemote,

  [FactorioRconDefinitionValue("on_spider_command_completed")]
  OnSpiderCommandCompleted,

  [FactorioRconDefinitionValue("on_entity_logistic_slot_changed")]
  OnEntityLogisticSlotChanged,

  [FactorioRconDefinitionValue("on_equipment_inserted")]
  OnEquipmentInserted,

  [FactorioRconDefinitionValue("on_equipment_removed")]
  OnEquipmentRemoved,

  [FactorioRconDefinitionValue("on_player_reverse_selected_area")]
  OnPlayerReverseSelectedArea,

  [FactorioRconDefinitionValue("on_player_alt_reverse_selected_area")]
  OnPlayerAltReverseSelectedArea,

  [FactorioRconDefinitionValue("on_gui_hover")]
  OnGuiHover,

  [FactorioRconDefinitionValue("on_gui_leave")]
  OnGuiLeave,

  [FactorioRconDefinitionValue("on_entity_color_changed")]
  OnEntityColorChanged,

  [FactorioRconDefinitionValue("on_cutscene_started")]
  OnCutsceneStarted,

  [FactorioRconDefinitionValue("on_cutscene_finished")]
  OnCutsceneFinished,

  [FactorioRconDefinitionValue("on_player_input_method_changed")]
  OnPlayerInputMethodChanged,

}

