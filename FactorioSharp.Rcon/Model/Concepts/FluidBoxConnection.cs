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
/// A definition of a fluidbox connection point.
/// </summary>
[FactorioRconConcept("FluidBoxConnection")]
public class FluidBoxConnection
{
  [FactorioRconAttribute("type")]
  public Literals1802748296 Type { get; set; }

  /// <summary>
  /// The 4 cardinal direction connection points for this pipe. This vector is a table with `x` and `y` keys instead of an array.
  /// </summary>
  [FactorioRconAttribute("positions")]
  public LuaArray<Vector> Positions { get; set; }

  /// <summary>
  /// The maximum tile distance this underground connection can connect at if this is an underground pipe.
  /// </summary>
  [FactorioRconAttribute("max_underground_distance")]
  public uint MaxUndergroundDistance { get; set; }

}

