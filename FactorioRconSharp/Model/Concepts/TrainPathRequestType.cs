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
/// A <see cref="LuaGameScript.RequestTrainPath" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TrainPathRequestType")]
public abstract partial class TrainPathRequestType: OneOfBase<Literal58563035, Literal20606438, Literal60715806, Literal15927932>
{
}

[GenerateOneOf]
public abstract partial class Union57557785: OneOfBase<Literal58563035, Literal20606438, Literal60715806, Literal15927932>
{
}

/// <summary>
/// Literal value: path
/// </summary>
public enum Literal58563035
{
  /// <summary>
  /// Literal value: path
  /// </summary>
  [FactorioRconDefinitionValue("path")]
  Path,

}

/// <summary>
/// Literal value: any-goal-accessible
/// </summary>
public enum Literal20606438
{
  /// <summary>
  /// Literal value: any-goal-accessible
  /// </summary>
  [FactorioRconDefinitionValue("any-goal-accessible")]
  AnyGoalAccessible,

}

/// <summary>
/// Literal value: all-goals-accessible
/// </summary>
public enum Literal60715806
{
  /// <summary>
  /// Literal value: all-goals-accessible
  /// </summary>
  [FactorioRconDefinitionValue("all-goals-accessible")]
  AllGoalsAccessible,

}

/// <summary>
/// Literal value: all-goals-penalties
/// </summary>
public enum Literal15927932
{
  /// <summary>
  /// Literal value: all-goals-penalties
  /// </summary>
  [FactorioRconDefinitionValue("all-goals-penalties")]
  AllGoalsPenalties,

}

