#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// Used by <see cref="TechnologyModifier" />.
/// </summary>
[FactorioRconDefinition("ModifierType")]
public enum ModifierType
{
  /// <summary>
  /// Literal value: inserter-stack-size-bonus
  /// </summary>
  [FactorioRconDefinitionValue("inserter-stack-size-bonus")]
  InserterStackSizeBonus,

  /// <summary>
  /// Literal value: stack-inserter-capacity-bonus
  /// </summary>
  [FactorioRconDefinitionValue("stack-inserter-capacity-bonus")]
  StackInserterCapacityBonus,

  /// <summary>
  /// Literal value: laboratory-speed
  /// </summary>
  [FactorioRconDefinitionValue("laboratory-speed")]
  LaboratorySpeed,

  /// <summary>
  /// Literal value: character-logistic-trash-slots
  /// </summary>
  [FactorioRconDefinitionValue("character-logistic-trash-slots")]
  CharacterLogisticTrashSlots,

  /// <summary>
  /// Literal value: maximum-following-robots-count
  /// </summary>
  [FactorioRconDefinitionValue("maximum-following-robots-count")]
  MaximumFollowingRobotsCount,

  /// <summary>
  /// Literal value: worker-robot-speed
  /// </summary>
  [FactorioRconDefinitionValue("worker-robot-speed")]
  WorkerRobotSpeed,

  /// <summary>
  /// Literal value: worker-robot-storage
  /// </summary>
  [FactorioRconDefinitionValue("worker-robot-storage")]
  WorkerRobotStorage,

  /// <summary>
  /// Literal value: ghost-time-to-live
  /// </summary>
  [FactorioRconDefinitionValue("ghost-time-to-live")]
  GhostTimeToLive,

  /// <summary>
  /// Literal value: turret-attack
  /// </summary>
  [FactorioRconDefinitionValue("turret-attack")]
  TurretAttack,

  /// <summary>
  /// Literal value: ammo-damage
  /// </summary>
  [FactorioRconDefinitionValue("ammo-damage")]
  AmmoDamage,

  /// <summary>
  /// Literal value: give-item
  /// </summary>
  [FactorioRconDefinitionValue("give-item")]
  GiveItem,

  /// <summary>
  /// Literal value: gun-speed
  /// </summary>
  [FactorioRconDefinitionValue("gun-speed")]
  GunSpeed,

  /// <summary>
  /// Literal value: unlock-recipe
  /// </summary>
  [FactorioRconDefinitionValue("unlock-recipe")]
  UnlockRecipe,

  /// <summary>
  /// Literal value: character-crafting-speed
  /// </summary>
  [FactorioRconDefinitionValue("character-crafting-speed")]
  CharacterCraftingSpeed,

  /// <summary>
  /// Literal value: character-mining-speed
  /// </summary>
  [FactorioRconDefinitionValue("character-mining-speed")]
  CharacterMiningSpeed,

  /// <summary>
  /// Literal value: character-running-speed
  /// </summary>
  [FactorioRconDefinitionValue("character-running-speed")]
  CharacterRunningSpeed,

  /// <summary>
  /// Literal value: character-build-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-build-distance")]
  CharacterBuildDistance,

  /// <summary>
  /// Literal value: character-item-drop-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-item-drop-distance")]
  CharacterItemDropDistance,

  /// <summary>
  /// Literal value: character-reach-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-reach-distance")]
  CharacterReachDistance,

  /// <summary>
  /// Literal value: character-resource-reach-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-resource-reach-distance")]
  CharacterResourceReachDistance,

  /// <summary>
  /// Literal value: character-item-pickup-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-item-pickup-distance")]
  CharacterItemPickupDistance,

  /// <summary>
  /// Literal value: character-loot-pickup-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-loot-pickup-distance")]
  CharacterLootPickupDistance,

  /// <summary>
  /// Literal value: character-inventory-slots-bonus
  /// </summary>
  [FactorioRconDefinitionValue("character-inventory-slots-bonus")]
  CharacterInventorySlotsBonus,

  /// <summary>
  /// Literal value: deconstruction-time-to-live
  /// </summary>
  [FactorioRconDefinitionValue("deconstruction-time-to-live")]
  DeconstructionTimeToLive,

  /// <summary>
  /// Literal value: max-failed-attempts-per-tick-per-construction-queue
  /// </summary>
  [FactorioRconDefinitionValue("max-failed-attempts-per-tick-per-construction-queue")]
  MaxFailedAttemptsPerTickPerConstructionQueue,

  /// <summary>
  /// Literal value: max-successful-attempts-per-tick-per-construction-queue
  /// </summary>
  [FactorioRconDefinitionValue("max-successful-attempts-per-tick-per-construction-queue")]
  MaxSuccessfulAttemptsPerTickPerConstructionQueue,

  /// <summary>
  /// Literal value: character-health-bonus
  /// </summary>
  [FactorioRconDefinitionValue("character-health-bonus")]
  CharacterHealthBonus,

  /// <summary>
  /// Literal value: mining-drill-productivity-bonus
  /// </summary>
  [FactorioRconDefinitionValue("mining-drill-productivity-bonus")]
  MiningDrillProductivityBonus,

  /// <summary>
  /// Literal value: train-braking-force-bonus
  /// </summary>
  [FactorioRconDefinitionValue("train-braking-force-bonus")]
  TrainBrakingForceBonus,

  /// <summary>
  /// Literal value: zoom-to-world-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-enabled")]
  ZoomToWorldEnabled,

  /// <summary>
  /// Literal value: zoom-to-world-ghost-building-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-ghost-building-enabled")]
  ZoomToWorldGhostBuildingEnabled,

  /// <summary>
  /// Literal value: zoom-to-world-blueprint-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-blueprint-enabled")]
  ZoomToWorldBlueprintEnabled,

  /// <summary>
  /// Literal value: zoom-to-world-deconstruction-planner-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-deconstruction-planner-enabled")]
  ZoomToWorldDeconstructionPlannerEnabled,

  /// <summary>
  /// Literal value: zoom-to-world-upgrade-planner-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-upgrade-planner-enabled")]
  ZoomToWorldUpgradePlannerEnabled,

  /// <summary>
  /// Literal value: zoom-to-world-selection-tool-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-selection-tool-enabled")]
  ZoomToWorldSelectionToolEnabled,

  /// <summary>
  /// Literal value: worker-robot-battery
  /// </summary>
  [FactorioRconDefinitionValue("worker-robot-battery")]
  WorkerRobotBattery,

  /// <summary>
  /// Literal value: laboratory-productivity
  /// </summary>
  [FactorioRconDefinitionValue("laboratory-productivity")]
  LaboratoryProductivity,

  /// <summary>
  /// Literal value: follower-robot-lifetime
  /// </summary>
  [FactorioRconDefinitionValue("follower-robot-lifetime")]
  FollowerRobotLifetime,

  /// <summary>
  /// Literal value: artillery-range
  /// </summary>
  [FactorioRconDefinitionValue("artillery-range")]
  ArtilleryRange,

  /// <summary>
  /// Literal value: nothing
  /// </summary>
  [FactorioRconDefinitionValue("nothing")]
  Nothing,

  /// <summary>
  /// Literal value: character-logistic-requests
  /// </summary>
  [FactorioRconDefinitionValue("character-logistic-requests")]
  CharacterLogisticRequests,

}

