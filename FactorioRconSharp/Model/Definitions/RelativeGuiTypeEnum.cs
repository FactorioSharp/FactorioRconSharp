#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("relative_gui_type")]
public enum RelativeGuiTypeEnum
{
  [FactorioRconDefinitionValue("accumulator_gui")]
  AccumulatorGui,

  [FactorioRconDefinitionValue("achievement_gui")]
  AchievementGui,

  [FactorioRconDefinitionValue("additional_entity_info_gui")]
  AdditionalEntityInfoGui,

  [FactorioRconDefinitionValue("admin_gui")]
  AdminGui,

  [FactorioRconDefinitionValue("arithmetic_combinator_gui")]
  ArithmeticCombinatorGui,

  [FactorioRconDefinitionValue("armor_gui")]
  ArmorGui,

  [FactorioRconDefinitionValue("assembling_machine_gui")]
  AssemblingMachineGui,

  [FactorioRconDefinitionValue("assembling_machine_select_recipe_gui")]
  AssemblingMachineSelectRecipeGui,

  [FactorioRconDefinitionValue("beacon_gui")]
  BeaconGui,

  [FactorioRconDefinitionValue("blueprint_book_gui")]
  BlueprintBookGui,

  [FactorioRconDefinitionValue("blueprint_library_gui")]
  BlueprintLibraryGui,

  [FactorioRconDefinitionValue("blueprint_setup_gui")]
  BlueprintSetupGui,

  [FactorioRconDefinitionValue("bonus_gui")]
  BonusGui,

  [FactorioRconDefinitionValue("burner_equipment_gui")]
  BurnerEquipmentGui,

  [FactorioRconDefinitionValue("car_gui")]
  CarGui,

  [FactorioRconDefinitionValue("constant_combinator_gui")]
  ConstantCombinatorGui,

  [FactorioRconDefinitionValue("container_gui")]
  ContainerGui,

  [FactorioRconDefinitionValue("controller_gui")]
  ControllerGui,

  [FactorioRconDefinitionValue("decider_combinator_gui")]
  DeciderCombinatorGui,

  [FactorioRconDefinitionValue("deconstruction_item_gui")]
  DeconstructionItemGui,

  [FactorioRconDefinitionValue("electric_energy_interface_gui")]
  ElectricEnergyInterfaceGui,

  [FactorioRconDefinitionValue("electric_network_gui")]
  ElectricNetworkGui,

  [FactorioRconDefinitionValue("entity_variations_gui")]
  EntityVariationsGui,

  [FactorioRconDefinitionValue("entity_with_energy_source_gui")]
  EntityWithEnergySourceGui,

  [FactorioRconDefinitionValue("equipment_grid_gui")]
  EquipmentGridGui,

  [FactorioRconDefinitionValue("furnace_gui")]
  FurnaceGui,

  [FactorioRconDefinitionValue("generic_on_off_entity_gui")]
  GenericOnOffEntityGui,

  [FactorioRconDefinitionValue("heat_interface_gui")]
  HeatInterfaceGui,

  [FactorioRconDefinitionValue("infinity_pipe_gui")]
  InfinityPipeGui,

  [FactorioRconDefinitionValue("inserter_gui")]
  InserterGui,

  [FactorioRconDefinitionValue("item_with_inventory_gui")]
  ItemWithInventoryGui,

  [FactorioRconDefinitionValue("lab_gui")]
  LabGui,

  [FactorioRconDefinitionValue("lamp_gui")]
  LampGui,

  [FactorioRconDefinitionValue("linked_container_gui")]
  LinkedContainerGui,

  [FactorioRconDefinitionValue("loader_gui")]
  LoaderGui,

  [FactorioRconDefinitionValue("logistic_gui")]
  LogisticGui,

  [FactorioRconDefinitionValue("market_gui")]
  MarketGui,

  [FactorioRconDefinitionValue("mining_drill_gui")]
  MiningDrillGui,

  [FactorioRconDefinitionValue("other_player_gui")]
  OtherPlayerGui,

  [FactorioRconDefinitionValue("permissions_gui")]
  PermissionsGui,

  [FactorioRconDefinitionValue("pipe_gui")]
  PipeGui,

  [FactorioRconDefinitionValue("power_switch_gui")]
  PowerSwitchGui,

  [FactorioRconDefinitionValue("production_gui")]
  ProductionGui,

  [FactorioRconDefinitionValue("programmable_speaker_gui")]
  ProgrammableSpeakerGui,

  [FactorioRconDefinitionValue("rail_chain_signal_gui")]
  RailChainSignalGui,

  [FactorioRconDefinitionValue("rail_signal_gui")]
  RailSignalGui,

  [FactorioRconDefinitionValue("reactor_gui")]
  ReactorGui,

  [FactorioRconDefinitionValue("rename_stop_gui")]
  RenameStopGui,

  [FactorioRconDefinitionValue("resource_entity_gui")]
  ResourceEntityGui,

  [FactorioRconDefinitionValue("roboport_gui")]
  RoboportGui,

  [FactorioRconDefinitionValue("rocket_silo_gui")]
  RocketSiloGui,

  [FactorioRconDefinitionValue("script_inventory_gui")]
  ScriptInventoryGui,

  [FactorioRconDefinitionValue("server_config_gui")]
  ServerConfigGui,

  [FactorioRconDefinitionValue("spider_vehicle_gui")]
  SpiderVehicleGui,

  [FactorioRconDefinitionValue("splitter_gui")]
  SplitterGui,

  [FactorioRconDefinitionValue("standalone_character_gui")]
  StandaloneCharacterGui,

  [FactorioRconDefinitionValue("storage_tank_gui")]
  StorageTankGui,

  [FactorioRconDefinitionValue("tile_variations_gui")]
  TileVariationsGui,

  [FactorioRconDefinitionValue("train_gui")]
  TrainGui,

  [FactorioRconDefinitionValue("train_stop_gui")]
  TrainStopGui,

  [FactorioRconDefinitionValue("trains_gui")]
  TrainsGui,

  [FactorioRconDefinitionValue("transport_belt_gui")]
  TransportBeltGui,

  [FactorioRconDefinitionValue("upgrade_item_gui")]
  UpgradeItemGui,

  [FactorioRconDefinitionValue("wall_gui")]
  WallGui,

}

