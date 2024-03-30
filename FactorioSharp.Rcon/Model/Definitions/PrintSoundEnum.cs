#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("print_sound")]
public enum PrintSoundEnum
{
    [FactorioRconDefinitionValue("always")]
    Always,

    [FactorioRconDefinitionValue("never")]
    Never,

    [FactorioRconDefinitionValue("use_player_settings")]
    UsePlayerSettings
}
