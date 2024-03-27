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
/// A set of flags on a selection tool that define how entities and tiles are selected. Active flags are in the dictionary as `true`, while inactive flags aren't present at all.
/// </summary>
[FactorioRconConcept("SelectionModeFlags")]
public abstract class SelectionModeFlags: Dictionary<Union22484352, Literal2409347>
{
}

[GenerateOneOf]
public abstract partial class Union22484352: OneOfBase<Literal50596300, Literal55889342, Literal32825514, Literal18247161, Literal47646072, Literal61043433, Literal6843685, Literal9499668, Literal65275310, Literal28604240, Literal63818145, Literal65112644, Literal25188253, Literal59191269, Literal35057102, Literal65110521, Literal25143668, Literal58254998, Literal15395421, Literal54868387, Literal11385445, Literal37767765, Literal54925564, Literal12586162>
{
}

/// <summary>
/// Literal value: blueprint
/// </summary>
public enum Literal50596300
{
  /// <summary>
  /// Literal value: blueprint
  /// </summary>
  [FactorioRconDefinitionValue("blueprint")]
  Blueprint,

}

/// <summary>
/// Literal value: deconstruct
/// </summary>
public enum Literal55889342
{
  /// <summary>
  /// Literal value: deconstruct
  /// </summary>
  [FactorioRconDefinitionValue("deconstruct")]
  Deconstruct,

}

/// <summary>
/// Literal value: cancel-deconstruct
/// </summary>
public enum Literal32825514
{
  /// <summary>
  /// Literal value: cancel-deconstruct
  /// </summary>
  [FactorioRconDefinitionValue("cancel-deconstruct")]
  CancelDeconstruct,

}

/// <summary>
/// Literal value: items
/// </summary>
public enum Literal18247161
{
  /// <summary>
  /// Literal value: items
  /// </summary>
  [FactorioRconDefinitionValue("items")]
  Items,

}

/// <summary>
/// Literal value: trees
/// </summary>
public enum Literal47646072
{
  /// <summary>
  /// Literal value: trees
  /// </summary>
  [FactorioRconDefinitionValue("trees")]
  Trees,

}

/// <summary>
/// Literal value: buildable-type
/// </summary>
public enum Literal61043433
{
  /// <summary>
  /// Literal value: buildable-type
  /// </summary>
  [FactorioRconDefinitionValue("buildable-type")]
  BuildableType,

}

/// <summary>
/// Literal value: nothing
/// </summary>
public enum Literal6843685
{
  /// <summary>
  /// Literal value: nothing
  /// </summary>
  [FactorioRconDefinitionValue("nothing")]
  Nothing,

}

/// <summary>
/// Literal value: items-to-place
/// </summary>
public enum Literal9499668
{
  /// <summary>
  /// Literal value: items-to-place
  /// </summary>
  [FactorioRconDefinitionValue("items-to-place")]
  ItemsToPlace,

}

/// <summary>
/// Literal value: any-entity
/// </summary>
public enum Literal65275310
{
  /// <summary>
  /// Literal value: any-entity
  /// </summary>
  [FactorioRconDefinitionValue("any-entity")]
  AnyEntity,

}

/// <summary>
/// Literal value: any-tile
/// </summary>
public enum Literal28604240
{
  /// <summary>
  /// Literal value: any-tile
  /// </summary>
  [FactorioRconDefinitionValue("any-tile")]
  AnyTile,

}

/// <summary>
/// Literal value: same-force
/// </summary>
public enum Literal63818145
{
  /// <summary>
  /// Literal value: same-force
  /// </summary>
  [FactorioRconDefinitionValue("same-force")]
  SameForce,

}

/// <summary>
/// Literal value: not-same-force
/// </summary>
public enum Literal65112644
{
  /// <summary>
  /// Literal value: not-same-force
  /// </summary>
  [FactorioRconDefinitionValue("not-same-force")]
  NotSameForce,

}

/// <summary>
/// Literal value: friend
/// </summary>
public enum Literal25188253
{
  /// <summary>
  /// Literal value: friend
  /// </summary>
  [FactorioRconDefinitionValue("friend")]
  Friend,

}

/// <summary>
/// Literal value: enemy
/// </summary>
public enum Literal59191269
{
  /// <summary>
  /// Literal value: enemy
  /// </summary>
  [FactorioRconDefinitionValue("enemy")]
  Enemy,

}

/// <summary>
/// Literal value: upgrade
/// </summary>
public enum Literal35057102
{
  /// <summary>
  /// Literal value: upgrade
  /// </summary>
  [FactorioRconDefinitionValue("upgrade")]
  Upgrade,

}

/// <summary>
/// Literal value: cancel-upgrade
/// </summary>
public enum Literal65110521
{
  /// <summary>
  /// Literal value: cancel-upgrade
  /// </summary>
  [FactorioRconDefinitionValue("cancel-upgrade")]
  CancelUpgrade,

}

/// <summary>
/// Literal value: downgrade
/// </summary>
public enum Literal25143668
{
  /// <summary>
  /// Literal value: downgrade
  /// </summary>
  [FactorioRconDefinitionValue("downgrade")]
  Downgrade,

}

/// <summary>
/// Literal value: entity-with-health
/// </summary>
public enum Literal58254998
{
  /// <summary>
  /// Literal value: entity-with-health
  /// </summary>
  [FactorioRconDefinitionValue("entity-with-health")]
  EntityWithHealth,

}

/// <summary>
/// Literal value: entity-with-force
/// </summary>
public enum Literal15395421
{
  /// <summary>
  /// Literal value: entity-with-force
  /// </summary>
  [FactorioRconDefinitionValue("entity-with-force")]
  EntityWithForce,

}

/// <summary>
/// Literal value: is-military-target
/// </summary>
public enum Literal54868387
{
  /// <summary>
  /// Literal value: is-military-target
  /// </summary>
  [FactorioRconDefinitionValue("is-military-target")]
  IsMilitaryTarget,

}

/// <summary>
/// Literal value: entity-with-owner
/// </summary>
public enum Literal11385445
{
  /// <summary>
  /// Literal value: entity-with-owner
  /// </summary>
  [FactorioRconDefinitionValue("entity-with-owner")]
  EntityWithOwner,

}

/// <summary>
/// Literal value: avoid-rolling-stock
/// </summary>
public enum Literal37767765
{
  /// <summary>
  /// Literal value: avoid-rolling-stock
  /// </summary>
  [FactorioRconDefinitionValue("avoid-rolling-stock")]
  AvoidRollingStock,

}

/// <summary>
/// Literal value: entity-ghost
/// </summary>
public enum Literal54925564
{
  /// <summary>
  /// Literal value: entity-ghost
  /// </summary>
  [FactorioRconDefinitionValue("entity-ghost")]
  EntityGhost,

}

/// <summary>
/// Literal value: tile-ghost
/// </summary>
public enum Literal12586162
{
  /// <summary>
  /// Literal value: tile-ghost
  /// </summary>
  [FactorioRconDefinitionValue("tile-ghost")]
  TileGhost,

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal2409347
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

