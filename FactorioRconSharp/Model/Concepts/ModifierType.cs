#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Used by <see cref="TechnologyModifier" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ModifierType")]
public abstract partial class ModifierType: OneOfBase<Literal39770002, Literal12479393, Literal26358080, Literal26186834, Literal21220699, Literal11420501, Literal62759096, Literal8074472, Literal32833118, Literal12636345, Literal30909699, Literal23966053, Literal23926925, Literal22792188, Literal56993681, Literal42204026, Literal15957206, Literal60105805, Literal65346770, Literal16008149, Literal61583146, Literal41080798, Literal50492470, Literal54995495, Literal51365498, Literal13204446, Literal47384621, Literal31976736, Literal54910132, Literal48889980, Literal8523303, Literal45849200, Literal54558410, Literal38690026, Literal48268948, Literal57622216, Literal60431530, Literal7683927, Literal21507300, Literal19731926, Literal35354950>
{
}

[GenerateOneOf]
public abstract partial class Union1371379: OneOfBase<Literal39770002, Literal12479393, Literal26358080, Literal26186834, Literal21220699, Literal11420501, Literal62759096, Literal8074472, Literal32833118, Literal12636345, Literal30909699, Literal23966053, Literal23926925, Literal22792188, Literal56993681, Literal42204026, Literal15957206, Literal60105805, Literal65346770, Literal16008149, Literal61583146, Literal41080798, Literal50492470, Literal54995495, Literal51365498, Literal13204446, Literal47384621, Literal31976736, Literal54910132, Literal48889980, Literal8523303, Literal45849200, Literal54558410, Literal38690026, Literal48268948, Literal57622216, Literal60431530, Literal7683927, Literal21507300, Literal19731926, Literal35354950>
{
}

/// <summary>
/// Literal value: inserter-stack-size-bonus
/// </summary>
public enum Literal39770002
{
  /// <summary>
  /// Literal value: inserter-stack-size-bonus
  /// </summary>
  [FactorioRconDefinitionValue("inserter-stack-size-bonus")]
  InserterStackSizeBonus,

}

/// <summary>
/// Literal value: stack-inserter-capacity-bonus
/// </summary>
public enum Literal12479393
{
  /// <summary>
  /// Literal value: stack-inserter-capacity-bonus
  /// </summary>
  [FactorioRconDefinitionValue("stack-inserter-capacity-bonus")]
  StackInserterCapacityBonus,

}

/// <summary>
/// Literal value: laboratory-speed
/// </summary>
public enum Literal26358080
{
  /// <summary>
  /// Literal value: laboratory-speed
  /// </summary>
  [FactorioRconDefinitionValue("laboratory-speed")]
  LaboratorySpeed,

}

/// <summary>
/// Literal value: character-logistic-trash-slots
/// </summary>
public enum Literal26186834
{
  /// <summary>
  /// Literal value: character-logistic-trash-slots
  /// </summary>
  [FactorioRconDefinitionValue("character-logistic-trash-slots")]
  CharacterLogisticTrashSlots,

}

/// <summary>
/// Literal value: maximum-following-robots-count
/// </summary>
public enum Literal21220699
{
  /// <summary>
  /// Literal value: maximum-following-robots-count
  /// </summary>
  [FactorioRconDefinitionValue("maximum-following-robots-count")]
  MaximumFollowingRobotsCount,

}

/// <summary>
/// Literal value: worker-robot-speed
/// </summary>
public enum Literal11420501
{
  /// <summary>
  /// Literal value: worker-robot-speed
  /// </summary>
  [FactorioRconDefinitionValue("worker-robot-speed")]
  WorkerRobotSpeed,

}

/// <summary>
/// Literal value: worker-robot-storage
/// </summary>
public enum Literal62759096
{
  /// <summary>
  /// Literal value: worker-robot-storage
  /// </summary>
  [FactorioRconDefinitionValue("worker-robot-storage")]
  WorkerRobotStorage,

}

/// <summary>
/// Literal value: ghost-time-to-live
/// </summary>
public enum Literal8074472
{
  /// <summary>
  /// Literal value: ghost-time-to-live
  /// </summary>
  [FactorioRconDefinitionValue("ghost-time-to-live")]
  GhostTimeToLive,

}

/// <summary>
/// Literal value: turret-attack
/// </summary>
public enum Literal32833118
{
  /// <summary>
  /// Literal value: turret-attack
  /// </summary>
  [FactorioRconDefinitionValue("turret-attack")]
  TurretAttack,

}

/// <summary>
/// Literal value: ammo-damage
/// </summary>
public enum Literal12636345
{
  /// <summary>
  /// Literal value: ammo-damage
  /// </summary>
  [FactorioRconDefinitionValue("ammo-damage")]
  AmmoDamage,

}

/// <summary>
/// Literal value: give-item
/// </summary>
public enum Literal30909699
{
  /// <summary>
  /// Literal value: give-item
  /// </summary>
  [FactorioRconDefinitionValue("give-item")]
  GiveItem,

}

/// <summary>
/// Literal value: gun-speed
/// </summary>
public enum Literal23966053
{
  /// <summary>
  /// Literal value: gun-speed
  /// </summary>
  [FactorioRconDefinitionValue("gun-speed")]
  GunSpeed,

}

/// <summary>
/// Literal value: unlock-recipe
/// </summary>
public enum Literal23926925
{
  /// <summary>
  /// Literal value: unlock-recipe
  /// </summary>
  [FactorioRconDefinitionValue("unlock-recipe")]
  UnlockRecipe,

}

/// <summary>
/// Literal value: character-crafting-speed
/// </summary>
public enum Literal22792188
{
  /// <summary>
  /// Literal value: character-crafting-speed
  /// </summary>
  [FactorioRconDefinitionValue("character-crafting-speed")]
  CharacterCraftingSpeed,

}

/// <summary>
/// Literal value: character-mining-speed
/// </summary>
public enum Literal56993681
{
  /// <summary>
  /// Literal value: character-mining-speed
  /// </summary>
  [FactorioRconDefinitionValue("character-mining-speed")]
  CharacterMiningSpeed,

}

/// <summary>
/// Literal value: character-running-speed
/// </summary>
public enum Literal42204026
{
  /// <summary>
  /// Literal value: character-running-speed
  /// </summary>
  [FactorioRconDefinitionValue("character-running-speed")]
  CharacterRunningSpeed,

}

/// <summary>
/// Literal value: character-build-distance
/// </summary>
public enum Literal15957206
{
  /// <summary>
  /// Literal value: character-build-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-build-distance")]
  CharacterBuildDistance,

}

/// <summary>
/// Literal value: character-item-drop-distance
/// </summary>
public enum Literal60105805
{
  /// <summary>
  /// Literal value: character-item-drop-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-item-drop-distance")]
  CharacterItemDropDistance,

}

/// <summary>
/// Literal value: character-reach-distance
/// </summary>
public enum Literal65346770
{
  /// <summary>
  /// Literal value: character-reach-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-reach-distance")]
  CharacterReachDistance,

}

/// <summary>
/// Literal value: character-resource-reach-distance
/// </summary>
public enum Literal16008149
{
  /// <summary>
  /// Literal value: character-resource-reach-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-resource-reach-distance")]
  CharacterResourceReachDistance,

}

/// <summary>
/// Literal value: character-item-pickup-distance
/// </summary>
public enum Literal61583146
{
  /// <summary>
  /// Literal value: character-item-pickup-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-item-pickup-distance")]
  CharacterItemPickupDistance,

}

/// <summary>
/// Literal value: character-loot-pickup-distance
/// </summary>
public enum Literal41080798
{
  /// <summary>
  /// Literal value: character-loot-pickup-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-loot-pickup-distance")]
  CharacterLootPickupDistance,

}

/// <summary>
/// Literal value: character-inventory-slots-bonus
/// </summary>
public enum Literal50492470
{
  /// <summary>
  /// Literal value: character-inventory-slots-bonus
  /// </summary>
  [FactorioRconDefinitionValue("character-inventory-slots-bonus")]
  CharacterInventorySlotsBonus,

}

/// <summary>
/// Literal value: deconstruction-time-to-live
/// </summary>
public enum Literal54995495
{
  /// <summary>
  /// Literal value: deconstruction-time-to-live
  /// </summary>
  [FactorioRconDefinitionValue("deconstruction-time-to-live")]
  DeconstructionTimeToLive,

}

/// <summary>
/// Literal value: max-failed-attempts-per-tick-per-construction-queue
/// </summary>
public enum Literal51365498
{
  /// <summary>
  /// Literal value: max-failed-attempts-per-tick-per-construction-queue
  /// </summary>
  [FactorioRconDefinitionValue("max-failed-attempts-per-tick-per-construction-queue")]
  MaxFailedAttemptsPerTickPerConstructionQueue,

}

/// <summary>
/// Literal value: max-successful-attempts-per-tick-per-construction-queue
/// </summary>
public enum Literal13204446
{
  /// <summary>
  /// Literal value: max-successful-attempts-per-tick-per-construction-queue
  /// </summary>
  [FactorioRconDefinitionValue("max-successful-attempts-per-tick-per-construction-queue")]
  MaxSuccessfulAttemptsPerTickPerConstructionQueue,

}

/// <summary>
/// Literal value: character-health-bonus
/// </summary>
public enum Literal47384621
{
  /// <summary>
  /// Literal value: character-health-bonus
  /// </summary>
  [FactorioRconDefinitionValue("character-health-bonus")]
  CharacterHealthBonus,

}

/// <summary>
/// Literal value: mining-drill-productivity-bonus
/// </summary>
public enum Literal31976736
{
  /// <summary>
  /// Literal value: mining-drill-productivity-bonus
  /// </summary>
  [FactorioRconDefinitionValue("mining-drill-productivity-bonus")]
  MiningDrillProductivityBonus,

}

/// <summary>
/// Literal value: train-braking-force-bonus
/// </summary>
public enum Literal54910132
{
  /// <summary>
  /// Literal value: train-braking-force-bonus
  /// </summary>
  [FactorioRconDefinitionValue("train-braking-force-bonus")]
  TrainBrakingForceBonus,

}

/// <summary>
/// Literal value: zoom-to-world-enabled
/// </summary>
public enum Literal48889980
{
  /// <summary>
  /// Literal value: zoom-to-world-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-enabled")]
  ZoomToWorldEnabled,

}

/// <summary>
/// Literal value: zoom-to-world-ghost-building-enabled
/// </summary>
public enum Literal8523303
{
  /// <summary>
  /// Literal value: zoom-to-world-ghost-building-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-ghost-building-enabled")]
  ZoomToWorldGhostBuildingEnabled,

}

/// <summary>
/// Literal value: zoom-to-world-blueprint-enabled
/// </summary>
public enum Literal45849200
{
  /// <summary>
  /// Literal value: zoom-to-world-blueprint-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-blueprint-enabled")]
  ZoomToWorldBlueprintEnabled,

}

/// <summary>
/// Literal value: zoom-to-world-deconstruction-planner-enabled
/// </summary>
public enum Literal54558410
{
  /// <summary>
  /// Literal value: zoom-to-world-deconstruction-planner-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-deconstruction-planner-enabled")]
  ZoomToWorldDeconstructionPlannerEnabled,

}

/// <summary>
/// Literal value: zoom-to-world-upgrade-planner-enabled
/// </summary>
public enum Literal38690026
{
  /// <summary>
  /// Literal value: zoom-to-world-upgrade-planner-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-upgrade-planner-enabled")]
  ZoomToWorldUpgradePlannerEnabled,

}

/// <summary>
/// Literal value: zoom-to-world-selection-tool-enabled
/// </summary>
public enum Literal48268948
{
  /// <summary>
  /// Literal value: zoom-to-world-selection-tool-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-selection-tool-enabled")]
  ZoomToWorldSelectionToolEnabled,

}

/// <summary>
/// Literal value: worker-robot-battery
/// </summary>
public enum Literal57622216
{
  /// <summary>
  /// Literal value: worker-robot-battery
  /// </summary>
  [FactorioRconDefinitionValue("worker-robot-battery")]
  WorkerRobotBattery,

}

/// <summary>
/// Literal value: laboratory-productivity
/// </summary>
public enum Literal60431530
{
  /// <summary>
  /// Literal value: laboratory-productivity
  /// </summary>
  [FactorioRconDefinitionValue("laboratory-productivity")]
  LaboratoryProductivity,

}

/// <summary>
/// Literal value: follower-robot-lifetime
/// </summary>
public enum Literal7683927
{
  /// <summary>
  /// Literal value: follower-robot-lifetime
  /// </summary>
  [FactorioRconDefinitionValue("follower-robot-lifetime")]
  FollowerRobotLifetime,

}

/// <summary>
/// Literal value: artillery-range
/// </summary>
public enum Literal21507300
{
  /// <summary>
  /// Literal value: artillery-range
  /// </summary>
  [FactorioRconDefinitionValue("artillery-range")]
  ArtilleryRange,

}

/// <summary>
/// Literal value: nothing
/// </summary>
public enum Literal19731926
{
  /// <summary>
  /// Literal value: nothing
  /// </summary>
  [FactorioRconDefinitionValue("nothing")]
  Nothing,

}

/// <summary>
/// Literal value: character-logistic-requests
/// </summary>
public enum Literal35354950
{
  /// <summary>
  /// Literal value: character-logistic-requests
  /// </summary>
  [FactorioRconDefinitionValue("character-logistic-requests")]
  CharacterLogisticRequests,

}

