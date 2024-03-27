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
public abstract class MouseButtonFlags: Dictionary<Union6843685, Literal9499668>
{
}

/// <summary>
/// Union of literals:
///   - left
///   - right
///   - middle
///   - button-4
///   - button-5
///   - button-6
///   - button-7
///   - button-8
///   - button-9
/// </summary>
public enum Union6843685
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
  /// Literal value: middle
  /// </summary>
  [FactorioRconDefinitionValue("middle")]
  Middle,

  /// <summary>
  /// Literal value: button-4
  /// </summary>
  [FactorioRconDefinitionValue("button-4")]
  Button4,

  /// <summary>
  /// Literal value: button-5
  /// </summary>
  [FactorioRconDefinitionValue("button-5")]
  Button5,

  /// <summary>
  /// Literal value: button-6
  /// </summary>
  [FactorioRconDefinitionValue("button-6")]
  Button6,

  /// <summary>
  /// Literal value: button-7
  /// </summary>
  [FactorioRconDefinitionValue("button-7")]
  Button7,

  /// <summary>
  /// Literal value: button-8
  /// </summary>
  [FactorioRconDefinitionValue("button-8")]
  Button8,

  /// <summary>
  /// Literal value: button-9
  /// </summary>
  [FactorioRconDefinitionValue("button-9")]
  Button9,

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal9499668
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

