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
/// Used by <see cref="TriggerEffectItem" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TriggerEffectItemType")]
public abstract partial class TriggerEffectItemType: OneOfBase<Literal47971044, Literal48983005, Literal11221016, Literal56974020, Literal41633851, Literal66530998, Literal50350770, Literal50886210, Literal66413973, Literal46957030, Literal19576616, Literal30850960, Literal22262626, Literal41636382, Literal66604392, Literal52479197, Literal45501714, Literal44481292, Literal14889060, Literal29129561>
{
}

[GenerateOneOf]
public abstract partial class Union34051556: OneOfBase<Literal47971044, Literal48983005, Literal11221016, Literal56974020, Literal41633851, Literal66530998, Literal50350770, Literal50886210, Literal66413973, Literal46957030, Literal19576616, Literal30850960, Literal22262626, Literal41636382, Literal66604392, Literal52479197, Literal45501714, Literal44481292, Literal14889060, Literal29129561>
{
}

/// <summary>
/// Literal value: damage
/// </summary>
public enum Literal47971044
{
  /// <summary>
  /// Literal value: damage
  /// </summary>
  [FactorioRconDefinitionValue("damage")]
  Damage,

}

/// <summary>
/// Literal value: create-entity
/// </summary>
public enum Literal48983005
{
  /// <summary>
  /// Literal value: create-entity
  /// </summary>
  [FactorioRconDefinitionValue("create-entity")]
  CreateEntity,

}

/// <summary>
/// Literal value: create-explosion
/// </summary>
public enum Literal11221016
{
  /// <summary>
  /// Literal value: create-explosion
  /// </summary>
  [FactorioRconDefinitionValue("create-explosion")]
  CreateExplosion,

}

/// <summary>
/// Literal value: create-fire
/// </summary>
public enum Literal56974020
{
  /// <summary>
  /// Literal value: create-fire
  /// </summary>
  [FactorioRconDefinitionValue("create-fire")]
  CreateFire,

}

/// <summary>
/// Literal value: create-smoke
/// </summary>
public enum Literal41633851
{
  /// <summary>
  /// Literal value: create-smoke
  /// </summary>
  [FactorioRconDefinitionValue("create-smoke")]
  CreateSmoke,

}

/// <summary>
/// Literal value: create-trivial-smoke
/// </summary>
public enum Literal66530998
{
  /// <summary>
  /// Literal value: create-trivial-smoke
  /// </summary>
  [FactorioRconDefinitionValue("create-trivial-smoke")]
  CreateTrivialSmoke,

}

/// <summary>
/// Literal value: create-particle
/// </summary>
public enum Literal50350770
{
  /// <summary>
  /// Literal value: create-particle
  /// </summary>
  [FactorioRconDefinitionValue("create-particle")]
  CreateParticle,

}

/// <summary>
/// Literal value: create-sticker
/// </summary>
public enum Literal50886210
{
  /// <summary>
  /// Literal value: create-sticker
  /// </summary>
  [FactorioRconDefinitionValue("create-sticker")]
  CreateSticker,

}

/// <summary>
/// Literal value: create-decorative
/// </summary>
public enum Literal66413973
{
  /// <summary>
  /// Literal value: create-decorative
  /// </summary>
  [FactorioRconDefinitionValue("create-decorative")]
  CreateDecorative,

}

/// <summary>
/// Literal value: nested-result
/// </summary>
public enum Literal46957030
{
  /// <summary>
  /// Literal value: nested-result
  /// </summary>
  [FactorioRconDefinitionValue("nested-result")]
  NestedResult,

}

/// <summary>
/// Literal value: play-sound
/// </summary>
public enum Literal19576616
{
  /// <summary>
  /// Literal value: play-sound
  /// </summary>
  [FactorioRconDefinitionValue("play-sound")]
  PlaySound,

}

/// <summary>
/// Literal value: push-back
/// </summary>
public enum Literal30850960
{
  /// <summary>
  /// Literal value: push-back
  /// </summary>
  [FactorioRconDefinitionValue("push-back")]
  PushBack,

}

/// <summary>
/// Literal value: destroy-cliffs
/// </summary>
public enum Literal22262626
{
  /// <summary>
  /// Literal value: destroy-cliffs
  /// </summary>
  [FactorioRconDefinitionValue("destroy-cliffs")]
  DestroyCliffs,

}

/// <summary>
/// Literal value: show-explosion-on-chart
/// </summary>
public enum Literal41636382
{
  /// <summary>
  /// Literal value: show-explosion-on-chart
  /// </summary>
  [FactorioRconDefinitionValue("show-explosion-on-chart")]
  ShowExplosionOnChart,

}

/// <summary>
/// Literal value: insert-item
/// </summary>
public enum Literal66604392
{
  /// <summary>
  /// Literal value: insert-item
  /// </summary>
  [FactorioRconDefinitionValue("insert-item")]
  InsertItem,

}

/// <summary>
/// Literal value: script
/// </summary>
public enum Literal52479197
{
  /// <summary>
  /// Literal value: script
  /// </summary>
  [FactorioRconDefinitionValue("script")]
  Script,

}

/// <summary>
/// Literal value: set-tile
/// </summary>
public enum Literal45501714
{
  /// <summary>
  /// Literal value: set-tile
  /// </summary>
  [FactorioRconDefinitionValue("set-tile")]
  SetTile,

}

/// <summary>
/// Literal value: invoke-tile-trigger
/// </summary>
public enum Literal44481292
{
  /// <summary>
  /// Literal value: invoke-tile-trigger
  /// </summary>
  [FactorioRconDefinitionValue("invoke-tile-trigger")]
  InvokeTileTrigger,

}

/// <summary>
/// Literal value: destroy-decoratives
/// </summary>
public enum Literal14889060
{
  /// <summary>
  /// Literal value: destroy-decoratives
  /// </summary>
  [FactorioRconDefinitionValue("destroy-decoratives")]
  DestroyDecoratives,

}

/// <summary>
/// Literal value: camera-effect
/// </summary>
public enum Literal29129561
{
  /// <summary>
  /// Literal value: camera-effect
  /// </summary>
  [FactorioRconDefinitionValue("camera-effect")]
  CameraEffect,

}

