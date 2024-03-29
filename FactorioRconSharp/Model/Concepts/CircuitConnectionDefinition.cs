#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CircuitConnectionDefinition")]
public class CircuitConnectionDefinition
{
  /// <summary>
  /// Wire color, either <see cref="Defines.WireType.Green" />.
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

