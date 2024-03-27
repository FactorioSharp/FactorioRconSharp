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
  public Union14042645 Type { get; set; }

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

/// <summary>
/// Union of literals:
///   - direct
///   - area
///   - line
///   - cluster
/// </summary>
public enum Union14042645
{
  /// <summary>
  /// Literal value: direct
  /// </summary>
  [FactorioRconDefinitionValue("direct")]
  Direct,

  /// <summary>
  /// Literal value: area
  /// </summary>
  [FactorioRconDefinitionValue("area")]
  Area,

  /// <summary>
  /// Literal value: line
  /// </summary>
  [FactorioRconDefinitionValue("line")]
  Line,

  /// <summary>
  /// Literal value: cluster
  /// </summary>
  [FactorioRconDefinitionValue("cluster")]
  Cluster,

}

