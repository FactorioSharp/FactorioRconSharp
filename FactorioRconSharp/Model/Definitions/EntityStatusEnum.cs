#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("entity_status")]
public enum EntityStatusEnum
{
  [FactorioRconDefinitionValue("working")]
  Working,

  [FactorioRconDefinitionValue("normal")]
  Normal,

  [FactorioRconDefinitionValue("no_power")]
  NoPower,

  [FactorioRconDefinitionValue("low_power")]
  LowPower,

  [FactorioRconDefinitionValue("no_fuel")]
  NoFuel,

  [FactorioRconDefinitionValue("disabled_by_control_behavior")]
  DisabledByControlBehavior,

  [FactorioRconDefinitionValue("opened_by_circuit_network")]
  OpenedByCircuitNetwork,

  [FactorioRconDefinitionValue("closed_by_circuit_network")]
  ClosedByCircuitNetwork,

  [FactorioRconDefinitionValue("disabled_by_script")]
  DisabledByScript,

  [FactorioRconDefinitionValue("marked_for_deconstruction")]
  MarkedForDeconstruction,

  /// <summary>
  /// Used by generators and solar panels.
  /// </summary>
  [FactorioRconDefinitionValue("not_plugged_in_electric_network")]
  NotPluggedInElectricNetwork,

  /// <summary>
  /// Used by power switches.
  /// </summary>
  [FactorioRconDefinitionValue("networks_connected")]
  NetworksConnected,

  /// <summary>
  /// Used by power switches.
  /// </summary>
  [FactorioRconDefinitionValue("networks_disconnected")]
  NetworksDisconnected,

  /// <summary>
  /// Used by accumulators.
  /// </summary>
  [FactorioRconDefinitionValue("charging")]
  Charging,

  /// <summary>
  /// Used by accumulators.
  /// </summary>
  [FactorioRconDefinitionValue("discharging")]
  Discharging,

  /// <summary>
  /// Used by accumulators.
  /// </summary>
  [FactorioRconDefinitionValue("fully_charged")]
  FullyCharged,

  /// <summary>
  /// Used by logistic containers.
  /// </summary>
  [FactorioRconDefinitionValue("out_of_logistic_network")]
  OutOfLogisticNetwork,

  /// <summary>
  /// Used by assembling machines.
  /// </summary>
  [FactorioRconDefinitionValue("no_recipe")]
  NoRecipe,

  /// <summary>
  /// Used by furnaces.
  /// </summary>
  [FactorioRconDefinitionValue("no_ingredients")]
  NoIngredients,

  /// <summary>
  /// Used by boilers, fluid turrets and fluid energy sources: Boiler has no fluid to work with.
  /// </summary>
  [FactorioRconDefinitionValue("no_input_fluid")]
  NoInputFluid,

  /// <summary>
  /// Used by labs.
  /// </summary>
  [FactorioRconDefinitionValue("no_research_in_progress")]
  NoResearchInProgress,

  /// <summary>
  /// Used by mining drills.
  /// </summary>
  [FactorioRconDefinitionValue("no_minable_resources")]
  NoMinableResources,

  /// <summary>
  /// Used by boilers and fluid turrets: Boiler still has some fluid but is about to run out.
  /// </summary>
  [FactorioRconDefinitionValue("low_input_fluid")]
  LowInputFluid,

  /// <summary>
  /// Used by crafting machines.
  /// </summary>
  [FactorioRconDefinitionValue("fluid_ingredient_shortage")]
  FluidIngredientShortage,

  /// <summary>
  /// Used by crafting machines, boilers, burner energy sources and reactors: Reactor/burner has full burnt result inventory, boiler has full output fluidbox.
  /// </summary>
  [FactorioRconDefinitionValue("full_output")]
  FullOutput,

  /// <summary>
  /// Used by burner energy sources.
  /// </summary>
  [FactorioRconDefinitionValue("full_burnt_result_output")]
  FullBurntResultOutput,

  /// <summary>
  /// Used by crafting machines.
  /// </summary>
  [FactorioRconDefinitionValue("item_ingredient_shortage")]
  ItemIngredientShortage,

  /// <summary>
  /// Used by mining drills when the mining fluid is missing.
  /// </summary>
  [FactorioRconDefinitionValue("missing_required_fluid")]
  MissingRequiredFluid,

  /// <summary>
  /// Used by labs.
  /// </summary>
  [FactorioRconDefinitionValue("missing_science_packs")]
  MissingSciencePacks,

  /// <summary>
  /// Used by inserters.
  /// </summary>
  [FactorioRconDefinitionValue("waiting_for_source_items")]
  WaitingForSourceItems,

  /// <summary>
  /// Used by inserters and mining drills.
  /// </summary>
  [FactorioRconDefinitionValue("waiting_for_space_in_destination")]
  WaitingForSpaceInDestination,

  /// <summary>
  /// Used by the rocket silo.
  /// </summary>
  [FactorioRconDefinitionValue("preparing_rocket_for_launch")]
  PreparingRocketForLaunch,

  /// <summary>
  /// Used by the rocket silo.
  /// </summary>
  [FactorioRconDefinitionValue("waiting_to_launch_rocket")]
  WaitingToLaunchRocket,

  /// <summary>
  /// Used by the rocket silo.
  /// </summary>
  [FactorioRconDefinitionValue("launching_rocket")]
  LaunchingRocket,

  /// <summary>
  /// Used by beacons.
  /// </summary>
  [FactorioRconDefinitionValue("no_modules_to_transmit")]
  NoModulesToTransmit,

  /// <summary>
  /// Used by roboports.
  /// </summary>
  [FactorioRconDefinitionValue("recharging_after_power_outage")]
  RechargingAfterPowerOutage,

  /// <summary>
  /// Used by inserters targeting entity ghosts.
  /// </summary>
  [FactorioRconDefinitionValue("waiting_for_target_to_be_built")]
  WaitingForTargetToBeBuilt,

  /// <summary>
  /// Used by inserters targeting rails.
  /// </summary>
  [FactorioRconDefinitionValue("waiting_for_train")]
  WaitingForTrain,

  /// <summary>
  /// Used by ammo turrets.
  /// </summary>
  [FactorioRconDefinitionValue("no_ammo")]
  NoAmmo,

  /// <summary>
  /// Used by heat energy sources.
  /// </summary>
  [FactorioRconDefinitionValue("low_temperature")]
  LowTemperature,

  /// <summary>
  /// Used by constant combinators: Combinator is turned off via switch in GUI.
  /// </summary>
  [FactorioRconDefinitionValue("disabled")]
  Disabled,

  /// <summary>
  /// Used by lamps.
  /// </summary>
  [FactorioRconDefinitionValue("turned_off_during_daytime")]
  TurnedOffDuringDaytime,

  /// <summary>
  /// Used by rail signals.
  /// </summary>
  [FactorioRconDefinitionValue("not_connected_to_rail")]
  NotConnectedToRail,

  /// <summary>
  /// Used by rail signals.
  /// </summary>
  [FactorioRconDefinitionValue("cant_divide_segments")]
  CantDivideSegments,

}

