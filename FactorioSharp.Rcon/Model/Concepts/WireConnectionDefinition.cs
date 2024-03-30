#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("WireConnectionDefinition")]
public class WireConnectionDefinition
{
  /// <summary>
  ///     The type of wire used.
  /// </summary>
  [FactorioRconAttribute("wire")]
    public WireTypeEnum Wire { get; set; }

  /// <summary>
  ///     The entity to (dis)connect the source entity with.
  /// </summary>
  [FactorioRconAttribute("target_entity")]
    public LuaEntity TargetEntity { get; set; }

  /// <summary>
  ///     Mandatory if the source entity has more than one circuit connection using circuit wire.
  /// </summary>
  [FactorioRconAttribute("source_circuit_id")]
    public CircuitConnectorIdEnum SourceCircuitId { get; set; }

  /// <summary>
  ///     Mandatory if the target entity has more than one circuit connection using circuit wire.
  /// </summary>
  [FactorioRconAttribute("target_circuit_id")]
    public CircuitConnectorIdEnum TargetCircuitId { get; set; }

  /// <summary>
  ///     Mandatory if the source entity has more than one wire connection using copper wire.
  /// </summary>
  [FactorioRconAttribute("source_wire_id")]
    public WireConnectionIdEnum SourceWireId { get; set; }

  /// <summary>
  ///     Mandatory if the target entity has more than one wire connection using copper wire.
  /// </summary>
  [FactorioRconAttribute("target_wire_id")]
    public WireConnectionIdEnum TargetWireId { get; set; }
}
