#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TriggerItem")]
public class TriggerItem: IFactorioRconModel
{
  [FactorioRconAttribute("type")]
  public Literals575912094 Type { get; set; }

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

  public void Load(string str) => throw new NotImplementedException();
}

