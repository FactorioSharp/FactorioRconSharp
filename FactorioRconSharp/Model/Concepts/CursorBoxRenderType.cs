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
/// One of the following values:
/// </summary>
[FactorioRconDefinition("CursorBoxRenderType")]
public enum CursorBoxRenderType
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
  Entity,

  /// <summary>
  /// Literal value: electricity
  /// </summary>
  [FactorioRconDefinitionValue("electricity")]
  Electricity,

  /// <summary>
  /// Literal value: copy
  /// </summary>
  [FactorioRconDefinitionValue("copy")]
  Copy,

  /// <summary>
  /// Literal value: not-allowed
  /// </summary>
  [FactorioRconDefinitionValue("not-allowed")]
  NotAllowed,

  /// <summary>
  /// Literal value: pair
  /// </summary>
  [FactorioRconDefinitionValue("pair")]
  Pair,

  /// <summary>
  /// Literal value: logistics
  /// </summary>
  [FactorioRconDefinitionValue("logistics")]
  Logistics,

  /// <summary>
  /// Literal value: train-visualization
  /// </summary>
  [FactorioRconDefinitionValue("train-visualization")]
  TrainVisualization,

  /// <summary>
  /// Literal value: blueprint-snap-rectangle
  /// </summary>
  [FactorioRconDefinitionValue("blueprint-snap-rectangle")]
  BlueprintSnapRectangle,

}

