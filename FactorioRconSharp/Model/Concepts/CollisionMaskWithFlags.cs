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
public abstract class CollisionMaskWithFlags: Dictionary<Union42571914, Literal31656973>
{
}

[GenerateOneOf]
public abstract partial class Union42571914: OneOfBase<CollisionMaskLayer, Literal30457319, Literal53179014, Literal21466472>
{
}

/// <summary>
/// Literal value: not-colliding-with-itself
/// </summary>
public abstract class Literal30457319
{
  /// <summary>
  /// Literal value: not-colliding-with-itself
  /// </summary>
  [FactorioRconAttribute("not-colliding-with-itself")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: consider-tile-transitions
/// </summary>
public abstract class Literal53179014
{
  /// <summary>
  /// Literal value: consider-tile-transitions
  /// </summary>
  [FactorioRconAttribute("consider-tile-transitions")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: colliding-with-tiles-only
/// </summary>
public abstract class Literal21466472
{
  /// <summary>
  /// Literal value: colliding-with-tiles-only
  /// </summary>
  [FactorioRconAttribute("colliding-with-tiles-only")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: True
/// </summary>
public abstract class Literal31656973
{
  /// <summary>
  /// Literal value: True
  /// </summary>
  [FactorioRconAttribute("True")]
  public static object Value { get; private set; }

}

