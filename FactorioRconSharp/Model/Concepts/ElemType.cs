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
/// A <see cref="LuaGuiElement.ElemTooltip" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ElemType")]
public abstract partial class ElemType: OneOfBase<Literal31968364, Literal247016, Literal5187339, Literal41825261, Literal5915254, Literal57111475, Literal58490299, Literal20336737, Literal24418296, Literal43022188, Literal31050716>
{
}

[GenerateOneOf]
public abstract partial class Union55848526: OneOfBase<Literal31968364, Literal247016, Literal5187339, Literal41825261, Literal5915254, Literal57111475, Literal58490299, Literal20336737, Literal24418296, Literal43022188, Literal31050716>
{
}

/// <summary>
/// Literal value: achievement
/// </summary>
public enum Literal31968364
{
  /// <summary>
  /// Literal value: achievement
  /// </summary>
  [FactorioRconDefinitionValue("achievement")]
  Achievement,

}

/// <summary>
/// Literal value: decorative
/// </summary>
public enum Literal247016
{
  /// <summary>
  /// Literal value: decorative
  /// </summary>
  [FactorioRconDefinitionValue("decorative")]
  Decorative,

}

/// <summary>
/// Literal value: entity
/// </summary>
public enum Literal5187339
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
  Entity,

}

/// <summary>
/// Literal value: equipment
/// </summary>
public enum Literal41825261
{
  /// <summary>
  /// Literal value: equipment
  /// </summary>
  [FactorioRconDefinitionValue("equipment")]
  Equipment,

}

/// <summary>
/// Literal value: fluid
/// </summary>
public enum Literal5915254
{
  /// <summary>
  /// Literal value: fluid
  /// </summary>
  [FactorioRconDefinitionValue("fluid")]
  Fluid,

}

/// <summary>
/// Literal value: item
/// </summary>
public enum Literal57111475
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconDefinitionValue("item")]
  Item,

}

/// <summary>
/// Literal value: item-group
/// </summary>
public enum Literal58490299
{
  /// <summary>
  /// Literal value: item-group
  /// </summary>
  [FactorioRconDefinitionValue("item-group")]
  ItemGroup,

}

/// <summary>
/// Literal value: recipe
/// </summary>
public enum Literal20336737
{
  /// <summary>
  /// Literal value: recipe
  /// </summary>
  [FactorioRconDefinitionValue("recipe")]
  Recipe,

}

/// <summary>
/// Literal value: signal
/// </summary>
public enum Literal24418296
{
  /// <summary>
  /// Literal value: signal
  /// </summary>
  [FactorioRconDefinitionValue("signal")]
  Signal,

}

/// <summary>
/// Literal value: technology
/// </summary>
public enum Literal43022188
{
  /// <summary>
  /// Literal value: technology
  /// </summary>
  [FactorioRconDefinitionValue("technology")]
  Technology,

}

/// <summary>
/// Literal value: tile
/// </summary>
public enum Literal31050716
{
  /// <summary>
  /// Literal value: tile
  /// </summary>
  [FactorioRconDefinitionValue("tile")]
  Tile,

}

