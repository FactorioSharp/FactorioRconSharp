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
  Notsubtractrotatable,

  /// <summary>
  /// Literal value: placeable-neutral
  /// </summary>
  [FactorioRconDefinitionValue("placeable-neutral")]
  Placeablesubtractneutral,

  /// <summary>
  /// Literal value: placeable-player
  /// </summary>
  [FactorioRconDefinitionValue("placeable-player")]
  Placeablesubtractplayer,

  /// <summary>
  /// Literal value: placeable-enemy
  /// </summary>
  [FactorioRconDefinitionValue("placeable-enemy")]
  Placeablesubtractenemy,

  /// <summary>
  /// Literal value: placeable-off-grid
  /// </summary>
  [FactorioRconDefinitionValue("placeable-off-grid")]
  Placeablesubtractoffsubtractgrid,

  /// <summary>
  /// Literal value: player-creation
  /// </summary>
  [FactorioRconDefinitionValue("player-creation")]
  Playersubtractcreation,

  /// <summary>
  /// Literal value: building-direction-8-way
  /// </summary>
  [FactorioRconDefinitionValue("building-direction-8-way")]
  Buildingsubtractdirectionsubtract8subtractway,

  /// <summary>
  /// Literal value: filter-directions
  /// </summary>
  [FactorioRconDefinitionValue("filter-directions")]
  Filtersubtractdirections,

  /// <summary>
  /// Literal value: fast-replaceable-no-build-while-moving
  /// </summary>
  [FactorioRconDefinitionValue("fast-replaceable-no-build-while-moving")]
  Fastsubtractreplaceablesubtractnosubtractbuildsubtractwhilesubtractmoving,

  /// <summary>
  /// Literal value: breaths-air
  /// </summary>
  [FactorioRconDefinitionValue("breaths-air")]
  Breathssubtractair,

  /// <summary>
  /// Literal value: not-repairable
  /// </summary>
  [FactorioRconDefinitionValue("not-repairable")]
  Notsubtractrepairable,

  /// <summary>
  /// Literal value: not-on-map
  /// </summary>
  [FactorioRconDefinitionValue("not-on-map")]
  Notsubtractonsubtractmap,

  /// <summary>
  /// Literal value: not-deconstructable
  /// </summary>
  [FactorioRconDefinitionValue("not-deconstructable")]
  Notsubtractdeconstructable,

  /// <summary>
  /// Literal value: not-blueprintable
  /// </summary>
  [FactorioRconDefinitionValue("not-blueprintable")]
  Notsubtractblueprintable,

  /// <summary>
  /// Literal value: hidden
  /// </summary>
  [FactorioRconDefinitionValue("hidden")]
  Hidden,

  /// <summary>
  /// Literal value: hide-alt-info
  /// </summary>
  [FactorioRconDefinitionValue("hide-alt-info")]
  Hidesubtractaltsubtractinfo,

  /// <summary>
  /// Literal value: fast-replaceable-no-cross-type-while-moving
  /// </summary>
  [FactorioRconDefinitionValue("fast-replaceable-no-cross-type-while-moving")]
  Fastsubtractreplaceablesubtractnosubtractcrosssubtracttypesubtractwhilesubtractmoving,

  /// <summary>
  /// Literal value: no-gap-fill-while-building
  /// </summary>
  [FactorioRconDefinitionValue("no-gap-fill-while-building")]
  Nosubtractgapsubtractfillsubtractwhilesubtractbuilding,

  /// <summary>
  /// Literal value: not-flammable
  /// </summary>
  [FactorioRconDefinitionValue("not-flammable")]
  Notsubtractflammable,

  /// <summary>
  /// Literal value: no-automated-item-removal
  /// </summary>
  [FactorioRconDefinitionValue("no-automated-item-removal")]
  Nosubtractautomatedsubtractitemsubtractremoval,

  /// <summary>
  /// Literal value: no-automated-item-insertion
  /// </summary>
  [FactorioRconDefinitionValue("no-automated-item-insertion")]
  Nosubtractautomatedsubtractitemsubtractinsertion,

  /// <summary>
  /// Literal value: no-copy-paste
  /// </summary>
  [FactorioRconDefinitionValue("no-copy-paste")]
  Nosubtractcopysubtractpaste,

  /// <summary>
  /// Literal value: not-selectable-in-game
  /// </summary>
  [FactorioRconDefinitionValue("not-selectable-in-game")]
  Notsubtractselectablesubtractinsubtractgame,

  /// <summary>
  /// Literal value: not-upgradable
  /// </summary>
  [FactorioRconDefinitionValue("not-upgradable")]
  Notsubtractupgradable,

  /// <summary>
  /// Literal value: not-in-kill-statistics
  /// </summary>
  [FactorioRconDefinitionValue("not-in-kill-statistics")]
  Notsubtractinsubtractkillsubtractstatistics,

  /// <summary>
  /// Literal value: not-in-made-in
  /// </summary>
  [FactorioRconDefinitionValue("not-in-made-in")]
  Notsubtractinsubtractmadesubtractin,

}

