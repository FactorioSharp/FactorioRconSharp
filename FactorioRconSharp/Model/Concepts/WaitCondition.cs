#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("WaitCondition")]
public abstract class WaitCondition
{
  [FactorioRconAttribute("type")]
  public WaitConditionType Type { get; set; }

  /// <summary>
  /// Specifies how this condition is to be compared with the preceding conditions in the corresponding `wait_conditions` array.
  /// </summary>
  [FactorioRconAttribute("compare_type")]
  public Union37759012 CompareType { get; set; }

  /// <summary>
  /// Number of ticks to wait when `type` is `"time"`, or number of ticks of inactivity when `type` is `"inactivity"`.
  /// </summary>
  [FactorioRconAttribute("ticks")]
  public uint Ticks { get; set; }

  /// <summary>
  /// Only present when `type` is `"item_count"`, `"circuit"` or `"fluid_count"`, and a circuit condition is configured.
  /// </summary>
  [FactorioRconAttribute("condition")]
  public CircuitCondition Condition { get; set; }

}

public abstract class Table12872528
{
  [FactorioRconAttribute("type")]
  public WaitConditionType Type { get; set; }

  /// <summary>
  /// Specifies how this condition is to be compared with the preceding conditions in the corresponding `wait_conditions` array.
  /// </summary>
  [FactorioRconAttribute("compare_type")]
  public Union37759012 CompareType { get; set; }

  /// <summary>
  /// Number of ticks to wait when `type` is `"time"`, or number of ticks of inactivity when `type` is `"inactivity"`.
  /// </summary>
  [FactorioRconAttribute("ticks")]
  public uint Ticks { get; set; }

  /// <summary>
  /// Only present when `type` is `"item_count"`, `"circuit"` or `"fluid_count"`, and a circuit condition is configured.
  /// </summary>
  [FactorioRconAttribute("condition")]
  public CircuitCondition Condition { get; set; }

}

[GenerateOneOf]
public abstract partial class Union37759012: OneOfBase<Literal21269535, Literal12836762>
{
}

/// <summary>
/// Literal value: and
/// </summary>
public enum Literal21269535
{
  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconDefinitionValue("and")]
  And,

}

/// <summary>
/// Literal value: or
/// </summary>
public enum Literal12836762
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconDefinitionValue("or")]
  Or,

}

