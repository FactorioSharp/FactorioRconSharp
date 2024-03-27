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
/// A <see cref="String" /> specifying an item prototype flag.
/// </summary>
[FactorioRconDefinition("ItemPrototypeFlag")]
public enum ItemPrototypeFlag
{
  /// <summary>
  /// Literal value: draw-logistic-overlay
  /// </summary>
  [FactorioRconDefinitionValue("draw-logistic-overlay")]
  Drawsubtractlogisticsubtractoverlay,

  /// <summary>
  /// Literal value: hidden
  /// </summary>
  [FactorioRconDefinitionValue("hidden")]
  Hidden,

  /// <summary>
  /// Literal value: always-show
  /// </summary>
  [FactorioRconDefinitionValue("always-show")]
  Alwayssubtractshow,

  /// <summary>
  /// Literal value: hide-from-bonus-gui
  /// </summary>
  [FactorioRconDefinitionValue("hide-from-bonus-gui")]
  Hidesubtractfromsubtractbonussubtractgui,

  /// <summary>
  /// Literal value: hide-from-fuel-tooltip
  /// </summary>
  [FactorioRconDefinitionValue("hide-from-fuel-tooltip")]
  Hidesubtractfromsubtractfuelsubtracttooltip,

  /// <summary>
  /// Literal value: not-stackable
  /// </summary>
  [FactorioRconDefinitionValue("not-stackable")]
  Notsubtractstackable,

  /// <summary>
  /// Literal value: can-extend-inventory
  /// </summary>
  [FactorioRconDefinitionValue("can-extend-inventory")]
  Cansubtractextendsubtractinventory,

  /// <summary>
  /// Literal value: primary-place-result
  /// </summary>
  [FactorioRconDefinitionValue("primary-place-result")]
  Primarysubtractplacesubtractresult,

  /// <summary>
  /// Literal value: mod-openable
  /// </summary>
  [FactorioRconDefinitionValue("mod-openable")]
  Modsubtractopenable,

  /// <summary>
  /// Literal value: only-in-cursor
  /// </summary>
  [FactorioRconDefinitionValue("only-in-cursor")]
  Onlysubtractinsubtractcursor,

  /// <summary>
  /// Literal value: spawnable
  /// </summary>
  [FactorioRconDefinitionValue("spawnable")]
  Spawnable,

}

