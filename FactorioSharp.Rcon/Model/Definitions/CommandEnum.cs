#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

/// <summary>
/// Command given to units describing what they should do.
/// </summary>
[FactorioRconDefinition("command")]
public enum CommandEnum
{
  /// <summary>
  /// Attack another entity.
  /// </summary>
  [FactorioRconDefinitionValue("attack")]
  Attack,

  /// <summary>
  /// Go to a specific position.
  /// </summary>
  [FactorioRconDefinitionValue("go_to_location")]
  GoToLocation,

  /// <summary>
  /// Chain commands together, see <see cref="Defines.CompoundCommand" />.
  /// </summary>
  [FactorioRconDefinitionValue("compound")]
  Compound,

  /// <summary>
  /// Do what your group wants you to do.
  /// </summary>
  [FactorioRconDefinitionValue("group")]
  Group,

  /// <summary>
  /// Go to a place and attack what you see.
  /// </summary>
  [FactorioRconDefinitionValue("attack_area")]
  AttackArea,

  /// <summary>
  /// Chill.
  /// </summary>
  [FactorioRconDefinitionValue("wander")]
  Wander,

  /// <summary>
  /// Flee from another entity.
  /// </summary>
  [FactorioRconDefinitionValue("flee")]
  Flee,

  /// <summary>
  /// Stop moving and stay where you are.
  /// </summary>
  [FactorioRconDefinitionValue("stop")]
  Stop,

  /// <summary>
  /// Go to a position and build a base there.
  /// </summary>
  [FactorioRconDefinitionValue("build_base")]
  BuildBase,

}

