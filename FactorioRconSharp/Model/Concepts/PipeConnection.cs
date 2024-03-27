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
/// A single pipe connection for a given fluidbox.
/// </summary>
[FactorioRconConcept("PipeConnection")]
public abstract class PipeConnection
{
  [FactorioRconAttribute("flow_direction")]
  public Union25188253 FlowDirection { get; set; }

  [FactorioRconAttribute("connection_type")]
  public Union59191269 ConnectionType { get; set; }

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

/// <summary>
/// Union of literals:
///   - normal
///   - underground
/// </summary>
public enum Union59191269
{
  /// <summary>
  /// Literal value: normal
  /// </summary>
  [FactorioRconDefinitionValue("normal")]
  Normal,

  /// <summary>
  /// Literal value: underground
  /// </summary>
  [FactorioRconDefinitionValue("underground")]
  Underground,

}

/// <summary>
/// Union of literals:
///   - input
///   - output
///   - input-output
/// </summary>
public enum Union25188253
{
  /// <summary>
  /// Literal value: input
  /// </summary>
  [FactorioRconDefinitionValue("input")]
  Input,

  /// <summary>
  /// Literal value: output
  /// </summary>
  [FactorioRconDefinitionValue("output")]
  Output,

  /// <summary>
  /// Literal value: input-output
  /// </summary>
  [FactorioRconDefinitionValue("input-output")]
  InputOutput,

}

