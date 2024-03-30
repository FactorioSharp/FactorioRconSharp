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
/// Type of a <see cref="WaitCondition" />.
/// </summary>
[FactorioRconDefinition("WaitConditionType")]
public enum WaitConditionType
{
  /// <summary>
  /// Literal value: time
  /// </summary>
  [FactorioRconDefinitionValue("time")]
  Time,

  /// <summary>
  /// Literal value: full
  /// </summary>
  [FactorioRconDefinitionValue("full")]
  Full,

  /// <summary>
  /// Literal value: empty
  /// </summary>
  [FactorioRconDefinitionValue("empty")]
  Empty,

  /// <summary>
  /// Literal value: item_count
  /// </summary>
  [FactorioRconDefinitionValue("item_count")]
  ItemCount,

  /// <summary>
  /// Literal value: circuit
  /// </summary>
  [FactorioRconDefinitionValue("circuit")]
  Circuit,

  /// <summary>
  /// Literal value: inactivity
  /// </summary>
  [FactorioRconDefinitionValue("inactivity")]
  Inactivity,

  /// <summary>
  /// Literal value: robots_inactive
  /// </summary>
  [FactorioRconDefinitionValue("robots_inactive")]
  RobotsInactive,

  /// <summary>
  /// Literal value: fluid_count
  /// </summary>
  [FactorioRconDefinitionValue("fluid_count")]
  FluidCount,

  /// <summary>
  /// Literal value: passenger_present
  /// </summary>
  [FactorioRconDefinitionValue("passenger_present")]
  PassengerPresent,

  /// <summary>
  /// Literal value: passenger_not_present
  /// </summary>
  [FactorioRconDefinitionValue("passenger_not_present")]
  PassengerNotPresent,

}

