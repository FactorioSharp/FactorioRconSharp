#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("wire_connection_id")]
public enum WireConnectionIdEnum
{
    [FactorioRconDefinitionValue("electric_pole")]
    ElectricPole,

    [FactorioRconDefinitionValue("power_switch_left")]
    PowerSwitchLeft,

    [FactorioRconDefinitionValue("power_switch_right")]
    PowerSwitchRight
}
