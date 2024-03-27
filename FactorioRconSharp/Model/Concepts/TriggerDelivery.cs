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
  public Union23275074 Type { get; set; }

  [FactorioRconAttribute("source_effects")]
  public List<TriggerEffectItem> SourceEffects { get; set; }

  [FactorioRconAttribute("target_effects")]
  public List<TriggerEffectItem> TargetEffects { get; set; }

}

public abstract class Table26257675
{
  [FactorioRconAttribute("type")]
  public Union23275074 Type { get; set; }

  [FactorioRconAttribute("source_effects")]
  public List<TriggerEffectItem> SourceEffects { get; set; }

  [FactorioRconAttribute("target_effects")]
  public List<TriggerEffectItem> TargetEffects { get; set; }

}

[GenerateOneOf]
public abstract partial class Union23275074: OneOfBase<Literal3888511, Literal45657968, Literal49012660, Literal12081011, Literal14805024, Literal26692523>
{
}

/// <summary>
/// Literal value: instant
/// </summary>
public enum Literal3888511
{
  /// <summary>
  /// Literal value: instant
  /// </summary>
  [FactorioRconDefinitionValue("instant")]
  Instant,

}

/// <summary>
/// Literal value: projectile
/// </summary>
public enum Literal45657968
{
  /// <summary>
  /// Literal value: projectile
  /// </summary>
  [FactorioRconDefinitionValue("projectile")]
  Projectile,

}

/// <summary>
/// Literal value: flame-thrower
/// </summary>
public enum Literal49012660
{
  /// <summary>
  /// Literal value: flame-thrower
  /// </summary>
  [FactorioRconDefinitionValue("flame-thrower")]
  FlameThrower,

}

/// <summary>
/// Literal value: beam
/// </summary>
public enum Literal12081011
{
  /// <summary>
  /// Literal value: beam
  /// </summary>
  [FactorioRconDefinitionValue("beam")]
  Beam,

}

/// <summary>
/// Literal value: stream
/// </summary>
public enum Literal14805024
{
  /// <summary>
  /// Literal value: stream
  /// </summary>
  [FactorioRconDefinitionValue("stream")]
  Stream,

}

/// <summary>
/// Literal value: artillery
/// </summary>
public enum Literal26692523
{
  /// <summary>
  /// Literal value: artillery
  /// </summary>
  [FactorioRconDefinitionValue("artillery")]
  Artillery,

}

