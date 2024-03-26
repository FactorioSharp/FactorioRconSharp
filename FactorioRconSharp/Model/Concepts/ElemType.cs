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
/// A <see cref="LuaGuiElement.ElemTooltip" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ElemType")]
public abstract partial class ElemType: OneOfBase<Literal40196552, Literal51417822, Literal19066549, Literal25216348, Literal26833123, Literal13077851, Literal28915924, Literal14701405, Literal15384326, Literal37920736, Literal43424763>
{
}

[GenerateOneOf]
public abstract partial class Union7318883: OneOfBase<Literal40196552, Literal51417822, Literal19066549, Literal25216348, Literal26833123, Literal13077851, Literal28915924, Literal14701405, Literal15384326, Literal37920736, Literal43424763>
{
}

/// <summary>
/// Literal value: achievement
/// </summary>
public abstract class Literal40196552
{
  /// <summary>
  /// Literal value: achievement
  /// </summary>
  [FactorioRconAttribute("achievement")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: decorative
/// </summary>
public abstract class Literal51417822
{
  /// <summary>
  /// Literal value: decorative
  /// </summary>
  [FactorioRconAttribute("decorative")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: entity
/// </summary>
public abstract class Literal19066549
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconAttribute("entity")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: equipment
/// </summary>
public abstract class Literal25216348
{
  /// <summary>
  /// Literal value: equipment
  /// </summary>
  [FactorioRconAttribute("equipment")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: fluid
/// </summary>
public abstract class Literal26833123
{
  /// <summary>
  /// Literal value: fluid
  /// </summary>
  [FactorioRconAttribute("fluid")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: item
/// </summary>
public abstract class Literal13077851
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconAttribute("item")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: item-group
/// </summary>
public abstract class Literal28915924
{
  /// <summary>
  /// Literal value: item-group
  /// </summary>
  [FactorioRconAttribute("item-group")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: recipe
/// </summary>
public abstract class Literal14701405
{
  /// <summary>
  /// Literal value: recipe
  /// </summary>
  [FactorioRconAttribute("recipe")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: signal
/// </summary>
public abstract class Literal15384326
{
  /// <summary>
  /// Literal value: signal
  /// </summary>
  [FactorioRconAttribute("signal")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: technology
/// </summary>
public abstract class Literal37920736
{
  /// <summary>
  /// Literal value: technology
  /// </summary>
  [FactorioRconAttribute("technology")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: tile
/// </summary>
public abstract class Literal43424763
{
  /// <summary>
  /// Literal value: tile
  /// </summary>
  [FactorioRconAttribute("tile")]
  public static object Value { get; private set; }

}

