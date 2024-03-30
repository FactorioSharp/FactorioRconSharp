#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("shooting")]
public enum ShootingEnum
{
    [FactorioRconDefinitionValue("not_shooting")]
    NotShooting,

    [FactorioRconDefinitionValue("shooting_enemies")]
    ShootingEnemies,

    [FactorioRconDefinitionValue("shooting_selected")]
    ShootingSelected
}
