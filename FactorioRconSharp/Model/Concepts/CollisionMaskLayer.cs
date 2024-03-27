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
/// A <see cref="String" /> specifying a collision mask layer.
/// 
/// In addition to the listed layers, there is `"layer-13"` through `"layer-55"`. These layers are currently unused by the game but may change. If a mod is going to use one of the unused layers it's recommended to start at the higher layers because the base game will take from the lower ones.
/// </summary>
[FactorioRconDefinition("CollisionMaskLayer")]
public enum CollisionMaskLayer
{
  /// <summary>
  /// Literal value: ground-tile
  /// </summary>
  [FactorioRconDefinitionValue("ground-tile")]
  Groundsubtracttile,

  /// <summary>
  /// Literal value: water-tile
  /// </summary>
  [FactorioRconDefinitionValue("water-tile")]
  Watersubtracttile,

  /// <summary>
  /// Literal value: resource-layer
  /// </summary>
  [FactorioRconDefinitionValue("resource-layer")]
  Resourcesubtractlayer,

  /// <summary>
  /// Literal value: doodad-layer
  /// </summary>
  [FactorioRconDefinitionValue("doodad-layer")]
  Doodadsubtractlayer,

  /// <summary>
  /// Literal value: floor-layer
  /// </summary>
  [FactorioRconDefinitionValue("floor-layer")]
  Floorsubtractlayer,

  /// <summary>
  /// Literal value: item-layer
  /// </summary>
  [FactorioRconDefinitionValue("item-layer")]
  Itemsubtractlayer,

  /// <summary>
  /// Literal value: ghost-layer
  /// </summary>
  [FactorioRconDefinitionValue("ghost-layer")]
  Ghostsubtractlayer,

  /// <summary>
  /// Literal value: object-layer
  /// </summary>
  [FactorioRconDefinitionValue("object-layer")]
  Objectsubtractlayer,

  /// <summary>
  /// Literal value: player-layer
  /// </summary>
  [FactorioRconDefinitionValue("player-layer")]
  Playersubtractlayer,

  /// <summary>
  /// Literal value: train-layer
  /// </summary>
  [FactorioRconDefinitionValue("train-layer")]
  Trainsubtractlayer,

  /// <summary>
  /// Literal value: rail-layer
  /// </summary>
  [FactorioRconDefinitionValue("rail-layer")]
  Railsubtractlayer,

  /// <summary>
  /// Literal value: transport-belt-layer
  /// </summary>
  [FactorioRconDefinitionValue("transport-belt-layer")]
  Transportsubtractbeltsubtractlayer,

  /// <summary>
  /// Literal value: not-setup
  /// </summary>
  [FactorioRconDefinitionValue("not-setup")]
  Notsubtractsetup,

}

