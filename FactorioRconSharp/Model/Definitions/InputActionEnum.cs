#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("input_action")]
public enum InputActionEnum
{
  [FactorioRconDefinitionValue("activate_copy")]
  ActivateCopy,

  [FactorioRconDefinitionValue("activate_cut")]
  ActivateCut,

  [FactorioRconDefinitionValue("activate_paste")]
  ActivatePaste,

  [FactorioRconDefinitionValue("add_permission_group")]
  AddPermissionGroup,

  [FactorioRconDefinitionValue("add_train_station")]
  AddTrainStation,

  [FactorioRconDefinitionValue("admin_action")]
  AdminAction,

  [FactorioRconDefinitionValue("alt_reverse_select_area")]
  AltReverseSelectArea,

  [FactorioRconDefinitionValue("alt_select_area")]
  AltSelectArea,

  [FactorioRconDefinitionValue("alt_select_blueprint_entities")]
  AltSelectBlueprintEntities,

  [FactorioRconDefinitionValue("alternative_copy")]
  AlternativeCopy,

  [FactorioRconDefinitionValue("begin_mining")]
  BeginMining,

  [FactorioRconDefinitionValue("begin_mining_terrain")]
  BeginMiningTerrain,

  [FactorioRconDefinitionValue("build")]
  Build,

  [FactorioRconDefinitionValue("build_rail")]
  BuildRail,

  [FactorioRconDefinitionValue("build_terrain")]
  BuildTerrain,

  [FactorioRconDefinitionValue("cancel_craft")]
  CancelCraft,

  [FactorioRconDefinitionValue("cancel_deconstruct")]
  CancelDeconstruct,

  [FactorioRconDefinitionValue("cancel_new_blueprint")]
  CancelNewBlueprint,

  [FactorioRconDefinitionValue("cancel_research")]
  CancelResearch,

  [FactorioRconDefinitionValue("cancel_upgrade")]
  CancelUpgrade,

  [FactorioRconDefinitionValue("change_active_character_tab")]
  ChangeActiveCharacterTab,

  [FactorioRconDefinitionValue("change_active_item_group_for_crafting")]
  ChangeActiveItemGroupForCrafting,

  [FactorioRconDefinitionValue("change_active_item_group_for_filters")]
  ChangeActiveItemGroupForFilters,

  [FactorioRconDefinitionValue("change_active_quick_bar")]
  ChangeActiveQuickBar,

  [FactorioRconDefinitionValue("change_arithmetic_combinator_parameters")]
  ChangeArithmeticCombinatorParameters,

  [FactorioRconDefinitionValue("change_decider_combinator_parameters")]
  ChangeDeciderCombinatorParameters,

  [FactorioRconDefinitionValue("change_entity_label")]
  ChangeEntityLabel,

  [FactorioRconDefinitionValue("change_item_description")]
  ChangeItemDescription,

  [FactorioRconDefinitionValue("change_item_label")]
  ChangeItemLabel,

  [FactorioRconDefinitionValue("change_multiplayer_config")]
  ChangeMultiplayerConfig,

  [FactorioRconDefinitionValue("change_picking_state")]
  ChangePickingState,

  [FactorioRconDefinitionValue("change_programmable_speaker_alert_parameters")]
  ChangeProgrammableSpeakerAlertParameters,

  [FactorioRconDefinitionValue("change_programmable_speaker_circuit_parameters")]
  ChangeProgrammableSpeakerCircuitParameters,

  [FactorioRconDefinitionValue("change_programmable_speaker_parameters")]
  ChangeProgrammableSpeakerParameters,

  [FactorioRconDefinitionValue("change_riding_state")]
  ChangeRidingState,

  [FactorioRconDefinitionValue("change_shooting_state")]
  ChangeShootingState,

  [FactorioRconDefinitionValue("change_train_stop_station")]
  ChangeTrainStopStation,

  [FactorioRconDefinitionValue("change_train_wait_condition")]
  ChangeTrainWaitCondition,

  [FactorioRconDefinitionValue("change_train_wait_condition_data")]
  ChangeTrainWaitConditionData,

  [FactorioRconDefinitionValue("clear_cursor")]
  ClearCursor,

  [FactorioRconDefinitionValue("connect_rolling_stock")]
  ConnectRollingStock,

  [FactorioRconDefinitionValue("copy")]
  Copy,

  [FactorioRconDefinitionValue("copy_entity_settings")]
  CopyEntitySettings,

  [FactorioRconDefinitionValue("copy_opened_blueprint")]
  CopyOpenedBlueprint,

  [FactorioRconDefinitionValue("copy_opened_item")]
  CopyOpenedItem,

  [FactorioRconDefinitionValue("craft")]
  Craft,

  [FactorioRconDefinitionValue("cursor_split")]
  CursorSplit,

  [FactorioRconDefinitionValue("cursor_transfer")]
  CursorTransfer,

  [FactorioRconDefinitionValue("custom_input")]
  CustomInput,

  [FactorioRconDefinitionValue("cycle_blueprint_book_backwards")]
  CycleBlueprintBookBackwards,

  [FactorioRconDefinitionValue("cycle_blueprint_book_forwards")]
  CycleBlueprintBookForwards,

  [FactorioRconDefinitionValue("deconstruct")]
  Deconstruct,

  [FactorioRconDefinitionValue("delete_blueprint_library")]
  DeleteBlueprintLibrary,

  [FactorioRconDefinitionValue("delete_blueprint_record")]
  DeleteBlueprintRecord,

  [FactorioRconDefinitionValue("delete_custom_tag")]
  DeleteCustomTag,

  [FactorioRconDefinitionValue("delete_permission_group")]
  DeletePermissionGroup,

  [FactorioRconDefinitionValue("destroy_item")]
  DestroyItem,

  [FactorioRconDefinitionValue("destroy_opened_item")]
  DestroyOpenedItem,

  [FactorioRconDefinitionValue("disconnect_rolling_stock")]
  DisconnectRollingStock,

  [FactorioRconDefinitionValue("drag_train_schedule")]
  DragTrainSchedule,

  [FactorioRconDefinitionValue("drag_train_wait_condition")]
  DragTrainWaitCondition,

  [FactorioRconDefinitionValue("drop_blueprint_record")]
  DropBlueprintRecord,

  [FactorioRconDefinitionValue("drop_item")]
  DropItem,

  [FactorioRconDefinitionValue("edit_blueprint_tool_preview")]
  EditBlueprintToolPreview,

  [FactorioRconDefinitionValue("edit_custom_tag")]
  EditCustomTag,

  [FactorioRconDefinitionValue("edit_permission_group")]
  EditPermissionGroup,

  [FactorioRconDefinitionValue("export_blueprint")]
  ExportBlueprint,

  [FactorioRconDefinitionValue("fast_entity_split")]
  FastEntitySplit,

  [FactorioRconDefinitionValue("fast_entity_transfer")]
  FastEntityTransfer,

  [FactorioRconDefinitionValue("flush_opened_entity_fluid")]
  FlushOpenedEntityFluid,

  [FactorioRconDefinitionValue("flush_opened_entity_specific_fluid")]
  FlushOpenedEntitySpecificFluid,

  [FactorioRconDefinitionValue("go_to_train_station")]
  GoToTrainStation,

  [FactorioRconDefinitionValue("grab_blueprint_record")]
  GrabBlueprintRecord,

  [FactorioRconDefinitionValue("gui_checked_state_changed")]
  GuiCheckedStateChanged,

  [FactorioRconDefinitionValue("gui_click")]
  GuiClick,

  [FactorioRconDefinitionValue("gui_confirmed")]
  GuiConfirmed,

  [FactorioRconDefinitionValue("gui_elem_changed")]
  GuiElemChanged,

  [FactorioRconDefinitionValue("gui_hover")]
  GuiHover,

  [FactorioRconDefinitionValue("gui_leave")]
  GuiLeave,

  [FactorioRconDefinitionValue("gui_location_changed")]
  GuiLocationChanged,

  [FactorioRconDefinitionValue("gui_selected_tab_changed")]
  GuiSelectedTabChanged,

  [FactorioRconDefinitionValue("gui_selection_state_changed")]
  GuiSelectionStateChanged,

  [FactorioRconDefinitionValue("gui_switch_state_changed")]
  GuiSwitchStateChanged,

  [FactorioRconDefinitionValue("gui_text_changed")]
  GuiTextChanged,

  [FactorioRconDefinitionValue("gui_value_changed")]
  GuiValueChanged,

  [FactorioRconDefinitionValue("import_blueprint")]
  ImportBlueprint,

  [FactorioRconDefinitionValue("import_blueprint_string")]
  ImportBlueprintString,

  [FactorioRconDefinitionValue("import_blueprints_filtered")]
  ImportBlueprintsFiltered,

  [FactorioRconDefinitionValue("import_permissions_string")]
  ImportPermissionsString,

  [FactorioRconDefinitionValue("inventory_split")]
  InventorySplit,

  [FactorioRconDefinitionValue("inventory_transfer")]
  InventoryTransfer,

  [FactorioRconDefinitionValue("launch_rocket")]
  LaunchRocket,

  [FactorioRconDefinitionValue("lua_shortcut")]
  LuaShortcut,

  [FactorioRconDefinitionValue("map_editor_action")]
  MapEditorAction,

  [FactorioRconDefinitionValue("market_offer")]
  MarketOffer,

  [FactorioRconDefinitionValue("mod_settings_changed")]
  ModSettingsChanged,

  [FactorioRconDefinitionValue("open_achievements_gui")]
  OpenAchievementsGui,

  [FactorioRconDefinitionValue("open_blueprint_library_gui")]
  OpenBlueprintLibraryGui,

  [FactorioRconDefinitionValue("open_blueprint_record")]
  OpenBlueprintRecord,

  [FactorioRconDefinitionValue("open_bonus_gui")]
  OpenBonusGui,

  [FactorioRconDefinitionValue("open_character_gui")]
  OpenCharacterGui,

  [FactorioRconDefinitionValue("open_current_vehicle_gui")]
  OpenCurrentVehicleGui,

  [FactorioRconDefinitionValue("open_equipment")]
  OpenEquipment,

  [FactorioRconDefinitionValue("open_gui")]
  OpenGui,

  [FactorioRconDefinitionValue("open_item")]
  OpenItem,

  [FactorioRconDefinitionValue("open_logistic_gui")]
  OpenLogisticGui,

  [FactorioRconDefinitionValue("open_mod_item")]
  OpenModItem,

  [FactorioRconDefinitionValue("open_parent_of_opened_item")]
  OpenParentOfOpenedItem,

  [FactorioRconDefinitionValue("open_production_gui")]
  OpenProductionGui,

  [FactorioRconDefinitionValue("open_technology_gui")]
  OpenTechnologyGui,

  [FactorioRconDefinitionValue("open_tips_and_tricks_gui")]
  OpenTipsAndTricksGui,

  [FactorioRconDefinitionValue("open_train_gui")]
  OpenTrainGui,

  [FactorioRconDefinitionValue("open_train_station_gui")]
  OpenTrainStationGui,

  [FactorioRconDefinitionValue("open_trains_gui")]
  OpenTrainsGui,

  [FactorioRconDefinitionValue("paste_entity_settings")]
  PasteEntitySettings,

  [FactorioRconDefinitionValue("place_equipment")]
  PlaceEquipment,

  [FactorioRconDefinitionValue("quick_bar_pick_slot")]
  QuickBarPickSlot,

  [FactorioRconDefinitionValue("quick_bar_set_selected_page")]
  QuickBarSetSelectedPage,

  [FactorioRconDefinitionValue("quick_bar_set_slot")]
  QuickBarSetSlot,

  [FactorioRconDefinitionValue("reassign_blueprint")]
  ReassignBlueprint,

  [FactorioRconDefinitionValue("remove_cables")]
  RemoveCables,

  [FactorioRconDefinitionValue("remove_train_station")]
  RemoveTrainStation,

  [FactorioRconDefinitionValue("reset_assembling_machine")]
  ResetAssemblingMachine,

  [FactorioRconDefinitionValue("reset_item")]
  ResetItem,

  [FactorioRconDefinitionValue("reverse_select_area")]
  ReverseSelectArea,

  [FactorioRconDefinitionValue("rotate_entity")]
  RotateEntity,

  [FactorioRconDefinitionValue("select_area")]
  SelectArea,

  [FactorioRconDefinitionValue("select_blueprint_entities")]
  SelectBlueprintEntities,

  [FactorioRconDefinitionValue("select_entity_slot")]
  SelectEntitySlot,

  [FactorioRconDefinitionValue("select_item")]
  SelectItem,

  [FactorioRconDefinitionValue("select_mapper_slot")]
  SelectMapperSlot,

  [FactorioRconDefinitionValue("select_next_valid_gun")]
  SelectNextValidGun,

  [FactorioRconDefinitionValue("select_tile_slot")]
  SelectTileSlot,

  [FactorioRconDefinitionValue("send_spidertron")]
  SendSpidertron,

  [FactorioRconDefinitionValue("set_auto_launch_rocket")]
  SetAutoLaunchRocket,

  [FactorioRconDefinitionValue("set_autosort_inventory")]
  SetAutosortInventory,

  [FactorioRconDefinitionValue("set_behavior_mode")]
  SetBehaviorMode,

  [FactorioRconDefinitionValue("set_car_weapons_control")]
  SetCarWeaponsControl,

  [FactorioRconDefinitionValue("set_circuit_condition")]
  SetCircuitCondition,

  [FactorioRconDefinitionValue("set_circuit_mode_of_operation")]
  SetCircuitModeOfOperation,

  [FactorioRconDefinitionValue("set_controller_logistic_trash_filter_item")]
  SetControllerLogisticTrashFilterItem,

  [FactorioRconDefinitionValue("set_deconstruction_item_tile_selection_mode")]
  SetDeconstructionItemTileSelectionMode,

  [FactorioRconDefinitionValue("set_deconstruction_item_trees_and_rocks_only")]
  SetDeconstructionItemTreesAndRocksOnly,

  [FactorioRconDefinitionValue("set_entity_color")]
  SetEntityColor,

  [FactorioRconDefinitionValue("set_entity_energy_property")]
  SetEntityEnergyProperty,

  [FactorioRconDefinitionValue("set_entity_logistic_trash_filter_item")]
  SetEntityLogisticTrashFilterItem,

  [FactorioRconDefinitionValue("set_filter")]
  SetFilter,

  [FactorioRconDefinitionValue("set_flat_controller_gui")]
  SetFlatControllerGui,

  [FactorioRconDefinitionValue("set_heat_interface_mode")]
  SetHeatInterfaceMode,

  [FactorioRconDefinitionValue("set_heat_interface_temperature")]
  SetHeatInterfaceTemperature,

  [FactorioRconDefinitionValue("set_infinity_container_filter_item")]
  SetInfinityContainerFilterItem,

  [FactorioRconDefinitionValue("set_infinity_container_remove_unfiltered_items")]
  SetInfinityContainerRemoveUnfilteredItems,

  [FactorioRconDefinitionValue("set_infinity_pipe_filter")]
  SetInfinityPipeFilter,

  [FactorioRconDefinitionValue("set_inserter_max_stack_size")]
  SetInserterMaxStackSize,

  [FactorioRconDefinitionValue("set_inventory_bar")]
  SetInventoryBar,

  [FactorioRconDefinitionValue("set_linked_container_link_i_d")]
  SetLinkedContainerLinkID,

  [FactorioRconDefinitionValue("set_logistic_filter_item")]
  SetLogisticFilterItem,

  [FactorioRconDefinitionValue("set_logistic_filter_signal")]
  SetLogisticFilterSignal,

  [FactorioRconDefinitionValue("set_player_color")]
  SetPlayerColor,

  [FactorioRconDefinitionValue("set_recipe_notifications")]
  SetRecipeNotifications,

  [FactorioRconDefinitionValue("set_request_from_buffers")]
  SetRequestFromBuffers,

  [FactorioRconDefinitionValue("set_research_finished_stops_game")]
  SetResearchFinishedStopsGame,

  [FactorioRconDefinitionValue("set_signal")]
  SetSignal,

  [FactorioRconDefinitionValue("set_splitter_priority")]
  SetSplitterPriority,

  [FactorioRconDefinitionValue("set_train_stopped")]
  SetTrainStopped,

  [FactorioRconDefinitionValue("set_trains_limit")]
  SetTrainsLimit,

  [FactorioRconDefinitionValue("set_vehicle_automatic_targeting_parameters")]
  SetVehicleAutomaticTargetingParameters,

  [FactorioRconDefinitionValue("setup_assembling_machine")]
  SetupAssemblingMachine,

  [FactorioRconDefinitionValue("setup_blueprint")]
  SetupBlueprint,

  [FactorioRconDefinitionValue("setup_single_blueprint_record")]
  SetupSingleBlueprintRecord,

  [FactorioRconDefinitionValue("smart_pipette")]
  SmartPipette,

  [FactorioRconDefinitionValue("spawn_item")]
  SpawnItem,

  [FactorioRconDefinitionValue("stack_split")]
  StackSplit,

  [FactorioRconDefinitionValue("stack_transfer")]
  StackTransfer,

  [FactorioRconDefinitionValue("start_repair")]
  StartRepair,

  [FactorioRconDefinitionValue("start_research")]
  StartResearch,

  [FactorioRconDefinitionValue("start_walking")]
  StartWalking,

  [FactorioRconDefinitionValue("stop_building_by_moving")]
  StopBuildingByMoving,

  [FactorioRconDefinitionValue("switch_connect_to_logistic_network")]
  SwitchConnectToLogisticNetwork,

  [FactorioRconDefinitionValue("switch_constant_combinator_state")]
  SwitchConstantCombinatorState,

  [FactorioRconDefinitionValue("switch_inserter_filter_mode_state")]
  SwitchInserterFilterModeState,

  [FactorioRconDefinitionValue("switch_power_switch_state")]
  SwitchPowerSwitchState,

  [FactorioRconDefinitionValue("switch_to_rename_stop_gui")]
  SwitchToRenameStopGui,

  [FactorioRconDefinitionValue("take_equipment")]
  TakeEquipment,

  [FactorioRconDefinitionValue("toggle_deconstruction_item_entity_filter_mode")]
  ToggleDeconstructionItemEntityFilterMode,

  [FactorioRconDefinitionValue("toggle_deconstruction_item_tile_filter_mode")]
  ToggleDeconstructionItemTileFilterMode,

  [FactorioRconDefinitionValue("toggle_driving")]
  ToggleDriving,

  [FactorioRconDefinitionValue("toggle_enable_vehicle_logistics_while_moving")]
  ToggleEnableVehicleLogisticsWhileMoving,

  [FactorioRconDefinitionValue("toggle_entity_logistic_requests")]
  ToggleEntityLogisticRequests,

  [FactorioRconDefinitionValue("toggle_equipment_movement_bonus")]
  ToggleEquipmentMovementBonus,

  [FactorioRconDefinitionValue("toggle_map_editor")]
  ToggleMapEditor,

  [FactorioRconDefinitionValue("toggle_personal_logistic_requests")]
  TogglePersonalLogisticRequests,

  [FactorioRconDefinitionValue("toggle_personal_roboport")]
  TogglePersonalRoboport,

  [FactorioRconDefinitionValue("toggle_show_entity_info")]
  ToggleShowEntityInfo,

  [FactorioRconDefinitionValue("translate_string")]
  TranslateString,

  [FactorioRconDefinitionValue("undo")]
  Undo,

  [FactorioRconDefinitionValue("upgrade")]
  Upgrade,

  [FactorioRconDefinitionValue("upgrade_opened_blueprint_by_item")]
  UpgradeOpenedBlueprintByItem,

  [FactorioRconDefinitionValue("upgrade_opened_blueprint_by_record")]
  UpgradeOpenedBlueprintByRecord,

  [FactorioRconDefinitionValue("use_artillery_remote")]
  UseArtilleryRemote,

  [FactorioRconDefinitionValue("use_item")]
  UseItem,

  [FactorioRconDefinitionValue("wire_dragging")]
  WireDragging,

  [FactorioRconDefinitionValue("write_to_console")]
  WriteToConsole,

}

