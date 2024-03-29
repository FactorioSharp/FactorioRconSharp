#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("shooting")]
public enum ShootingEnum
{
  [FactorioRconDefinitionValue("not_shooting")]
  NotShooting,

  [FactorioRconDefinitionValue("shooting_enemies")]
  ShootingEnemies,

  [FactorioRconDefinitionValue("shooting_selected")]
  ShootingSelected,

}

