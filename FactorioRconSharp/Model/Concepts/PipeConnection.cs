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
/// A single pipe connection for a given fluidbox.
/// </summary>
[FactorioRconConcept("PipeConnection")]
public abstract class PipeConnection
{
  [FactorioRconAttribute("flow_direction")]
  public Type1421203362 FlowDirection { get; set; }

  [FactorioRconAttribute("connection_type")]
  public Type1421203362 ConnectionType { get; set; }

  /// <summary>
  /// The absolute position of this connection within the entity.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  /// <summary>
  /// The absolute position of the connection's intended target.
  /// </summary>
  [FactorioRconAttribute("target_position")]
  public MapPosition TargetPosition { get; set; }

  /// <summary>
  /// The connected fluidbox, if any.
  /// </summary>
  [FactorioRconAttribute("target")]
  public LuaFluidBox Target { get; set; }

  /// <summary>
  /// The index of the target fluidbox, if any.
  /// </summary>
  [FactorioRconAttribute("target_fluidbox_index")]
  public uint TargetFluidboxIndex { get; set; }

  /// <summary>
  /// The index of the target fluidbox pipe connection, if any.
  /// </summary>
  [FactorioRconAttribute("target_pipe_connection_index")]
  public uint TargetPipeConnectionIndex { get; set; }

}

