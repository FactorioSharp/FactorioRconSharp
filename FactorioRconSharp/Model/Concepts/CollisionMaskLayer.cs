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
public abstract partial class CollisionMaskLayer: OneOfBase<Literal31662221, Literal45789204, Literal52818505, Literal55341663, Literal61404363, Literal35896081, Literal34353393, Literal56724303, Literal34392072, Literal57846001, Literal66921295, Literal61669371, Literal43581300>
{
}

[GenerateOneOf]
public abstract partial class Union28860985: OneOfBase<Literal31662221, Literal45789204, Literal52818505, Literal55341663, Literal61404363, Literal35896081, Literal34353393, Literal56724303, Literal34392072, Literal57846001, Literal66921295, Literal61669371, Literal43581300>
{
}

/// <summary>
/// Literal value: ground-tile
/// </summary>
public enum Literal31662221
{
  /// <summary>
  /// Literal value: ground-tile
  /// </summary>
  [FactorioRconDefinitionValue("ground-tile")]
  GroundTile,

}

/// <summary>
/// Literal value: water-tile
/// </summary>
public enum Literal45789204
{
  /// <summary>
  /// Literal value: water-tile
  /// </summary>
  [FactorioRconDefinitionValue("water-tile")]
  WaterTile,

}

/// <summary>
/// Literal value: resource-layer
/// </summary>
public enum Literal52818505
{
  /// <summary>
  /// Literal value: resource-layer
  /// </summary>
  [FactorioRconDefinitionValue("resource-layer")]
  ResourceLayer,

}

/// <summary>
/// Literal value: doodad-layer
/// </summary>
public enum Literal55341663
{
  /// <summary>
  /// Literal value: doodad-layer
  /// </summary>
  [FactorioRconDefinitionValue("doodad-layer")]
  DoodadLayer,

}

/// <summary>
/// Literal value: floor-layer
/// </summary>
public enum Literal61404363
{
  /// <summary>
  /// Literal value: floor-layer
  /// </summary>
  [FactorioRconDefinitionValue("floor-layer")]
  FloorLayer,

}

/// <summary>
/// Literal value: item-layer
/// </summary>
public enum Literal35896081
{
  /// <summary>
  /// Literal value: item-layer
  /// </summary>
  [FactorioRconDefinitionValue("item-layer")]
  ItemLayer,

}

/// <summary>
/// Literal value: ghost-layer
/// </summary>
public enum Literal34353393
{
  /// <summary>
  /// Literal value: ghost-layer
  /// </summary>
  [FactorioRconDefinitionValue("ghost-layer")]
  GhostLayer,

}

/// <summary>
/// Literal value: object-layer
/// </summary>
public enum Literal56724303
{
  /// <summary>
  /// Literal value: object-layer
  /// </summary>
  [FactorioRconDefinitionValue("object-layer")]
  ObjectLayer,

}

/// <summary>
/// Literal value: player-layer
/// </summary>
public enum Literal34392072
{
  /// <summary>
  /// Literal value: player-layer
  /// </summary>
  [FactorioRconDefinitionValue("player-layer")]
  PlayerLayer,

}

/// <summary>
/// Literal value: train-layer
/// </summary>
public enum Literal57846001
{
  /// <summary>
  /// Literal value: train-layer
  /// </summary>
  [FactorioRconDefinitionValue("train-layer")]
  TrainLayer,

}

/// <summary>
/// Literal value: rail-layer
/// </summary>
public enum Literal66921295
{
  /// <summary>
  /// Literal value: rail-layer
  /// </summary>
  [FactorioRconDefinitionValue("rail-layer")]
  RailLayer,

}

/// <summary>
/// Literal value: transport-belt-layer
/// </summary>
public enum Literal61669371
{
  /// <summary>
  /// Literal value: transport-belt-layer
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt-layer")]
  TransportBeltLayer,

}

/// <summary>
/// Literal value: not-setup
/// </summary>
public enum Literal43581300
{
  /// <summary>
  /// Literal value: not-setup
  /// </summary>
  [FactorioRconDefinitionValue("not-setup")]
  NotSetup,

}

