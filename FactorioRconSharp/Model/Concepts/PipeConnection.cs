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
  public Union1188066 FlowDirection { get; set; }

  [FactorioRconAttribute("connection_type")]
  public Union34453934 ConnectionType { get; set; }

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

public abstract class Table32438350
{
  [FactorioRconAttribute("flow_direction")]
  public Union1188066 FlowDirection { get; set; }

  [FactorioRconAttribute("connection_type")]
  public Union34453934 ConnectionType { get; set; }

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

[GenerateOneOf]
public abstract partial class Union34453934: OneOfBase<Literal59640001, Literal51838452>
{
}

/// <summary>
/// Literal value: normal
/// </summary>
public enum Literal59640001
{
  /// <summary>
  /// Literal value: normal
  /// </summary>
  [FactorioRconDefinitionValue("normal")]
  Normal,

}

/// <summary>
/// Literal value: underground
/// </summary>
public enum Literal51838452
{
  /// <summary>
  /// Literal value: underground
  /// </summary>
  [FactorioRconDefinitionValue("underground")]
  Underground,

}

[GenerateOneOf]
public abstract partial class Union1188066: OneOfBase<Literal26920103, Literal42485501, Literal24119994>
{
}

/// <summary>
/// Literal value: input
/// </summary>
public enum Literal26920103
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
public enum Literal42485501
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
public enum Literal24119994
{
  /// <summary>
  /// Literal value: input-output
  /// </summary>
  [FactorioRconDefinitionValue("input-output")]
  InputOutput,

}

