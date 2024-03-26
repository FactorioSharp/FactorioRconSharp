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
public abstract partial class ItemPrototypeFlag: OneOfBase<Literal47484882, Literal12110199, Literal45424197, Literal2973708, Literal42918335, Literal44474540, Literal34945278, Literal17906896, Literal58575377, Literal19805307, Literal61707732>
{
}

[GenerateOneOf]
public abstract partial class Union44813449: OneOfBase<Literal47484882, Literal12110199, Literal45424197, Literal2973708, Literal42918335, Literal44474540, Literal34945278, Literal17906896, Literal58575377, Literal19805307, Literal61707732>
{
}

/// <summary>
/// Literal value: draw-logistic-overlay
/// </summary>
public abstract class Literal47484882
{
  /// <summary>
  /// Literal value: draw-logistic-overlay
  /// </summary>
  [FactorioRconAttribute("draw-logistic-overlay")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: hidden
/// </summary>
public abstract class Literal12110199
{
  /// <summary>
  /// Literal value: hidden
  /// </summary>
  [FactorioRconAttribute("hidden")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: always-show
/// </summary>
public abstract class Literal45424197
{
  /// <summary>
  /// Literal value: always-show
  /// </summary>
  [FactorioRconAttribute("always-show")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: hide-from-bonus-gui
/// </summary>
public abstract class Literal2973708
{
  /// <summary>
  /// Literal value: hide-from-bonus-gui
  /// </summary>
  [FactorioRconAttribute("hide-from-bonus-gui")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: hide-from-fuel-tooltip
/// </summary>
public abstract class Literal42918335
{
  /// <summary>
  /// Literal value: hide-from-fuel-tooltip
  /// </summary>
  [FactorioRconAttribute("hide-from-fuel-tooltip")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: not-stackable
/// </summary>
public abstract class Literal44474540
{
  /// <summary>
  /// Literal value: not-stackable
  /// </summary>
  [FactorioRconAttribute("not-stackable")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: can-extend-inventory
/// </summary>
public abstract class Literal34945278
{
  /// <summary>
  /// Literal value: can-extend-inventory
  /// </summary>
  [FactorioRconAttribute("can-extend-inventory")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: primary-place-result
/// </summary>
public abstract class Literal17906896
{
  /// <summary>
  /// Literal value: primary-place-result
  /// </summary>
  [FactorioRconAttribute("primary-place-result")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: mod-openable
/// </summary>
public abstract class Literal58575377
{
  /// <summary>
  /// Literal value: mod-openable
  /// </summary>
  [FactorioRconAttribute("mod-openable")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: only-in-cursor
/// </summary>
public abstract class Literal19805307
{
  /// <summary>
  /// Literal value: only-in-cursor
  /// </summary>
  [FactorioRconAttribute("only-in-cursor")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: spawnable
/// </summary>
public abstract class Literal61707732
{
  /// <summary>
  /// Literal value: spawnable
  /// </summary>
  [FactorioRconAttribute("spawnable")]
  public static object Value { get; private set; }

}

