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
/// A <see cref="String" /> specifying an entity prototype flag.
/// </summary>
[FactorioRconDefinition("EntityPrototypeFlag")]
public enum EntityPrototypeFlag
{
  /// <summary>
  /// Literal value: not-rotatable
  /// </summary>
  [FactorioRconDefinitionValue("not-rotatable")]
  NotRotatable,

  /// <summary>
  /// Literal value: placeable-neutral
  /// </summary>
  [FactorioRconDefinitionValue("placeable-neutral")]
  PlaceableNeutral,

  /// <summary>
  /// Literal value: placeable-player
  /// </summary>
  [FactorioRconDefinitionValue("placeable-player")]
  PlaceablePlayer,

  /// <summary>
  /// Literal value: placeable-enemy
  /// </summary>
  [FactorioRconDefinitionValue("placeable-enemy")]
  PlaceableEnemy,

  /// <summary>
  /// Literal value: placeable-off-grid
  /// </summary>
  [FactorioRconDefinitionValue("placeable-off-grid")]
  PlaceableOffGrid,

  /// <summary>
  /// Literal value: player-creation
  /// </summary>
  [FactorioRconDefinitionValue("player-creation")]
  PlayerCreation,

  /// <summary>
  /// Literal value: building-direction-8-way
  /// </summary>
  [FactorioRconDefinitionValue("building-direction-8-way")]
  BuildingDirection8Way,

  /// <summary>
  /// Literal value: filter-directions
  /// </summary>
  [FactorioRconDefinitionValue("filter-directions")]
  FilterDirections,

  /// <summary>
  /// Literal value: fast-replaceable-no-build-while-moving
  /// </summary>
  [FactorioRconDefinitionValue("fast-replaceable-no-build-while-moving")]
  FastReplaceableNoBuildWhileMoving,

  /// <summary>
  /// Literal value: breaths-air
  /// </summary>
  [FactorioRconDefinitionValue("breaths-air")]
  BreathsAir,

  /// <summary>
  /// Literal value: not-repairable
  /// </summary>
  [FactorioRconDefinitionValue("not-repairable")]
  NotRepairable,

  /// <summary>
  /// Literal value: not-on-map
  /// </summary>
  [FactorioRconDefinitionValue("not-on-map")]
  NotOnMap,

  /// <summary>
  /// Literal value: not-deconstructable
  /// </summary>
  [FactorioRconDefinitionValue("not-deconstructable")]
  NotDeconstructable,

  /// <summary>
  /// Literal value: not-blueprintable
  /// </summary>
  [FactorioRconDefinitionValue("not-blueprintable")]
  NotBlueprintable,

  /// <summary>
  /// Literal value: hidden
  /// </summary>
  [FactorioRconDefinitionValue("hidden")]
  Hidden,

  /// <summary>
  /// Literal value: hide-alt-info
  /// </summary>
  [FactorioRconDefinitionValue("hide-alt-info")]
  HideAltInfo,

  /// <summary>
  /// Literal value: fast-replaceable-no-cross-type-while-moving
  /// </summary>
  [FactorioRconDefinitionValue("fast-replaceable-no-cross-type-while-moving")]
  FastReplaceableNoCrossTypeWhileMoving,

  /// <summary>
  /// Literal value: no-gap-fill-while-building
  /// </summary>
  [FactorioRconDefinitionValue("no-gap-fill-while-building")]
  NoGapFillWhileBuilding,

  /// <summary>
  /// Literal value: not-flammable
  /// </summary>
  [FactorioRconDefinitionValue("not-flammable")]
  NotFlammable,

  /// <summary>
  /// Literal value: no-automated-item-removal
  /// </summary>
  [FactorioRconDefinitionValue("no-automated-item-removal")]
  NoAutomatedItemRemoval,

  /// <summary>
  /// Literal value: no-automated-item-insertion
  /// </summary>
  [FactorioRconDefinitionValue("no-automated-item-insertion")]
  NoAutomatedItemInsertion,

  /// <summary>
  /// Literal value: no-copy-paste
  /// </summary>
  [FactorioRconDefinitionValue("no-copy-paste")]
  NoCopyPaste,

  /// <summary>
  /// Literal value: not-selectable-in-game
  /// </summary>
  [FactorioRconDefinitionValue("not-selectable-in-game")]
  NotSelectableInGame,

  /// <summary>
  /// Literal value: not-upgradable
  /// </summary>
  [FactorioRconDefinitionValue("not-upgradable")]
  NotUpgradable,

  /// <summary>
  /// Literal value: not-in-kill-statistics
  /// </summary>
  [FactorioRconDefinitionValue("not-in-kill-statistics")]
  NotInKillStatistics,

  /// <summary>
  /// Literal value: not-in-made-in
  /// </summary>
  [FactorioRconDefinitionValue("not-in-made-in")]
  NotInMadeIn,

}

