#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// The primary interface for interacting with entities through the Lua API. Entities are everything that exists on the map except for tiles (see <see cref="LuaTile)" />.
/// 
/// Most functions on LuaEntity also work when the entity is contained in a ghost.
/// </summary>
[FactorioRconClass("LuaEntity")]
public abstract class LuaEntity: LuaObject
{
  /// <summary>
  /// Name of the entity prototype. E.g. "inserter" or "filter-inserter".
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// Name of the entity or tile contained in this ghost
  /// </summary>
  [FactorioRconAttribute("ghost_name")]
  public string GhostName { get; private set; }

  /// <summary>
  /// Localised name of the entity.
  /// </summary>
  [FactorioRconAttribute("localised_name")]
  public LocalisedString LocalisedName { get; private set; }

  [FactorioRconAttribute("localised_description")]
  public LocalisedString LocalisedDescription { get; private set; }

  /// <summary>
  /// Localised name of the entity or tile contained in this ghost.
  /// </summary>
  [FactorioRconAttribute("ghost_localised_name")]
  public LocalisedString GhostLocalisedName { get; private set; }

  [FactorioRconAttribute("ghost_localised_description")]
  public LocalisedString GhostLocalisedDescription { get; private set; }

  /// <summary>
  /// The entity prototype type of this entity.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; private set; }

  /// <summary>
  /// The prototype type of the entity or tile contained in this ghost.
  /// </summary>
  [FactorioRconAttribute("ghost_type")]
  public string GhostType { get; private set; }

  /// <summary>
  /// Deactivating an entity will stop all its operations (car will stop moving, inserters will stop working, fish will stop moving etc).
  /// </summary>
  [FactorioRconAttribute("active")]
  public bool Active { get; set; }

  /// <summary>
  /// If set to `false`, this entity can't be damaged and won't be attacked automatically. It can however still be mined.
  /// </summary>
  [FactorioRconAttribute("destructible")]
  public bool Destructible { get; set; }

  [FactorioRconAttribute("minable")]
  public bool Minable { get; set; }

  /// <summary>
  /// When entity is not to be rotatable (inserter, transport belt etc), it can't be rotated by player using the R key.
  /// </summary>
  [FactorioRconAttribute("rotatable")]
  public bool Rotatable { get; set; }

  /// <summary>
  /// Player can't open gui of this entity and he can't quick insert/input stuff in to the entity when it is not operable.
  /// </summary>
  [FactorioRconAttribute("operable")]
  public bool Operable { get; set; }

  /// <summary>
  /// The current health of the entity, if any. Health is automatically clamped to be between `0` and max health (inclusive). Entities with a health of `0` can not be attacked.
  /// </summary>
  [FactorioRconAttribute("health")]
  public float Health { get; set; }

  /// <summary>
  /// The current direction this entity is facing.
  /// </summary>
  [FactorioRconAttribute("direction")]
  public DirectionEnum Direction { get; set; }

  /// <summary>
  /// Whether the entity has direction. When it is false for this entity, it will always return north direction when asked for.
  /// </summary>
  [FactorioRconAttribute("supports_direction")]
  public bool SupportsDirection { get; private set; }

  /// <summary>
  /// The smooth orientation of this entity.
  /// </summary>
  [FactorioRconAttribute("orientation")]
  public RealOrientation Orientation { get; set; }

  /// <summary>
  /// The orientation of this cliff.
  /// </summary>
  [FactorioRconAttribute("cliff_orientation")]
  public CliffOrientation CliffOrientation { get; private set; }

  /// <summary>
  /// The relative orientation of the vehicle turret, artillery turret, artillery wagon. `nil` if this entity isn't a vehicle with a vehicle turret or artillery turret/wagon.
  /// </summary>
  [FactorioRconAttribute("relative_turret_orientation")]
  public RealOrientation RelativeTurretOrientation { get; set; }

  /// <summary>
  /// The torso orientation of this spider vehicle.
  /// </summary>
  [FactorioRconAttribute("torso_orientation")]
  public RealOrientation TorsoOrientation { get; set; }

  /// <summary>
  /// Count of resource units contained.
  /// </summary>
  [FactorioRconAttribute("amount")]
  public uint Amount { get; set; }

  /// <summary>
  /// Count of initial resource units contained. `nil` if this is not an infinite resource.
  /// </summary>
  [FactorioRconAttribute("initial_amount")]
  public uint InitialAmount { get; set; }

  /// <summary>
  /// Multiplies the acceleration the vehicle can create for one unit of energy. Defaults to `1`.
  /// </summary>
  [FactorioRconAttribute("effectivity_modifier")]
  public float EffectivityModifier { get; set; }

  /// <summary>
  /// Multiplies the energy consumption.
  /// </summary>
  [FactorioRconAttribute("consumption_modifier")]
  public float ConsumptionModifier { get; set; }

  /// <summary>
  /// Multiplies the car friction rate.
  /// </summary>
  [FactorioRconAttribute("friction_modifier")]
  public float FrictionModifier { get; set; }

  /// <summary>
  /// Whether the driver of this car or spidertron is the gunner. If `false`, the passenger is the gunner. `nil` if this is neither a car or a spidertron.
  /// </summary>
  [FactorioRconAttribute("driver_is_gunner")]
  public bool DriverIsGunner { get; set; }

  /// <summary>
  /// Read when this spidertron auto-targets enemies
  /// </summary>
  [FactorioRconAttribute("vehicle_automatic_targeting_parameters")]
  public VehicleAutomaticTargetingParameters VehicleAutomaticTargetingParameters { get; set; }

  /// <summary>
  /// The current speed if this is a car, rolling stock, projectile or spidertron, or the maximum speed if this is a unit. The speed is in tiles per tick. `nil` if this is not a car, rolling stock, unit, projectile or spidertron.
  /// 
  /// Only the speed of units, cars, and projectiles are writable.
  /// </summary>
  [FactorioRconAttribute("speed")]
  public float Speed { get; set; }

  /// <summary>
  /// The current speed of this unit in tiles per tick, taking into account any walking speed modifier given by the tile the unit is standing on. `nil` if this is not a unit.
  /// </summary>
  [FactorioRconAttribute("effective_speed")]
  public float EffectiveSpeed { get; private set; }

  [FactorioRconAttribute("stack")]
  public LuaItemStack Stack { get; private set; }

  /// <summary>
  /// The entity prototype of this entity.
  /// </summary>
  [FactorioRconAttribute("prototype")]
  public LuaEntityPrototype Prototype { get; private set; }

  /// <summary>
  /// The prototype of the entity or tile contained in this ghost.
  /// </summary>
  [FactorioRconAttribute("ghost_prototype")]
  public Union1651140272 GhostPrototype { get; private set; }

  /// <summary>
  /// Position where the entity puts its stuff.
  /// </summary>
  [FactorioRconAttribute("drop_position")]
  public MapPosition DropPosition { get; set; }

  /// <summary>
  /// Where the inserter will pick up items from.
  /// </summary>
  [FactorioRconAttribute("pickup_position")]
  public MapPosition PickupPosition { get; set; }

  /// <summary>
  /// The entity this entity is putting its items to. If there are multiple possible entities at the drop-off point, writing to this attribute allows a mod to choose which one to drop off items to. The entity needs to collide with the tile box under the drop-off position. `nil` if there is no entity to put items to, or if this is not an entity that puts items somewhere.
  /// </summary>
  [FactorioRconAttribute("drop_target")]
  public LuaEntity DropTarget { get; set; }

  /// <summary>
  /// The entity this inserter will attempt to pick up items from. If there are multiple possible entities at the pick-up point, writing to this attribute allows a mod to choose which one to pick up items from. The entity needs to collide with the tile box under the pick-up position. `nil` if there is no entity to pull items from.
  /// </summary>
  [FactorioRconAttribute("pickup_target")]
  public LuaEntity PickupTarget { get; set; }

  /// <summary>
  /// Index of the currently selected weapon slot of this character, car, or spidertron. `nil` if this entity doesn't have guns.
  /// </summary>
  [FactorioRconAttribute("selected_gun_index")]
  public uint SelectedGunIndex { get; set; }

  /// <summary>
  /// Energy stored in the entity (heat in furnace, energy stored in electrical devices etc.). always 0 for entities that don't have the concept of energy stored inside.
  /// </summary>
  [FactorioRconAttribute("energy")]
  public double Energy { get; set; }

  /// <summary>
  /// The temperature of this entity's heat energy source. `nil` if this entity does not use a heat energy source.
  /// </summary>
  [FactorioRconAttribute("temperature")]
  public double Temperature { get; set; }

  /// <summary>
  /// The previous recipe this furnace was using, if any.
  /// </summary>
  [FactorioRconAttribute("previous_recipe")]
  public LuaRecipe PreviousRecipe { get; private set; }

  /// <summary>
  /// The item stack currently held in an inserter's hand.
  /// </summary>
  [FactorioRconAttribute("held_stack")]
  public LuaItemStack HeldStack { get; private set; }

  /// <summary>
  /// Current position of the inserter's "hand".
  /// </summary>
  [FactorioRconAttribute("held_stack_position")]
  public MapPosition HeldStackPosition { get; private set; }

  /// <summary>
  /// The train this rolling stock belongs to, if any. `nil` if this is not a rolling stock.
  /// </summary>
  [FactorioRconAttribute("train")]
  public LuaTrain Train { get; private set; }

  /// <summary>
  /// A list of neighbours for certain types of entities. Applies to electric poles, power switches, underground belts, walls, gates, reactors, cliffs, and pipe-connectable entities.
  /// 
  /// - When called on an electric pole, this is a dictionary of all connections, indexed by the strings `"copper"`, `"red"`, and `"green"`.
  /// - When called on a pipe-connectable entity, this is an array of entity arrays of all entities a given fluidbox is connected to.
  /// - When called on an underground transport belt, this is the other end of the underground belt connection, or `nil` if none.
  /// - When called on a wall-connectable entity or reactor, this is a dictionary of all connections indexed by the connection direction "north", "south", "east", and "west".
  /// - When called on a cliff entity, this is a dictionary of all connections indexed by the connection direction "north", "south", "east", and "west".
  /// </summary>
  [FactorioRconAttribute("neighbours")]
  public Union759188142 Neighbours { get; private set; }

  /// <summary>
  /// The belt connectable neighbours of this belt connectable entity. Only entities that input to or are outputs of this entity. Does not contain the other end of an underground belt, see <see cref="LuaEntity.Neighbours" /> for that.
  /// </summary>
  [FactorioRconAttribute("belt_neighbours")]
  public Table1283735251 BeltNeighbours { get; private set; }

  /// <summary>
  /// Fluidboxes of this entity.
  /// </summary>
  [FactorioRconAttribute("fluidbox")]
  public LuaFluidBox Fluidbox { get; set; }

  /// <summary>
  /// The backer name assigned to this entity. Entities that support backer names are labs, locomotives, radars, roboports, and train stops. `nil` if this entity doesn't support backer names.
  /// </summary>
  [FactorioRconAttribute("backer_name")]
  public string BackerName { get; set; }

  /// <summary>
  /// The label on this spider-vehicle entity, if any. `nil` if this is not a spider-vehicle.
  /// </summary>
  [FactorioRconAttribute("entity_label")]
  public string EntityLabel { get; set; }

  /// <summary>
  /// The ticks left before a ghost, combat robot, highlight box or smoke with trigger is destroyed.
  /// 
  /// - for ghosts set to uint32 max (4 294 967 295) to never expire.
  /// - for ghosts can not be set higher than <see cref="LuaForce.GhostTimeToLive" /> of the entity's force.
  /// </summary>
  [FactorioRconAttribute("time_to_live")]
  public uint TimeToLive { get; set; }

  /// <summary>
  /// The color of this character, rolling stock, train stop, car, spider-vehicle, flying text, corpse or simple-entity-with-owner. `nil` if this entity doesn't use custom colors.
  /// </summary>
  [FactorioRconAttribute("color")]
  public Color Color { get; set; }

  /// <summary>
  /// The text of this flying-text entity.
  /// </summary>
  [FactorioRconAttribute("text")]
  public LocalisedString Text { get; set; }

  /// <summary>
  /// The state of this rail signal.
  /// </summary>
  [FactorioRconAttribute("signal_state")]
  public SignalStateEnum SignalState { get; private set; }

  /// <summary>
  /// The state of this chain signal.
  /// </summary>
  [FactorioRconAttribute("chain_signal_state")]
  public ChainSignalStateEnum ChainSignalState { get; private set; }

  /// <summary>
  /// Will this entity be picked up automatically when the player walks over it?
  /// </summary>
  [FactorioRconAttribute("to_be_looted")]
  public bool ToBeLooted { get; set; }

  /// <summary>
  /// The current crafting speed, including speed bonuses from modules and beacons.
  /// </summary>
  [FactorioRconAttribute("crafting_speed")]
  public double CraftingSpeed { get; private set; }

  /// <summary>
  /// The current crafting progress, as a number in range [0, 1].
  /// </summary>
  [FactorioRconAttribute("crafting_progress")]
  public float CraftingProgress { get; set; }

  /// <summary>
  /// The current productivity bonus progress, as a number in range [0, 1].
  /// </summary>
  [FactorioRconAttribute("bonus_progress")]
  public double BonusProgress { get; set; }

  /// <summary>
  /// The productivity bonus of this entity.
  /// </summary>
  [FactorioRconAttribute("productivity_bonus")]
  public double ProductivityBonus { get; private set; }

  /// <summary>
  /// The pollution bonus of this entity.
  /// </summary>
  [FactorioRconAttribute("pollution_bonus")]
  public double PollutionBonus { get; private set; }

  /// <summary>
  /// The speed bonus of this entity.
  /// </summary>
  [FactorioRconAttribute("speed_bonus")]
  public double SpeedBonus { get; private set; }

  /// <summary>
  /// The consumption bonus of this entity.
  /// </summary>
  [FactorioRconAttribute("consumption_bonus")]
  public double ConsumptionBonus { get; private set; }

  /// <summary>
  /// Whether this underground belt goes into or out of the ground.
  /// </summary>
  [FactorioRconAttribute("belt_to_ground_type")]
  public Literals454913991 BeltToGroundType { get; private set; }

  /// <summary>
  /// Whether this loader gets items from or puts item into a container.
  /// </summary>
  [FactorioRconAttribute("loader_type")]
  public Literals2104249807 LoaderType { get; set; }

  /// <summary>
  /// Number of rocket parts in the silo.
  /// </summary>
  [FactorioRconAttribute("rocket_parts")]
  public uint RocketParts { get; set; }

  /// <summary>
  /// The logistic network this entity is a part of, or `nil` if this entity is not a part of any logistic network.
  /// </summary>
  [FactorioRconAttribute("logistic_network")]
  public LuaLogisticNetwork LogisticNetwork { get; set; }

  /// <summary>
  /// The logistic cell this entity is a part of. Will be `nil` if this entity is not a part of any logistic cell.
  /// </summary>
  [FactorioRconAttribute("logistic_cell")]
  public LuaLogisticCell LogisticCell { get; private set; }

  /// <summary>
  /// Items this ghost will request when revived or items this item request proxy is requesting. Result is a dictionary mapping each item prototype name to the required count.
  /// </summary>
  [FactorioRconAttribute("item_requests")]
  public Dictionary<string, uint> ItemRequests { get; set; }

  /// <summary>
  /// The player connected to this character, if any.
  /// </summary>
  [FactorioRconAttribute("player")]
  public LuaPlayer Player { get; private set; }

  /// <summary>
  /// The unit group this unit is a member of, if any.
  /// </summary>
  [FactorioRconAttribute("unit_group")]
  public LuaUnitGroup UnitGroup { get; private set; }

  /// <summary>
  /// The damage dealt by this turret, artillery turret, or artillery wagon.
  /// </summary>
  [FactorioRconAttribute("damage_dealt")]
  public double DamageDealt { get; set; }

  /// <summary>
  /// The number of units killed by this turret, artillery turret, or artillery wagon.
  /// </summary>
  [FactorioRconAttribute("kills")]
  public uint Kills { get; set; }

  /// <summary>
  /// The last player that changed any setting on this entity. This includes building the entity, changing its color, or configuring its circuit network. `nil` if the last user is not part of the save anymore.
  /// 
  /// Reading this property will return a <see cref="PlayerIdentification" /> can be used when writing.
  /// </summary>
  [FactorioRconAttribute("last_user")]
  public Union999362882 LastUser { get; set; }

  /// <summary>
  /// The buffer size for the electric energy source. `nil` if the entity doesn't have an electric energy source.
  /// </summary>
  [FactorioRconAttribute("electric_buffer_size")]
  public double ElectricBufferSize { get; set; }

  /// <summary>
  /// The input flow limit for the electric energy source. `nil` if the entity doesn't have an electric energy source.
  /// </summary>
  [FactorioRconAttribute("electric_input_flow_limit")]
  public double ElectricInputFlowLimit { get; private set; }

  /// <summary>
  /// The output flow limit for the electric energy source. `nil` if the entity doesn't have an electric energy source.
  /// </summary>
  [FactorioRconAttribute("electric_output_flow_limit")]
  public double ElectricOutputFlowLimit { get; private set; }

  /// <summary>
  /// The electric drain for the electric energy source. `nil` if the entity doesn't have an electric energy source.
  /// </summary>
  [FactorioRconAttribute("electric_drain")]
  public double ElectricDrain { get; private set; }

  /// <summary>
  /// The emissions for the electric energy source. `nil` if the entity doesn't have an electric energy source.
  /// </summary>
  [FactorioRconAttribute("electric_emissions")]
  public double ElectricEmissions { get; private set; }

  /// <summary>
  /// A unique number identifying this entity for the lifetime of the save. These are allocated sequentially, and not re-used (until overflow).
  /// 
  /// Only entities inheriting from [EntityWithOwnerPrototype](prototype:EntityWithOwnerPrototype), as well as [ItemRequestProxyPrototype](prototype:ItemRequestProxyPrototype) and [EntityGhostPrototype](prototype:EntityGhostPrototype) are assigned a unit number. Returns `nil` otherwise.
  /// </summary>
  [FactorioRconAttribute("unit_number")]
  public uint UnitNumber { get; private set; }

  /// <summary>
  /// The <see cref="LuaEntity.UnitNumber)OfTheEntityContainedInThisGhost.ItIsTheSameAsTheUnitNumberOfThe[EntityWithOwnerPrototype](Prototype:EntityWithOwnerPrototype" /> that was destroyed to create this ghost. If it was created by other means, or if the inner entity does not support unit numbers, this property is `nil`.
  /// </summary>
  [FactorioRconAttribute("ghost_unit_number")]
  public uint GhostUnitNumber { get; private set; }

  /// <summary>
  /// The mining progress for this mining drill. Is a number in range [0, mining_target.prototype.mineable_properties.mining_time]. `nil` if this isn't a mining drill.
  /// </summary>
  [FactorioRconAttribute("mining_progress")]
  public double MiningProgress { get; set; }

  /// <summary>
  /// The bonus mining progress for this mining drill. Read yields a number in range [0, mining_target.prototype.mineable_properties.mining_time]. `nil` if this isn't a mining drill.
  /// </summary>
  [FactorioRconAttribute("bonus_mining_progress")]
  public double BonusMiningProgress { get; set; }

  /// <summary>
  /// The power production specific to the ElectricEnergyInterface entity type.
  /// </summary>
  [FactorioRconAttribute("power_production")]
  public double PowerProduction { get; set; }

  /// <summary>
  /// The power usage specific to the ElectricEnergyInterface entity type.
  /// </summary>
  [FactorioRconAttribute("power_usage")]
  public double PowerUsage { get; set; }

  /// <summary>
  /// <see cref="LuaEntityPrototype.CollisionBox" /> around entity's given position and respecting the current entity orientation.
  /// </summary>
  [FactorioRconAttribute("bounding_box")]
  public BoundingBox BoundingBox { get; private set; }

  /// <summary>
  /// The secondary bounding box of this entity or `nil` if it doesn't have one. This only exists for curved rails, and is automatically determined by the game.
  /// </summary>
  [FactorioRconAttribute("secondary_bounding_box")]
  public BoundingBox SecondaryBoundingBox { get; private set; }

  /// <summary>
  /// <see cref="LuaEntityPrototype.SelectionBox" /> around entity's given position and respecting the current entity orientation.
  /// </summary>
  [FactorioRconAttribute("selection_box")]
  public BoundingBox SelectionBox { get; private set; }

  /// <summary>
  /// The secondary selection box of this entity or `nil` if it doesn't have one. This only exists for curved rails, and is automatically determined by the game.
  /// </summary>
  [FactorioRconAttribute("secondary_selection_box")]
  public BoundingBox SecondarySelectionBox { get; private set; }

  /// <summary>
  /// The mining target, if any.
  /// </summary>
  [FactorioRconAttribute("mining_target")]
  public LuaEntity MiningTarget { get; private set; }

  /// <summary>
  /// Entities that are directly connected to this entity via the circuit network. `nil` if this entity can't be connected to the circuit network.
  /// </summary>
  [FactorioRconAttribute("circuit_connected_entities")]
  public Table2145063180 CircuitConnectedEntities { get; private set; }

  /// <summary>
  /// The connection definition for entities that are directly connected to this entity via the circuit network. `nil` if this entity can't be connected to the circuit network.
  /// </summary>
  [FactorioRconAttribute("circuit_connection_definitions")]
  public List<CircuitConnectionDefinition> CircuitConnectionDefinitions { get; private set; }

  /// <summary>
  /// The connection definition for entities that are directly connected to this entity via copper cables.
  /// </summary>
  [FactorioRconAttribute("copper_connection_definitions")]
  public List<CopperConnectionDefinition> CopperConnectionDefinitions { get; private set; }

  /// <summary>
  /// The index of the configured request with the highest index for this entity. This means 0 if no requests are set and e.g. 20 if the 20th request slot is configured.
  /// </summary>
  [FactorioRconAttribute("request_slot_count")]
  public uint RequestSlotCount { get; private set; }

  /// <summary>
  /// The number of filter slots this inserter, loader, or logistic storage container has. 0 if not one of those entities.
  /// </summary>
  [FactorioRconAttribute("filter_slot_count")]
  public uint FilterSlotCount { get; private set; }

  /// <summary>
  /// The container entity this loader is pointing at/pulling from depending on the <see cref="LuaEntity.LoaderType" />, if any.
  /// </summary>
  [FactorioRconAttribute("loader_container")]
  public LuaEntity LoaderContainer { get; private set; }

  /// <summary>
  /// This entity's equipment grid, if any.
  /// </summary>
  [FactorioRconAttribute("grid")]
  public LuaEquipmentGrid Grid { get; private set; }

  /// <summary>
  /// The graphics variation for this entity. `nil` if this entity doesn't use graphics variations.
  /// </summary>
  [FactorioRconAttribute("graphics_variation")]
  public byte GraphicsVariation { get; set; }

  /// <summary>
  /// Index of the tree color.
  /// </summary>
  [FactorioRconAttribute("tree_color_index")]
  public byte TreeColorIndex { get; set; }

  /// <summary>
  /// Maximum index of the tree colors.
  /// </summary>
  [FactorioRconAttribute("tree_color_index_max")]
  public byte TreeColorIndexMax { get; private set; }

  /// <summary>
  /// Index of the tree stage.
  /// </summary>
  [FactorioRconAttribute("tree_stage_index")]
  public byte TreeStageIndex { get; set; }

  /// <summary>
  /// Maximum index of the tree stages.
  /// </summary>
  [FactorioRconAttribute("tree_stage_index_max")]
  public byte TreeStageIndexMax { get; private set; }

  /// <summary>
  /// Index of the tree gray stage
  /// </summary>
  [FactorioRconAttribute("tree_gray_stage_index")]
  public byte TreeGrayStageIndex { get; set; }

  /// <summary>
  /// Maximum index of the tree gray stages.
  /// </summary>
  [FactorioRconAttribute("tree_gray_stage_index_max")]
  public byte TreeGrayStageIndexMax { get; private set; }

  /// <summary>
  /// The burner energy source for this entity, if any.
  /// </summary>
  [FactorioRconAttribute("burner")]
  public LuaBurner Burner { get; private set; }

  /// <summary>
  /// The shooting target for this turret, if any. Can't be set to `nil` via script.
  /// </summary>
  [FactorioRconAttribute("shooting_target")]
  public LuaEntity ShootingTarget { get; set; }

  /// <summary>
  /// The target entity for this item-request-proxy, if any.
  /// </summary>
  [FactorioRconAttribute("proxy_target")]
  public LuaEntity ProxyTarget { get; private set; }

  /// <summary>
  /// The sticker entities attached to this entity, if any.
  /// </summary>
  [FactorioRconAttribute("stickers")]
  public List<LuaEntity> Stickers { get; private set; }

  /// <summary>
  /// The entity this sticker is sticked to.
  /// </summary>
  [FactorioRconAttribute("sticked_to")]
  public LuaEntity StickedTo { get; private set; }

  /// <summary>
  /// The vehicle modifiers applied to this entity through the attached stickers.
  /// </summary>
  [FactorioRconAttribute("sticker_vehicle_modifiers")]
  public Table1571526210 StickerVehicleModifiers { get; private set; }

  [FactorioRconAttribute("parameters")]
  public ProgrammableSpeakerParameters Parameters { get; set; }

  [FactorioRconAttribute("alert_parameters")]
  public ProgrammableSpeakerAlertParameters AlertParameters { get; set; }

  /// <summary>
  /// The electric network statistics for this electric pole.
  /// </summary>
  [FactorioRconAttribute("electric_network_statistics")]
  public LuaFlowStatistics ElectricNetworkStatistics { get; private set; }

  /// <summary>
  /// Returns the current target pickup count of the inserter.
  /// </summary>
  [FactorioRconAttribute("inserter_target_pickup_count")]
  public uint InserterTargetPickupCount { get; private set; }

  /// <summary>
  /// Sets the stack size limit on this inserter. If the stack size is > than the force stack size limit the value is ignored.
  /// </summary>
  [FactorioRconAttribute("inserter_stack_size_override")]
  public uint InserterStackSizeOverride { get; set; }

  /// <summary>
  /// The number of products this machine finished crafting in its lifetime.
  /// </summary>
  [FactorioRconAttribute("products_finished")]
  public uint ProductsFinished { get; set; }

  /// <summary>
  /// The spawner associated with this unit entity, if any.
  /// </summary>
  [FactorioRconAttribute("spawner")]
  public LuaEntity Spawner { get; private set; }

  [FactorioRconAttribute("spawning_cooldown")]
  public double SpawningCooldown { get; private set; }

  [FactorioRconAttribute("absorbed_pollution")]
  public double AbsorbedPollution { get; private set; }

  [FactorioRconAttribute("spawn_shift")]
  public double SpawnShift { get; private set; }

  /// <summary>
  /// The units associated with this spawner entity.
  /// </summary>
  [FactorioRconAttribute("units")]
  public List<LuaEntity> Units { get; private set; }

  /// <summary>
  /// The state of this power switch.
  /// </summary>
  [FactorioRconAttribute("power_switch_state")]
  public bool PowerSwitchState { get; set; }

  /// <summary>
  /// The effects being applied to this entity, if any. For beacons, this is the effect the beacon is broadcasting.
  /// </summary>
  [FactorioRconAttribute("effects")]
  public ModuleEffects Effects { get; private set; }

  /// <summary>
  /// Number of beacons affecting this effect receiver. Can only be used when the entity has an effect receiver (AssemblingMachine, Furnace, Lab, MiningDrills)
  /// </summary>
  [FactorioRconAttribute("beacons_count")]
  public uint BeaconsCount { get; private set; }

  /// <summary>
  /// The filters for this infinity container.
  /// </summary>
  [FactorioRconAttribute("infinity_container_filters")]
  public List<InfinityInventoryFilter> InfinityContainerFilters { get; set; }

  /// <summary>
  /// Whether items not included in this infinity container filters should be removed from the container.
  /// </summary>
  [FactorioRconAttribute("remove_unfiltered_items")]
  public bool RemoveUnfilteredItems { get; set; }

  /// <summary>
  /// The player index associated with this character corpse.
  /// </summary>
  [FactorioRconAttribute("character_corpse_player_index")]
  public uint CharacterCorpsePlayerIndex { get; set; }

  /// <summary>
  /// The tick this character corpse died at.
  /// </summary>
  [FactorioRconAttribute("character_corpse_tick_of_death")]
  public uint CharacterCorpseTickOfDeath { get; set; }

  /// <summary>
  /// The reason this character corpse character died. `""` if there is no reason.
  /// </summary>
  [FactorioRconAttribute("character_corpse_death_cause")]
  public LocalisedString CharacterCorpseDeathCause { get; set; }

  /// <summary>
  /// The player this character is associated with, if any. Set to `nil` to clear.
  /// 
  /// The player will be automatically disassociated when a controller is set on the character. Also, all characters associated to a player will be logged off when the player logs off in multiplayer.
  /// 
  /// Reading this property will return a <see cref="PlayerIdentification" /> can be used when writing.
  /// </summary>
  [FactorioRconAttribute("associated_player")]
  public Union999362882 AssociatedPlayer { get; set; }

  /// <summary>
  /// The last tick this character entity was attacked.
  /// </summary>
  [FactorioRconAttribute("tick_of_last_attack")]
  public uint TickOfLastAttack { get; set; }

  /// <summary>
  /// The last tick this character entity was damaged.
  /// </summary>
  [FactorioRconAttribute("tick_of_last_damage")]
  public uint TickOfLastDamage { get; set; }

  /// <summary>
  /// The filter for this splitter, if any is set.
  /// </summary>
  [FactorioRconAttribute("splitter_filter")]
  public LuaItemPrototype SplitterFilter { get; set; }

  /// <summary>
  /// The filter mode for this filter inserter. `nil` if this inserter doesn't use filters.
  /// </summary>
  [FactorioRconAttribute("inserter_filter_mode")]
  public Literals929816135 InserterFilterMode { get; set; }

  /// <summary>
  /// The input priority for this splitter.
  /// </summary>
  [FactorioRconAttribute("splitter_input_priority")]
  public Literals913597270 SplitterInputPriority { get; set; }

  /// <summary>
  /// The output priority for this splitter.
  /// </summary>
  [FactorioRconAttribute("splitter_output_priority")]
  public Literals721940713 SplitterOutputPriority { get; set; }

  /// <summary>
  /// Whether this land mine is armed.
  /// </summary>
  [FactorioRconAttribute("armed")]
  public bool Armed { get; private set; }

  /// <summary>
  /// When locked; the recipe in this assembling machine can't be changed by the player.
  /// </summary>
  [FactorioRconAttribute("recipe_locked")]
  public bool RecipeLocked { get; set; }

  /// <summary>
  /// The rail entity this train stop is connected to, if any.
  /// </summary>
  [FactorioRconAttribute("connected_rail")]
  public LuaEntity ConnectedRail { get; private set; }

  /// <summary>
  /// Rail direction to which this train stop is binding. This returns a value even when no rails are present.
  /// </summary>
  [FactorioRconAttribute("connected_rail_direction")]
  public RailDirectionEnum ConnectedRailDirection { get; private set; }

  /// <summary>
  /// The number of trains in this rail block for this rail entity.
  /// </summary>
  [FactorioRconAttribute("trains_in_block")]
  public uint TrainsInBlock { get; private set; }

  /// <summary>
  /// The timeout that's left on this landmine in ticks. It describes the time between the landmine being placed and it being armed.
  /// </summary>
  [FactorioRconAttribute("timeout")]
  public uint Timeout { get; set; }

  /// <summary>
  /// The current total neighbour bonus of this reactor.
  /// </summary>
  [FactorioRconAttribute("neighbour_bonus")]
  public double NeighbourBonus { get; private set; }

  /// <summary>
  /// The ai settings of this unit.
  /// </summary>
  [FactorioRconAttribute("ai_settings")]
  public LuaAISettings AiSettings { get; private set; }

  /// <summary>
  /// The hightlight box type of this highlight box entity.
  /// </summary>
  [FactorioRconAttribute("highlight_box_type")]
  public CursorBoxRenderType HighlightBoxType { get; set; }

  /// <summary>
  /// The blink interval of this highlight box entity. 0 indicates no blink.
  /// </summary>
  [FactorioRconAttribute("highlight_box_blink_interval")]
  public uint HighlightBoxBlinkInterval { get; set; }

  /// <summary>
  /// The status of this entity, if any.
  /// </summary>
  [FactorioRconAttribute("status")]
  public EntityStatusEnum Status { get; private set; }

  /// <summary>
  /// Whether equipment grid logistics are enabled while this vehicle is moving.
  /// </summary>
  [FactorioRconAttribute("enable_logistics_while_moving")]
  public bool EnableLogisticsWhileMoving { get; set; }

  /// <summary>
  /// The player that this `simple-entity-with-owner`, `simple-entity-with-force`, `flying-text`, or `highlight-box` is visible to. `nil` when this entity is rendered for all players.
  /// 
  /// Reading this property will return a <see cref="PlayerIdentification" /> can be used when writing.
  /// </summary>
  [FactorioRconAttribute("render_player")]
  public Union999362882 RenderPlayer { get; set; }

  /// <summary>
  /// The forces that this `simple-entity-with-owner`, `simple-entity-with-force`, or `flying-text` is visible to. `nil` or an empty array when this entity is rendered for all forces.
  /// </summary>
  [FactorioRconAttribute("render_to_forces")]
  public List<ForceIdentification> RenderToForces { get; set; }

  /// <summary>
  /// The rail target of this pump, if any.
  /// </summary>
  [FactorioRconAttribute("pump_rail_target")]
  public LuaEntity PumpRailTarget { get; private set; }

  /// <summary>
  /// Returns true if this unit is moving.
  /// </summary>
  [FactorioRconAttribute("moving")]
  public bool Moving { get; private set; }

  /// <summary>
  /// Returns the id of the electric network that this entity is connected to, if any.
  /// </summary>
  [FactorioRconAttribute("electric_network_id")]
  public uint ElectricNetworkId { get; private set; }

  /// <summary>
  /// Whether this character's personal roboports are allowed to dispatch robots.
  /// </summary>
  [FactorioRconAttribute("allow_dispatching_robots")]
  public bool AllowDispatchingRobots { get; set; }

  /// <summary>
  /// Whether this rocket silo automatically launches the rocket when cargo is inserted.
  /// </summary>
  [FactorioRconAttribute("auto_launch")]
  public bool AutoLaunch { get; set; }

  /// <summary>
  /// How much energy this generator generated in the last tick.
  /// </summary>
  [FactorioRconAttribute("energy_generated_last_tick")]
  public double EnergyGeneratedLastTick { get; private set; }

  /// <summary>
  /// The storage filter for this logistic storage container.
  /// </summary>
  [FactorioRconAttribute("storage_filter")]
  public LuaItemPrototype StorageFilter { get; set; }

  /// <summary>
  /// Whether this requester chest is set to also request from buffer chests.
  /// </summary>
  [FactorioRconAttribute("request_from_buffers")]
  public bool RequestFromBuffers { get; set; }

  /// <summary>
  /// Whether this corpse will ever fade away.
  /// </summary>
  [FactorioRconAttribute("corpse_expires")]
  public bool CorpseExpires { get; set; }

  /// <summary>
  /// If true, corpse won't be destroyed when entities are placed over it. If false, whether corpse will be removed or not depends on value of CorpsePrototype::remove_on_entity_placement.
  /// </summary>
  [FactorioRconAttribute("corpse_immune_to_entity_placement")]
  public bool CorpseImmuneToEntityPlacement { get; set; }

  /// <summary>
  /// The tags associated with this entity ghost. `nil` if this is not an entity ghost.
  /// </summary>
  [FactorioRconAttribute("tags")]
  public Tags Tags { get; set; }

  /// <summary>
  /// The command given to this unit, if any.
  /// </summary>
  [FactorioRconAttribute("command")]
  public Command Command { get; private set; }

  /// <summary>
  /// The distraction command given to this unit, if any.
  /// </summary>
  [FactorioRconAttribute("distraction_command")]
  public Command DistractionCommand { get; private set; }

  /// <summary>
  /// The ticks until the next trigger effect of this smoke-with-trigger.
  /// </summary>
  [FactorioRconAttribute("time_to_next_effect")]
  public uint TimeToNextEffect { get; set; }

  /// <summary>
  /// Destination of this spidertron's autopilot, if any. Writing `nil` clears all destinations.
  /// </summary>
  [FactorioRconAttribute("autopilot_destination")]
  public MapPosition AutopilotDestination { get; set; }

  /// <summary>
  /// The queued destination positions of spidertron's autopilot.
  /// </summary>
  [FactorioRconAttribute("autopilot_destinations")]
  public List<MapPosition> AutopilotDestinations { get; private set; }

  /// <summary>
  /// Amount of trains related to this particular train stop. Includes train stopped at this train stop (until it finds a path to next target) and trains having this train stop as goal or waypoint.
  /// </summary>
  [FactorioRconAttribute("trains_count")]
  public uint TrainsCount { get; private set; }

  /// <summary>
  /// Amount of trains above which no new trains will be sent to this train stop. Writing nil will disable the limit (will set a maximum possible value).
  /// </summary>
  [FactorioRconAttribute("trains_limit")]
  public uint TrainsLimit { get; set; }

  /// <summary>
  /// (deprecated by 1.1.51) If this entity is a MilitaryTarget. Returns same value as LuaEntity::is_military_target
  /// </summary>
  [FactorioRconAttribute("is_entity_with_force")]
  public bool IsEntityWithForce { get; private set; }

  /// <summary>
  /// Whether this entity is a MilitaryTarget. Can be written to if <see cref="LuaEntityPrototype.AllowRunTimeChangeOfIsMilitaryTarget" /> returns `true`.
  /// </summary>
  [FactorioRconAttribute("is_military_target")]
  public bool IsMilitaryTarget { get; set; }

  /// <summary>
  /// If this entity is EntityWithOwner
  /// </summary>
  [FactorioRconAttribute("is_entity_with_owner")]
  public bool IsEntityWithOwner { get; private set; }

  /// <summary>
  /// If this entity is EntityWithHealth
  /// </summary>
  [FactorioRconAttribute("is_entity_with_health")]
  public bool IsEntityWithHealth { get; private set; }

  /// <summary>
  /// The owner of this combat robot, if any.
  /// </summary>
  [FactorioRconAttribute("combat_robot_owner")]
  public LuaEntity CombatRobotOwner { get; set; }

  /// <summary>
  /// The link ID this linked container is using.
  /// </summary>
  [FactorioRconAttribute("link_id")]
  public uint LinkId { get; set; }

  /// <summary>
  /// The follow target of this spidertron, if any.
  /// </summary>
  [FactorioRconAttribute("follow_target")]
  public LuaEntity FollowTarget { get; set; }

  /// <summary>
  /// The follow offset of this spidertron, if any entity is being followed. This is randomized each time the follow entity is set.
  /// </summary>
  [FactorioRconAttribute("follow_offset")]
  public Vector FollowOffset { get; set; }

  /// <summary>
  /// Type of linked belt. Changing type will also flip direction so the belt is out of the same side.
  /// </summary>
  [FactorioRconAttribute("linked_belt_type")]
  public Literals1571199611 LinkedBeltType { get; set; }

  /// <summary>
  /// Neighbour to which this linked belt is connected to, if any.
  /// </summary>
  [FactorioRconAttribute("linked_belt_neighbour")]
  public LuaEntity LinkedBeltNeighbour { get; private set; }

  /// <summary>
  /// The current radar scan progress, as a number in range [0, 1].
  /// </summary>
  [FactorioRconAttribute("radar_scan_progress")]
  public float RadarScanProgress { get; private set; }

  /// <summary>
  /// The status of this rocket silo entity.
  /// </summary>
  [FactorioRconAttribute("rocket_silo_status")]
  public RocketSiloStatusEnum RocketSiloStatus { get; private set; }

  /// <summary>
  /// Specifies the tiling size of the entity, is used to decide, if the center should be in the center of the tile (odd tile size dimension) or on the tile border (even tile size dimension). Uses the current direction of the entity.
  /// </summary>
  [FactorioRconAttribute("tile_width")]
  public uint TileWidth { get; private set; }

  /// <summary>
  /// Specifies the tiling size of the entity, is used to decide, if the center should be in the center of the tile (odd tile size dimension) or on the tile border (even tile size dimension). Uses the current direction of the entity.
  /// </summary>
  [FactorioRconAttribute("tile_height")]
  public uint TileHeight { get; private set; }

  /// <summary>
  /// If the rolling stock is facing train's front.
  /// </summary>
  [FactorioRconAttribute("is_headed_to_trains_front")]
  public bool IsHeadedToTrainsFront { get; private set; }

  /// <summary>
  /// Gives a draw data of the given entity if it supports such data.
  /// </summary>
  [FactorioRconAttribute("draw_data")]
  public RollingStockDrawData DrawData { get; private set; }

  /// <summary>
  /// Gives what is the current shape of a transport-belt.
  /// </summary>
  [FactorioRconAttribute("belt_shape")]
  public Literals888349890 BeltShape { get; private set; }

  /// <summary>
  /// Returns a <see cref="LuaGameScript.Print" /> it will ping the location of the entity.
  /// </summary>
  [FactorioRconAttribute("gps_tag")]
  public string GpsTag { get; private set; }

  /// <summary>
  /// Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the game state might have occurred between the creation of the Lua object and its access.
  /// </summary>
  [FactorioRconAttribute("valid")]
  public bool Valid { get; private set; }

  /// <summary>
  /// The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// Gets the entity's output inventory if it has one.
  /// </summary>
  [FactorioRconMethod("get_output_inventory")]
  public abstract LuaInventory? GetOutputInventory();

  /// <summary>
  /// Inventory for storing modules of this entity; `nil` if this entity has no module inventory.
  /// </summary>
  [FactorioRconMethod("get_module_inventory")]
  public abstract LuaInventory? GetModuleInventory();

  /// <summary>
  /// The fuel inventory for this entity or `nil` if this entity doesn't have a fuel inventory.
  /// </summary>
  [FactorioRconMethod("get_fuel_inventory")]
  public abstract LuaInventory? GetFuelInventory();

  /// <summary>
  /// The burnt result inventory for this entity or `nil` if this entity doesn't have a burnt result inventory.
  /// </summary>
  [FactorioRconMethod("get_burnt_result_inventory")]
  public abstract LuaInventory? GetBurntResultInventory();

  /// <summary>
  /// Damages the entity.
  /// </summary>
  /// <param name="damage">Lua name: damage</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="type">Lua name: type</param>
  /// <param name="dealer">Lua name: dealer</param>
  [FactorioRconMethod("damage")]
  public abstract float Damage(float damage, ForceIdentification force, string? type = null, LuaEntity? dealer = null);

  /// <summary>
  /// Whether the entity can be destroyed
  /// </summary>
  [FactorioRconMethod("can_be_destroyed")]
  public abstract bool CanBeDestroyed();

  /// <summary>
  /// Destroys the entity.
  /// </summary>
  /// <remarks>
  /// Not all entities can be destroyed - things such as rails under trains cannot be destroyed until the train is moved or destroyed.
  /// </remarks>
  /// <param name="doCliffCorrection">Lua name: do_cliff_correction</param>
  /// <param name="raiseDestroy">Lua name: raise_destroy</param>
  [FactorioRconMethod("destroy")]
  public abstract bool Destroy(bool? doCliffCorrection = null, bool? raiseDestroy = null);

  /// <summary>
  /// Give the entity a command.
  /// </summary>
  /// <param name="command">Lua name: command</param>
  [FactorioRconMethod("set_command")]
  public abstract void SetCommand(Command command);

  /// <summary>
  /// Give the entity a distraction command.
  /// </summary>
  /// <param name="command">Lua name: command</param>
  [FactorioRconMethod("set_distraction_command")]
  public abstract void SetDistractionCommand(Command command);

  /// <summary>
  /// Has this unit been assigned a command?
  /// </summary>
  [FactorioRconMethod("has_command")]
  public abstract bool HasCommand();

  /// <summary>
  /// Immediately kills the entity. Does nothing if the entity doesn't have health.
  /// 
  /// Unlike <see cref="OnEntityDied" /> event and the entity will produce a corpse and drop loot if it has any.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  /// <param name="cause">Lua name: cause</param>
  [FactorioRconMethod("die")]
  public abstract bool Die(ForceIdentification? force = null, LuaEntity? cause = null);

  /// <summary>
  /// Test whether this entity's prototype has a certain flag set.
  /// </summary>
  /// <remarks>
  /// `entity.has_flag(f)` is a shortcut for `entity.prototype.has_flag(f)`.
  /// </remarks>
  /// <param name="flag">Lua name: flag</param>
  [FactorioRconMethod("has_flag")]
  public abstract bool HasFlag(EntityPrototypeFlag flag);

  /// <summary>
  /// Same as <see cref="LuaEntity.HasFlag" />, but targets the inner entity on a entity ghost.
  /// </summary>
  /// <param name="flag">Lua name: flag</param>
  [FactorioRconMethod("ghost_has_flag")]
  public abstract bool GhostHasFlag(EntityPrototypeFlag flag);

  /// <summary>
  /// Offer a thing on the market.
  /// </summary>
  /// <param name="offer">Lua name: offer</param>
  [FactorioRconMethod("add_market_item")]
  public abstract void AddMarketItem(Offer offer);

  /// <summary>
  /// Remove an offer from a market.
  /// </summary>
  /// <remarks>
  /// The other offers are moved down to fill the gap created by removing the offer, which decrements the overall size of the offer array.
  /// </remarks>
  /// <param name="offer">Lua name: offer</param>
  [FactorioRconMethod("remove_market_item")]
  public abstract bool RemoveMarketItem(uint offer);

  /// <summary>
  /// Get all offers in a market as an array.
  /// </summary>
  [FactorioRconMethod("get_market_items")]
  public abstract List<Offer> GetMarketItems();

  /// <summary>
  /// Removes all offers from a market.
  /// </summary>
  [FactorioRconMethod("clear_market_items")]
  public abstract void ClearMarketItems();

  /// <summary>
  /// Connect two devices with a circuit wire or copper cable. Depending on which type of connection should be made, there are different procedures:
  /// 
  /// - To connect two electric poles, `target` must be a <see cref="LuaEntity" /> that specifies another electric pole. This will connect them with copper cable.
  /// - To connect two devices with circuit wire, `target` must be a table of type <see cref="WireConnectionDefinition" />.
  /// </summary>
  /// <param name="target">Lua name: target</param>
  [FactorioRconMethod("connect_neighbour")]
  public abstract bool ConnectNeighbour(Union1078429072 target);

  /// <summary>
  /// Disconnect circuit wires or copper cables between devices. Depending on which type of connection should be cut, there are different procedures:
  /// 
  /// - To remove all copper cables, leave the `target` parameter blank: `pole.disconnect_neighbour()`.
  /// - To remove all wires of a specific color, set `target` to <see cref="Defines.WireType.Green" />.
  /// - To remove a specific copper cable between two electric poles, `target` must be a <see cref="LuaEntity)ThatSpecifiesTheOtherPole:`Pole1.DisconnectNeighbour(Pole2" />`.
  /// - To remove a specific circuit wire, `target` must be a table of type <see cref="WireConnectionDefinition" />.
  /// </summary>
  /// <param name="target">Lua name: target</param>
  [FactorioRconMethod("disconnect_neighbour")]
  public abstract void DisconnectNeighbour(Union375182924? target = null);

  /// <summary>
  /// Sets the entity to be deconstructed by construction robots.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("order_deconstruction")]
  public abstract bool OrderDeconstruction(ForceIdentification force, PlayerIdentification? player = null);

  /// <summary>
  /// Cancels deconstruction if it is scheduled, does nothing otherwise.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("cancel_deconstruction")]
  public abstract void CancelDeconstruction(ForceIdentification force, PlayerIdentification? player = null);

  /// <summary>
  /// Is this entity marked for deconstruction?
  /// </summary>
  [FactorioRconMethod("to_be_deconstructed")]
  public abstract bool ToBeDeconstructed();

  /// <summary>
  /// Sets the entity to be upgraded by construction robots.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  /// <param name="target">Lua name: target</param>
  /// <param name="player">Lua name: player</param>
  /// <param name="direction">Lua name: direction</param>
  [FactorioRconMethod("order_upgrade")]
  public abstract bool OrderUpgrade(ForceIdentification force, EntityPrototypeIdentification target, PlayerIdentification? player = null, DirectionEnum? direction = null);

  /// <summary>
  /// Cancels upgrade if it is scheduled, does nothing otherwise.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("cancel_upgrade")]
  public abstract bool CancelUpgrade(ForceIdentification force, PlayerIdentification? player = null);

  /// <summary>
  /// Is this entity marked for upgrade?
  /// </summary>
  [FactorioRconMethod("to_be_upgraded")]
  public abstract bool ToBeUpgraded();

  /// <summary>
  /// Get a logistic requester slot.
  /// </summary>
  /// <remarks>
  /// Useable only on entities that have requester slots.
  /// </remarks>
  /// <param name="slot">Lua name: slot</param>
  [FactorioRconMethod("get_request_slot")]
  public abstract SimpleItemStack? GetRequestSlot(uint slot);

  /// <summary>
  /// Set a logistic requester slot.
  /// </summary>
  /// <remarks>
  /// Useable only on entities that have requester slots.
  /// </remarks>
  /// <param name="request">Lua name: request</param>
  /// <param name="slot">Lua name: slot</param>
  [FactorioRconMethod("set_request_slot")]
  public abstract bool SetRequestSlot(ItemStackIdentification request, uint slot);

  /// <summary>
  /// Clear a logistic requester slot.
  /// </summary>
  /// <remarks>
  /// Useable only on entities that have requester slots.
  /// </remarks>
  /// <param name="slot">Lua name: slot</param>
  [FactorioRconMethod("clear_request_slot")]
  public abstract void ClearRequestSlot(uint slot);

  /// <summary>
  /// Returns whether a craft is currently in process. It does not indicate whether progress is currently being made, but whether a crafting process has been started in this machine.
  /// </summary>
  [FactorioRconMethod("is_crafting")]
  public abstract bool IsCrafting();

  [FactorioRconMethod("is_opened")]
  public abstract bool IsOpened();

  [FactorioRconMethod("is_opening")]
  public abstract bool IsOpening();

  [FactorioRconMethod("is_closed")]
  public abstract bool IsClosed();

  [FactorioRconMethod("is_closing")]
  public abstract bool IsClosing();

  /// <param name="force">Lua name: force</param>
  /// <param name="extraTime">Lua name: extra_time</param>
  [FactorioRconMethod("request_to_open")]
  public abstract void RequestToOpen(ForceIdentification force, uint? extraTime = null);

  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("request_to_close")]
  public abstract void RequestToClose(ForceIdentification force);

  /// <summary>
  /// Get a transport line of a belt or belt connectable entity.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_transport_line")]
  public abstract LuaTransportLine GetTransportLine(uint index);

  /// <summary>
  /// Get the maximum transport line index of a belt or belt connectable entity.
  /// </summary>
  [FactorioRconMethod("get_max_transport_line_index")]
  public abstract uint GetMaxTransportLineIndex();

  [FactorioRconMethod("launch_rocket")]
  public abstract bool LaunchRocket();

  /// <summary>
  /// Revive a ghost. I.e. turn it from a ghost to a real entity or tile.
  /// </summary>
  /// <param name="returnItemRequestProxy">Lua name: return_item_request_proxy</param>
  /// <param name="raiseRevive">Lua name: raise_revive</param>
  [FactorioRconMethod("revive")]
  public abstract (Dictionary<string, uint>?, LuaEntity?, LuaEntity?) Revive(bool? returnItemRequestProxy = null, bool? raiseRevive = null);

  /// <summary>
  /// Revives a ghost silently.
  /// </summary>
  /// <param name="returnItemRequestProxy">Lua name: return_item_request_proxy</param>
  /// <param name="raiseRevive">Lua name: raise_revive</param>
  [FactorioRconMethod("silent_revive")]
  public abstract (Dictionary<string, uint>?, LuaEntity?, LuaEntity?) SilentRevive(bool? returnItemRequestProxy = null, bool? raiseRevive = null);

  /// <param name="railDirection">Lua name: rail_direction</param>
  /// <param name="railConnectionDirection">Lua name: rail_connection_direction</param>
  [FactorioRconMethod("get_connected_rail")]
  public abstract (LuaEntity?, RailDirectionEnum?, RailConnectionDirectionEnum?) GetConnectedRail(RailDirectionEnum railDirection, RailConnectionDirectionEnum railConnectionDirection);

  /// <summary>
  /// Get the rails that this signal is connected to.
  /// </summary>
  [FactorioRconMethod("get_connected_rails")]
  public abstract List<LuaEntity> GetConnectedRails();

  /// <summary>
  /// Get the rail signal or train stop at the start/end of the rail segment this rail is in.
  /// </summary>
  /// <remarks>
  /// A rail segment is a continuous section of rail with no branches, signals, nor train stops.
  /// </remarks>
  /// <param name="direction">Lua name: direction</param>
  /// <param name="inElseOut">Lua name: in_else_out</param>
  [FactorioRconMethod("get_rail_segment_entity")]
  public abstract LuaEntity? GetRailSegmentEntity(RailDirectionEnum direction, bool inElseOut);

  /// <summary>
  /// Get the rail at the end of the rail segment this rail is in.
  /// </summary>
  /// <remarks>
  /// A rail segment is a continuous section of rail with no branches, signals, nor train stops.
  /// </remarks>
  /// <param name="direction">Lua name: direction</param>
  [FactorioRconMethod("get_rail_segment_end")]
  public abstract (LuaEntity, RailDirectionEnum) GetRailSegmentEnd(RailDirectionEnum direction);

  /// <summary>
  /// Get all rails of a rail segment this rail is in
  /// </summary>
  /// <remarks>
  /// A rail segment is a continuous section of rail with no branches, signals, nor train stops.
  /// </remarks>
  /// <param name="direction">Lua name: direction</param>
  [FactorioRconMethod("get_rail_segment_rails")]
  public abstract List<LuaEntity> GetRailSegmentRails(RailDirectionEnum direction);

  /// <summary>
  /// Get the length of the rail segment this rail is in.
  /// </summary>
  /// <remarks>
  /// A rail segment is a continuous section of rail with no branches, signals, nor train stops.
  /// </remarks>
  [FactorioRconMethod("get_rail_segment_length")]
  public abstract double GetRailSegmentLength();

  /// <summary>
  /// Get a rail from each rail segment that overlaps with this rail's rail segment.
  /// </summary>
  /// <remarks>
  /// A rail segment is a continuous section of rail with no branches, signals, nor train stops.
  /// </remarks>
  [FactorioRconMethod("get_rail_segment_overlaps")]
  public abstract List<LuaEntity> GetRailSegmentOverlaps();

  /// <summary>
  /// Checks if this rail and other rail both belong to the same rail segment.
  /// </summary>
  /// <param name="otherRail">Lua name: other_rail</param>
  [FactorioRconMethod("is_rail_in_same_rail_segment_as")]
  public abstract bool IsRailInSameRailSegmentAs(LuaEntity otherRail);

  /// <summary>
  /// Checks if this rail and other rail both belong to the same rail block.
  /// </summary>
  /// <param name="otherRail">Lua name: other_rail</param>
  [FactorioRconMethod("is_rail_in_same_rail_block_as")]
  public abstract bool IsRailInSameRailBlockAs(LuaEntity otherRail);

  /// <summary>
  /// Returns all parent signals. Parent signals are always RailChainSignal. Parent signals are those signals that are checking state of this signal to determine their own chain state.
  /// </summary>
  [FactorioRconMethod("get_parent_signals")]
  public abstract List<LuaEntity> GetParentSignals();

  /// <summary>
  /// Returns all child signals. Child signals can be either RailSignal or RailChainSignal. Child signals are signals which are checked by this signal to determine a chain state.
  /// </summary>
  [FactorioRconMethod("get_child_signals")]
  public abstract List<LuaEntity> GetChildSignals();

  /// <summary>
  /// Returns all signals guarding entrance to a rail block this rail belongs to.
  /// </summary>
  [FactorioRconMethod("get_inbound_signals")]
  public abstract List<LuaEntity> GetInboundSignals();

  /// <summary>
  /// Returns all signals guarding exit from a rail block this rail belongs to.
  /// </summary>
  [FactorioRconMethod("get_outbound_signals")]
  public abstract List<LuaEntity> GetOutboundSignals();

  /// <summary>
  /// Get the filter for a slot in an inserter, loader, or logistic storage container.
  /// </summary>
  /// <remarks>
  /// The entity must allow filters.
  /// </remarks>
  /// <param name="slotIndex">Lua name: slot_index</param>
  [FactorioRconMethod("get_filter")]
  public abstract string? GetFilter(uint slotIndex);

  /// <summary>
  /// Set the filter for a slot in an inserter, loader, or logistic storage container.
  /// </summary>
  /// <remarks>
  /// The entity must allow filters.
  /// </remarks>
  /// <param name="slotIndex">Lua name: slot_index</param>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("set_filter")]
  public abstract void SetFilter(uint slotIndex, Union2058824877 item);

  /// <summary>
  /// Gets the filter for this infinity container at the given index, or `nil` if the filter index doesn't exist or is empty.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_infinity_container_filter")]
  public abstract InfinityInventoryFilter? GetInfinityContainerFilter(uint index);

  /// <summary>
  /// Sets the filter for this infinity container at the given index.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("set_infinity_container_filter")]
  public abstract void SetInfinityContainerFilter(uint index, Union1400437807 filter);

  /// <summary>
  /// Gets the filter for this infinity pipe, or `nil` if the filter is empty.
  /// </summary>
  [FactorioRconMethod("get_infinity_pipe_filter")]
  public abstract InfinityPipeFilter? GetInfinityPipeFilter();

  /// <summary>
  /// Sets the filter for this infinity pipe.
  /// </summary>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("set_infinity_pipe_filter")]
  public abstract void SetInfinityPipeFilter(Union1711592058 filter);

  /// <summary>
  /// Gets the heat setting for this heat interface.
  /// </summary>
  [FactorioRconMethod("get_heat_setting")]
  public abstract HeatSetting GetHeatSetting();

  /// <summary>
  /// Sets the heat setting for this heat interface.
  /// </summary>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("set_heat_setting")]
  public abstract void SetHeatSetting(HeatSetting filter);

  /// <summary>
  /// Gets the control behavior of the entity (if any).
  /// </summary>
  [FactorioRconMethod("get_control_behavior")]
  public abstract LuaControlBehavior? GetControlBehavior();

  /// <summary>
  /// Gets (and or creates if needed) the control behavior of the entity.
  /// </summary>
  [FactorioRconMethod("get_or_create_control_behavior")]
  public abstract LuaControlBehavior? GetOrCreateControlBehavior();

  /// <param name="wire">Lua name: wire</param>
  /// <param name="circuitConnector">Lua name: circuit_connector</param>
  [FactorioRconMethod("get_circuit_network")]
  public abstract LuaCircuitNetwork? GetCircuitNetwork(WireTypeEnum wire, CircuitConnectorIdEnum? circuitConnector = null);

  /// <summary>
  /// Read a single signal from the combined circuit networks.
  /// </summary>
  /// <param name="signal">Lua name: signal</param>
  /// <param name="circuitConnector">Lua name: circuit_connector</param>
  [FactorioRconMethod("get_merged_signal")]
  public abstract int GetMergedSignal(SignalID signal, CircuitConnectorIdEnum? circuitConnector = null);

  /// <summary>
  /// The merged circuit network signals or `nil` if there are no signals.
  /// </summary>
  /// <param name="circuitConnector">Lua name: circuit_connector</param>
  [FactorioRconMethod("get_merged_signals")]
  public abstract List<Signal>? GetMergedSignals(CircuitConnectorIdEnum? circuitConnector = null);

  /// <summary>
  /// Whether this entity supports a backer name.
  /// </summary>
  [FactorioRconMethod("supports_backer_name")]
  public abstract bool SupportsBackerName();

  /// <summary>
  /// Copies settings from the given entity onto this entity.
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  /// <param name="byPlayer">Lua name: by_player</param>
  [FactorioRconMethod("copy_settings")]
  public abstract Dictionary<string, uint> CopySettings(LuaEntity entity, PlayerIdentification? byPlayer = null);

  /// <summary>
  /// Gets all the `LuaLogisticPoint`s that this entity owns. Optionally returns only the point specified by the index parameter.
  /// </summary>
  /// <remarks>
  /// When `index` is not given, this will be a single `LuaLogisticPoint` for most entities. For some (such as the player character), it can be zero or more.
  /// </remarks>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_logistic_point")]
  public abstract Union287506920? GetLogisticPoint(LogisticMemberIndexEnum? index = null);

  /// <summary>
  /// Plays a note with the given instrument and note.
  /// </summary>
  /// <param name="instrument">Lua name: instrument</param>
  /// <param name="note">Lua name: note</param>
  [FactorioRconMethod("play_note")]
  public abstract bool PlayNote(uint instrument, uint note);

  /// <summary>
  /// Connects the rolling stock in the given direction.
  /// </summary>
  /// <param name="direction">Lua name: direction</param>
  [FactorioRconMethod("connect_rolling_stock")]
  public abstract bool ConnectRollingStock(RailDirectionEnum direction);

  /// <summary>
  /// Tries to disconnect this rolling stock in the given direction.
  /// </summary>
  /// <param name="direction">Lua name: direction</param>
  [FactorioRconMethod("disconnect_rolling_stock")]
  public abstract bool DisconnectRollingStock(RailDirectionEnum direction);

  /// <summary>
  /// Reconnect loader, beacon, cliff and mining drill connections to entities that might have been teleported out or in by the script. The game doesn't do this automatically as we don't want to loose performance by checking this in normal games.
  /// </summary>
  [FactorioRconMethod("update_connections")]
  public abstract void UpdateConnections();

  /// <summary>
  /// Current recipe being assembled by this machine, if any.
  /// </summary>
  [FactorioRconMethod("get_recipe")]
  public abstract LuaRecipe? GetRecipe();

  /// <summary>
  /// Sets the given recipe in this assembly machine.
  /// </summary>
  /// <param name="recipe">Lua name: recipe</param>
  [FactorioRconMethod("set_recipe")]
  public abstract Dictionary<string, uint> SetRecipe(Union1754038198 recipe);

  /// <summary>
  /// Rotates this entity as if the player rotated it.
  /// </summary>
  /// <param name="reverse">Lua name: reverse</param>
  /// <param name="byPlayer">Lua name: by_player</param>
  /// <param name="spillItems">Lua name: spill_items</param>
  /// <param name="enableLooted">Lua name: enable_looted</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("rotate")]
  public abstract (bool, Dictionary<string, uint>?) Rotate(bool? reverse = null, PlayerIdentification? byPlayer = null, bool? spillItems = null, bool? enableLooted = null, ForceIdentification? force = null);

  /// <summary>
  /// Gets the driver of this vehicle if any.
  /// </summary>
  [FactorioRconMethod("get_driver")]
  public abstract Union1147381287? GetDriver();

  /// <summary>
  /// Sets the driver of this vehicle.
  /// </summary>
  /// <remarks>
  /// This differs from <see cref="LuaEntity.SetPassenger" /> in that the passenger can't drive the vehicle.
  /// </remarks>
  /// <param name="driver">Lua name: driver</param>
  [FactorioRconMethod("set_driver")]
  public abstract void SetDriver(Union1517216140? driver = null);

  /// <summary>
  /// Gets the passenger of this car or spidertron if any.
  /// </summary>
  /// <remarks>
  /// This differs over <see cref="LuaEntity.GetDriver" /> in that the passenger can't drive the car.
  /// </remarks>
  [FactorioRconMethod("get_passenger")]
  public abstract Union1147381287? GetPassenger();

  /// <summary>
  /// Sets the passenger of this car or spidertron.
  /// </summary>
  /// <remarks>
  /// This differs from <see cref="LuaEntity.GetDriver" /> in that the passenger can't drive the car.
  /// </remarks>
  /// <param name="passenger">Lua name: passenger</param>
  [FactorioRconMethod("set_passenger")]
  public abstract void SetPassenger(Union1517216140? passenger = null);

  /// <summary>
  /// Returns `true` if this entity produces or consumes electricity and is connected to an electric network that has at least one entity that can produce power.
  /// </summary>
  [FactorioRconMethod("is_connected_to_electric_network")]
  public abstract bool IsConnectedToElectricNetwork();

  /// <summary>
  /// The trains scheduled to stop at this train stop.
  /// </summary>
  [FactorioRconMethod("get_train_stop_trains")]
  public abstract List<LuaTrain> GetTrainStopTrains();

  /// <summary>
  /// The train currently stopped at this train stop, if any.
  /// </summary>
  [FactorioRconMethod("get_stopped_train")]
  public abstract LuaTrain? GetStoppedTrain();

  /// <summary>
  /// Clones this entity.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="createBuildEffectSmoke">Lua name: create_build_effect_smoke</param>
  [FactorioRconMethod("clone")]
  public abstract LuaEntity? Clone(MapPosition position, LuaSurface? surface = null, ForceIdentification? force = null, bool? createBuildEffectSmoke = null);

  /// <summary>
  /// Get the amount of all or some fluid in this entity.
  /// </summary>
  /// <remarks>
  /// If information about fluid temperatures is required, <see cref="LuaEntity.Fluidbox" /> should be used instead.
  /// </remarks>
  /// <param name="fluid">Lua name: fluid</param>
  [FactorioRconMethod("get_fluid_count")]
  public abstract double GetFluidCount(string? fluid = null);

  /// <summary>
  /// Get amounts of all fluids in this entity.
  /// </summary>
  /// <remarks>
  /// If information about fluid temperatures is required, <see cref="LuaEntity.Fluidbox" /> should be used instead.
  /// </remarks>
  [FactorioRconMethod("get_fluid_contents")]
  public abstract Dictionary<string, double> GetFluidContents();

  /// <summary>
  /// Remove fluid from this entity.
  /// </summary>
  /// <remarks>
  /// If temperature is given only fluid matching that exact temperature is removed. If minimum and maximum is given fluid within that range is removed.
  /// </remarks>
  /// <param name="name">Lua name: name</param>
  /// <param name="amount">Lua name: amount</param>
  /// <param name="minimumTemperature">Lua name: minimum_temperature</param>
  /// <param name="maximumTemperature">Lua name: maximum_temperature</param>
  /// <param name="temperature">Lua name: temperature</param>
  [FactorioRconMethod("remove_fluid")]
  public abstract double RemoveFluid(string name, double amount, double? minimumTemperature = null, double? maximumTemperature = null, double? temperature = null);

  /// <summary>
  /// Insert fluid into this entity. Fluidbox is chosen automatically.
  /// </summary>
  /// <param name="fluid">Lua name: fluid</param>
  [FactorioRconMethod("insert_fluid")]
  public abstract double InsertFluid(Fluid fluid);

  /// <summary>
  /// Remove all fluids from this entity.
  /// </summary>
  [FactorioRconMethod("clear_fluid_inside")]
  public abstract void ClearFluidInside();

  /// <summary>
  /// Get the source of this beam.
  /// </summary>
  [FactorioRconMethod("get_beam_source")]
  public abstract BeamTarget? GetBeamSource();

  /// <summary>
  /// Set the source of this beam.
  /// </summary>
  /// <param name="source">Lua name: source</param>
  [FactorioRconMethod("set_beam_source")]
  public abstract void SetBeamSource(Union906229161 source);

  /// <summary>
  /// Get the target of this beam.
  /// </summary>
  [FactorioRconMethod("get_beam_target")]
  public abstract BeamTarget? GetBeamTarget();

  /// <summary>
  /// Set the target of this beam.
  /// </summary>
  /// <param name="target">Lua name: target</param>
  [FactorioRconMethod("set_beam_target")]
  public abstract void SetBeamTarget(Union906229161 target);

  /// <summary>
  /// The radius of this entity.
  /// </summary>
  [FactorioRconMethod("get_radius")]
  public abstract double GetRadius();

  /// <summary>
  /// The health ratio of this entity between 1 and 0 (for full health and no health respectively).
  /// </summary>
  [FactorioRconMethod("get_health_ratio")]
  public abstract float? GetHealthRatio();

  /// <summary>
  /// Creates the same smoke that is created when you place a building by hand. You can play the building sound to go with it by using <see cref="LuaSurface.PlaySound" />, eg: entity.surface.play_sound{path="entity-build/"..entity.prototype.name, position=entity.position}
  /// </summary>
  [FactorioRconMethod("create_build_effect_smoke")]
  public abstract void CreateBuildEffectSmoke();

  /// <summary>
  /// Release the unit from the spawner which spawned it. This allows the spawner to continue spawning additional units.
  /// </summary>
  [FactorioRconMethod("release_from_spawner")]
  public abstract void ReleaseFromSpawner();

  /// <summary>
  /// Toggle this entity's equipment movement bonus. Does nothing if the entity does not have an equipment grid.
  /// </summary>
  /// <remarks>
  /// This property can also be read and written on the equipment grid of this entity.
  /// </remarks>
  [FactorioRconMethod("toggle_equipment_movement_bonus")]
  public abstract void ToggleEquipmentMovementBonus();

  /// <summary>
  /// Whether this character can shoot the given entity or position.
  /// </summary>
  /// <param name="target">Lua name: target</param>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("can_shoot")]
  public abstract bool CanShoot(LuaEntity target, MapPosition position);

  /// <summary>
  /// Only works if the entity is a speech-bubble, with an "effect" defined in its wrapper_flow_style. Starts animating the opacity of the speech bubble towards zero, and destroys the entity when it hits zero.
  /// </summary>
  [FactorioRconMethod("start_fading_out")]
  public abstract void StartFadingOut();

  /// <summary>
  /// Returns the new entity prototype.
  /// </summary>
  [FactorioRconMethod("get_upgrade_target")]
  public abstract LuaEntityPrototype? GetUpgradeTarget();

  /// <summary>
  /// Returns the new entity direction after upgrading.
  /// </summary>
  [FactorioRconMethod("get_upgrade_direction")]
  public abstract DirectionEnum? GetUpgradeDirection();

  /// <summary>
  /// Returns the amount of damage to be taken by this entity.
  /// </summary>
  [FactorioRconMethod("get_damage_to_be_taken")]
  public abstract float? GetDamageToBeTaken();

  /// <summary>
  /// Depletes and destroys this resource entity.
  /// </summary>
  [FactorioRconMethod("deplete")]
  public abstract void Deplete();

  /// <summary>
  /// Mines this entity.
  /// </summary>
  /// <remarks>
  /// 'Standard' operation is to keep calling `LuaEntity.mine` with an inventory until all items are transferred and the items dealt with.
  /// The result of mining the entity (the item(s) it produces when mined) will be dropped on the ground if they don't fit into the provided inventory.
  /// </remarks>
  /// <param name="inventory">Lua name: inventory</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="raiseDestroyed">Lua name: raise_destroyed</param>
  /// <param name="ignoreMinable">Lua name: ignore_minable</param>
  [FactorioRconMethod("mine")]
  public abstract bool Mine(LuaInventory? inventory = null, bool? force = null, bool? raiseDestroyed = null, bool? ignoreMinable = null);

  /// <summary>
  /// Triggers spawn_decoration actions defined in the entity prototype or does nothing if entity is not "turret" or "unit-spawner".
  /// </summary>
  [FactorioRconMethod("spawn_decorations")]
  public abstract void SpawnDecorations();

  /// <summary>
  /// Can wires reach between these entities.
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  [FactorioRconMethod("can_wires_reach")]
  public abstract bool CanWiresReach(LuaEntity entity);

  /// <summary>
  /// Gets rolling stock connected to the given end of this stock.
  /// </summary>
  /// <param name="direction">Lua name: direction</param>
  [FactorioRconMethod("get_connected_rolling_stock")]
  public abstract (LuaEntity?, RailDirectionEnum?) GetConnectedRollingStock(RailDirectionEnum direction);

  /// <summary>
  /// Is this entity or tile ghost or item request proxy registered for construction? If false, it means a construction robot has been dispatched to build the entity, or it is not an entity that can be constructed.
  /// </summary>
  [FactorioRconMethod("is_registered_for_construction")]
  public abstract bool IsRegisteredForConstruction();

  /// <summary>
  /// Is this entity registered for deconstruction with this force? If false, it means a construction robot has been dispatched to deconstruct it, or it is not marked for deconstruction. The complexity is effectively O(1) - it depends on the number of objects targeting this entity which should be small enough.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("is_registered_for_deconstruction")]
  public abstract bool IsRegisteredForDeconstruction(ForceIdentification force);

  /// <summary>
  /// Is this entity registered for upgrade? If false, it means a construction robot has been dispatched to upgrade it, or it is not marked for upgrade. This is worst-case O(N) complexity where N is the current number of things in the upgrade queue.
  /// </summary>
  [FactorioRconMethod("is_registered_for_upgrade")]
  public abstract bool IsRegisteredForUpgrade();

  /// <summary>
  /// Is this entity registered for repair? If false, it means a construction robot has been dispatched to upgrade it, or it is not damaged. This is worst-case O(N) complexity where N is the current number of things in the repair queue.
  /// </summary>
  [FactorioRconMethod("is_registered_for_repair")]
  public abstract bool IsRegisteredForRepair();

  /// <summary>
  /// Adds the given position to this spidertron's autopilot's queue of destinations.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("add_autopilot_destination")]
  public abstract void AddAutopilotDestination(MapPosition position);

  /// <summary>
  /// Connects current linked belt with another one.
  /// 
  /// Neighbours have to be of different type. If given linked belt is connected to something else it will be disconnected first. If provided neighbour is connected to something else it will also be disconnected first. Automatically updates neighbour to be connected back to this one.
  /// </summary>
  /// <remarks>
  /// Can also be used on entity ghost if it contains linked-belt
  /// </remarks>
  /// <param name="neighbour">Lua name: neighbour</param>
  [FactorioRconMethod("connect_linked_belts")]
  public abstract void ConnectLinkedBelts(LuaEntity neighbour);

  /// <summary>
  /// Disconnects linked belt from its neighbour.
  /// </summary>
  /// <remarks>
  /// Can also be used on entity ghost if it contains linked-belt
  /// </remarks>
  [FactorioRconMethod("disconnect_linked_belts")]
  public abstract void DisconnectLinkedBelts();

  /// <summary>
  /// Gets legs of given SpiderVehicle.
  /// </summary>
  [FactorioRconMethod("get_spider_legs")]
  public abstract List<LuaEntity> GetSpiderLegs();

  /// <summary>
  /// Sets the <see cref="LuaEntity.AutopilotDestination" />, which it will continue moving towards if set.
  /// </summary>
  [FactorioRconMethod("stop_spider")]
  public abstract void StopSpider();

  /// <summary>
  /// Returns a table with all beacons affecting this effect receiver. Can only be used when the entity has an effect receiver (AssemblingMachine, Furnace, Lab, MiningDrills)
  /// </summary>
  [FactorioRconMethod("get_beacons")]
  public abstract List<LuaEntity>? GetBeacons();

  /// <summary>
  /// Returns a table with all entities affected by this beacon
  /// </summary>
  [FactorioRconMethod("get_beacon_effect_receivers")]
  public abstract List<LuaEntity> GetBeaconEffectReceivers();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

