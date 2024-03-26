#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[GenerateOneOf]
[FactorioRconConcept("ForceCondition")]
public abstract partial class ForceCondition: OneOfBase<Literal13418196, Literal40147308, Literal49792773, Literal32548782, Literal367991, Literal12143729, Literal65198764>
{
}

[GenerateOneOf]
public abstract partial class Union26843437: OneOfBase<Literal13418196, Literal40147308, Literal49792773, Literal32548782, Literal367991, Literal12143729, Literal65198764>
{
}

/// <summary>
/// Literal value: all
/// </summary>
public abstract class Literal13418196
{
  /// <summary>
  /// Literal value: all
  /// </summary>
  [FactorioRconAttribute("all")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: enemy
/// </summary>
public abstract class Literal40147308
{
  /// <summary>
  /// Literal value: enemy
  /// </summary>
  [FactorioRconAttribute("enemy")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: ally
/// </summary>
public abstract class Literal49792773
{
  /// <summary>
  /// Literal value: ally
  /// </summary>
  [FactorioRconAttribute("ally")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: friend
/// </summary>
public abstract class Literal32548782
{
  /// <summary>
  /// Literal value: friend
  /// </summary>
  [FactorioRconAttribute("friend")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: not-friend
/// </summary>
public abstract class Literal367991
{
  /// <summary>
  /// Literal value: not-friend
  /// </summary>
  [FactorioRconAttribute("not-friend")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: same
/// </summary>
public abstract class Literal12143729
{
  /// <summary>
  /// Literal value: same
  /// </summary>
  [FactorioRconAttribute("same")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: not-same
/// </summary>
public abstract class Literal65198764
{
  /// <summary>
  /// Literal value: not-same
  /// </summary>
  [FactorioRconAttribute("not-same")]
  public static object Value { get; private set; }

}

