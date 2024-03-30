#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A <see cref="String" /> specifying a collision mask layer.
///     In addition to the listed layers, there is `"layer-13"` through `"layer-55"`. These layers are currently unused by the game but may change. If a mod is going to use one of the
///     unused layers it's recommended to start at the higher layers because the base game will take from the lower ones.
/// </summary>
[FactorioRconDefinition("CollisionMaskLayer")]
public enum CollisionMaskLayer
{
  /// <summary>
  ///     Literal value: ground-tile
  /// </summary>
  [FactorioRconDefinitionValue("ground-tile")]
    GroundTile,

  /// <summary>
  ///     Literal value: water-tile
  /// </summary>
  [FactorioRconDefinitionValue("water-tile")]
    WaterTile,

  /// <summary>
  ///     Literal value: resource-layer
  /// </summary>
  [FactorioRconDefinitionValue("resource-layer")]
    ResourceLayer,

  /// <summary>
  ///     Literal value: doodad-layer
  /// </summary>
  [FactorioRconDefinitionValue("doodad-layer")]
    DoodadLayer,

  /// <summary>
  ///     Literal value: floor-layer
  /// </summary>
  [FactorioRconDefinitionValue("floor-layer")]
    FloorLayer,

  /// <summary>
  ///     Literal value: item-layer
  /// </summary>
  [FactorioRconDefinitionValue("item-layer")]
    ItemLayer,

  /// <summary>
  ///     Literal value: ghost-layer
  /// </summary>
  [FactorioRconDefinitionValue("ghost-layer")]
    GhostLayer,

  /// <summary>
  ///     Literal value: object-layer
  /// </summary>
  [FactorioRconDefinitionValue("object-layer")]
    ObjectLayer,

  /// <summary>
  ///     Literal value: player-layer
  /// </summary>
  [FactorioRconDefinitionValue("player-layer")]
    PlayerLayer,

  /// <summary>
  ///     Literal value: train-layer
  /// </summary>
  [FactorioRconDefinitionValue("train-layer")]
    TrainLayer,

  /// <summary>
  ///     Literal value: rail-layer
  /// </summary>
  [FactorioRconDefinitionValue("rail-layer")]
    RailLayer,

  /// <summary>
  ///     Literal value: transport-belt-layer
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt-layer")]
    TransportBeltLayer,

  /// <summary>
  ///     Literal value: not-setup
  /// </summary>
  [FactorioRconDefinitionValue("not-setup")]
    NotSetup
}
