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
  public Union778356 FlowDirection { get; set; }

  [FactorioRconAttribute("connection_type")]
  public Union16345490 ConnectionType { get; set; }

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

public abstract class Table6428384
{
  [FactorioRconAttribute("flow_direction")]
  public Union778356 FlowDirection { get; set; }

  [FactorioRconAttribute("connection_type")]
  public Union16345490 ConnectionType { get; set; }

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
public abstract partial class Union16345490: OneOfBase<Literal7710979, Literal27712842>
{
}

/// <summary>
/// Literal value: normal
/// </summary>
public abstract class Literal7710979
{
  /// <summary>
  /// Literal value: normal
  /// </summary>
  [FactorioRconAttribute("normal")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: underground
/// </summary>
public abstract class Literal27712842
{
  /// <summary>
  /// Literal value: underground
  /// </summary>
  [FactorioRconAttribute("underground")]
  public static object Value { get; private set; }

}

[GenerateOneOf]
public abstract partial class Union778356: OneOfBase<Literal45098773, Literal7550150, Literal24335424>
{
}

/// <summary>
/// Literal value: input
/// </summary>
public abstract class Literal45098773
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
public abstract class Literal7550150
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
public abstract class Literal24335424
{
  /// <summary>
  /// Literal value: input-output
  /// </summary>
  [FactorioRconAttribute("input-output")]
  public static object Value { get; private set; }

}

