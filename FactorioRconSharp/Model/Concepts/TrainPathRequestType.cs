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
/// A <see cref="LuaGameScript.RequestTrainPath" />.
/// </summary>
[FactorioRconDefinition("TrainPathRequestType")]
public enum TrainPathRequestType
{
  /// <summary>
  /// Literal value: path
  /// </summary>
  [FactorioRconDefinitionValue("path")]
  Path,

  /// <summary>
  /// Literal value: any-goal-accessible
  /// </summary>
  [FactorioRconDefinitionValue("any-goal-accessible")]
  AnyGoalAccessible,

  /// <summary>
  /// Literal value: all-goals-accessible
  /// </summary>
  [FactorioRconDefinitionValue("all-goals-accessible")]
  AllGoalsAccessible,

  /// <summary>
  /// Literal value: all-goals-penalties
  /// </summary>
  [FactorioRconDefinitionValue("all-goals-penalties")]
  AllGoalsPenalties,

}

