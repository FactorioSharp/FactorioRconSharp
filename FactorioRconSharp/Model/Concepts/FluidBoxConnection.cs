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
/// A definition of a fluidbox connection point.
/// </summary>
[FactorioRconConcept("FluidBoxConnection")]
public abstract class FluidBoxConnection
{
  [FactorioRconAttribute("type")]
  public Literals1518599809 Type { get; set; }

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

