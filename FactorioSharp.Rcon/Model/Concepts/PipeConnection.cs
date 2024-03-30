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
/// A single pipe connection for a given fluidbox.
/// </summary>
[FactorioRconConcept("PipeConnection")]
public class PipeConnection
{
  [FactorioRconAttribute("flow_direction")]
  public Literals1728736698 FlowDirection { get; set; }

  [FactorioRconAttribute("connection_type")]
  public Literals1991856432 ConnectionType { get; set; }

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

