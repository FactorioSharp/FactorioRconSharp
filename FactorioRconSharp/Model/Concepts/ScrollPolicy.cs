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
/// Scroll policy of a <see cref="LuaGuiElement" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ScrollPolicy")]
public abstract partial class ScrollPolicy: OneOfBase<Literal35893325, Literal15562337, Literal58373622, Literal17886530, Literal40072824>
{
}

[GenerateOneOf]
public abstract partial class Union14491846: OneOfBase<Literal35893325, Literal15562337, Literal58373622, Literal17886530, Literal40072824>
{
}

/// <summary>
/// Literal value: never
/// </summary>
public enum Literal35893325
{
  /// <summary>
  /// Literal value: never
  /// </summary>
  [FactorioRconDefinitionValue("never")]
  Never,

}

/// <summary>
/// Literal value: dont-show-but-allow-scrolling
/// </summary>
public enum Literal15562337
{
  /// <summary>
  /// Literal value: dont-show-but-allow-scrolling
  /// </summary>
  [FactorioRconDefinitionValue("dont-show-but-allow-scrolling")]
  DontShowButAllowScrolling,

}

/// <summary>
/// Literal value: always
/// </summary>
public enum Literal58373622
{
  /// <summary>
  /// Literal value: always
  /// </summary>
  [FactorioRconDefinitionValue("always")]
  Always,

}

/// <summary>
/// Literal value: auto
/// </summary>
public enum Literal17886530
{
  /// <summary>
  /// Literal value: auto
  /// </summary>
  [FactorioRconDefinitionValue("auto")]
  Auto,

}

/// <summary>
/// Literal value: auto-and-reserve-space
/// </summary>
public enum Literal40072824
{
  /// <summary>
  /// Literal value: auto-and-reserve-space
  /// </summary>
  [FactorioRconDefinitionValue("auto-and-reserve-space")]
  AutoAndReserveSpace,

}

