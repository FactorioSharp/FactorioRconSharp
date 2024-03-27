#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TriggerDelivery")]
public abstract class TriggerDelivery
{
  [FactorioRconAttribute("type")]
  public Union61525340 Type { get; set; }

  [FactorioRconAttribute("source_effects")]
  public List<TriggerEffectItem> SourceEffects { get; set; }

  [FactorioRconAttribute("target_effects")]
  public List<TriggerEffectItem> TargetEffects { get; set; }

}

/// <summary>
/// Union of literals:
///   - instant
///   - projectile
///   - flame-thrower
///   - beam
///   - stream
///   - artillery
/// </summary>
public enum Union61525340
{
  /// <summary>
  /// Literal value: instant
  /// </summary>
  [FactorioRconDefinitionValue("instant")]
  Instant,

  /// <summary>
  /// Literal value: projectile
  /// </summary>
  [FactorioRconDefinitionValue("projectile")]
  Projectile,

  /// <summary>
  /// Literal value: flame-thrower
  /// </summary>
  [FactorioRconDefinitionValue("flame-thrower")]
  FlameThrower,

  /// <summary>
  /// Literal value: beam
  /// </summary>
  [FactorioRconDefinitionValue("beam")]
  Beam,

  /// <summary>
  /// Literal value: stream
  /// </summary>
  [FactorioRconDefinitionValue("stream")]
  Stream,

  /// <summary>
  /// Literal value: artillery
  /// </summary>
  [FactorioRconDefinitionValue("artillery")]
  Artillery,

}

