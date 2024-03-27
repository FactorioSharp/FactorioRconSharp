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
/// A <see cref="String" /> that specifies where a GUI element should be.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("Alignment")]
public abstract partial class Alignment: OneOfBase<Literal21178267, Literal10189992, Literal27074336, Literal46958254, Literal19612087, Literal31879635, Literal52094183, Literal34336325, Literal56229350, Literal20038436, Literal44243738>
{
}

[GenerateOneOf]
public abstract partial class Union7672581: OneOfBase<Literal21178267, Literal10189992, Literal27074336, Literal46958254, Literal19612087, Literal31879635, Literal52094183, Literal34336325, Literal56229350, Literal20038436, Literal44243738>
{
}

/// <summary>
/// Literal value: top-left
/// </summary>
public enum Literal21178267
{
  /// <summary>
  /// Literal value: top-left
  /// </summary>
  [FactorioRconDefinitionValue("top-left")]
  TopLeft,

}

/// <summary>
/// Literal value: middle-left
/// </summary>
public enum Literal10189992
{
  /// <summary>
  /// Literal value: middle-left
  /// </summary>
  [FactorioRconDefinitionValue("middle-left")]
  MiddleLeft,

}

/// <summary>
/// Literal value: left
/// </summary>
public enum Literal27074336
{
  /// <summary>
  /// Literal value: left
  /// </summary>
  [FactorioRconDefinitionValue("left")]
  Left,

}

/// <summary>
/// Literal value: bottom-left
/// </summary>
public enum Literal46958254
{
  /// <summary>
  /// Literal value: bottom-left
  /// </summary>
  [FactorioRconDefinitionValue("bottom-left")]
  BottomLeft,

}

/// <summary>
/// Literal value: top-center
/// </summary>
public enum Literal19612087
{
  /// <summary>
  /// Literal value: top-center
  /// </summary>
  [FactorioRconDefinitionValue("top-center")]
  TopCenter,

}

/// <summary>
/// Literal value: middle-center
/// </summary>
public enum Literal31879635
{
  /// <summary>
  /// Literal value: middle-center
  /// </summary>
  [FactorioRconDefinitionValue("middle-center")]
  MiddleCenter,

}

/// <summary>
/// Literal value: center
/// </summary>
public enum Literal52094183
{
  /// <summary>
  /// Literal value: center
  /// </summary>
  [FactorioRconDefinitionValue("center")]
  Center,

}

/// <summary>
/// Literal value: bottom-center
/// </summary>
public enum Literal34336325
{
  /// <summary>
  /// Literal value: bottom-center
  /// </summary>
  [FactorioRconDefinitionValue("bottom-center")]
  BottomCenter,

}

/// <summary>
/// Literal value: top-right
/// </summary>
public enum Literal56229350
{
  /// <summary>
  /// Literal value: top-right
  /// </summary>
  [FactorioRconDefinitionValue("top-right")]
  TopRight,

}

/// <summary>
/// Literal value: right
/// </summary>
public enum Literal20038436
{
  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
  Right,

}

/// <summary>
/// Literal value: bottom-right
/// </summary>
public enum Literal44243738
{
  /// <summary>
  /// Literal value: bottom-right
  /// </summary>
  [FactorioRconDefinitionValue("bottom-right")]
  BottomRight,

}

