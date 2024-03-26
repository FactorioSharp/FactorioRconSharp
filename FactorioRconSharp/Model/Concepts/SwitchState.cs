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
/// State of a GUI <see cref="LuaGuiElement.SwitchState" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("SwitchState")]
public abstract partial class SwitchState: OneOfBase<Literal1084693, Literal22778559, Literal8587703>
{
}

[GenerateOneOf]
public abstract partial class Union51182215: OneOfBase<Literal1084693, Literal22778559, Literal8587703>
{
}

/// <summary>
/// Literal value: left
/// </summary>
public abstract class Literal1084693
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
public abstract class Literal22778559
{
  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconAttribute("right")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: none
/// </summary>
public abstract class Literal8587703
{
  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconAttribute("none")]
  public static object Value { get; private set; }

}

