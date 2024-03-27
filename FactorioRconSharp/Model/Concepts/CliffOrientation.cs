#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconDefinition("CliffOrientation")]
public enum CliffOrientation
{
  /// <summary>
  /// Literal value: west-to-east
  /// </summary>
  [FactorioRconDefinitionValue("west-to-east")]
  Westsubtracttosubtracteast,

  /// <summary>
  /// Literal value: north-to-south
  /// </summary>
  [FactorioRconDefinitionValue("north-to-south")]
  Northsubtracttosubtractsouth,

  /// <summary>
  /// Literal value: east-to-west
  /// </summary>
  [FactorioRconDefinitionValue("east-to-west")]
  Eastsubtracttosubtractwest,

  /// <summary>
  /// Literal value: south-to-north
  /// </summary>
  [FactorioRconDefinitionValue("south-to-north")]
  Southsubtracttosubtractnorth,

  /// <summary>
  /// Literal value: west-to-north
  /// </summary>
  [FactorioRconDefinitionValue("west-to-north")]
  Westsubtracttosubtractnorth,

  /// <summary>
  /// Literal value: north-to-east
  /// </summary>
  [FactorioRconDefinitionValue("north-to-east")]
  Northsubtracttosubtracteast,

  /// <summary>
  /// Literal value: east-to-south
  /// </summary>
  [FactorioRconDefinitionValue("east-to-south")]
  Eastsubtracttosubtractsouth,

  /// <summary>
  /// Literal value: south-to-west
  /// </summary>
  [FactorioRconDefinitionValue("south-to-west")]
  Southsubtracttosubtractwest,

  /// <summary>
  /// Literal value: west-to-south
  /// </summary>
  [FactorioRconDefinitionValue("west-to-south")]
  Westsubtracttosubtractsouth,

  /// <summary>
  /// Literal value: north-to-west
  /// </summary>
  [FactorioRconDefinitionValue("north-to-west")]
  Northsubtracttosubtractwest,

  /// <summary>
  /// Literal value: east-to-north
  /// </summary>
  [FactorioRconDefinitionValue("east-to-north")]
  Eastsubtracttosubtractnorth,

  /// <summary>
  /// Literal value: south-to-east
  /// </summary>
  [FactorioRconDefinitionValue("south-to-east")]
  Southsubtracttosubtracteast,

  /// <summary>
  /// Literal value: west-to-none
  /// </summary>
  [FactorioRconDefinitionValue("west-to-none")]
  Westsubtracttosubtractnone,

  /// <summary>
  /// Literal value: none-to-east
  /// </summary>
  [FactorioRconDefinitionValue("none-to-east")]
  Nonesubtracttosubtracteast,

  /// <summary>
  /// Literal value: east-to-none
  /// </summary>
  [FactorioRconDefinitionValue("east-to-none")]
  Eastsubtracttosubtractnone,

  /// <summary>
  /// Literal value: none-to-west
  /// </summary>
  [FactorioRconDefinitionValue("none-to-west")]
  Nonesubtracttosubtractwest,

  /// <summary>
  /// Literal value: north-to-none
  /// </summary>
  [FactorioRconDefinitionValue("north-to-none")]
  Northsubtracttosubtractnone,

  /// <summary>
  /// Literal value: none-to-south
  /// </summary>
  [FactorioRconDefinitionValue("none-to-south")]
  Nonesubtracttosubtractsouth,

  /// <summary>
  /// Literal value: south-to-none
  /// </summary>
  [FactorioRconDefinitionValue("south-to-none")]
  Southsubtracttosubtractnone,

  /// <summary>
  /// Literal value: none-to-north
  /// </summary>
  [FactorioRconDefinitionValue("none-to-north")]
  Nonesubtracttosubtractnorth,

}

