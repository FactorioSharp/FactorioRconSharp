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
public abstract partial class TrainPathRequestType: OneOfBase<Literal63132315, Literal54194300, Literal59032059, Literal36702536>
{
}

[GenerateOneOf]
public abstract partial class Union57932624: OneOfBase<Literal63132315, Literal54194300, Literal59032059, Literal36702536>
{
}

/// <summary>
/// Literal value: path
/// </summary>
public abstract class Literal63132315
{
  /// <summary>
  /// Literal value: path
  /// </summary>
  [FactorioRconAttribute("path")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: any-goal-accessible
/// </summary>
public abstract class Literal54194300
{
  /// <summary>
  /// Literal value: any-goal-accessible
  /// </summary>
  [FactorioRconAttribute("any-goal-accessible")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: all-goals-accessible
/// </summary>
public abstract class Literal59032059
{
  /// <summary>
  /// Literal value: all-goals-accessible
  /// </summary>
  [FactorioRconAttribute("all-goals-accessible")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: all-goals-penalties
/// </summary>
public abstract class Literal36702536
{
  /// <summary>
  /// Literal value: all-goals-penalties
  /// </summary>
  [FactorioRconAttribute("all-goals-penalties")]
  public static object Value { get; private set; }

}

