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
  public Union24974776 Type { get; set; }

  [FactorioRconAttribute("source_effects")]
  public List<TriggerEffectItem> SourceEffects { get; set; }

  [FactorioRconAttribute("target_effects")]
  public List<TriggerEffectItem> TargetEffects { get; set; }

}

public abstract class Table23558896
{
  [FactorioRconAttribute("type")]
  public Union24974776 Type { get; set; }

  [FactorioRconAttribute("source_effects")]
  public List<TriggerEffectItem> SourceEffects { get; set; }

  [FactorioRconAttribute("target_effects")]
  public List<TriggerEffectItem> TargetEffects { get; set; }

}

[GenerateOneOf]
public abstract partial class Union24974776: OneOfBase<Literal54708252, Literal8022616, Literal34257225, Literal48313086, Literal7941859, Literal32561327>
{
}

/// <summary>
/// Literal value: instant
/// </summary>
public abstract class Literal54708252
{
  /// <summary>
  /// Literal value: instant
  /// </summary>
  [FactorioRconAttribute("instant")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: projectile
/// </summary>
public abstract class Literal8022616
{
  /// <summary>
  /// Literal value: projectile
  /// </summary>
  [FactorioRconAttribute("projectile")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: flame-thrower
/// </summary>
public abstract class Literal34257225
{
  /// <summary>
  /// Literal value: flame-thrower
  /// </summary>
  [FactorioRconAttribute("flame-thrower")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: beam
/// </summary>
public abstract class Literal48313086
{
  /// <summary>
  /// Literal value: beam
  /// </summary>
  [FactorioRconAttribute("beam")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: stream
/// </summary>
public abstract class Literal7941859
{
  /// <summary>
  /// Literal value: stream
  /// </summary>
  [FactorioRconAttribute("stream")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: artillery
/// </summary>
public abstract class Literal32561327
{
  /// <summary>
  /// Literal value: artillery
  /// </summary>
  [FactorioRconAttribute("artillery")]
  public static object Value { get; private set; }

}

