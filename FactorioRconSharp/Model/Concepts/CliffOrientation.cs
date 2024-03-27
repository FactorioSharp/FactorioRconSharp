#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[GenerateOneOf]
[FactorioRconConcept("CliffOrientation")]
public abstract partial class CliffOrientation: OneOfBase<Literal19531649, Literal7511460, Literal23522948, Literal24219861, Literal38855053, Literal10649759, Literal22318356, Literal66032303, Literal44501086, Literal62107587, Literal29190913, Literal9029417, Literal55400036, Literal22550079, Literal3789628, Literal12473332, Literal60613391, Literal64921669, Literal21177779, Literal42080192>
{
}

[GenerateOneOf]
public abstract partial class Union55256301: OneOfBase<Literal19531649, Literal7511460, Literal23522948, Literal24219861, Literal38855053, Literal10649759, Literal22318356, Literal66032303, Literal44501086, Literal62107587, Literal29190913, Literal9029417, Literal55400036, Literal22550079, Literal3789628, Literal12473332, Literal60613391, Literal64921669, Literal21177779, Literal42080192>
{
}

/// <summary>
/// Literal value: west-to-east
/// </summary>
public enum Literal19531649
{
  /// <summary>
  /// Literal value: west-to-east
  /// </summary>
  [FactorioRconDefinitionValue("west-to-east")]
  WestToEast,

}

/// <summary>
/// Literal value: north-to-south
/// </summary>
public enum Literal7511460
{
  /// <summary>
  /// Literal value: north-to-south
  /// </summary>
  [FactorioRconDefinitionValue("north-to-south")]
  NorthToSouth,

}

/// <summary>
/// Literal value: east-to-west
/// </summary>
public enum Literal23522948
{
  /// <summary>
  /// Literal value: east-to-west
  /// </summary>
  [FactorioRconDefinitionValue("east-to-west")]
  EastToWest,

}

/// <summary>
/// Literal value: south-to-north
/// </summary>
public enum Literal24219861
{
  /// <summary>
  /// Literal value: south-to-north
  /// </summary>
  [FactorioRconDefinitionValue("south-to-north")]
  SouthToNorth,

}

/// <summary>
/// Literal value: west-to-north
/// </summary>
public enum Literal38855053
{
  /// <summary>
  /// Literal value: west-to-north
  /// </summary>
  [FactorioRconDefinitionValue("west-to-north")]
  WestToNorth,

}

/// <summary>
/// Literal value: north-to-east
/// </summary>
public enum Literal10649759
{
  /// <summary>
  /// Literal value: north-to-east
  /// </summary>
  [FactorioRconDefinitionValue("north-to-east")]
  NorthToEast,

}

/// <summary>
/// Literal value: east-to-south
/// </summary>
public enum Literal22318356
{
  /// <summary>
  /// Literal value: east-to-south
  /// </summary>
  [FactorioRconDefinitionValue("east-to-south")]
  EastToSouth,

}

/// <summary>
/// Literal value: south-to-west
/// </summary>
public enum Literal66032303
{
  /// <summary>
  /// Literal value: south-to-west
  /// </summary>
  [FactorioRconDefinitionValue("south-to-west")]
  SouthToWest,

}

/// <summary>
/// Literal value: west-to-south
/// </summary>
public enum Literal44501086
{
  /// <summary>
  /// Literal value: west-to-south
  /// </summary>
  [FactorioRconDefinitionValue("west-to-south")]
  WestToSouth,

}

/// <summary>
/// Literal value: north-to-west
/// </summary>
public enum Literal62107587
{
  /// <summary>
  /// Literal value: north-to-west
  /// </summary>
  [FactorioRconDefinitionValue("north-to-west")]
  NorthToWest,

}

/// <summary>
/// Literal value: east-to-north
/// </summary>
public enum Literal29190913
{
  /// <summary>
  /// Literal value: east-to-north
  /// </summary>
  [FactorioRconDefinitionValue("east-to-north")]
  EastToNorth,

}

/// <summary>
/// Literal value: south-to-east
/// </summary>
public enum Literal9029417
{
  /// <summary>
  /// Literal value: south-to-east
  /// </summary>
  [FactorioRconDefinitionValue("south-to-east")]
  SouthToEast,

}

/// <summary>
/// Literal value: west-to-none
/// </summary>
public enum Literal55400036
{
  /// <summary>
  /// Literal value: west-to-none
  /// </summary>
  [FactorioRconDefinitionValue("west-to-none")]
  WestToNone,

}

/// <summary>
/// Literal value: none-to-east
/// </summary>
public enum Literal22550079
{
  /// <summary>
  /// Literal value: none-to-east
  /// </summary>
  [FactorioRconDefinitionValue("none-to-east")]
  NoneToEast,

}

/// <summary>
/// Literal value: east-to-none
/// </summary>
public enum Literal3789628
{
  /// <summary>
  /// Literal value: east-to-none
  /// </summary>
  [FactorioRconDefinitionValue("east-to-none")]
  EastToNone,

}

/// <summary>
/// Literal value: none-to-west
/// </summary>
public enum Literal12473332
{
  /// <summary>
  /// Literal value: none-to-west
  /// </summary>
  [FactorioRconDefinitionValue("none-to-west")]
  NoneToWest,

}

/// <summary>
/// Literal value: north-to-none
/// </summary>
public enum Literal60613391
{
  /// <summary>
  /// Literal value: north-to-none
  /// </summary>
  [FactorioRconDefinitionValue("north-to-none")]
  NorthToNone,

}

/// <summary>
/// Literal value: none-to-south
/// </summary>
public enum Literal64921669
{
  /// <summary>
  /// Literal value: none-to-south
  /// </summary>
  [FactorioRconDefinitionValue("none-to-south")]
  NoneToSouth,

}

/// <summary>
/// Literal value: south-to-none
/// </summary>
public enum Literal21177779
{
  /// <summary>
  /// Literal value: south-to-none
  /// </summary>
  [FactorioRconDefinitionValue("south-to-none")]
  SouthToNone,

}

/// <summary>
/// Literal value: none-to-north
/// </summary>
public enum Literal42080192
{
  /// <summary>
  /// Literal value: none-to-north
  /// </summary>
  [FactorioRconDefinitionValue("none-to-north")]
  NoneToNorth,

}

