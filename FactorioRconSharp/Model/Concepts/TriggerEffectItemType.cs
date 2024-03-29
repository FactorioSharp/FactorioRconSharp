#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Used by <see cref="TriggerEffectItem" />.
/// </summary>
[FactorioRconDefinition("TriggerEffectItemType")]
public enum TriggerEffectItemType
{
  /// <summary>
  /// Literal value: damage
  /// </summary>
  [FactorioRconDefinitionValue("damage")]
  Damage,

  /// <summary>
  /// Literal value: create-entity
  /// </summary>
  [FactorioRconDefinitionValue("create-entity")]
  CreateEntity,

  /// <summary>
  /// Literal value: create-explosion
  /// </summary>
  [FactorioRconDefinitionValue("create-explosion")]
  CreateExplosion,

  /// <summary>
  /// Literal value: create-fire
  /// </summary>
  [FactorioRconDefinitionValue("create-fire")]
  CreateFire,

  /// <summary>
  /// Literal value: create-smoke
  /// </summary>
  [FactorioRconDefinitionValue("create-smoke")]
  CreateSmoke,

  /// <summary>
  /// Literal value: create-trivial-smoke
  /// </summary>
  [FactorioRconDefinitionValue("create-trivial-smoke")]
  CreateTrivialSmoke,

  /// <summary>
  /// Literal value: create-particle
  /// </summary>
  [FactorioRconDefinitionValue("create-particle")]
  CreateParticle,

  /// <summary>
  /// Literal value: create-sticker
  /// </summary>
  [FactorioRconDefinitionValue("create-sticker")]
  CreateSticker,

  /// <summary>
  /// Literal value: create-decorative
  /// </summary>
  [FactorioRconDefinitionValue("create-decorative")]
  CreateDecorative,

  /// <summary>
  /// Literal value: nested-result
  /// </summary>
  [FactorioRconDefinitionValue("nested-result")]
  NestedResult,

  /// <summary>
  /// Literal value: play-sound
  /// </summary>
  [FactorioRconDefinitionValue("play-sound")]
  PlaySound,

  /// <summary>
  /// Literal value: push-back
  /// </summary>
  [FactorioRconDefinitionValue("push-back")]
  PushBack,

  /// <summary>
  /// Literal value: destroy-cliffs
  /// </summary>
  [FactorioRconDefinitionValue("destroy-cliffs")]
  DestroyCliffs,

  /// <summary>
  /// Literal value: show-explosion-on-chart
  /// </summary>
  [FactorioRconDefinitionValue("show-explosion-on-chart")]
  ShowExplosionOnChart,

  /// <summary>
  /// Literal value: insert-item
  /// </summary>
  [FactorioRconDefinitionValue("insert-item")]
  InsertItem,

  /// <summary>
  /// Literal value: script
  /// </summary>
  [FactorioRconDefinitionValue("script")]
  Script,

  /// <summary>
  /// Literal value: set-tile
  /// </summary>
  [FactorioRconDefinitionValue("set-tile")]
  SetTile,

  /// <summary>
  /// Literal value: invoke-tile-trigger
  /// </summary>
  [FactorioRconDefinitionValue("invoke-tile-trigger")]
  InvokeTileTrigger,

  /// <summary>
  /// Literal value: destroy-decoratives
  /// </summary>
  [FactorioRconDefinitionValue("destroy-decoratives")]
  DestroyDecoratives,

  /// <summary>
  /// Literal value: camera-effect
  /// </summary>
  [FactorioRconDefinitionValue("camera-effect")]
  CameraEffect,

}

