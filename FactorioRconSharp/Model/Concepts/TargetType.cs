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
/// Target type of an <see cref="AmmoType" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TargetType")]
public abstract partial class TargetType: OneOfBase<Literal29003094, Literal35783371, Literal31084816>
{
}

[GenerateOneOf]
public abstract partial class Union17198798: OneOfBase<Literal29003094, Literal35783371, Literal31084816>
{
}

/// <summary>
/// Literal value: entity
/// </summary>
public enum Literal29003094
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
  Entity,

}

/// <summary>
/// Literal value: position
/// </summary>
public enum Literal35783371
{
  /// <summary>
  /// Literal value: position
  /// </summary>
  [FactorioRconDefinitionValue("position")]
  Position,

}

/// <summary>
/// Literal value: direction
/// </summary>
public enum Literal31084816
{
  /// <summary>
  /// Literal value: direction
  /// </summary>
  [FactorioRconDefinitionValue("direction")]
  Direction,

}

