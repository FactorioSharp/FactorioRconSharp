#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("CircuitConnectionDefinition")]
public class CircuitConnectionDefinition
{
  /// <summary>
  ///     Wire color, either <see cref="Defines.WireType.Green" />.
  /// </summary>
  [FactorioRconAttribute("wire")]
    public WireTypeEnum Wire { get; set; }

    [FactorioRconAttribute("target_entity")]
    public LuaEntity TargetEntity { get; set; }

    [FactorioRconAttribute("source_circuit_id")]
    public CircuitConnectorIdEnum SourceCircuitId { get; set; }

    [FactorioRconAttribute("target_circuit_id")]
    public CircuitConnectorIdEnum TargetCircuitId { get; set; }
}
