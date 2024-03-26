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
/// The text is aligned so that the target position is at the given side of the text.
/// 
/// For example, `"top"` aligned text means the top of the text is at the target position. Or in other words, the target is at the top of the text.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("VerticalTextAlign")]
public abstract partial class VerticalTextAlign: OneOfBase<Literal51862043, Literal15361084, Literal54147313, Literal63351761>
{
}

[GenerateOneOf]
public abstract partial class Union5665281: OneOfBase<Literal51862043, Literal15361084, Literal54147313, Literal63351761>
{
}

/// <summary>
/// Literal value: top
/// </summary>
public abstract class Literal51862043
{
  /// <summary>
  /// Literal value: top
  /// </summary>
  [FactorioRconAttribute("top")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: middle
/// </summary>
public abstract class Literal15361084
{
  /// <summary>
  /// Literal value: middle
  /// </summary>
  [FactorioRconAttribute("middle")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: baseline
/// </summary>
public abstract class Literal54147313
{
  /// <summary>
  /// Literal value: baseline
  /// </summary>
  [FactorioRconAttribute("baseline")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: bottom
/// </summary>
public abstract class Literal63351761
{
  /// <summary>
  /// Literal value: bottom
  /// </summary>
  [FactorioRconAttribute("bottom")]
  public static object Value { get; private set; }

}

