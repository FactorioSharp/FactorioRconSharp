#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("DragTarget")]
public class DragTarget
{
    [FactorioRconAttribute("target_entity")]
    public LuaEntity TargetEntity { get; set; }

    /// <summary>
    ///     If the wire being dragged is a circuit wire this is the connector id.
    /// </summary>
    [FactorioRconAttribute("target_circuit_id")]
    public CircuitConnectorIdEnum TargetCircuitId { get; set; }

    /// <summary>
    ///     If the wire being dragged is copper wire this is the wire id.
    /// </summary>
    [FactorioRconAttribute("target_wire_id")]
    public WireConnectionIdEnum TargetWireId { get; set; }
}
