#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// This is an abstract base class containing the common functionality between <see cref="LuaEntity" />, it must refer to a character entity.
/// </summary>
[FactorioRconClass("LuaControl")]
public class LuaControl
{
  /// <summary>
  /// The surface this entity is currently on.
  /// </summary>
  [FactorioRconAttribute("surface")]
  public LuaSurface Surface { get; private set; }

  /// <summary>
  /// Unique <see cref="LuaSurface.Index)(ID" /> associated with the surface this entity is currently on.
  /// </summary>
  [FactorioRconAttribute("surface_index")]
  public uint SurfaceIndex { get; private set; }

  /// <summary>
  /// The current position of the entity.
  /// </summary>
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; private set; }

  /// <summary>
  /// The vehicle the player is currently sitting in.
  /// </summary>
  [FactorioRconAttribute("vehicle")]
  public LuaEntity Vehicle { get; private set; }

  /// <summary>
  /// The force of this entity. Reading will always give a <see cref="LuaForce" /> to this attribute to change the force.
  /// </summary>
  [FactorioRconAttribute("force")]
  public ForceIdentification Force { get; set; }

  /// <summary>
  /// Unique <see cref="LuaForce.Index)(ID" /> associated with the force of this entity.
  /// </summary>
  [FactorioRconAttribute("force_index")]
  public uint ForceIndex { get; private set; }

  /// <summary>
  /// The currently selected entity. Assigning an entity will select it if is selectable, otherwise the selection is cleared.
  /// </summary>
  [FactorioRconAttribute("selected")]
  public LuaEntity Selected { get; set; }

  /// <summary>
  /// The GUI the player currently has open.
  /// 
  /// This is the GUI that will asked to close (by firing the <see cref="OnGuiClosed)Event" /> when the `Esc` or `E` keys are pressed. If this attribute is not `nil`, and a new GUI is written to it, the existing one will be asked to close.
  /// </summary>
  [FactorioRconAttribute("opened")]
  public OneOf<LuaEntity, LuaItemStack, LuaEquipment, LuaEquipmentGrid, LuaPlayer, LuaGuiElement, LuaInventory, LuaTechnology, GuiTypeEnum> Opened { get; set; }

  /// <summary>
  /// Size of the crafting queue.
  /// </summary>
  [FactorioRconAttribute("crafting_queue_size")]
  public uint CraftingQueueSize { get; private set; }

  /// <summary>
  /// The crafting queue progress in the range `[0-1]`. `0` when no recipe is being crafted.
  /// </summary>
  [FactorioRconAttribute("crafting_queue_progress")]
  public double CraftingQueueProgress { get; set; }

  /// <summary>
  /// Current walking state.
  /// </summary>
  [FactorioRconAttribute("walking_state")]
  public Table49924125 WalkingState { get; set; }

  /// <summary>
  /// Current riding state of this car, or of the car this player is riding in.
  /// </summary>
  [FactorioRconAttribute("riding_state")]
  public RidingState RidingState { get; set; }

  /// <summary>
  /// Current mining state.
  /// </summary>
  [FactorioRconAttribute("mining_state")]
  public Table5773521 MiningState { get; set; }

  /// <summary>
  /// Current shooting state.
  /// </summary>
  [FactorioRconAttribute("shooting_state")]
  public Table63094882 ShootingState { get; set; }

  /// <summary>
  /// Current item-picking state.
  /// </summary>
  [FactorioRconAttribute("picking_state")]
  public bool PickingState { get; set; }

  /// <summary>
  /// Current repair state.
  /// </summary>
  [FactorioRconAttribute("repair_state")]
  public Table54135081 RepairState { get; set; }

  /// <summary>
  /// The player's cursor stack. `nil` if the player controller is a spectator.
  /// </summary>
  [FactorioRconAttribute("cursor_stack")]
  public LuaItemStack CursorStack { get; private set; }

  /// <summary>
  /// The ghost prototype in the player's cursor. When read, it will be a <see cref="LuaItemPrototype" />.
  /// </summary>
  [FactorioRconAttribute("cursor_ghost")]
  public ItemPrototypeIdentification CursorGhost { get; set; }

  /// <summary>
  /// `true` if the player is in a vehicle. Writing to this attribute puts the player in or out of a vehicle.
  /// </summary>
  [FactorioRconAttribute("driving")]
  public bool Driving { get; set; }

  /// <summary>
  /// The current crafting queue items.
  /// </summary>
  [FactorioRconAttribute("crafting_queue")]
  public CraftingQueueItem[] CraftingQueue { get; private set; }

  /// <summary>
  /// The current combat robots following the character.
  /// </summary>
  [FactorioRconAttribute("following_robots")]
  public LuaEntity[] FollowingRobots { get; private set; }

  /// <summary>
  /// When `true` hand crafting is free and instant.
  /// </summary>
  [FactorioRconAttribute("cheat_mode")]
  public bool CheatMode { get; set; }

  [FactorioRconAttribute("character_crafting_speed_modifier")]
  public double CharacterCraftingSpeedModifier { get; set; }

  [FactorioRconAttribute("character_mining_speed_modifier")]
  public double CharacterMiningSpeedModifier { get; set; }

  [FactorioRconAttribute("character_additional_mining_categories")]
  public string[] CharacterAdditionalMiningCategories { get; set; }

  /// <summary>
  /// Modifies the running speed of this character by the given value as a percentage. Setting the running modifier to `0.5` makes the character run 50% faster. The minimum value of `-1` reduces the movement speed by 100%, resulting in a speed of `0`.
  /// </summary>
  [FactorioRconAttribute("character_running_speed_modifier")]
  public double CharacterRunningSpeedModifier { get; set; }

  [FactorioRconAttribute("character_build_distance_bonus")]
  public uint CharacterBuildDistanceBonus { get; set; }

  [FactorioRconAttribute("character_item_drop_distance_bonus")]
  public uint CharacterItemDropDistanceBonus { get; set; }

  [FactorioRconAttribute("character_reach_distance_bonus")]
  public uint CharacterReachDistanceBonus { get; set; }

  [FactorioRconAttribute("character_resource_reach_distance_bonus")]
  public uint CharacterResourceReachDistanceBonus { get; set; }

  [FactorioRconAttribute("character_item_pickup_distance_bonus")]
  public uint CharacterItemPickupDistanceBonus { get; set; }

  [FactorioRconAttribute("character_loot_pickup_distance_bonus")]
  public uint CharacterLootPickupDistanceBonus { get; set; }

  [FactorioRconAttribute("character_inventory_slots_bonus")]
  public uint CharacterInventorySlotsBonus { get; set; }

  [FactorioRconAttribute("character_trash_slot_count_bonus")]
  public uint CharacterTrashSlotCountBonus { get; set; }

  [FactorioRconAttribute("character_maximum_following_robot_count_bonus")]
  public uint CharacterMaximumFollowingRobotCountBonus { get; set; }

  [FactorioRconAttribute("character_health_bonus")]
  public float CharacterHealthBonus { get; set; }

  /// <summary>
  /// If personal logistic requests are enabled for this character or players character.
  /// </summary>
  [FactorioRconAttribute("character_personal_logistic_requests_enabled")]
  public bool CharacterPersonalLogisticRequestsEnabled { get; set; }

  /// <summary>
  /// If personal logistic requests are enabled for this vehicle (spidertron).
  /// </summary>
  [FactorioRconAttribute("vehicle_logistic_requests_enabled")]
  public bool VehicleLogisticRequestsEnabled { get; set; }

  [FactorioRconAttribute("opened_gui_type")]
  public GuiTypeEnum OpenedGuiType { get; private set; }

  /// <summary>
  /// The build distance of this character or max uint when not a character or player connected to a character.
  /// </summary>
  [FactorioRconAttribute("build_distance")]
  public uint BuildDistance { get; private set; }

  /// <summary>
  /// The item drop distance of this character or max uint when not a character or player connected to a character.
  /// </summary>
  [FactorioRconAttribute("drop_item_distance")]
  public uint DropItemDistance { get; private set; }

  /// <summary>
  /// The reach distance of this character or max uint when not a character or player connected to a character.
  /// </summary>
  [FactorioRconAttribute("reach_distance")]
  public uint ReachDistance { get; private set; }

  /// <summary>
  /// The item pickup distance of this character or max double when not a character or player connected to a character.
  /// </summary>
  [FactorioRconAttribute("item_pickup_distance")]
  public double ItemPickupDistance { get; private set; }

  /// <summary>
  /// The loot pickup distance of this character or max double when not a character or player connected to a character.
  /// </summary>
  [FactorioRconAttribute("loot_pickup_distance")]
  public double LootPickupDistance { get; private set; }

  /// <summary>
  /// The resource reach distance of this character or max double when not a character or player connected to a character.
  /// </summary>
  [FactorioRconAttribute("resource_reach_distance")]
  public double ResourceReachDistance { get; private set; }

  /// <summary>
  /// Whether this character entity is in combat.
  /// </summary>
  [FactorioRconAttribute("in_combat")]
  public bool InCombat { get; private set; }

  /// <summary>
  /// The current movement speed of this character, including effects from exoskeletons, tiles, stickers and shooting.
  /// </summary>
  [FactorioRconAttribute("character_running_speed")]
  public double CharacterRunningSpeed { get; private set; }

  /// <summary>
  /// The current mining progress between 0 and 1 of this character, or 0 if they aren't mining.
  /// </summary>
  [FactorioRconAttribute("character_mining_progress")]
  public double CharacterMiningProgress { get; private set; }

  /// <summary>
  /// Get an inventory belonging to this entity. This can be either the "main" inventory or some auxiliary one, like the module slots or logistic trash slots.
  /// </summary>
  /// <remarks>
  /// A given <see cref="Defines.Inventory" /> it's almost guaranteed to not be the inventory asked for.
  /// </remarks>
  /// <param name="inventory">Lua name: inventory</param>
  [FactorioRconMethod("get_inventory")]
  public LuaInventory? GetInventory(InventoryEnum inventory) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// The highest index of all inventories this entity can use. Allows iteration over all of them if desired.
  /// </summary>
  [FactorioRconMethod("get_max_inventory_index")]
  public InventoryEnum GetMaxInventoryIndex() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Gets the main inventory for this character or player if this is a character or player.
  /// </summary>
  [FactorioRconMethod("get_main_inventory")]
  public LuaInventory? GetMainInventory() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Can at least some items be inserted?
  /// </summary>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("can_insert")]
  public bool CanInsert(ItemStackIdentification items) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Insert items into this entity. This works the same way as inserters or shift-clicking: the "best" inventory is chosen automatically.
  /// </summary>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("insert")]
  public uint Insert(ItemStackIdentification items) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Create an arrow which points at this entity. This is used in the tutorial. For examples, see `control.lua` in the campaign missions.
  /// </summary>
  /// <param name="margin">Lua name: margin</param>
  /// <param name="type">Lua name: type</param>
  [FactorioRconMethod("set_gui_arrow")]
  public void SetGuiArrow(uint margin, GuiArrowType type) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Removes the arrow created by `set_gui_arrow`.
  /// </summary>
  [FactorioRconMethod("clear_gui_arrow")]
  public void ClearGuiArrow() => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Get the number of all or some items in this entity.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_item_count")]
  public uint GetItemCount(string? item = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Does this entity have any item inside it?
  /// </summary>
  [FactorioRconMethod("has_items_inside")]
  public bool HasItemsInside() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Can a given entity be opened or accessed?
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  [FactorioRconMethod("can_reach_entity")]
  public bool CanReachEntity(LuaEntity entity) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Remove all items from this entity.
  /// </summary>
  [FactorioRconMethod("clear_items_inside")]
  public void ClearItemsInside() => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Remove items from this entity.
  /// </summary>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("remove_item")]
  public uint RemoveItem(ItemStackIdentification items) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Teleport the entity to a given position, possibly on another surface.
  /// </summary>
  /// <remarks>
  /// Some entities may not be teleported. For instance, transport belts won't allow teleportation and this method will always return `false` when used on any such entity.
  /// You can also pass 1 or 2 numbers as the parameters and they will be used as relative teleport coordinates `'teleport(0, 1)'` to move the entity 1 tile positive y. `'teleport(4)'` to move the entity 4 tiles to the positive x.
  /// `script_raised_teleported` will not be raised if teleporting a player with no character.
  /// </remarks>
  /// <param name="position">Lua name: position</param>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="raiseTeleported">Lua name: raise_teleported</param>
  [FactorioRconMethod("teleport")]
  public bool Teleport(MapPosition position, SurfaceIdentification? surface = null, bool? raiseTeleported = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Select an entity, as if by hovering the mouse above it.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("update_selected_entity")]
  public void UpdateSelectedEntity(MapPosition position) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Unselect any selected entity.
  /// </summary>
  [FactorioRconMethod("clear_selected_entity")]
  public void ClearSelectedEntity() => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Disable the flashlight.
  /// </summary>
  [FactorioRconMethod("disable_flashlight")]
  public void DisableFlashlight() => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Enable the flashlight.
  /// </summary>
  [FactorioRconMethod("enable_flashlight")]
  public void EnableFlashlight() => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Is the flashlight enabled.
  /// </summary>
  [FactorioRconMethod("is_flashlight_enabled")]
  public bool IsFlashlightEnabled() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Gets the count of the given recipe that can be crafted.
  /// </summary>
  /// <param name="recipe">Lua name: recipe</param>
  [FactorioRconMethod("get_craftable_count")]
  public uint GetCraftableCount(OneOf<string, LuaRecipe> recipe) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Begins crafting the given count of the given recipe.
  /// </summary>
  /// <param name="count">Lua name: count</param>
  /// <param name="recipe">Lua name: recipe</param>
  /// <param name="silent">Lua name: silent</param>
  [FactorioRconMethod("begin_crafting")]
  public uint BeginCrafting(uint count, OneOf<string, LuaRecipe> recipe, bool? silent = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Cancels crafting the given count of the given crafting queue index.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="count">Lua name: count</param>
  [FactorioRconMethod("cancel_crafting")]
  public void CancelCrafting(uint index, uint count) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Mines the given entity as if this player (or character) mined it.
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("mine_entity")]
  public bool MineEntity(LuaEntity entity, bool? force = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Mines the given tile as if this player (or character) mined it.
  /// </summary>
  /// <param name="tile">Lua name: tile</param>
  [FactorioRconMethod("mine_tile")]
  public bool MineTile(LuaTile tile) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// When `true` control adapter is a LuaPlayer object, `false` for entities including characters with players.
  /// </summary>
  [FactorioRconMethod("is_player")]
  public bool IsPlayer() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Open the technology GUI and select a given technology.
  /// </summary>
  /// <param name="technology">Lua name: technology</param>
  [FactorioRconMethod("open_technology_gui")]
  public void OpenTechnologyGui(TechnologyIdentification? technology = null) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Sets a personal logistic request and auto-trash slot to the given value.
  /// </summary>
  /// <remarks>
  /// This will silently fail if personal logistics are not researched yet.
  /// </remarks>
  /// <param name="slotIndex">Lua name: slot_index</param>
  /// <param name="value">Lua name: value</param>
  [FactorioRconMethod("set_personal_logistic_slot")]
  public bool SetPersonalLogisticSlot(uint slotIndex, LogisticParameters value) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Sets a vehicle logistic request and auto-trash slot to the given value. Only used on `spider-vehicle`.
  /// </summary>
  /// <param name="slotIndex">Lua name: slot_index</param>
  /// <param name="value">Lua name: value</param>
  [FactorioRconMethod("set_vehicle_logistic_slot")]
  public bool SetVehicleLogisticSlot(uint slotIndex, LogisticParameters value) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Gets the parameters of a personal logistic request and auto-trash slot.
  /// </summary>
  /// <param name="slotIndex">Lua name: slot_index</param>
  [FactorioRconMethod("get_personal_logistic_slot")]
  public LogisticParameters GetPersonalLogisticSlot(uint slotIndex) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Gets the parameters of a vehicle logistic request and auto-trash slot. Only used on `spider-vehicle`.
  /// </summary>
  /// <param name="slotIndex">Lua name: slot_index</param>
  [FactorioRconMethod("get_vehicle_logistic_slot")]
  public LogisticParameters GetVehicleLogisticSlot(uint slotIndex) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <remarks>
  /// This will silently fail if personal logistics are not researched yet.
  /// </remarks>
  /// <param name="slotIndex">Lua name: slot_index</param>
  [FactorioRconMethod("clear_personal_logistic_slot")]
  public void ClearPersonalLogisticSlot(uint slotIndex) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <remarks>
  /// This will silently fail if the vehicle does not use logistics.
  /// </remarks>
  /// <param name="slotIndex">Lua name: slot_index</param>
  [FactorioRconMethod("clear_vehicle_logistic_slot")]
  public void ClearVehicleLogisticSlot(uint slotIndex) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Returns whether the player is holding a blueprint. This takes both blueprint items as well as blueprint records from the blueprint library into account.
  /// 
  /// Note that both this method and <see cref="LuaControl.GetBlueprintEntities" /> refer to the currently selected blueprint, meaning a blueprint book with a selected blueprint will return the information as well.
  /// </summary>
  [FactorioRconMethod("is_cursor_blueprint")]
  public bool IsCursorBlueprint() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Gets the entities that are part of the currently selected blueprint, regardless of it being in a blueprint book or picked from the blueprint library.
  /// </summary>
  [FactorioRconMethod("get_blueprint_entities")]
  public BlueprintEntity[]? GetBlueprintEntities() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Returns whether the player is holding something in the cursor. It takes into account items from the blueprint library, as well as items and ghost cursor.
  /// </summary>
  [FactorioRconMethod("is_cursor_empty")]
  public bool IsCursorEmpty() => throw FactorioModelUtils.UseClientReadAsyncMethod();

}

public class Table5773521
{
}

public class Table54135081
{
}

public class Table63094882
{
}

public class Table49924125
{
}

