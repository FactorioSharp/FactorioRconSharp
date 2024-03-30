#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconDefinition("CliffOrientation")]
public enum CliffOrientation
{
  /// <summary>
  ///     Literal value: west-to-east
  /// </summary>
  [FactorioRconDefinitionValue("west-to-east")]
    WestToEast,

  /// <summary>
  ///     Literal value: north-to-south
  /// </summary>
  [FactorioRconDefinitionValue("north-to-south")]
    NorthToSouth,

  /// <summary>
  ///     Literal value: east-to-west
  /// </summary>
  [FactorioRconDefinitionValue("east-to-west")]
    EastToWest,

  /// <summary>
  ///     Literal value: south-to-north
  /// </summary>
  [FactorioRconDefinitionValue("south-to-north")]
    SouthToNorth,

  /// <summary>
  ///     Literal value: west-to-north
  /// </summary>
  [FactorioRconDefinitionValue("west-to-north")]
    WestToNorth,

  /// <summary>
  ///     Literal value: north-to-east
  /// </summary>
  [FactorioRconDefinitionValue("north-to-east")]
    NorthToEast,

  /// <summary>
  ///     Literal value: east-to-south
  /// </summary>
  [FactorioRconDefinitionValue("east-to-south")]
    EastToSouth,

  /// <summary>
  ///     Literal value: south-to-west
  /// </summary>
  [FactorioRconDefinitionValue("south-to-west")]
    SouthToWest,

  /// <summary>
  ///     Literal value: west-to-south
  /// </summary>
  [FactorioRconDefinitionValue("west-to-south")]
    WestToSouth,

  /// <summary>
  ///     Literal value: north-to-west
  /// </summary>
  [FactorioRconDefinitionValue("north-to-west")]
    NorthToWest,

  /// <summary>
  ///     Literal value: east-to-north
  /// </summary>
  [FactorioRconDefinitionValue("east-to-north")]
    EastToNorth,

  /// <summary>
  ///     Literal value: south-to-east
  /// </summary>
  [FactorioRconDefinitionValue("south-to-east")]
    SouthToEast,

  /// <summary>
  ///     Literal value: west-to-none
  /// </summary>
  [FactorioRconDefinitionValue("west-to-none")]
    WestToNone,

  /// <summary>
  ///     Literal value: none-to-east
  /// </summary>
  [FactorioRconDefinitionValue("none-to-east")]
    NoneToEast,

  /// <summary>
  ///     Literal value: east-to-none
  /// </summary>
  [FactorioRconDefinitionValue("east-to-none")]
    EastToNone,

  /// <summary>
  ///     Literal value: none-to-west
  /// </summary>
  [FactorioRconDefinitionValue("none-to-west")]
    NoneToWest,

  /// <summary>
  ///     Literal value: north-to-none
  /// </summary>
  [FactorioRconDefinitionValue("north-to-none")]
    NorthToNone,

  /// <summary>
  ///     Literal value: none-to-south
  /// </summary>
  [FactorioRconDefinitionValue("none-to-south")]
    NoneToSouth,

  /// <summary>
  ///     Literal value: south-to-none
  /// </summary>
  [FactorioRconDefinitionValue("south-to-none")]
    SouthToNone,

  /// <summary>
  ///     Literal value: none-to-north
  /// </summary>
  [FactorioRconDefinitionValue("none-to-north")]
    NoneToNorth
}
