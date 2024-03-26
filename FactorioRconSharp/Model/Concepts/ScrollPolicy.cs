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
/// Scroll policy of a <see cref="LuaGuiElement" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ScrollPolicy")]
public abstract partial class ScrollPolicy: OneOfBase<Literal13799077, Literal40803818, Literal33346292, Literal25853278, Literal17047191>
{
}

[GenerateOneOf]
public abstract partial class Union23951738: OneOfBase<Literal13799077, Literal40803818, Literal33346292, Literal25853278, Literal17047191>
{
}

/// <summary>
/// Literal value: never
/// </summary>
public abstract class Literal13799077
{
  /// <summary>
  /// Literal value: never
  /// </summary>
  [FactorioRconAttribute("never")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: dont-show-but-allow-scrolling
/// </summary>
public abstract class Literal40803818
{
  /// <summary>
  /// Literal value: dont-show-but-allow-scrolling
  /// </summary>
  [FactorioRconAttribute("dont-show-but-allow-scrolling")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: always
/// </summary>
public abstract class Literal33346292
{
  /// <summary>
  /// Literal value: always
  /// </summary>
  [FactorioRconAttribute("always")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: auto
/// </summary>
public abstract class Literal25853278
{
  /// <summary>
  /// Literal value: auto
  /// </summary>
  [FactorioRconAttribute("auto")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: auto-and-reserve-space
/// </summary>
public abstract class Literal17047191
{
  /// <summary>
  /// Literal value: auto-and-reserve-space
  /// </summary>
  [FactorioRconAttribute("auto-and-reserve-space")]
  public static object Value { get; private set; }

}

