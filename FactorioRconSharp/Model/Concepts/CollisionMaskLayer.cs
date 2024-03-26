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
/// A <see cref="String" /> specifying a collision mask layer.
/// 
/// In addition to the listed layers, there is `"layer-13"` through `"layer-55"`. These layers are currently unused by the game but may change. If a mod is going to use one of the unused layers it's recommended to start at the higher layers because the base game will take from the lower ones.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("CollisionMaskLayer")]
public abstract partial class CollisionMaskLayer: OneOfBase<Literal32739668, Literal9926279, Literal19426640, Literal26501661, Literal30350669, Literal7754184, Literal23544769, Literal11709672, Literal4036177, Literal49940297, Literal38982485, Literal56750250, Literal35144529>
{
}

[GenerateOneOf]
public abstract partial class Union40468632: OneOfBase<Literal32739668, Literal9926279, Literal19426640, Literal26501661, Literal30350669, Literal7754184, Literal23544769, Literal11709672, Literal4036177, Literal49940297, Literal38982485, Literal56750250, Literal35144529>
{
}

/// <summary>
/// Literal value: ground-tile
/// </summary>
public abstract class Literal32739668
{
  /// <summary>
  /// Literal value: ground-tile
  /// </summary>
  [FactorioRconAttribute("ground-tile")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: water-tile
/// </summary>
public abstract class Literal9926279
{
  /// <summary>
  /// Literal value: water-tile
  /// </summary>
  [FactorioRconAttribute("water-tile")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: resource-layer
/// </summary>
public abstract class Literal19426640
{
  /// <summary>
  /// Literal value: resource-layer
  /// </summary>
  [FactorioRconAttribute("resource-layer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: doodad-layer
/// </summary>
public abstract class Literal26501661
{
  /// <summary>
  /// Literal value: doodad-layer
  /// </summary>
  [FactorioRconAttribute("doodad-layer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: floor-layer
/// </summary>
public abstract class Literal30350669
{
  /// <summary>
  /// Literal value: floor-layer
  /// </summary>
  [FactorioRconAttribute("floor-layer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: item-layer
/// </summary>
public abstract class Literal7754184
{
  /// <summary>
  /// Literal value: item-layer
  /// </summary>
  [FactorioRconAttribute("item-layer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: ghost-layer
/// </summary>
public abstract class Literal23544769
{
  /// <summary>
  /// Literal value: ghost-layer
  /// </summary>
  [FactorioRconAttribute("ghost-layer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: object-layer
/// </summary>
public abstract class Literal11709672
{
  /// <summary>
  /// Literal value: object-layer
  /// </summary>
  [FactorioRconAttribute("object-layer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: player-layer
/// </summary>
public abstract class Literal4036177
{
  /// <summary>
  /// Literal value: player-layer
  /// </summary>
  [FactorioRconAttribute("player-layer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: train-layer
/// </summary>
public abstract class Literal49940297
{
  /// <summary>
  /// Literal value: train-layer
  /// </summary>
  [FactorioRconAttribute("train-layer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: rail-layer
/// </summary>
public abstract class Literal38982485
{
  /// <summary>
  /// Literal value: rail-layer
  /// </summary>
  [FactorioRconAttribute("rail-layer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: transport-belt-layer
/// </summary>
public abstract class Literal56750250
{
  /// <summary>
  /// Literal value: transport-belt-layer
  /// </summary>
  [FactorioRconAttribute("transport-belt-layer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: not-setup
/// </summary>
public abstract class Literal35144529
{
  /// <summary>
  /// Literal value: not-setup
  /// </summary>
  [FactorioRconAttribute("not-setup")]
  public static object Value { get; private set; }

}

