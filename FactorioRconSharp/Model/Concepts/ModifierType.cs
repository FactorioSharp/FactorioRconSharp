#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

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
  Insertersubtractstacksubtractsizesubtractbonus,

  /// <summary>
  /// Literal value: stack-inserter-capacity-bonus
  /// </summary>
  [FactorioRconDefinitionValue("stack-inserter-capacity-bonus")]
  Stacksubtractinsertersubtractcapacitysubtractbonus,

  /// <summary>
  /// Literal value: laboratory-speed
  /// </summary>
  [FactorioRconDefinitionValue("laboratory-speed")]
  Laboratorysubtractspeed,

  /// <summary>
  /// Literal value: character-logistic-trash-slots
  /// </summary>
  [FactorioRconDefinitionValue("character-logistic-trash-slots")]
  Charactersubtractlogisticsubtracttrashsubtractslots,

  /// <summary>
  /// Literal value: maximum-following-robots-count
  /// </summary>
  [FactorioRconDefinitionValue("maximum-following-robots-count")]
  Maximumsubtractfollowingsubtractrobotssubtractcount,

  /// <summary>
  /// Literal value: worker-robot-speed
  /// </summary>
  [FactorioRconDefinitionValue("worker-robot-speed")]
  Workersubtractrobotsubtractspeed,

  /// <summary>
  /// Literal value: worker-robot-storage
  /// </summary>
  [FactorioRconDefinitionValue("worker-robot-storage")]
  Workersubtractrobotsubtractstorage,

  /// <summary>
  /// Literal value: ghost-time-to-live
  /// </summary>
  [FactorioRconDefinitionValue("ghost-time-to-live")]
  Ghostsubtracttimesubtracttosubtractlive,

  /// <summary>
  /// Literal value: turret-attack
  /// </summary>
  [FactorioRconDefinitionValue("turret-attack")]
  Turretsubtractattack,

  /// <summary>
  /// Literal value: ammo-damage
  /// </summary>
  [FactorioRconDefinitionValue("ammo-damage")]
  Ammosubtractdamage,

  /// <summary>
  /// Literal value: give-item
  /// </summary>
  [FactorioRconDefinitionValue("give-item")]
  Givesubtractitem,

  /// <summary>
  /// Literal value: gun-speed
  /// </summary>
  [FactorioRconDefinitionValue("gun-speed")]
  Gunsubtractspeed,

  /// <summary>
  /// Literal value: unlock-recipe
  /// </summary>
  [FactorioRconDefinitionValue("unlock-recipe")]
  Unlocksubtractrecipe,

  /// <summary>
  /// Literal value: character-crafting-speed
  /// </summary>
  [FactorioRconDefinitionValue("character-crafting-speed")]
  Charactersubtractcraftingsubtractspeed,

  /// <summary>
  /// Literal value: character-mining-speed
  /// </summary>
  [FactorioRconDefinitionValue("character-mining-speed")]
  Charactersubtractminingsubtractspeed,

  /// <summary>
  /// Literal value: character-running-speed
  /// </summary>
  [FactorioRconDefinitionValue("character-running-speed")]
  Charactersubtractrunningsubtractspeed,

  /// <summary>
  /// Literal value: character-build-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-build-distance")]
  Charactersubtractbuildsubtractdistance,

  /// <summary>
  /// Literal value: character-item-drop-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-item-drop-distance")]
  Charactersubtractitemsubtractdropsubtractdistance,

  /// <summary>
  /// Literal value: character-reach-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-reach-distance")]
  Charactersubtractreachsubtractdistance,

  /// <summary>
  /// Literal value: character-resource-reach-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-resource-reach-distance")]
  Charactersubtractresourcesubtractreachsubtractdistance,

  /// <summary>
  /// Literal value: character-item-pickup-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-item-pickup-distance")]
  Charactersubtractitemsubtractpickupsubtractdistance,

  /// <summary>
  /// Literal value: character-loot-pickup-distance
  /// </summary>
  [FactorioRconDefinitionValue("character-loot-pickup-distance")]
  Charactersubtractlootsubtractpickupsubtractdistance,

  /// <summary>
  /// Literal value: character-inventory-slots-bonus
  /// </summary>
  [FactorioRconDefinitionValue("character-inventory-slots-bonus")]
  Charactersubtractinventorysubtractslotssubtractbonus,

  /// <summary>
  /// Literal value: deconstruction-time-to-live
  /// </summary>
  [FactorioRconDefinitionValue("deconstruction-time-to-live")]
  Deconstructionsubtracttimesubtracttosubtractlive,

  /// <summary>
  /// Literal value: max-failed-attempts-per-tick-per-construction-queue
  /// </summary>
  [FactorioRconDefinitionValue("max-failed-attempts-per-tick-per-construction-queue")]
  Maxsubtractfailedsubtractattemptssubtractpersubtractticksubtractpersubtractconstructionsubtractqueue,

  /// <summary>
  /// Literal value: max-successful-attempts-per-tick-per-construction-queue
  /// </summary>
  [FactorioRconDefinitionValue("max-successful-attempts-per-tick-per-construction-queue")]
  Maxsubtractsuccessfulsubtractattemptssubtractpersubtractticksubtractpersubtractconstructionsubtractqueue,

  /// <summary>
  /// Literal value: character-health-bonus
  /// </summary>
  [FactorioRconDefinitionValue("character-health-bonus")]
  Charactersubtracthealthsubtractbonus,

  /// <summary>
  /// Literal value: mining-drill-productivity-bonus
  /// </summary>
  [FactorioRconDefinitionValue("mining-drill-productivity-bonus")]
  Miningsubtractdrillsubtractproductivitysubtractbonus,

  /// <summary>
  /// Literal value: train-braking-force-bonus
  /// </summary>
  [FactorioRconDefinitionValue("train-braking-force-bonus")]
  Trainsubtractbrakingsubtractforcesubtractbonus,

  /// <summary>
  /// Literal value: zoom-to-world-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-enabled")]
  Zoomsubtracttosubtractworldsubtractenabled,

  /// <summary>
  /// Literal value: zoom-to-world-ghost-building-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-ghost-building-enabled")]
  Zoomsubtracttosubtractworldsubtractghostsubtractbuildingsubtractenabled,

  /// <summary>
  /// Literal value: zoom-to-world-blueprint-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-blueprint-enabled")]
  Zoomsubtracttosubtractworldsubtractblueprintsubtractenabled,

  /// <summary>
  /// Literal value: zoom-to-world-deconstruction-planner-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-deconstruction-planner-enabled")]
  Zoomsubtracttosubtractworldsubtractdeconstructionsubtractplannersubtractenabled,

  /// <summary>
  /// Literal value: zoom-to-world-upgrade-planner-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-upgrade-planner-enabled")]
  Zoomsubtracttosubtractworldsubtractupgradesubtractplannersubtractenabled,

  /// <summary>
  /// Literal value: zoom-to-world-selection-tool-enabled
  /// </summary>
  [FactorioRconDefinitionValue("zoom-to-world-selection-tool-enabled")]
  Zoomsubtracttosubtractworldsubtractselectionsubtracttoolsubtractenabled,

  /// <summary>
  /// Literal value: worker-robot-battery
  /// </summary>
  [FactorioRconDefinitionValue("worker-robot-battery")]
  Workersubtractrobotsubtractbattery,

  /// <summary>
  /// Literal value: laboratory-productivity
  /// </summary>
  [FactorioRconDefinitionValue("laboratory-productivity")]
  Laboratorysubtractproductivity,

  /// <summary>
  /// Literal value: follower-robot-lifetime
  /// </summary>
  [FactorioRconDefinitionValue("follower-robot-lifetime")]
  Followersubtractrobotsubtractlifetime,

  /// <summary>
  /// Literal value: artillery-range
  /// </summary>
  [FactorioRconDefinitionValue("artillery-range")]
  Artillerysubtractrange,

  /// <summary>
  /// Literal value: nothing
  /// </summary>
  [FactorioRconDefinitionValue("nothing")]
  Nothing,

  /// <summary>
  /// Literal value: character-logistic-requests
  /// </summary>
  [FactorioRconDefinitionValue("character-logistic-requests")]
  Charactersubtractlogisticsubtractrequests,

}

