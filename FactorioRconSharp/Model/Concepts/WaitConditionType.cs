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
/// Type of a <see cref="WaitCondition" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("WaitConditionType")]
public abstract partial class WaitConditionType: OneOfBase<Literal27077418, Literal31754879, Literal62872692, Literal45258134, Literal10896719, Literal27504513, Literal40723880, Literal49895113, Literal41164413, Literal59146305>
{
}

[GenerateOneOf]
public abstract partial class Union55615624: OneOfBase<Literal27077418, Literal31754879, Literal62872692, Literal45258134, Literal10896719, Literal27504513, Literal40723880, Literal49895113, Literal41164413, Literal59146305>
{
}

/// <summary>
/// Literal value: time
/// </summary>
public abstract class Literal27077418
{
  /// <summary>
  /// Literal value: time
  /// </summary>
  [FactorioRconAttribute("time")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: full
/// </summary>
public abstract class Literal31754879
{
  /// <summary>
  /// Literal value: full
  /// </summary>
  [FactorioRconAttribute("full")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: empty
/// </summary>
public abstract class Literal62872692
{
  /// <summary>
  /// Literal value: empty
  /// </summary>
  [FactorioRconAttribute("empty")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: item_count
/// </summary>
public abstract class Literal45258134
{
  /// <summary>
  /// Literal value: item_count
  /// </summary>
  [FactorioRconAttribute("item_count")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: circuit
/// </summary>
public abstract class Literal10896719
{
  /// <summary>
  /// Literal value: circuit
  /// </summary>
  [FactorioRconAttribute("circuit")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: inactivity
/// </summary>
public abstract class Literal27504513
{
  /// <summary>
  /// Literal value: inactivity
  /// </summary>
  [FactorioRconAttribute("inactivity")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: robots_inactive
/// </summary>
public abstract class Literal40723880
{
  /// <summary>
  /// Literal value: robots_inactive
  /// </summary>
  [FactorioRconAttribute("robots_inactive")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: fluid_count
/// </summary>
public abstract class Literal49895113
{
  /// <summary>
  /// Literal value: fluid_count
  /// </summary>
  [FactorioRconAttribute("fluid_count")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: passenger_present
/// </summary>
public abstract class Literal41164413
{
  /// <summary>
  /// Literal value: passenger_present
  /// </summary>
  [FactorioRconAttribute("passenger_present")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: passenger_not_present
/// </summary>
public abstract class Literal59146305
{
  /// <summary>
  /// Literal value: passenger_not_present
  /// </summary>
  [FactorioRconAttribute("passenger_not_present")]
  public static object Value { get; private set; }

}

