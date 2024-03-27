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
public abstract partial class VerticalTextAlign: OneOfBase<Literal48677406, Literal2358652, Literal1292050, Literal37469460>
{
}

[GenerateOneOf]
public abstract partial class Union64159197: OneOfBase<Literal48677406, Literal2358652, Literal1292050, Literal37469460>
{
}

/// <summary>
/// Literal value: top
/// </summary>
public enum Literal48677406
{
  /// <summary>
  /// Literal value: top
  /// </summary>
  [FactorioRconDefinitionValue("top")]
  Top,

}

/// <summary>
/// Literal value: middle
/// </summary>
public enum Literal2358652
{
  /// <summary>
  /// Literal value: middle
  /// </summary>
  [FactorioRconDefinitionValue("middle")]
  Middle,

}

/// <summary>
/// Literal value: baseline
/// </summary>
public enum Literal1292050
{
  /// <summary>
  /// Literal value: baseline
  /// </summary>
  [FactorioRconDefinitionValue("baseline")]
  Baseline,

}

/// <summary>
/// Literal value: bottom
/// </summary>
public enum Literal37469460
{
  /// <summary>
  /// Literal value: bottom
  /// </summary>
  [FactorioRconDefinitionValue("bottom")]
  Bottom,

}

