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
[GenerateOneOf]
[FactorioRconConcept("CursorBoxRenderType")]
public abstract partial class CursorBoxRenderType: OneOfBase<Literal61131337, Literal27978332, Literal6065276, Literal41675298, Literal624109, Literal18099175, Literal55114041, Literal54803345>
{
}

[GenerateOneOf]
public abstract partial class Union20620767: OneOfBase<Literal61131337, Literal27978332, Literal6065276, Literal41675298, Literal624109, Literal18099175, Literal55114041, Literal54803345>
{
}

/// <summary>
/// Literal value: entity
/// </summary>
public enum Literal61131337
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconDefinitionValue("entity")]
  Entity,

}

/// <summary>
/// Literal value: electricity
/// </summary>
public enum Literal27978332
{
  /// <summary>
  /// Literal value: electricity
  /// </summary>
  [FactorioRconDefinitionValue("electricity")]
  Electricity,

}

/// <summary>
/// Literal value: copy
/// </summary>
public enum Literal6065276
{
  /// <summary>
  /// Literal value: copy
  /// </summary>
  [FactorioRconDefinitionValue("copy")]
  Copy,

}

/// <summary>
/// Literal value: not-allowed
/// </summary>
public enum Literal41675298
{
  /// <summary>
  /// Literal value: not-allowed
  /// </summary>
  [FactorioRconDefinitionValue("not-allowed")]
  NotAllowed,

}

/// <summary>
/// Literal value: pair
/// </summary>
public enum Literal624109
{
  /// <summary>
  /// Literal value: pair
  /// </summary>
  [FactorioRconDefinitionValue("pair")]
  Pair,

}

/// <summary>
/// Literal value: logistics
/// </summary>
public enum Literal18099175
{
  /// <summary>
  /// Literal value: logistics
  /// </summary>
  [FactorioRconDefinitionValue("logistics")]
  Logistics,

}

/// <summary>
/// Literal value: train-visualization
/// </summary>
public enum Literal55114041
{
  /// <summary>
  /// Literal value: train-visualization
  /// </summary>
  [FactorioRconDefinitionValue("train-visualization")]
  TrainVisualization,

}

/// <summary>
/// Literal value: blueprint-snap-rectangle
/// </summary>
public enum Literal54803345
{
  /// <summary>
  /// Literal value: blueprint-snap-rectangle
  /// </summary>
  [FactorioRconDefinitionValue("blueprint-snap-rectangle")]
  BlueprintSnapRectangle,

}

