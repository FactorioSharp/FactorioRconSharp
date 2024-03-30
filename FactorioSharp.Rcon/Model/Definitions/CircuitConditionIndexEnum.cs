#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("circuit_condition_index")]
public enum CircuitConditionIndexEnum
{
    [FactorioRconDefinitionValue("inserter_circuit")]
    InserterCircuit,

    [FactorioRconDefinitionValue("inserter_logistic")]
    InserterLogistic,

    [FactorioRconDefinitionValue("lamp")]
    Lamp,

    [FactorioRconDefinitionValue("arithmetic_combinator")]
    ArithmeticCombinator,

    [FactorioRconDefinitionValue("decider_combinator")]
    DeciderCombinator,

    [FactorioRconDefinitionValue("constant_combinator")]
    ConstantCombinator,

    [FactorioRconDefinitionValue("offshore_pump")]
    OffshorePump,

    [FactorioRconDefinitionValue("pump")]
    Pump
}
