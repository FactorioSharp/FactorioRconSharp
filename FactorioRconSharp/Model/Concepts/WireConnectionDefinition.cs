#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("WireConnectionDefinition")]
public abstract class WireConnectionDefinition
{
  /// <summary>
  /// The type of wire used.
  /// </summary>
  [FactorioRconAttribute("wire")]
  public WireTypeEnum Wire { get; set; }

  /// <summary>
  /// The entity to (dis)connect the source entity with.
  /// </summary>
  [FactorioRconAttribute("target_entity")]
  public LuaEntity TargetEntity { get; set; }

  /// <summary>
  /// Mandatory if the source entity has more than one circuit connection using circuit wire.
  /// </summary>
  [FactorioRconAttribute("source_circuit_id")]
  public CircuitConnectorIdEnum SourceCircuitId { get; set; }

  /// <summary>
  /// Mandatory if the target entity has more than one circuit connection using circuit wire.
  /// </summary>
  [FactorioRconAttribute("target_circuit_id")]
  public CircuitConnectorIdEnum TargetCircuitId { get; set; }

  /// <summary>
  /// Mandatory if the source entity has more than one wire connection using copper wire.
  /// </summary>
  [FactorioRconAttribute("source_wire_id")]
  public WireConnectionIdEnum SourceWireId { get; set; }

  /// <summary>
  /// Mandatory if the target entity has more than one wire connection using copper wire.
  /// </summary>
  [FactorioRconAttribute("target_wire_id")]
  public WireConnectionIdEnum TargetWireId { get; set; }

}

