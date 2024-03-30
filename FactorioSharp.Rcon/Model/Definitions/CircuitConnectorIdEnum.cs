#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("circuit_connector_id")]
public enum CircuitConnectorIdEnum
{
    [FactorioRconDefinitionValue("accumulator")]
    Accumulator,

    [FactorioRconDefinitionValue("constant_combinator")]
    ConstantCombinator,

    [FactorioRconDefinitionValue("container")]
    Container,

    [FactorioRconDefinitionValue("linked_container")]
    LinkedContainer,

    [FactorioRconDefinitionValue("programmable_speaker")]
    ProgrammableSpeaker,

    [FactorioRconDefinitionValue("rail_signal")]
    RailSignal,

    [FactorioRconDefinitionValue("rail_chain_signal")]
    RailChainSignal,

    [FactorioRconDefinitionValue("roboport")]
    Roboport,

    [FactorioRconDefinitionValue("storage_tank")]
    StorageTank,

    [FactorioRconDefinitionValue("wall")]
    Wall,

    [FactorioRconDefinitionValue("electric_pole")]
    ElectricPole,

    [FactorioRconDefinitionValue("inserter")]
    Inserter,

    [FactorioRconDefinitionValue("lamp")]
    Lamp,

    [FactorioRconDefinitionValue("combinator_input")]
    CombinatorInput,

    [FactorioRconDefinitionValue("combinator_output")]
    CombinatorOutput,

    [FactorioRconDefinitionValue("offshore_pump")]
    OffshorePump,

    [FactorioRconDefinitionValue("pump")]
    Pump
}
