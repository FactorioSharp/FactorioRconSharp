#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;
using FactorioSharp.Rcon.Model.Definitions;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
///     Prototype of an entity.
/// </summary>
[FactorioRconClass("LuaEntityPrototype")]
public abstract class LuaEntityPrototype : LuaObject
{
  /// <summary>
  ///     Type of this prototype.
  /// </summary>
  [FactorioRconAttribute("type")]
    public string Type { get; private set; }

  /// <summary>
  ///     Name of this prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
    public string Name { get; private set; }

    [FactorioRconAttribute("localised_name")]
    public LocalisedString LocalisedName { get; private set; }

    [FactorioRconAttribute("localised_description")]
    public LocalisedString LocalisedDescription { get; private set; }

    /// <summary>
    ///     Max health of this entity. Will be `0` if this is not an entity with health.
    /// </summary>
    [FactorioRconAttribute("max_health")]
    public float MaxHealth { get; private set; }

    /// <summary>
    ///     Whether this resource is infinite.
    /// </summary>
    [FactorioRconAttribute("infinite_resource")]
    public bool InfiniteResource { get; private set; }

    /// <summary>
    ///     Minimum amount of this resource.
    /// </summary>
    [FactorioRconAttribute("minimum_resource_amount")]
    public uint MinimumResourceAmount { get; private set; }

    /// <summary>
    ///     The normal amount for this resource.
    /// </summary>
    [FactorioRconAttribute("normal_resource_amount")]
    public uint NormalResourceAmount { get; private set; }

    /// <summary>
    ///     Every time this infinite resource 'ticks' down, it is reduced by this amount. Meaningless if this isn't an infinite resource.
    /// </summary>
    [FactorioRconAttribute("infinite_depletion_resource_amount")]
    public uint InfiniteDepletionResourceAmount { get; private set; }

    /// <summary>
    ///     Name of the category of this resource.
    /// </summary>
    [FactorioRconAttribute("resource_category")]
    public string ResourceCategory { get; private set; }

    /// <summary>
    ///     Whether this entity is minable and what can be obtained by mining it.
    /// </summary>
    [FactorioRconAttribute("mineable_properties")]
    public Table133459763 MineableProperties { get; private set; }

    /// <summary>
    ///     Items that when placed will produce this entity, if any. Construction bots will choose the first item in the list to build this entity.
    /// </summary>
    [FactorioRconAttribute("items_to_place_this")]
    public List<ItemStackDefinition> ItemsToPlaceThis { get; private set; }

    /// <summary>
    ///     The bounding box used for collision checking.
    /// </summary>
    [FactorioRconAttribute("collision_box")]
    public BoundingBox CollisionBox { get; private set; }

    /// <summary>
    ///     The secondary bounding box used for collision checking, if any. This is only used in rails and rail remnants.
    /// </summary>
    [FactorioRconAttribute("secondary_collision_box")]
    public BoundingBox SecondaryCollisionBox { get; private set; }

    /// <summary>
    ///     The bounding box used for map generator collision checking.
    /// </summary>
    [FactorioRconAttribute("map_generator_bounding_box")]
    public BoundingBox MapGeneratorBoundingBox { get; private set; }

    /// <summary>
    ///     The bounding box used for drawing selection.
    /// </summary>
    [FactorioRconAttribute("selection_box")]
    public BoundingBox SelectionBox { get; private set; }

    /// <summary>
    ///     The bounding box used for drawing the entity icon.
    /// </summary>
    [FactorioRconAttribute("drawing_box")]
    public BoundingBox DrawingBox { get; private set; }

    /// <summary>
    ///     The bounding box used to attach sticker type entities.
    /// </summary>
    [FactorioRconAttribute("sticker_box")]
    public BoundingBox StickerBox { get; private set; }

    /// <summary>
    ///     The collision masks this entity uses
    /// </summary>
    [FactorioRconAttribute("collision_mask")]
    public CollisionMask CollisionMask { get; private set; }

    [FactorioRconAttribute("collision_mask_with_flags")]
    public CollisionMaskWithFlags CollisionMaskWithFlags { get; private set; }

    /// <summary>
    ///     The hardcoded default collision mask (with flags) for this entity prototype type.
    /// </summary>
    [FactorioRconAttribute("default_collision_mask_with_flags")]
    public CollisionMaskWithFlags DefaultCollisionMaskWithFlags { get; private set; }

    /// <summary>
    ///     The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
    /// </summary>
    [FactorioRconAttribute("order")]
    public string Order { get; private set; }

    /// <summary>
    ///     Group of this entity.
    /// </summary>
    [FactorioRconAttribute("group")]
    public LuaGroup Group { get; private set; }

    /// <summary>
    ///     Subgroup of this entity.
    /// </summary>
    [FactorioRconAttribute("subgroup")]
    public LuaGroup Subgroup { get; private set; }

    /// <summary>
    ///     Amount this entity can heal per tick, if any.
    /// </summary>
    [FactorioRconAttribute("healing_per_tick")]
    public float HealingPerTick { get; private set; }

    /// <summary>
    ///     Amount of pollution emissions per second this entity will create.
    /// </summary>
    [FactorioRconAttribute("emissions_per_second")]
    public double EmissionsPerSecond { get; private set; }

    /// <summary>
    ///     Corpses used when this entity is destroyed. It is a dictionary indexed by the corpse's prototype name.
    /// </summary>
    [FactorioRconAttribute("corpses")]
    public Dictionary<string, LuaEntityPrototype> Corpses { get; private set; }

    /// <summary>
    ///     Is this entity selectable?
    /// </summary>
    [FactorioRconAttribute("selectable_in_game")]
    public bool SelectableInGame { get; private set; }

    /// <summary>
    ///     The selection priority of this entity - a value between 0 and 255
    /// </summary>
    [FactorioRconAttribute("selection_priority")]
    public uint SelectionPriority { get; private set; }

    /// <summary>
    ///     The weight of this vehicle prototype.
    /// </summary>
    [FactorioRconAttribute("weight")]
    public double Weight { get; private set; }

    /// <summary>
    ///     List of resistances towards each damage type. It is a dictionary indexed by damage type names (see `data/base/prototypes/damage-type.lua`).
    /// </summary>
    [FactorioRconAttribute("resistances")]
    public Dictionary<string, Resistance> Resistances { get; private set; }

    /// <summary>
    ///     The group of mutually fast-replaceable entities, if any.
    /// </summary>
    [FactorioRconAttribute("fast_replaceable_group")]
    public string FastReplaceableGroup { get; private set; }

    /// <summary>
    ///     The next upgrade for this entity, if any.
    /// </summary>
    [FactorioRconAttribute("next_upgrade")]
    public LuaEntityPrototype NextUpgrade { get; private set; }

    /// <summary>
    ///     Loot that will be dropped when this entity is killed, if any.
    /// </summary>
    [FactorioRconAttribute("loot")]
    public List<Loot> Loot { get; private set; }

    /// <summary>
    ///     Repair-speed modifier for this entity, if any. Actual repair speed will be `tool_repair_speed * entity_repair_speed_modifier`.
    /// </summary>
    [FactorioRconAttribute("repair_speed_modifier")]
    public uint RepairSpeedModifier { get; private set; }

    /// <summary>
    ///     The range of this turret.
    /// </summary>
    [FactorioRconAttribute("turret_range")]
    public uint TurretRange { get; private set; }

    /// <summary>
    ///     Autoplace specification for this entity prototype, if any.
    /// </summary>
    [FactorioRconAttribute("autoplace_specification")]
    public AutoplaceSpecification AutoplaceSpecification { get; private set; }

    /// <summary>
    ///     The speed of this transport belt.
    /// </summary>
    [FactorioRconAttribute("belt_speed")]
    public double BeltSpeed { get; private set; }

    /// <summary>
    ///     The result units and spawn points with weight and evolution factor for a biter spawner entity.
    /// </summary>
    [FactorioRconAttribute("result_units")]
    public List<UnitSpawnDefinition> ResultUnits { get; private set; }

    /// <summary>
    ///     The attack result of this entity, if any.
    /// </summary>
    [FactorioRconAttribute("attack_result")]
    public List<TriggerItem> AttackResult { get; private set; }

    /// <summary>
    ///     The final attack result for this projectile.
    /// </summary>
    [FactorioRconAttribute("final_attack_result")]
    public List<TriggerItem> FinalAttackResult { get; private set; }

    /// <summary>
    ///     The attack parameters for this entity, if any.
    /// </summary>
    [FactorioRconAttribute("attack_parameters")]
    public AttackParameters AttackParameters { get; private set; }

    /// <summary>
    ///     The spawning cooldown for this enemy spawner prototype.
    /// </summary>
    [FactorioRconAttribute("spawn_cooldown")]
    public Table350516831 SpawnCooldown { get; private set; }

    /// <summary>
    ///     The mining radius of this mining drill prototype.
    /// </summary>
    [FactorioRconAttribute("mining_drill_radius")]
    public double MiningDrillRadius { get; private set; }

    /// <summary>
    ///     The mining speed of this mining drill/character prototype.
    /// </summary>
    [FactorioRconAttribute("mining_speed")]
    public double MiningSpeed { get; private set; }

    /// <summary>
    ///     The logistic mode of this logistic container.
    /// </summary>
    [FactorioRconAttribute("logistic_mode")]
    public Literals1551579449 LogisticMode { get; private set; }

    /// <summary>
    ///     The max underground distance for underground belts and underground pipes.
    /// </summary>
    [FactorioRconAttribute("max_underground_distance")]
    public byte MaxUndergroundDistance { get; private set; }

    /// <summary>
    ///     The flags for this entity prototype.
    /// </summary>
    [FactorioRconAttribute("flags")]
    public EntityPrototypeFlags Flags { get; private set; }

    /// <summary>
    ///     The remains left behind when this entity is mined.
    /// </summary>
    [FactorioRconAttribute("remains_when_mined")]
    public List<LuaEntityPrototype> RemainsWhenMined { get; private set; }

    /// <summary>
    ///     Entities this entity can be pasted onto in addition to the normal allowed ones.
    /// </summary>
    [FactorioRconAttribute("additional_pastable_entities")]
    public List<LuaEntityPrototype> AdditionalPastableEntities { get; private set; }

    /// <summary>
    ///     When false copy-paste is not allowed for this entity.
    /// </summary>
    [FactorioRconAttribute("allow_copy_paste")]
    public bool AllowCopyPaste { get; private set; }

    /// <summary>
    ///     The cursor size used when shooting at this entity.
    /// </summary>
    [FactorioRconAttribute("shooting_cursor_size")]
    public float ShootingCursorSize { get; private set; }

    /// <summary>
    ///     The smoke trigger run when this entity is built, if any.
    /// </summary>
    [FactorioRconAttribute("created_smoke")]
    public Table162611662 CreatedSmoke { get; private set; }

    /// <summary>
    ///     The trigger to run when this entity is created, if any.
    /// </summary>
    [FactorioRconAttribute("created_effect")]
    public List<TriggerItem> CreatedEffect { get; private set; }

    /// <summary>
    ///     The map color used when charting this entity if a friendly or enemy color isn't defined, if any.
    /// </summary>
    [FactorioRconAttribute("map_color")]
    public Color MapColor { get; private set; }

    /// <summary>
    ///     The friendly map color used when charting this entity.
    /// </summary>
    [FactorioRconAttribute("friendly_map_color")]
    public Color FriendlyMapColor { get; private set; }

    /// <summary>
    ///     The enemy map color used when charting this entity.
    /// </summary>
    [FactorioRconAttribute("enemy_map_color")]
    public Color EnemyMapColor { get; private set; }

    /// <summary>
    ///     The evolution requirement to build this entity as a base when expanding enemy bases.
    /// </summary>
    [FactorioRconAttribute("build_base_evolution_requirement")]
    public double BuildBaseEvolutionRequirement { get; private set; }

    /// <summary>
    ///     The instruments for this programmable speaker.
    /// </summary>
    [FactorioRconAttribute("instruments")]
    public List<ProgrammableSpeakerInstrument> Instruments { get; private set; }

    /// <summary>
    ///     The maximum polyphony for this programmable speaker.
    /// </summary>
    [FactorioRconAttribute("max_polyphony")]
    public uint MaxPolyphony { get; private set; }

    /// <summary>
    ///     The module inventory size. `nil` if this entity doesn't support modules.
    /// </summary>
    [FactorioRconAttribute("module_inventory_size")]
    public uint ModuleInventorySize { get; private set; }

    /// <summary>
    ///     The max number of ingredients this crafting machine prototype supports.
    /// </summary>
    [FactorioRconAttribute("ingredient_count")]
    public uint IngredientCount { get; private set; }

    /// <summary>
    ///     The crafting speed.
    /// </summary>
    [FactorioRconAttribute("crafting_speed")]
    public double CraftingSpeed { get; private set; }

    /// <summary>
    ///     The <see cref="LuaRecipeCategoryPrototype" /> this entity prototype supports.
    /// </summary>
    [FactorioRconAttribute("crafting_categories")]
    public Dictionary<string, bool> CraftingCategories { get; private set; }

    /// <summary>
    ///     The <see cref="LuaResourceCategoryPrototype" /> this character or mining drill supports.
    /// </summary>
    [FactorioRconAttribute("resource_categories")]
    public Dictionary<string, bool> ResourceCategories { get; private set; }

    /// <summary>
    ///     The supply area of this electric pole or beacon prototype.
    /// </summary>
    [FactorioRconAttribute("supply_area_distance")]
    public double SupplyAreaDistance { get; private set; }

    /// <summary>
    ///     The maximum wire distance for this entity. 0 if the entity doesn't support wires.
    /// </summary>
    [FactorioRconAttribute("max_wire_distance")]
    public double MaxWireDistance { get; private set; }

    /// <summary>
    ///     The maximum circuit wire distance for this entity. 0 if the entity doesn't support circuit wires.
    /// </summary>
    [FactorioRconAttribute("max_circuit_wire_distance")]
    public double MaxCircuitWireDistance { get; private set; }

    /// <summary>
    ///     The direct energy usage of this entity, if any.
    /// </summary>
    [FactorioRconAttribute("energy_usage")]
    public double EnergyUsage { get; private set; }

    /// <summary>
    ///     The theoretical maximum energy usage for this entity.
    /// </summary>
    [FactorioRconAttribute("max_energy_usage")]
    public double MaxEnergyUsage { get; private set; }

    /// <summary>
    ///     The theoretical maximum energy production for this this entity.
    /// </summary>
    [FactorioRconAttribute("max_energy_production")]
    public double MaxEnergyProduction { get; private set; }

    /// <summary>
    ///     The effectivity of this car prototype, generator prototype.
    /// </summary>
    [FactorioRconAttribute("effectivity")]
    public double Effectivity { get; private set; }

    /// <summary>
    ///     The energy consumption of this car prototype.
    /// </summary>
    [FactorioRconAttribute("consumption")]
    public double Consumption { get; private set; }

    /// <summary>
    ///     The friction of this vehicle prototype.
    /// </summary>
    [FactorioRconAttribute("friction_force")]
    public double FrictionForce { get; private set; }

    /// <summary>
    ///     The braking force of this vehicle prototype.
    /// </summary>
    [FactorioRconAttribute("braking_force")]
    public double BrakingForce { get; private set; }

    /// <summary>
    ///     The air resistance of this rolling stock prototype.
    /// </summary>
    [FactorioRconAttribute("air_resistance")]
    public double AirResistance { get; private set; }

    /// <summary>
    ///     If this car prototype uses tank controls to drive.
    /// </summary>
    [FactorioRconAttribute("tank_driving")]
    public bool TankDriving { get; private set; }

    /// <summary>
    ///     The rotation speed of this car prototype.
    /// </summary>
    [FactorioRconAttribute("rotation_speed")]
    public double RotationSpeed { get; private set; }

    /// <summary>
    ///     The turret rotation speed of this car prototype.
    /// </summary>
    [FactorioRconAttribute("turret_rotation_speed")]
    public float TurretRotationSpeed { get; private set; }

    /// <summary>
    ///     A mapping of the gun name to the gun prototype this prototype uses. `nil` if this entity prototype doesn't use guns.
    /// </summary>
    [FactorioRconAttribute("guns")]
    public Dictionary<string, LuaItemPrototype> Guns { get; private set; }

    /// <summary>
    ///     A vector of the gun prototypes of this car, spider vehicle, artillery wagon, or turret.
    /// </summary>
    [FactorioRconAttribute("indexed_guns")]
    public List<LuaItemPrototype> IndexedGuns { get; private set; }

    /// <summary>
    ///     The default speed of this flying robot, rolling stock or unit. For rolling stocks, this is their `max_speed`.
    /// </summary>
    [FactorioRconAttribute("speed")]
    public double Speed { get; private set; }

    /// <summary>
    ///     The speed multiplier when this flying robot is out of energy.
    /// </summary>
    [FactorioRconAttribute("speed_multiplier_when_out_of_energy")]
    public float SpeedMultiplierWhenOutOfEnergy { get; private set; }

    /// <summary>
    ///     The max payload size of this logistics or construction robot.
    /// </summary>
    [FactorioRconAttribute("max_payload_size")]
    public uint MaxPayloadSize { get; private set; }

    /// <summary>
    ///     Whether this logistics or construction robot renders its cargo when flying.
    /// </summary>
    [FactorioRconAttribute("draw_cargo")]
    public bool DrawCargo { get; private set; }

    /// <summary>
    ///     The energy consumed per tile moved for this flying robot.
    /// </summary>
    [FactorioRconAttribute("energy_per_move")]
    public double EnergyPerMove { get; private set; }

    /// <summary>
    ///     The energy consumed per tick for this flying robot.
    /// </summary>
    [FactorioRconAttribute("energy_per_tick")]
    public double EnergyPerTick { get; private set; }

    /// <summary>
    ///     The max energy for this flying robot.
    /// </summary>
    [FactorioRconAttribute("max_energy")]
    public double MaxEnergy { get; private set; }

    /// <summary>
    ///     The minimum energy for this flying robot before it tries to recharge.
    /// </summary>
    [FactorioRconAttribute("min_to_charge")]
    public float MinToCharge { get; private set; }

    /// <summary>
    ///     The maximum energy for this flying robot above which it won't try to recharge when stationing.
    /// </summary>
    [FactorioRconAttribute("max_to_charge")]
    public float MaxToCharge { get; private set; }

    /// <summary>
    ///     The burner energy source prototype this entity uses, if any.
    /// </summary>
    [FactorioRconAttribute("burner_prototype")]
    public LuaBurnerPrototype BurnerPrototype { get; private set; }

    /// <summary>
    ///     The electric energy source prototype this entity uses, if any.
    /// </summary>
    [FactorioRconAttribute("electric_energy_source_prototype")]
    public LuaElectricEnergySourcePrototype ElectricEnergySourcePrototype { get; private set; }

    /// <summary>
    ///     The heat energy source prototype this entity uses, if any.
    /// </summary>
    [FactorioRconAttribute("heat_energy_source_prototype")]
    public LuaHeatEnergySourcePrototype HeatEnergySourcePrototype { get; private set; }

    /// <summary>
    ///     The fluid energy source prototype this entity uses, if any.
    /// </summary>
    [FactorioRconAttribute("fluid_energy_source_prototype")]
    public LuaFluidEnergySourcePrototype FluidEnergySourcePrototype { get; private set; }

    /// <summary>
    ///     The void energy source prototype this entity uses, if any.
    /// </summary>
    [FactorioRconAttribute("void_energy_source_prototype")]
    public LuaVoidEnergySourcePrototype VoidEnergySourcePrototype { get; private set; }

    /// <summary>
    ///     The heat buffer prototype this entity uses, if any.
    /// </summary>
    [FactorioRconAttribute("heat_buffer_prototype")]
    public LuaHeatBufferPrototype HeatBufferPrototype { get; private set; }

    /// <summary>
    ///     The log2 of grid size of the building
    /// </summary>
    [FactorioRconAttribute("building_grid_bit_shift")]
    public uint BuildingGridBitShift { get; private set; }

    /// <summary>
    ///     The fluid usage of this generator prototype.
    /// </summary>
    [FactorioRconAttribute("fluid_usage_per_tick")]
    public double FluidUsagePerTick { get; private set; }

    /// <summary>
    ///     The maximum fluid temperature of this generator prototype.
    /// </summary>
    [FactorioRconAttribute("maximum_temperature")]
    public double MaximumTemperature { get; private set; }

    /// <summary>
    ///     Whether this generator prototype burns fluid.
    /// </summary>
    [FactorioRconAttribute("burns_fluid")]
    public bool BurnsFluid { get; private set; }

    /// <summary>
    ///     Whether this generator prototype scales fluid usage.
    /// </summary>
    [FactorioRconAttribute("scale_fluid_usage")]
    public bool ScaleFluidUsage { get; private set; }

    /// <summary>
    ///     Whether this generator prototype destroys non-fuel fluids.
    /// </summary>
    [FactorioRconAttribute("destroy_non_fuel_fluid")]
    public bool DestroyNonFuelFluid { get; private set; }

    /// <summary>
    ///     The default maximum power output of this generator prototype.
    /// </summary>
    [FactorioRconAttribute("max_power_output")]
    public double MaxPowerOutput { get; private set; }

    /// <summary>
    ///     The target temperature of this boiler prototype.
    /// </summary>
    [FactorioRconAttribute("target_temperature")]
    public double TargetTemperature { get; private set; }

    /// <summary>
    ///     The boiler operation mode of this boiler prototype.
    /// </summary>
    [FactorioRconAttribute("boiler_mode")]
    public Literals761816996 BoilerMode { get; private set; }

    /// <summary>
    ///     The fluid this offshore pump produces.
    /// </summary>
    [FactorioRconAttribute("fluid")]
    public LuaFluidPrototype Fluid { get; private set; }

    /// <summary>
    ///     The fluid capacity of this entity or 0 if this entity doesn't support fluids.
    /// </summary>
    [FactorioRconAttribute("fluid_capacity")]
    public double FluidCapacity { get; private set; }

    /// <summary>
    ///     The pumping speed of this offshore or normal pump.
    /// </summary>
    [FactorioRconAttribute("pumping_speed")]
    public double PumpingSpeed { get; private set; }

    /// <summary>
    ///     Whether this inserter is a stack-type.
    /// </summary>
    [FactorioRconAttribute("stack")]
    public bool Stack { get; private set; }

    /// <summary>
    ///     Whether this inserter allows custom pickup and drop vectors.
    /// </summary>
    [FactorioRconAttribute("allow_custom_vectors")]
    public bool AllowCustomVectors { get; private set; }

    /// <summary>
    ///     Whether this inserter allows burner leeching.
    /// </summary>
    [FactorioRconAttribute("allow_burner_leech")]
    public bool AllowBurnerLeech { get; private set; }

    /// <summary>
    ///     The extension speed of this inserter.
    /// </summary>
    [FactorioRconAttribute("inserter_extension_speed")]
    public double InserterExtensionSpeed { get; private set; }

    /// <summary>
    ///     The rotation speed of this inserter.
    /// </summary>
    [FactorioRconAttribute("inserter_rotation_speed")]
    public double InserterRotationSpeed { get; private set; }

    /// <summary>
    ///     The pickup position for this inserter.
    /// </summary>
    [FactorioRconAttribute("inserter_pickup_position")]
    public Vector InserterPickupPosition { get; private set; }

    /// <summary>
    ///     The drop position for this inserter.
    /// </summary>
    [FactorioRconAttribute("inserter_drop_position")]
    public Vector InserterDropPosition { get; private set; }

    /// <summary>
    ///     True if this inserter chases items on belts for pickup.
    /// </summary>
    [FactorioRconAttribute("inserter_chases_belt_items")]
    public bool InserterChasesBeltItems { get; private set; }

    /// <summary>
    ///     If this simple-entity is counted as a rock for the deconstruction planner "trees and rocks only" filter.
    /// </summary>
    [FactorioRconAttribute("count_as_rock_for_filtered_deconstruction")]
    public bool CountAsRockForFilteredDeconstruction { get; private set; }

    /// <summary>
    ///     The filter count of this inserter, loader, or logistic chest. For logistic containers, `nil` means no limit.
    /// </summary>
    [FactorioRconAttribute("filter_count")]
    public uint FilterCount { get; private set; }

    /// <summary>
    ///     The time to live for this prototype or `0` if prototype doesn't have time_to_live or time_before_removed.
    /// </summary>
    [FactorioRconAttribute("time_to_live")]
    public uint TimeToLive { get; private set; }

    /// <summary>
    ///     The distribution effectivity for this beacon prototype.
    /// </summary>
    [FactorioRconAttribute("distribution_effectivity")]
    public double DistributionEffectivity { get; private set; }

    /// <summary>
    ///     Whether this explosion has a beam.
    /// </summary>
    [FactorioRconAttribute("explosion_beam")]
    public double ExplosionBeam { get; private set; }

    /// <summary>
    ///     Whether this explosion rotates.
    /// </summary>
    [FactorioRconAttribute("explosion_rotate")]
    public double ExplosionRotate { get; private set; }

    /// <summary>
    ///     If it is a tree, return the number of colors it supports.
    /// </summary>
    [FactorioRconAttribute("tree_color_count")]
    public byte TreeColorCount { get; private set; }

    /// <summary>
    ///     Whether this entity raises an alert when damaged.
    /// </summary>
    [FactorioRconAttribute("alert_when_damaged")]
    public bool AlertWhenDamaged { get; private set; }

    /// <summary>
    ///     Whether this turret raises an alert when attacking
    /// </summary>
    [FactorioRconAttribute("alert_when_attacking")]
    public bool AlertWhenAttacking { get; private set; }

    /// <summary>
    ///     The color of the prototype, if any.
    /// </summary>
    [FactorioRconAttribute("color")]
    public Color Color { get; private set; }

    /// <summary>
    ///     Does this prototype collision mask collide with itself?
    /// </summary>
    [FactorioRconAttribute("collision_mask_collides_with_self")]
    public bool CollisionMaskCollidesWithSelf { get; private set; }

    /// <summary>
    ///     Does this prototype collision mask collide with tiles only?
    /// </summary>
    [FactorioRconAttribute("collision_mask_collides_with_tiles_only")]
    public bool CollisionMaskCollidesWithTilesOnly { get; private set; }

    /// <summary>
    ///     Does this prototype collision mask consider tile transitions?
    /// </summary>
    [FactorioRconAttribute("collision_mask_considers_tile_transitions")]
    public bool CollisionMaskConsidersTileTransitions { get; private set; }

    /// <summary>
    ///     The allowed module effects for this entity, if any.
    /// </summary>
    [FactorioRconAttribute("allowed_effects")]
    public Dictionary<string, bool> AllowedEffects { get; private set; }

    /// <summary>
    ///     The rocket parts required for this rocket silo prototype.
    /// </summary>
    [FactorioRconAttribute("rocket_parts_required")]
    public uint RocketPartsRequired { get; private set; }

    /// <summary>
    ///     The rocket rising delay for this rocket silo prototype.
    /// </summary>
    [FactorioRconAttribute("rocket_rising_delay")]
    public byte RocketRisingDelay { get; private set; }

    /// <summary>
    ///     The rocket launch delay for this rocket silo prototype.
    /// </summary>
    [FactorioRconAttribute("launch_wait_time")]
    public byte LaunchWaitTime { get; private set; }

    /// <summary>
    ///     The light blinking speed for this rocket silo prototype.
    /// </summary>
    [FactorioRconAttribute("light_blinking_speed")]
    public double LightBlinkingSpeed { get; private set; }

    /// <summary>
    ///     The door opening speed for this rocket silo prototype.
    /// </summary>
    [FactorioRconAttribute("door_opening_speed")]
    public double DoorOpeningSpeed { get; private set; }

    /// <summary>
    ///     The rising speed for this rocket silo rocket prototype.
    /// </summary>
    [FactorioRconAttribute("rising_speed")]
    public double RisingSpeed { get; private set; }

    /// <summary>
    ///     The engine starting speed for this rocket silo rocket prototype.
    /// </summary>
    [FactorioRconAttribute("engine_starting_speed")]
    public double EngineStartingSpeed { get; private set; }

    /// <summary>
    ///     The flying speed for this rocket silo rocket prototype.
    /// </summary>
    [FactorioRconAttribute("flying_speed")]
    public double FlyingSpeed { get; private set; }

    /// <summary>
    ///     The flying acceleration for this rocket silo rocket prototype.
    /// </summary>
    [FactorioRconAttribute("flying_acceleration")]
    public double FlyingAcceleration { get; private set; }

    /// <summary>
    ///     The fixed recipe name for this assembling machine prototype, if any.
    /// </summary>
    [FactorioRconAttribute("fixed_recipe")]
    public string FixedRecipe { get; private set; }

    /// <summary>
    ///     The construction radius for this roboport prototype.
    /// </summary>
    [FactorioRconAttribute("construction_radius")]
    public double ConstructionRadius { get; private set; }

    /// <summary>
    ///     The logistic radius for this roboport prototype.
    /// </summary>
    [FactorioRconAttribute("logistic_radius")]
    public double LogisticRadius { get; private set; }

    /// <summary>
    ///     The energy used per hitpoint taken for this vehicle during collisions.
    /// </summary>
    [FactorioRconAttribute("energy_per_hit_point")]
    public double EnergyPerHitPoint { get; private set; }

    /// <summary>
    ///     If this prototype will attempt to create a ghost of itself on death.
    /// </summary>
    [FactorioRconAttribute("create_ghost_on_death")]
    public bool CreateGhostOnDeath { get; private set; }

    /// <summary>
    ///     Name of the ammo category of this land mine.
    /// </summary>
    [FactorioRconAttribute("ammo_category")]
    public string AmmoCategory { get; private set; }

    /// <summary>
    ///     The time it takes this land mine to arm.
    /// </summary>
    [FactorioRconAttribute("timeout")]
    public uint Timeout { get; private set; }

    /// <summary>
    ///     The collision mask entities must collide with to make this landmine blow up.
    /// </summary>
    [FactorioRconAttribute("trigger_collision_mask")]
    public CollisionMaskWithFlags TriggerCollisionMask { get; private set; }

    /// <summary>
    ///     The fluidbox prototypes for this entity.
    /// </summary>
    [FactorioRconAttribute("fluidbox_prototypes")]
    public List<LuaFluidBoxPrototype> FluidboxPrototypes { get; private set; }

    [FactorioRconAttribute("neighbour_bonus")]
    public double NeighbourBonus { get; private set; }

    [FactorioRconAttribute("container_distance")]
    public double ContainerDistance { get; private set; }

    [FactorioRconAttribute("belt_distance")]
    public double BeltDistance { get; private set; }

    [FactorioRconAttribute("belt_length")]
    public double BeltLength { get; private set; }

    /// <summary>
    ///     Everything in the following list is considered a building.
    ///     - AccumulatorPrototype
    ///     - ArtilleryTurretPrototype
    ///     - BeaconPrototype
    ///     - BoilerPrototype
    ///     - BurnerGeneratorPrototype
    ///     - CombinatorPrototype → ArithmeticCombinator, DeciderCombinator
    ///     - ConstantCombinatorPrototype
    ///     - ContainerPrototype → LogisticContainer, InfinityContainer
    ///     - CraftingMachinePrototype → AssemblingMachine, RocketSilo, Furnace
    ///     - ElectricEnergyInterfacePrototype
    ///     - ElectricPolePrototype
    ///     - EnemySpawnerPrototype
    ///     - GatePrototype
    ///     - GeneratorPrototype
    ///     - HeatInterfacePrototype
    ///     - HeatPipePrototype
    ///     - InserterPrototype
    ///     - LabPrototype
    ///     - LampPrototype
    ///     - LinkedContainerPrototype
    ///     - MarketPrototype
    ///     - MiningDrillPrototype
    ///     - OffshorePumpPrototype
    ///     - PipePrototype → InfinityPipe
    ///     - PipeToGroundPrototype
    ///     - PlayerPortPrototype
    ///     - PowerSwitchPrototype
    ///     - ProgrammableSpeakerPrototype
    ///     - PumpPrototype
    ///     - RadarPrototype
    ///     - RailPrototype → CurvedRail, StraightRail
    ///     - RailSignalBasePrototype → RailChainSignal, RailSignal
    ///     - ReactorPrototype
    ///     - RoboportPrototype
    ///     - SimpleEntityPrototype
    ///     - SimpleEntityWithOwnerPrototype → SimpleEntityWithForce
    ///     - SolarPanelPrototype
    ///     - StorageTankPrototype
    ///     - TrainStopPrototype
    ///     - TransportBeltConnectablePrototype → LinkedBelt, Loader1x1, Loader1x2, Splitter, TransportBelt, UndergroundBelt
    ///     - TurretPrototype → AmmoTurret, ElectricTurret, FluidTurret
    ///     - WallPrototype
    /// </summary>
    [FactorioRconAttribute("is_building")]
    public bool IsBuilding { get; private set; }

    /// <summary>
    ///     The amount of ammo that inserters automatically insert into this ammo-turret or artillery-turret.
    /// </summary>
    [FactorioRconAttribute("automated_ammo_count")]
    public uint AutomatedAmmoCount { get; private set; }

    /// <summary>
    ///     The max speed of this projectile or flying robot prototype.
    /// </summary>
    [FactorioRconAttribute("max_speed")]
    public double MaxSpeed { get; private set; }

    /// <summary>
    ///     Value between 0 and 1 darkness where all lamps of this lamp prototype are on.
    /// </summary>
    [FactorioRconAttribute("darkness_for_all_lamps_on")]
    public float DarknessForAllLampsOn { get; private set; }

    /// <summary>
    ///     Value between 0 and 1 darkness where all lamps of this lamp prototype are off.
    /// </summary>
    [FactorioRconAttribute("darkness_for_all_lamps_off")]
    public float DarknessForAllLampsOff { get; private set; }

    /// <summary>
    ///     Whether the lamp is always on (except when out of power or turned off by the circuit network).
    /// </summary>
    [FactorioRconAttribute("always_on")]
    public bool AlwaysOn { get; private set; }

    /// <summary>
    ///     The minimum darkness at which this unit spawner can spawn entities.
    /// </summary>
    [FactorioRconAttribute("min_darkness_to_spawn")]
    public float MinDarknessToSpawn { get; private set; }

    /// <summary>
    ///     The maximum darkness at which this unit spawner can spawn entities.
    /// </summary>
    [FactorioRconAttribute("max_darkness_to_spawn")]
    public float MaxDarknessToSpawn { get; private set; }

    [FactorioRconAttribute("call_for_help_radius")]
    public double CallForHelpRadius { get; private set; }

    /// <summary>
    ///     Count of enemies this spawner can sustain.
    /// </summary>
    [FactorioRconAttribute("max_count_of_owned_units")]
    public double MaxCountOfOwnedUnits { get; private set; }

    /// <summary>
    ///     How many friendly units are required within the spawning_radius of this spawner for it to stop producing more units.
    /// </summary>
    [FactorioRconAttribute("max_friends_around_to_spawn")]
    public double MaxFriendsAroundToSpawn { get; private set; }

    /// <summary>
    ///     How far from the spawner can the units be spawned.
    /// </summary>
    [FactorioRconAttribute("spawning_radius")]
    public double SpawningRadius { get; private set; }

    /// <summary>
    ///     What spaces should be between the spawned units.
    /// </summary>
    [FactorioRconAttribute("spawning_spacing")]
    public double SpawningSpacing { get; private set; }

    /// <summary>
    ///     The radius of this entity prototype.
    /// </summary>
    [FactorioRconAttribute("radius")]
    public double Radius { get; private set; }

    /// <summary>
    ///     The item prototype name used to destroy this cliff.
    /// </summary>
    [FactorioRconAttribute("cliff_explosive_prototype")]
    public string CliffExplosivePrototype { get; private set; }

    /// <summary>
    ///     The rocket entity prototype associated with this rocket silo prototype.
    /// </summary>
    [FactorioRconAttribute("rocket_entity_prototype")]
    public LuaEntityPrototype RocketEntityPrototype { get; private set; }

    /// <summary>
    ///     Whether this unit, car, or character prototype has belt immunity.
    /// </summary>
    [FactorioRconAttribute("has_belt_immunity")]
    public bool HasBeltImmunity { get; private set; }

    /// <summary>
    ///     The vision distance of this unit prototype.
    /// </summary>
    [FactorioRconAttribute("vision_distance")]
    public double VisionDistance { get; private set; }

    /// <summary>
    ///     The amount of pollution that has to be absorbed by the unit's spawner before the unit will leave the spawner and attack the source of the pollution.
    /// </summary>
    [FactorioRconAttribute("pollution_to_join_attack")]
    public float PollutionToJoinAttack { get; private set; }

    /// <summary>
    ///     The minimum pursue time of this unit prototype.
    /// </summary>
    [FactorioRconAttribute("min_pursue_time")]
    public uint MinPursueTime { get; private set; }

    /// <summary>
    ///     The maximum pursue distance of this unit prototype.
    /// </summary>
    [FactorioRconAttribute("max_pursue_distance")]
    public double MaxPursueDistance { get; private set; }

    /// <summary>
    ///     The radar range of this unit prototype.
    /// </summary>
    [FactorioRconAttribute("radar_range")]
    public uint RadarRange { get; private set; }

    /// <summary>
    ///     Whether this unit prototype can move while shooting.
    /// </summary>
    [FactorioRconAttribute("move_while_shooting")]
    public bool MoveWhileShooting { get; private set; }

    /// <summary>
    ///     Whether this unit prototype can open gates.
    /// </summary>
    [FactorioRconAttribute("can_open_gates")]
    public bool CanOpenGates { get; private set; }

    /// <summary>
    ///     Whether this unit prototype is affected by tile walking speed modifiers.
    /// </summary>
    [FactorioRconAttribute("affected_by_tiles")]
    public bool AffectedByTiles { get; private set; }

    /// <summary>
    ///     The distraction cooldown of this unit prototype.
    /// </summary>
    [FactorioRconAttribute("distraction_cooldown")]
    public uint DistractionCooldown { get; private set; }

    /// <summary>
    ///     The spawning time modifier of this unit prototype.
    /// </summary>
    [FactorioRconAttribute("spawning_time_modifier")]
    public double SpawningTimeModifier { get; private set; }

    /// <summary>
    ///     The alert icon shift of this entity prototype.
    /// </summary>
    [FactorioRconAttribute("alert_icon_shift")]
    public Vector AlertIconShift { get; private set; }

    /// <summary>
    ///     The alert icon scale of this entity prototype.
    /// </summary>
    [FactorioRconAttribute("alert_icon_scale")]
    public float AlertIconScale { get; private set; }

    /// <summary>
    ///     The item prototype names that are the inputs of this lab prototype.
    /// </summary>
    [FactorioRconAttribute("lab_inputs")]
    public List<string> LabInputs { get; private set; }

    /// <summary>
    ///     The base researching speed of this lab prototype.
    /// </summary>
    [FactorioRconAttribute("researching_speed")]
    public double ResearchingSpeed { get; private set; }

    /// <summary>
    ///     The item slot count of this constant combinator prototype.
    /// </summary>
    [FactorioRconAttribute("item_slot_count")]
    public uint ItemSlotCount { get; private set; }

    /// <summary>
    ///     The base productivity of this crafting machine, lab, or mining drill.
    /// </summary>
    [FactorioRconAttribute("base_productivity")]
    public double BaseProductivity { get; private set; }

    /// <summary>
    ///     Whether this market allows access to all forces or just friendly ones.
    /// </summary>
    [FactorioRconAttribute("allow_access_to_all_forces")]
    public bool AllowAccessToAllForces { get; private set; }

    /// <summary>
    ///     Whether this entity prototype could possibly ever be rotated.
    /// </summary>
    [FactorioRconAttribute("supports_direction")]
    public bool SupportsDirection { get; private set; }

    /// <summary>
    ///     The terrain friction modifier for this vehicle.
    /// </summary>
    [FactorioRconAttribute("terrain_friction_modifier")]
    public float TerrainFrictionModifier { get; private set; }

    /// <summary>
    ///     Whether this vehicle allows passengers.
    /// </summary>
    [FactorioRconAttribute("allow_passengers")]
    public bool AllowPassengers { get; private set; }

    /// <summary>
    ///     The radius of the area this radar can chart, in chunks.
    /// </summary>
    [FactorioRconAttribute("max_distance_of_sector_revealed")]
    public uint MaxDistanceOfSectorRevealed { get; private set; }

    /// <summary>
    ///     The radius of the area constantly revealed by this radar, in chunks.
    /// </summary>
    [FactorioRconAttribute("max_distance_of_nearby_sector_revealed")]
    public uint MaxDistanceOfNearbySectorRevealed { get; private set; }

    /// <summary>
    ///     The bounding box that specifies which tiles adjacent to the offshore pump should be checked.
    /// </summary>
    [FactorioRconAttribute("adjacent_tile_collision_box")]
    public BoundingBox AdjacentTileCollisionBox { get; private set; }

    /// <summary>
    ///     Tiles adjacent to the offshore pump must not collide with this collision mask.
    /// </summary>
    [FactorioRconAttribute("adjacent_tile_collision_mask")]
    public CollisionMask AdjacentTileCollisionMask { get; private set; }

    /// <summary>
    ///     If this mask is not empty, tiles adjacent to the offshore pump must not collide with this collision mask.
    /// </summary>
    [FactorioRconAttribute("adjacent_tile_collision_test")]
    public CollisionMask AdjacentTileCollisionTest { get; private set; }

    /// <summary>
    ///     The collision mask used only for collision test with tile directly at offshore pump position.
    /// </summary>
    [FactorioRconAttribute("center_collision_mask")]
    public CollisionMask CenterCollisionMask { get; private set; }

    /// <summary>
    ///     The equipment grid prototype for this entity, if any.
    /// </summary>
    [FactorioRconAttribute("grid_prototype")]
    public LuaEquipmentGridPrototype GridPrototype { get; private set; }

    /// <summary>
    ///     Whether this entity should remove decoratives that collide with it when this entity is built. Possible values are `"automatic"`, `"true"` and `"false"`.
    /// </summary>
    [FactorioRconAttribute("remove_decoratives")]
    public string RemoveDecoratives { get; private set; }

    [FactorioRconAttribute("related_underground_belt")]
    public LuaEntityPrototype RelatedUndergroundBelt { get; private set; }

    /// <summary>
    ///     The built-in stack size bonus of this inserter prototype.
    /// </summary>
    [FactorioRconAttribute("inserter_stack_size_bonus")]
    public double InserterStackSizeBonus { get; private set; }

    /// <summary>
    ///     True if this entity prototype should be included during tile collision checks with <see cref="LuaTilePrototype.CheckCollisionWithEntities" /> enabled.
    /// </summary>
    [FactorioRconAttribute("protected_from_tile_building")]
    public bool ProtectedFromTileBuilding { get; private set; }

    /// <summary>
    ///     True if this is entity-with-owner
    /// </summary>
    [FactorioRconAttribute("is_entity_with_owner")]
    public bool IsEntityWithOwner { get; private set; }

    /// <summary>
    ///     True if this entity-with-owner is military target
    /// </summary>
    [FactorioRconAttribute("is_military_target")]
    public bool IsMilitaryTarget { get; private set; }

    /// <summary>
    ///     True if this entity-with-owner's is_military_target can be changed run-time (on the entity, not on the prototype itself)
    /// </summary>
    [FactorioRconAttribute("allow_run_time_change_of_is_military_target")]
    public bool AllowRunTimeChangeOfIsMilitaryTarget { get; private set; }

    /// <summary>
    ///     The logistic parameters for this roboport.
    /// </summary>
    [FactorioRconAttribute("logistic_parameters")]
    public Table1436604149 LogisticParameters { get; private set; }

    /// <summary>
    ///     The height of this spider vehicle prototype.
    /// </summary>
    [FactorioRconAttribute("height")]
    public double Height { get; private set; }

    /// <summary>
    ///     The torso rotation speed of this spider vehicle prototype.
    /// </summary>
    [FactorioRconAttribute("torso_rotation_speed")]
    public double TorsoRotationSpeed { get; private set; }

    /// <summary>
    ///     The torso bob speed of this spider vehicle prototype.
    /// </summary>
    [FactorioRconAttribute("torso_bob_speed")]
    public double TorsoBobSpeed { get; private set; }

    /// <summary>
    ///     Whether this spider vehicle prototype automatically cycles weapons.
    /// </summary>
    [FactorioRconAttribute("automatic_weapon_cycling")]
    public bool AutomaticWeaponCycling { get; private set; }

    /// <summary>
    ///     The chain shooting cooldown modifier of this spider vehicle prototype.
    /// </summary>
    [FactorioRconAttribute("chain_shooting_cooldown_modifier")]
    public double ChainShootingCooldownModifier { get; private set; }

    /// <summary>
    ///     The chunk exploration radius of this spider vehicle prototype.
    /// </summary>
    [FactorioRconAttribute("chunk_exploration_radius")]
    public double ChunkExplorationRadius { get; private set; }

    /// <summary>
    ///     The animation speed coefficient of this belt connectable prototype.
    /// </summary>
    [FactorioRconAttribute("animation_speed_coefficient")]
    public double AnimationSpeedCoefficient { get; private set; }

    /// <summary>
    ///     The manual range modifier for this artillery turret or wagon prototype.
    ///     subclass(ArtilleryWagon, ArtilleryTurret)
    /// </summary>
    [FactorioRconAttribute("manual_range_modifier")]
    public double ManualRangeModifier { get; private set; }

    /// <summary>
    ///     The dying time of this corpse prototype.
    /// </summary>
    [FactorioRconAttribute("dying_speed")]
    public float DyingSpeed { get; private set; }

    /// <summary>
    ///     The active energy usage of this rocket silo or combinator prototype.
    /// </summary>
    [FactorioRconAttribute("active_energy_usage")]
    public double ActiveEnergyUsage { get; private set; }

    /// <summary>
    ///     The lamp energy usage of this rocket silo prototype.
    /// </summary>
    [FactorioRconAttribute("lamp_energy_usage")]
    public double LampEnergyUsage { get; private set; }

    /// <summary>
    ///     Whether this logistic container prototype uses exact mode
    /// </summary>
    [FactorioRconAttribute("use_exact_mode")]
    public bool UseExactMode { get; private set; }

    /// <summary>
    ///     Specifies the tiling size of the entity, is used to decide, if the center should be in the center of the tile (odd tile size dimension) or on the tile border (even tile size
    ///     dimension)
    /// </summary>
    [FactorioRconAttribute("tile_width")]
    public uint TileWidth { get; private set; }

    /// <summary>
    ///     Specifies the tiling size of the entity, is used to decide, if the center should be in the center of the tile (odd tile size dimension) or on the tile border (even tile size
    ///     dimension)
    /// </summary>
    [FactorioRconAttribute("tile_height")]
    public uint TileHeight { get; private set; }

    /// <summary>
    ///     Vertical selection shift used by rolling stocks. It affects selection box vertical position but is also used to shift rolling stock graphics along the rails to fine tune
    ///     train's look.
    /// </summary>
    [FactorioRconAttribute("vertical_selection_shift")]
    public double VerticalSelectionShift { get; private set; }

    [FactorioRconAttribute("spawn_decoration")]
    public List<TriggerEffectItem> SpawnDecoration { get; private set; }

    [FactorioRconAttribute("spawn_decorations_on_expansion")]
    public bool SpawnDecorationsOnExpansion { get; private set; }

    [FactorioRconAttribute("connection_distance")]
    public double ConnectionDistance { get; private set; }

    [FactorioRconAttribute("joint_distance")]
    public double JointDistance { get; private set; }

    [FactorioRconAttribute("radius_visualisation_specification")]
    public RadiusVisualisationSpecification RadiusVisualisationSpecification { get; private set; }

    /// <summary>
    ///     The current movement speed of this character, including effects from exoskeletons, tiles, stickers and shooting.
    /// </summary>
    [FactorioRconAttribute("running_speed")]
    public double RunningSpeed { get; private set; }

    [FactorioRconAttribute("maximum_corner_sliding_distance")]
    public double MaximumCornerSlidingDistance { get; private set; }

    [FactorioRconAttribute("build_distance")]
    public uint BuildDistance { get; private set; }

    [FactorioRconAttribute("drop_item_distance")]
    public uint DropItemDistance { get; private set; }

    [FactorioRconAttribute("reach_distance")]
    public uint ReachDistance { get; private set; }

    [FactorioRconAttribute("reach_resource_distance")]
    public double ReachResourceDistance { get; private set; }

    [FactorioRconAttribute("item_pickup_distance")]
    public double ItemPickupDistance { get; private set; }

    [FactorioRconAttribute("loot_pickup_distance")]
    public double LootPickupDistance { get; private set; }

    [FactorioRconAttribute("enter_vehicle_distance")]
    public double EnterVehicleDistance { get; private set; }

    [FactorioRconAttribute("ticks_to_keep_gun")]
    public uint TicksToKeepGun { get; private set; }

    [FactorioRconAttribute("ticks_to_keep_aiming_direction")]
    public uint TicksToKeepAimingDirection { get; private set; }

    [FactorioRconAttribute("ticks_to_stay_in_combat")]
    public uint TicksToStayInCombat { get; private set; }

    [FactorioRconAttribute("respawn_time")]
    public uint RespawnTime { get; private set; }

    [FactorioRconAttribute("damage_hit_tint")]
    public Color DamageHitTint { get; private set; }

    [FactorioRconAttribute("character_corpse")]
    public LuaEntityPrototype CharacterCorpse { get; private set; }

    /// <summary>
    ///     Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the
    ///     corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the
    ///     game state might have occurred between the creation of the Lua object and its access.
    /// </summary>
    [FactorioRconAttribute("valid")]
    public bool Valid { get; private set; }

    /// <summary>
    ///     The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
    /// </summary>
    [FactorioRconAttribute("object_name")]
    public string ObjectName { get; private set; }

    /// <summary>
    ///     Test whether this entity prototype has a certain flag set.
    /// </summary>
    /// <param name="flag">Lua name: flag</param>
    [FactorioRconMethod("has_flag")]
    public abstract bool HasFlag(EntityPrototypeFlag flag);

    /// <summary>
    ///     Gets the base size of the given inventory on this entity or `nil` if the given inventory doesn't exist.
    /// </summary>
    /// <param name="index">Lua name: index</param>
    [FactorioRconMethod("get_inventory_size")]
    public abstract uint? GetInventorySize(InventoryEnum index);

    /// <summary>
    ///     All methods and properties that this object supports.
    /// </summary>
    [FactorioRconMethod("help")]
    public abstract string Help();
}
