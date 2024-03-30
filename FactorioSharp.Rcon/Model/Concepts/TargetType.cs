#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

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

