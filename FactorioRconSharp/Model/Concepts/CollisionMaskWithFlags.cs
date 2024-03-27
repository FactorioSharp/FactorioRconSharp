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
/// A <see cref="CollisionMask" /> which also includes any flags this mask has.
/// </summary>
[FactorioRconConcept("CollisionMaskWithFlags")]
public abstract class CollisionMaskWithFlags: Dictionary<Union40196552, Literal51417822>
{
}

[GenerateOneOf]
public abstract partial class Union40196552: OneOfBase<CollisionMaskLayer, Literal19066549, Literal25216348, Literal26833123>
{
}

/// <summary>
/// Literal value: not-colliding-with-itself
/// </summary>
public enum Literal19066549
{
  /// <summary>
  /// Literal value: not-colliding-with-itself
  /// </summary>
  [FactorioRconDefinitionValue("not-colliding-with-itself")]
  NotCollidingWithItself,

}

/// <summary>
/// Literal value: consider-tile-transitions
/// </summary>
public enum Literal25216348
{
  /// <summary>
  /// Literal value: consider-tile-transitions
  /// </summary>
  [FactorioRconDefinitionValue("consider-tile-transitions")]
  ConsiderTileTransitions,

}

/// <summary>
/// Literal value: colliding-with-tiles-only
/// </summary>
public enum Literal26833123
{
  /// <summary>
  /// Literal value: colliding-with-tiles-only
  /// </summary>
  [FactorioRconDefinitionValue("colliding-with-tiles-only")]
  CollidingWithTilesOnly,

}

/// <summary>
/// Literal value: True
/// </summary>
public enum Literal51417822
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconDefinitionValue("True")]
  True,

}

