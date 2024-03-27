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
public abstract partial class SwitchState: OneOfBase<Literal19313531, Literal23221489, Literal2334549>
{
}

[GenerateOneOf]
public abstract partial class Union63146650: OneOfBase<Literal19313531, Literal23221489, Literal2334549>
{
}

/// <summary>
/// Literal value: left
/// </summary>
public enum Literal19313531
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
public enum Literal23221489
{
  /// <summary>
  /// Literal value: right
  /// </summary>
  [FactorioRconDefinitionValue("right")]
  Right,

}

/// <summary>
/// Literal value: none
/// </summary>
public enum Literal2334549
{
  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
  None,

}

