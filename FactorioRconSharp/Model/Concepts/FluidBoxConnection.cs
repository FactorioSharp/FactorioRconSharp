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
  public Union30384602 Type { get; set; }

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

public abstract class Table17189561
{
  [FactorioRconAttribute("type")]
  public Union30384602 Type { get; set; }

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
public abstract partial class Union30384602: OneOfBase<Literal63167771, Literal4161677, Literal3117632>
{
}

/// <summary>
/// Literal value: input
/// </summary>
public abstract class Literal63167771
{
  /// <summary>
  /// Literal value: input
  /// </summary>
  [FactorioRconAttribute("input")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: output
/// </summary>
public abstract class Literal4161677
{
  /// <summary>
  /// Literal value: output
  /// </summary>
  [FactorioRconAttribute("output")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: input-output
/// </summary>
public abstract class Literal3117632
{
  /// <summary>
  /// Literal value: input-output
  /// </summary>
  [FactorioRconAttribute("input-output")]
  public static object Value { get; private set; }

}

