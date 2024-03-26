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
/// For example, `"right"` aligned text means the right side of the text is at the target position. Or in other words, the target is on the right of the text.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TextAlign")]
public abstract partial class TextAlign: OneOfBase<Literal40648905, Literal48320655, Literal8100796>
{
}

[GenerateOneOf]
public abstract partial class Union40283584: OneOfBase<Literal40648905, Literal48320655, Literal8100796>
{
}

/// <summary>
/// Literal value: left
/// </summary>
public abstract class Literal40648905
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
public abstract class Literal48320655
{
  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconAttribute("right")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: center
/// </summary>
public abstract class Literal8100796
{
  /// <summary>
  /// Literal value: center
  /// </summary>
  [FactorioRconAttribute("center")]
  public static object Value { get; private set; }

}

