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
/// A <see cref="String" /> specifying an item prototype flag.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ItemPrototypeFlag")]
public abstract partial class ItemPrototypeFlag: OneOfBase<Literal19967849, Literal42196733, Literal15745719, Literal53972668, Literal21703524, Literal25422420, Literal66161566, Literal39637243, Literal8629381, Literal48925463, Literal9552293>
{
}

[GenerateOneOf]
public abstract partial class Union26143632: OneOfBase<Literal19967849, Literal42196733, Literal15745719, Literal53972668, Literal21703524, Literal25422420, Literal66161566, Literal39637243, Literal8629381, Literal48925463, Literal9552293>
{
}

/// <summary>
/// Literal value: draw-logistic-overlay
/// </summary>
public enum Literal19967849
{
  /// <summary>
  /// Literal value: draw-logistic-overlay
  /// </summary>
  [FactorioRconDefinitionValue("draw-logistic-overlay")]
  DrawLogisticOverlay,

}

/// <summary>
/// Literal value: hidden
/// </summary>
public enum Literal42196733
{
  /// <summary>
  /// Literal value: hidden
  /// </summary>
  [FactorioRconDefinitionValue("hidden")]
  Hidden,

}

/// <summary>
/// Literal value: always-show
/// </summary>
public enum Literal15745719
{
  /// <summary>
  /// Literal value: always-show
  /// </summary>
  [FactorioRconDefinitionValue("always-show")]
  AlwaysShow,

}

/// <summary>
/// Literal value: hide-from-bonus-gui
/// </summary>
public enum Literal53972668
{
  /// <summary>
  /// Literal value: hide-from-bonus-gui
  /// </summary>
  [FactorioRconDefinitionValue("hide-from-bonus-gui")]
  HideFromBonusGui,

}

/// <summary>
/// Literal value: hide-from-fuel-tooltip
/// </summary>
public enum Literal21703524
{
  /// <summary>
  /// Literal value: hide-from-fuel-tooltip
  /// </summary>
  [FactorioRconDefinitionValue("hide-from-fuel-tooltip")]
  HideFromFuelTooltip,

}

/// <summary>
/// Literal value: not-stackable
/// </summary>
public enum Literal25422420
{
  /// <summary>
  /// Literal value: not-stackable
  /// </summary>
  [FactorioRconDefinitionValue("not-stackable")]
  NotStackable,

}

/// <summary>
/// Literal value: can-extend-inventory
/// </summary>
public enum Literal66161566
{
  /// <summary>
  /// Literal value: can-extend-inventory
  /// </summary>
  [FactorioRconDefinitionValue("can-extend-inventory")]
  CanExtendInventory,

}

/// <summary>
/// Literal value: primary-place-result
/// </summary>
public enum Literal39637243
{
  /// <summary>
  /// Literal value: primary-place-result
  /// </summary>
  [FactorioRconDefinitionValue("primary-place-result")]
  PrimaryPlaceResult,

}

/// <summary>
/// Literal value: mod-openable
/// </summary>
public enum Literal8629381
{
  /// <summary>
  /// Literal value: mod-openable
  /// </summary>
  [FactorioRconDefinitionValue("mod-openable")]
  ModOpenable,

}

/// <summary>
/// Literal value: only-in-cursor
/// </summary>
public enum Literal48925463
{
  /// <summary>
  /// Literal value: only-in-cursor
  /// </summary>
  [FactorioRconDefinitionValue("only-in-cursor")]
  OnlyInCursor,

}

/// <summary>
/// Literal value: spawnable
/// </summary>
public enum Literal9552293
{
  /// <summary>
  /// Literal value: spawnable
  /// </summary>
  [FactorioRconDefinitionValue("spawnable")]
  Spawnable,

}

