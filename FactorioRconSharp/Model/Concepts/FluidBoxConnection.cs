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
/// A definition of a fluidbox connection point.
/// </summary>
[FactorioRconConcept("FluidBoxConnection")]
public abstract class FluidBoxConnection
{
  [FactorioRconAttribute("type")]
  public Union18555401 Type { get; set; }

  /// <summary>
  /// The 4 cardinal direction connection points for this pipe. This vector is a table with `x` and `y` keys instead of an array.
  /// </summary>
  [FactorioRconAttribute("positions")]
  public List<Vector> Positions { get; set; }

  /// <summary>
  /// The maximum tile distance this underground connection can connect at if this is an underground pipe.
  /// </summary>
  [FactorioRconAttribute("max_underground_distance")]
  public uint MaxUndergroundDistance { get; set; }

}

public abstract class Table9896236
{
  [FactorioRconAttribute("type")]
  public Union18555401 Type { get; set; }

  /// <summary>
  /// The 4 cardinal direction connection points for this pipe. This vector is a table with `x` and `y` keys instead of an array.
  /// </summary>
  [FactorioRconAttribute("positions")]
  public List<Vector> Positions { get; set; }

  /// <summary>
  /// The maximum tile distance this underground connection can connect at if this is an underground pipe.
  /// </summary>
  [FactorioRconAttribute("max_underground_distance")]
  public uint MaxUndergroundDistance { get; set; }

}

[GenerateOneOf]
public abstract partial class Union18555401: OneOfBase<Literal1235721, Literal35835924, Literal32608861>
{
}

/// <summary>
/// Literal value: input
/// </summary>
public enum Literal1235721
{
  /// <summary>
  /// Literal value: input
  /// </summary>
  [FactorioRconDefinitionValue("input")]
  Input,

}

/// <summary>
/// Literal value: output
/// </summary>
public enum Literal35835924
{
  /// <summary>
  /// Literal value: output
  /// </summary>
  [FactorioRconDefinitionValue("output")]
  Output,

}

/// <summary>
/// Literal value: input-output
/// </summary>
public enum Literal32608861
{
  /// <summary>
  /// Literal value: input-output
  /// </summary>
  [FactorioRconDefinitionValue("input-output")]
  InputOutput,

}

