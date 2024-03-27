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
[FactorioRconDefinition("TextAlign")]
public enum TextAlign
{
  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconDefinitionValue("left")]
  Left,

  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
  Right,

  /// <summary>
  /// Literal value: center
  /// </summary>
  [FactorioRconDefinitionValue("center")]
  Center,

}

