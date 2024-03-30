#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("wire_type")]
public enum WireTypeEnum
{
    [FactorioRconDefinitionValue("red")]
    Red,

    [FactorioRconDefinitionValue("green")]
    Green,

    [FactorioRconDefinitionValue("copper")]
    Copper
}
