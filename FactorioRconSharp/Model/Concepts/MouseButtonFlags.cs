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
/// A set of flags. Active flags are in the dictionary as `true`, while inactive flags aren't present at all.
/// 
/// To write to this, use an array<see cref="String" />] of the mouse buttons that should be possible to use with on button. The flag `"left-and-right"` can also be set, which will set `"left"` and `"right"` to `true`.
/// </summary>
[FactorioRconConcept("MouseButtonFlags")]
public abstract class MouseButtonFlags: Dictionary<Union24083131, Literal27322174>
{
}

[GenerateOneOf]
public abstract partial class Union24083131: OneOfBase<Literal54145554, Literal26717201, Literal36601332, Literal54805688, Literal45861104, Literal54903627, Literal48701316, Literal3052046, Literal21400478>
{
}

/// <summary>
/// Literal value: left
/// </summary>
public abstract class Literal54145554
{
  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconAttribute("left")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: right
/// </summary>
public abstract class Literal26717201
{
  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconAttribute("right")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: middle
/// </summary>
public abstract class Literal36601332
{
  /// <summary>
  /// Literal value: middle
  /// </summary>
  [FactorioRconAttribute("middle")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: button-4
/// </summary>
public abstract class Literal54805688
{
  /// <summary>
  /// Literal value: button-4
  /// </summary>
  [FactorioRconAttribute("button-4")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: button-5
/// </summary>
public abstract class Literal45861104
{
  /// <summary>
  /// Literal value: button-5
  /// </summary>
  [FactorioRconAttribute("button-5")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: button-6
/// </summary>
public abstract class Literal54903627
{
  /// <summary>
  /// Literal value: button-6
  /// </summary>
  [FactorioRconAttribute("button-6")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: button-7
/// </summary>
public abstract class Literal48701316
{
  /// <summary>
  /// Literal value: button-7
  /// </summary>
  [FactorioRconAttribute("button-7")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: button-8
/// </summary>
public abstract class Literal3052046
{
  /// <summary>
  /// Literal value: button-8
  /// </summary>
  [FactorioRconAttribute("button-8")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: button-9
/// </summary>
public abstract class Literal21400478
{
  /// <summary>
  /// Literal value: button-9
  /// </summary>
  [FactorioRconAttribute("button-9")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: True
/// </summary>
public abstract class Literal27322174
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconAttribute("True")]
  public static object Value { get; private set; }

}

