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
/// A string that specifies how the inputs should be compared
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ComparatorString")]
public abstract partial class ComparatorString: OneOfBase<Literal31364015, Literal28379535, Literal64109423, Literal35236192, Literal21943666, Literal53052340, Literal5896758, Literal60375305, Literal46228029>
{
}

[GenerateOneOf]
public abstract partial class Union41622463: OneOfBase<Literal31364015, Literal28379535, Literal64109423, Literal35236192, Literal21943666, Literal53052340, Literal5896758, Literal60375305, Literal46228029>
{
}

/// <summary>
/// Literal value: =
/// </summary>
public abstract class Literal31364015
{
  /// <summary>
  /// Literal value: =
  /// </summary>
  [FactorioRconAttribute("=")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: >
/// </summary>
public abstract class Literal28379535
{
  /// <summary>
  /// Literal value: >
  /// </summary>
  [FactorioRconAttribute(">")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: <
/// </summary>
public abstract class Literal64109423
{
  /// <summary>
  /// Literal value: <
  /// </summary>
  [FactorioRconAttribute("<")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: ≥
/// </summary>
public abstract class Literal35236192
{
  /// <summary>
  /// Literal value: ≥
  /// </summary>
  [FactorioRconAttribute("≥")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: >=
/// </summary>
public abstract class Literal21943666
{
  /// <summary>
  /// Literal value: >=
  /// </summary>
  [FactorioRconAttribute(">=")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: ≤
/// </summary>
public abstract class Literal53052340
{
  /// <summary>
  /// Literal value: ≤
  /// </summary>
  [FactorioRconAttribute("≤")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: <=
/// </summary>
public abstract class Literal5896758
{
  /// <summary>
  /// Literal value: <=
  /// </summary>
  [FactorioRconAttribute("<=")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: ≠
/// </summary>
public abstract class Literal60375305
{
  /// <summary>
  /// Literal value: ≠
  /// </summary>
  [FactorioRconAttribute("≠")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: !=
/// </summary>
public abstract class Literal46228029
{
  /// <summary>
  /// Literal value: !=
  /// </summary>
  [FactorioRconAttribute("!=")]
  public static object Value { get; private set; }

}

