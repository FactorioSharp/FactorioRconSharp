#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("InserterCircuitConditions")]
public class InserterCircuitConditions
{
    [FactorioRconAttribute("circuit")]
    public CircuitCondition Circuit { get; set; }

    [FactorioRconAttribute("logistics")]
    public CircuitCondition Logistics { get; set; }
}
