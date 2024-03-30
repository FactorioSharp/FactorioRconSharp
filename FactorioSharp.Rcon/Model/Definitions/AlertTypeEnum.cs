#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("alert_type")]
public enum AlertTypeEnum
{
  [FactorioRconDefinitionValue("entity_destroyed")]
  EntityDestroyed,

  [FactorioRconDefinitionValue("entity_under_attack")]
  EntityUnderAttack,

  [FactorioRconDefinitionValue("not_enough_construction_robots")]
  NotEnoughConstructionRobots,

  [FactorioRconDefinitionValue("no_material_for_construction")]
  NoMaterialForConstruction,

  [FactorioRconDefinitionValue("not_enough_repair_packs")]
  NotEnoughRepairPacks,

  [FactorioRconDefinitionValue("turret_fire")]
  TurretFire,

  [FactorioRconDefinitionValue("custom")]
  Custom,

  [FactorioRconDefinitionValue("no_storage")]
  NoStorage,

  [FactorioRconDefinitionValue("train_out_of_fuel")]
  TrainOutOfFuel,

}

