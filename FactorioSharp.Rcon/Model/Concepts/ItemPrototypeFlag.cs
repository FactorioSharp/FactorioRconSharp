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
/// A <see cref="String" /> specifying an item prototype flag.
/// </summary>
[FactorioRconDefinition("ItemPrototypeFlag")]
public enum ItemPrototypeFlag
{
  /// <summary>
  /// Literal value: draw-logistic-overlay
  /// </summary>
  [FactorioRconDefinitionValue("draw-logistic-overlay")]
  DrawLogisticOverlay,

  /// <summary>
  /// Literal value: hidden
  /// </summary>
  [FactorioRconDefinitionValue("hidden")]
  Hidden,

  /// <summary>
  /// Literal value: always-show
  /// </summary>
  [FactorioRconDefinitionValue("always-show")]
  AlwaysShow,

  /// <summary>
  /// Literal value: hide-from-bonus-gui
  /// </summary>
  [FactorioRconDefinitionValue("hide-from-bonus-gui")]
  HideFromBonusGui,

  /// <summary>
  /// Literal value: hide-from-fuel-tooltip
  /// </summary>
  [FactorioRconDefinitionValue("hide-from-fuel-tooltip")]
  HideFromFuelTooltip,

  /// <summary>
  /// Literal value: not-stackable
  /// </summary>
  [FactorioRconDefinitionValue("not-stackable")]
  NotStackable,

  /// <summary>
  /// Literal value: can-extend-inventory
  /// </summary>
  [FactorioRconDefinitionValue("can-extend-inventory")]
  CanExtendInventory,

  /// <summary>
  /// Literal value: primary-place-result
  /// </summary>
  [FactorioRconDefinitionValue("primary-place-result")]
  PrimaryPlaceResult,

  /// <summary>
  /// Literal value: mod-openable
  /// </summary>
  [FactorioRconDefinitionValue("mod-openable")]
  ModOpenable,

  /// <summary>
  /// Literal value: only-in-cursor
  /// </summary>
  [FactorioRconDefinitionValue("only-in-cursor")]
  OnlyInCursor,

  /// <summary>
  /// Literal value: spawnable
  /// </summary>
  [FactorioRconDefinitionValue("spawnable")]
  Spawnable,

}

