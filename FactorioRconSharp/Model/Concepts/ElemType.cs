#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A <see cref="LuaGuiElement.ElemTooltip" />.
/// </summary>
[FactorioRconDefinition("ElemType")]
public enum ElemType
{
  /// <summary>
  /// Literal value: achievement
  /// </summary>
  [FactorioRconDefinitionValue("achievement")]
  Achievement,

  /// <summary>
  /// Literal value: decorative
  /// </summary>
  [FactorioRconDefinitionValue("decorative")]
  Decorative,

  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
  Entity,

  /// <summary>
  /// Literal value: equipment
  /// </summary>
  [FactorioRconDefinitionValue("equipment")]
  Equipment,

  /// <summary>
  /// Literal value: fluid
  /// </summary>
  [FactorioRconDefinitionValue("fluid")]
  Fluid,

  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconDefinitionValue("item")]
  Item,

  /// <summary>
  /// Literal value: item-group
  /// </summary>
  [FactorioRconDefinitionValue("item-group")]
  ItemGroup,

  /// <summary>
  /// Literal value: recipe
  /// </summary>
  [FactorioRconDefinitionValue("recipe")]
  Recipe,

  /// <summary>
  /// Literal value: signal
  /// </summary>
  [FactorioRconDefinitionValue("signal")]
  Signal,

  /// <summary>
  /// Literal value: technology
  /// </summary>
  [FactorioRconDefinitionValue("technology")]
  Technology,

  /// <summary>
  /// Literal value: tile
  /// </summary>
  [FactorioRconDefinitionValue("tile")]
  Tile,

}

