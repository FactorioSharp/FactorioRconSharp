#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("inventory")]
public enum InventoryEnum
{
    [FactorioRconDefinitionValue("fuel")]
    Fuel,

    [FactorioRconDefinitionValue("burnt_result")]
    BurntResult,

    [FactorioRconDefinitionValue("chest")]
    Chest,

    [FactorioRconDefinitionValue("furnace_source")]
    FurnaceSource,

    [FactorioRconDefinitionValue("furnace_result")]
    FurnaceResult,

    [FactorioRconDefinitionValue("furnace_modules")]
    FurnaceModules,

    [FactorioRconDefinitionValue("character_main")]
    CharacterMain,

    [FactorioRconDefinitionValue("character_guns")]
    CharacterGuns,

    [FactorioRconDefinitionValue("character_ammo")]
    CharacterAmmo,

    [FactorioRconDefinitionValue("character_armor")]
    CharacterArmor,

    [FactorioRconDefinitionValue("character_vehicle")]
    CharacterVehicle,

    [FactorioRconDefinitionValue("character_trash")]
    CharacterTrash,

    [FactorioRconDefinitionValue("god_main")]
    GodMain,

    [FactorioRconDefinitionValue("editor_main")]
    EditorMain,

    [FactorioRconDefinitionValue("editor_guns")]
    EditorGuns,

    [FactorioRconDefinitionValue("editor_ammo")]
    EditorAmmo,

    [FactorioRconDefinitionValue("editor_armor")]
    EditorArmor,

    [FactorioRconDefinitionValue("roboport_robot")]
    RoboportRobot,

    [FactorioRconDefinitionValue("roboport_material")]
    RoboportMaterial,

    [FactorioRconDefinitionValue("robot_cargo")]
    RobotCargo,

    [FactorioRconDefinitionValue("robot_repair")]
    RobotRepair,

    [FactorioRconDefinitionValue("assembling_machine_input")]
    AssemblingMachineInput,

    [FactorioRconDefinitionValue("assembling_machine_output")]
    AssemblingMachineOutput,

    [FactorioRconDefinitionValue("assembling_machine_modules")]
    AssemblingMachineModules,

    [FactorioRconDefinitionValue("lab_input")]
    LabInput,

    [FactorioRconDefinitionValue("lab_modules")]
    LabModules,

    [FactorioRconDefinitionValue("mining_drill_modules")]
    MiningDrillModules,

    [FactorioRconDefinitionValue("item_main")]
    ItemMain,

    [FactorioRconDefinitionValue("rocket_silo_rocket")]
    RocketSiloRocket,

    [FactorioRconDefinitionValue("rocket_silo_result")]
    RocketSiloResult,

    [FactorioRconDefinitionValue("rocket_silo_input")]
    RocketSiloInput,

    [FactorioRconDefinitionValue("rocket_silo_output")]
    RocketSiloOutput,

    [FactorioRconDefinitionValue("rocket_silo_modules")]
    RocketSiloModules,

    [FactorioRconDefinitionValue("rocket")]
    Rocket,

    [FactorioRconDefinitionValue("car_trunk")]
    CarTrunk,

    [FactorioRconDefinitionValue("car_ammo")]
    CarAmmo,

    [FactorioRconDefinitionValue("cargo_wagon")]
    CargoWagon,

    [FactorioRconDefinitionValue("turret_ammo")]
    TurretAmmo,

    [FactorioRconDefinitionValue("beacon_modules")]
    BeaconModules,

    [FactorioRconDefinitionValue("character_corpse")]
    CharacterCorpse,

    [FactorioRconDefinitionValue("artillery_turret_ammo")]
    ArtilleryTurretAmmo,

    [FactorioRconDefinitionValue("artillery_wagon_ammo")]
    ArtilleryWagonAmmo,

    [FactorioRconDefinitionValue("spider_trunk")]
    SpiderTrunk,

    [FactorioRconDefinitionValue("spider_ammo")]
    SpiderAmmo,

    [FactorioRconDefinitionValue("spider_trash")]
    SpiderTrash
}
