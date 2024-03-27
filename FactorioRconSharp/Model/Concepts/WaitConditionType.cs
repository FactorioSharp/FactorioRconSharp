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
/// Type of a <see cref="WaitCondition" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("WaitConditionType")]
public abstract partial class WaitConditionType: OneOfBase<Literal58298707, Literal12940920, Literal39742366, Literal11677949, Literal3116217, Literal23261451, Literal3493458, Literal34201432, Literal52317446, Literal40810954>
{
}

[GenerateOneOf]
public abstract partial class Union36721781: OneOfBase<Literal58298707, Literal12940920, Literal39742366, Literal11677949, Literal3116217, Literal23261451, Literal3493458, Literal34201432, Literal52317446, Literal40810954>
{
}

/// <summary>
/// Literal value: time
/// </summary>
public enum Literal58298707
{
  /// <summary>
  /// Literal value: time
  /// </summary>
  [FactorioRconDefinitionValue("time")]
  Time,

}

/// <summary>
/// Literal value: full
/// </summary>
public enum Literal12940920
{
  /// <summary>
  /// Literal value: full
  /// </summary>
  [FactorioRconDefinitionValue("full")]
  Full,

}

/// <summary>
/// Literal value: empty
/// </summary>
public enum Literal39742366
{
  /// <summary>
  /// Literal value: empty
  /// </summary>
  [FactorioRconDefinitionValue("empty")]
  Empty,

}

/// <summary>
/// Literal value: item_count
/// </summary>
public enum Literal11677949
{
  /// <summary>
  /// Literal value: item_count
  /// </summary>
  [FactorioRconDefinitionValue("item_count")]
  ItemCount,

}

/// <summary>
/// Literal value: circuit
/// </summary>
public enum Literal3116217
{
  /// <summary>
  /// Literal value: circuit
  /// </summary>
  [FactorioRconDefinitionValue("circuit")]
  Circuit,

}

/// <summary>
/// Literal value: inactivity
/// </summary>
public enum Literal23261451
{
  /// <summary>
  /// Literal value: inactivity
  /// </summary>
  [FactorioRconDefinitionValue("inactivity")]
  Inactivity,

}

/// <summary>
/// Literal value: robots_inactive
/// </summary>
public enum Literal3493458
{
  /// <summary>
  /// Literal value: robots_inactive
  /// </summary>
  [FactorioRconDefinitionValue("robots_inactive")]
  RobotsInactive,

}

/// <summary>
/// Literal value: fluid_count
/// </summary>
public enum Literal34201432
{
  /// <summary>
  /// Literal value: fluid_count
  /// </summary>
  [FactorioRconDefinitionValue("fluid_count")]
  FluidCount,

}

/// <summary>
/// Literal value: passenger_present
/// </summary>
public enum Literal52317446
{
  /// <summary>
  /// Literal value: passenger_present
  /// </summary>
  [FactorioRconDefinitionValue("passenger_present")]
  PassengerPresent,

}

/// <summary>
/// Literal value: passenger_not_present
/// </summary>
public enum Literal40810954
{
  /// <summary>
  /// Literal value: passenger_not_present
  /// </summary>
  [FactorioRconDefinitionValue("passenger_not_present")]
  PassengerNotPresent,

}

