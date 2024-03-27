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
/// A <see cref="String" /> specifying an entity prototype flag.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("EntityPrototypeFlag")]
public abstract partial class EntityPrototypeFlag: OneOfBase<Literal36937578, Literal64556810, Literal60208167, Literal1206379, Literal34984991, Literal7931792, Literal28695393, Literal26860048, Literal40743915, Literal40722866, Literal40112427, Literal22409705, Literal45901694, Literal56080734, Literal15728564, Literal53475173, Literal7276169, Literal9682309, Literal12351531, Literal22650100, Literal52873146, Literal56926232, Literal40248002, Literal26341382, Literal25702594, Literal7177733>
{
}

[GenerateOneOf]
public abstract partial class Union63754376: OneOfBase<Literal36937578, Literal64556810, Literal60208167, Literal1206379, Literal34984991, Literal7931792, Literal28695393, Literal26860048, Literal40743915, Literal40722866, Literal40112427, Literal22409705, Literal45901694, Literal56080734, Literal15728564, Literal53475173, Literal7276169, Literal9682309, Literal12351531, Literal22650100, Literal52873146, Literal56926232, Literal40248002, Literal26341382, Literal25702594, Literal7177733>
{
}

/// <summary>
/// Literal value: not-rotatable
/// </summary>
public enum Literal36937578
{
  /// <summary>
  /// Literal value: not-rotatable
  /// </summary>
  [FactorioRconDefinitionValue("not-rotatable")]
  NotRotatable,

}

/// <summary>
/// Literal value: placeable-neutral
/// </summary>
public enum Literal64556810
{
  /// <summary>
  /// Literal value: placeable-neutral
  /// </summary>
  [FactorioRconDefinitionValue("placeable-neutral")]
  PlaceableNeutral,

}

/// <summary>
/// Literal value: placeable-player
/// </summary>
public enum Literal60208167
{
  /// <summary>
  /// Literal value: placeable-player
  /// </summary>
  [FactorioRconDefinitionValue("placeable-player")]
  PlaceablePlayer,

}

/// <summary>
/// Literal value: placeable-enemy
/// </summary>
public enum Literal1206379
{
  /// <summary>
  /// Literal value: placeable-enemy
  /// </summary>
  [FactorioRconDefinitionValue("placeable-enemy")]
  PlaceableEnemy,

}

/// <summary>
/// Literal value: placeable-off-grid
/// </summary>
public enum Literal34984991
{
  /// <summary>
  /// Literal value: placeable-off-grid
  /// </summary>
  [FactorioRconDefinitionValue("placeable-off-grid")]
  PlaceableOffGrid,

}

/// <summary>
/// Literal value: player-creation
/// </summary>
public enum Literal7931792
{
  /// <summary>
  /// Literal value: player-creation
  /// </summary>
  [FactorioRconDefinitionValue("player-creation")]
  PlayerCreation,

}

/// <summary>
/// Literal value: building-direction-8-way
/// </summary>
public enum Literal28695393
{
  /// <summary>
  /// Literal value: building-direction-8-way
  /// </summary>
  [FactorioRconDefinitionValue("building-direction-8-way")]
  BuildingDirection8Way,

}

/// <summary>
/// Literal value: filter-directions
/// </summary>
public enum Literal26860048
{
  /// <summary>
  /// Literal value: filter-directions
  /// </summary>
  [FactorioRconDefinitionValue("filter-directions")]
  FilterDirections,

}

/// <summary>
/// Literal value: fast-replaceable-no-build-while-moving
/// </summary>
public enum Literal40743915
{
  /// <summary>
  /// Literal value: fast-replaceable-no-build-while-moving
  /// </summary>
  [FactorioRconDefinitionValue("fast-replaceable-no-build-while-moving")]
  FastReplaceableNoBuildWhileMoving,

}

/// <summary>
/// Literal value: breaths-air
/// </summary>
public enum Literal40722866
{
  /// <summary>
  /// Literal value: breaths-air
  /// </summary>
  [FactorioRconDefinitionValue("breaths-air")]
  BreathsAir,

}

/// <summary>
/// Literal value: not-repairable
/// </summary>
public enum Literal40112427
{
  /// <summary>
  /// Literal value: not-repairable
  /// </summary>
  [FactorioRconDefinitionValue("not-repairable")]
  NotRepairable,

}

/// <summary>
/// Literal value: not-on-map
/// </summary>
public enum Literal22409705
{
  /// <summary>
  /// Literal value: not-on-map
  /// </summary>
  [FactorioRconDefinitionValue("not-on-map")]
  NotOnMap,

}

/// <summary>
/// Literal value: not-deconstructable
/// </summary>
public enum Literal45901694
{
  /// <summary>
  /// Literal value: not-deconstructable
  /// </summary>
  [FactorioRconDefinitionValue("not-deconstructable")]
  NotDeconstructable,

}

/// <summary>
/// Literal value: not-blueprintable
/// </summary>
public enum Literal56080734
{
  /// <summary>
  /// Literal value: not-blueprintable
  /// </summary>
  [FactorioRconDefinitionValue("not-blueprintable")]
  NotBlueprintable,

}

/// <summary>
/// Literal value: hidden
/// </summary>
public enum Literal15728564
{
  /// <summary>
  /// Literal value: hidden
  /// </summary>
  [FactorioRconDefinitionValue("hidden")]
  Hidden,

}

/// <summary>
/// Literal value: hide-alt-info
/// </summary>
public enum Literal53475173
{
  /// <summary>
  /// Literal value: hide-alt-info
  /// </summary>
  [FactorioRconDefinitionValue("hide-alt-info")]
  HideAltInfo,

}

/// <summary>
/// Literal value: fast-replaceable-no-cross-type-while-moving
/// </summary>
public enum Literal7276169
{
  /// <summary>
  /// Literal value: fast-replaceable-no-cross-type-while-moving
  /// </summary>
  [FactorioRconDefinitionValue("fast-replaceable-no-cross-type-while-moving")]
  FastReplaceableNoCrossTypeWhileMoving,

}

/// <summary>
/// Literal value: no-gap-fill-while-building
/// </summary>
public enum Literal9682309
{
  /// <summary>
  /// Literal value: no-gap-fill-while-building
  /// </summary>
  [FactorioRconDefinitionValue("no-gap-fill-while-building")]
  NoGapFillWhileBuilding,

}

/// <summary>
/// Literal value: not-flammable
/// </summary>
public enum Literal12351531
{
  /// <summary>
  /// Literal value: not-flammable
  /// </summary>
  [FactorioRconDefinitionValue("not-flammable")]
  NotFlammable,

}

/// <summary>
/// Literal value: no-automated-item-removal
/// </summary>
public enum Literal22650100
{
  /// <summary>
  /// Literal value: no-automated-item-removal
  /// </summary>
  [FactorioRconDefinitionValue("no-automated-item-removal")]
  NoAutomatedItemRemoval,

}

/// <summary>
/// Literal value: no-automated-item-insertion
/// </summary>
public enum Literal52873146
{
  /// <summary>
  /// Literal value: no-automated-item-insertion
  /// </summary>
  [FactorioRconDefinitionValue("no-automated-item-insertion")]
  NoAutomatedItemInsertion,

}

/// <summary>
/// Literal value: no-copy-paste
/// </summary>
public enum Literal56926232
{
  /// <summary>
  /// Literal value: no-copy-paste
  /// </summary>
  [FactorioRconDefinitionValue("no-copy-paste")]
  NoCopyPaste,

}

/// <summary>
/// Literal value: not-selectable-in-game
/// </summary>
public enum Literal40248002
{
  /// <summary>
  /// Literal value: not-selectable-in-game
  /// </summary>
  [FactorioRconDefinitionValue("not-selectable-in-game")]
  NotSelectableInGame,

}

/// <summary>
/// Literal value: not-upgradable
/// </summary>
public enum Literal26341382
{
  /// <summary>
  /// Literal value: not-upgradable
  /// </summary>
  [FactorioRconDefinitionValue("not-upgradable")]
  NotUpgradable,

}

/// <summary>
/// Literal value: not-in-kill-statistics
/// </summary>
public enum Literal25702594
{
  /// <summary>
  /// Literal value: not-in-kill-statistics
  /// </summary>
  [FactorioRconDefinitionValue("not-in-kill-statistics")]
  NotInKillStatistics,

}

/// <summary>
/// Literal value: not-in-made-in
/// </summary>
public enum Literal7177733
{
  /// <summary>
  /// Literal value: not-in-made-in
  /// </summary>
  [FactorioRconDefinitionValue("not-in-made-in")]
  NotInMadeIn,

}

