#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

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

