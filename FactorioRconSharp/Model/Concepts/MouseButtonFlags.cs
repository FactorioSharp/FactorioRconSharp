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
public abstract class MouseButtonFlags: Dictionary<Union57195083, Literal48044684>
{
}

[GenerateOneOf]
public abstract partial class Union57195083: OneOfBase<Literal51118573, Literal6043628, Literal41047511, Literal49527150, Literal27001207, Literal44837509, Literal25219370, Literal60273114, Literal3089856>
{
}

/// <summary>
/// Literal value: left
/// </summary>
public enum Literal51118573
{
  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconDefinitionValue("left")]
  Left,

}

/// <summary>
/// Literal value: right
/// </summary>
public enum Literal6043628
{
  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
  Right,

}

/// <summary>
/// Literal value: middle
/// </summary>
public enum Literal41047511
{
  /// <summary>
  /// Literal value: middle
  /// </summary>
  [FactorioRconDefinitionValue("middle")]
  Middle,

}

/// <summary>
/// Literal value: button-4
/// </summary>
public enum Literal49527150
{
  /// <summary>
  /// Literal value: button-4
  /// </summary>
  [FactorioRconDefinitionValue("button-4")]
  Button4,

}

/// <summary>
/// Literal value: button-5
/// </summary>
public enum Literal27001207
{
  /// <summary>
  /// Literal value: button-5
  /// </summary>
  [FactorioRconDefinitionValue("button-5")]
  Button5,

}

/// <summary>
/// Literal value: button-6
/// </summary>
public enum Literal44837509
{
  /// <summary>
  /// Literal value: button-6
  /// </summary>
  [FactorioRconDefinitionValue("button-6")]
  Button6,

}

/// <summary>
/// Literal value: button-7
/// </summary>
public enum Literal25219370
{
  /// <summary>
  /// Literal value: button-7
  /// </summary>
  [FactorioRconDefinitionValue("button-7")]
  Button7,

}

/// <summary>
/// Literal value: button-8
/// </summary>
public enum Literal60273114
{
  /// <summary>
  /// Literal value: button-8
  /// </summary>
  [FactorioRconDefinitionValue("button-8")]
  Button8,

}

/// <summary>
/// Literal value: button-9
/// </summary>
public enum Literal3089856
{
  /// <summary>
  /// Literal value: button-9
  /// </summary>
  [FactorioRconDefinitionValue("button-9")]
  Button9,

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal48044684
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

