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
/// A floating point number specifying an amount.
/// 
/// For backwards compatibility, MapGenSizes can also be specified as one of the following strings, which will be converted to a number (when queried, a number will always be returned):
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("MapGenSize")]
public abstract partial class MapGenSize: OneOfBase<float, Literal59035966, Literal34321427, Literal55797291, Literal7508718, Literal16426255, Literal6599358, Literal57163663, Literal47133519, Literal24694787, Literal45060192, Literal31677167, Literal46222623, Literal65387658, Literal17193897, Literal28860985, Literal31662221>
{
}

[GenerateOneOf]
public abstract partial class Union57574093: OneOfBase<float, Literal59035966, Literal34321427, Literal55797291, Literal7508718, Literal16426255, Literal6599358, Literal57163663, Literal47133519, Literal24694787, Literal45060192, Literal31677167, Literal46222623, Literal65387658, Literal17193897, Literal28860985, Literal31662221>
{
}

/// <summary>
/// Literal value: none
/// </summary>
public abstract class Literal59035966
{
  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconAttribute("none")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: very-low
/// </summary>
public abstract class Literal34321427
{
  /// <summary>
  /// Literal value: very-low
  /// </summary>
  [FactorioRconAttribute("very-low")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: very-small
/// </summary>
public abstract class Literal55797291
{
  /// <summary>
  /// Literal value: very-small
  /// </summary>
  [FactorioRconAttribute("very-small")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: very-poor
/// </summary>
public abstract class Literal7508718
{
  /// <summary>
  /// Literal value: very-poor
  /// </summary>
  [FactorioRconAttribute("very-poor")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: low
/// </summary>
public abstract class Literal16426255
{
  /// <summary>
  /// Literal value: low
  /// </summary>
  [FactorioRconAttribute("low")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: small
/// </summary>
public abstract class Literal6599358
{
  /// <summary>
  /// Literal value: small
  /// </summary>
  [FactorioRconAttribute("small")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: poor
/// </summary>
public abstract class Literal57163663
{
  /// <summary>
  /// Literal value: poor
  /// </summary>
  [FactorioRconAttribute("poor")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: normal
/// </summary>
public abstract class Literal47133519
{
  /// <summary>
  /// Literal value: normal
  /// </summary>
  [FactorioRconAttribute("normal")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: medium
/// </summary>
public abstract class Literal24694787
{
  /// <summary>
  /// Literal value: medium
  /// </summary>
  [FactorioRconAttribute("medium")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: regular
/// </summary>
public abstract class Literal45060192
{
  /// <summary>
  /// Literal value: regular
  /// </summary>
  [FactorioRconAttribute("regular")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: high
/// </summary>
public abstract class Literal31677167
{
  /// <summary>
  /// Literal value: high
  /// </summary>
  [FactorioRconAttribute("high")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: big
/// </summary>
public abstract class Literal46222623
{
  /// <summary>
  /// Literal value: big
  /// </summary>
  [FactorioRconAttribute("big")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: good
/// </summary>
public abstract class Literal65387658
{
  /// <summary>
  /// Literal value: good
  /// </summary>
  [FactorioRconAttribute("good")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: very-high
/// </summary>
public abstract class Literal17193897
{
  /// <summary>
  /// Literal value: very-high
  /// </summary>
  [FactorioRconAttribute("very-high")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: very-big
/// </summary>
public abstract class Literal28860985
{
  /// <summary>
  /// Literal value: very-big
  /// </summary>
  [FactorioRconAttribute("very-big")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: very-good
/// </summary>
public abstract class Literal31662221
{
  /// <summary>
  /// Literal value: very-good
  /// </summary>
  [FactorioRconAttribute("very-good")]
  public static object Value { get; private set; }

}

