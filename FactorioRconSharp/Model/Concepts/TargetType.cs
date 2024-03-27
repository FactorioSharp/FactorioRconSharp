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
/// Target type of an <see cref="AmmoType" />.
/// </summary>
[FactorioRconDefinition("TargetType")]
public enum TargetType
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
  Entity,

  /// <summary>
  /// Literal value: position
  /// </summary>
  [FactorioRconDefinitionValue("position")]
  Position,

  /// <summary>
  /// Literal value: direction
  /// </summary>
  [FactorioRconDefinitionValue("direction")]
  Direction,

}

