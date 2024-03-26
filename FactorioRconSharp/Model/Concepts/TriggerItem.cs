#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TriggerItem")]
public abstract class TriggerItem
{
  [FactorioRconAttribute("type")]
  public Union2933762 Type { get; set; }

  [FactorioRconAttribute("action_delivery")]
  public List<TriggerDelivery> ActionDelivery { get; set; }

  /// <summary>
  /// The trigger will only affect entities that contain any of these flags.
  /// </summary>
  [FactorioRconAttribute("entity_flags")]
  public EntityPrototypeFlags EntityFlags { get; set; }

  [FactorioRconAttribute("ignore_collision_condition")]
  public bool IgnoreCollisionCondition { get; set; }

  /// <summary>
  /// The trigger will only affect entities that would collide with given collision mask.
  /// </summary>
  [FactorioRconAttribute("collision_mask")]
  public CollisionMask CollisionMask { get; set; }

  [FactorioRconAttribute("trigger_target_mask")]
  public TriggerTargetMask TriggerTargetMask { get; set; }

  /// <summary>
  /// If `"enemy"`, the trigger will only affect entities whose force is different from the attacker's and for which there is no cease-fire set. `"ally"` is the opposite of `"enemy"`.
  /// </summary>
  [FactorioRconAttribute("force")]
  public ForceCondition Force { get; set; }

  [FactorioRconAttribute("repeat_count")]
  public uint RepeatCount { get; set; }

  [FactorioRconAttribute("probability")]
  public float Probability { get; set; }

}

public abstract class Table16118003
{
  [FactorioRconAttribute("type")]
  public Union2933762 Type { get; set; }

  [FactorioRconAttribute("action_delivery")]
  public List<TriggerDelivery> ActionDelivery { get; set; }

  /// <summary>
  /// The trigger will only affect entities that contain any of these flags.
  /// </summary>
  [FactorioRconAttribute("entity_flags")]
  public EntityPrototypeFlags EntityFlags { get; set; }

  [FactorioRconAttribute("ignore_collision_condition")]
  public bool IgnoreCollisionCondition { get; set; }

  /// <summary>
  /// The trigger will only affect entities that would collide with given collision mask.
  /// </summary>
  [FactorioRconAttribute("collision_mask")]
  public CollisionMask CollisionMask { get; set; }

  [FactorioRconAttribute("trigger_target_mask")]
  public TriggerTargetMask TriggerTargetMask { get; set; }

  /// <summary>
  /// If `"enemy"`, the trigger will only affect entities whose force is different from the attacker's and for which there is no cease-fire set. `"ally"` is the opposite of `"enemy"`.
  /// </summary>
  [FactorioRconAttribute("force")]
  public ForceCondition Force { get; set; }

  [FactorioRconAttribute("repeat_count")]
  public uint RepeatCount { get; set; }

  [FactorioRconAttribute("probability")]
  public float Probability { get; set; }

}

[GenerateOneOf]
public abstract partial class Union2933762: OneOfBase<Literal61609009, Literal18720791, Literal57592306, Literal1478876>
{
}

/// <summary>
/// Literal value: direct
/// </summary>
public abstract class Literal61609009
{
  /// <summary>
  /// Literal value: direct
  /// </summary>
  [FactorioRconAttribute("direct")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: area
/// </summary>
public abstract class Literal18720791
{
  /// <summary>
  /// Literal value: area
  /// </summary>
  [FactorioRconAttribute("area")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: line
/// </summary>
public abstract class Literal57592306
{
  /// <summary>
  /// Literal value: line
  /// </summary>
  [FactorioRconAttribute("line")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: cluster
/// </summary>
public abstract class Literal1478876
{
  /// <summary>
  /// Literal value: cluster
  /// </summary>
  [FactorioRconAttribute("cluster")]
  public static object Value { get; private set; }

}

