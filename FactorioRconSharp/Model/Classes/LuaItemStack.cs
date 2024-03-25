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
/// A reference to an item and count owned by some external entity.
/// </summary>
[FactorioRconClass("LuaItemStack")]
public class LuaItemStack
{
  /// <summary>
  /// Is this valid for reading? Differs from the usual `valid` in that `valid` will be `true` even if the item stack is blank but the entity that holds it is still valid.
  /// </summary>
  [FactorioRconAttribute("valid_for_read")]
  public bool ValidForRead { get; private set; }

  /// <summary>
  /// Prototype of the item held in this stack.
  /// </summary>
  [FactorioRconAttribute("prototype")]
  public LuaItemPrototype Prototype { get; private set; }

  /// <summary>
  /// Prototype name of the item held in this stack.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// Type of the item prototype.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; private set; }

  /// <summary>
  /// Number of items in this stack.
  /// </summary>
  [FactorioRconAttribute("count")]
  public uint Count { get; set; }

  /// <summary>
  /// The equipment grid of this item, if any.
  /// </summary>
  [FactorioRconAttribute("grid")]
  public LuaEquipmentGrid Grid { get; private set; }

  /// <summary>
  /// How much health the item has, as a number in range [0, 1].
  /// </summary>
  [FactorioRconAttribute("health")]
  public float Health { get; set; }

  /// <summary>
  /// Durability of the contained item. Automatically capped at the item's maximum durability.
  /// </summary>
  [FactorioRconAttribute("durability")]
  public double Durability { get; set; }

  /// <summary>
  /// Number of bullets left in the magazine.
  /// </summary>
  [FactorioRconAttribute("ammo")]
  public uint Ammo { get; set; }

  /// <summary>
  /// Icons of this blueprint item, blueprint book, deconstruction item or upgrade planner. An item that doesn't have icons returns `nil` on read and throws error on write.
  /// </summary>
  [FactorioRconAttribute("blueprint_icons")]
  public BlueprintSignalIcon[] BlueprintIcons { get; set; }

  /// <summary>
  /// The snapping grid size in this blueprint item. `nil` if snapping is not enabled.
  /// </summary>
  [FactorioRconAttribute("blueprint_snap_to_grid")]
  public TilePosition BlueprintSnapToGrid { get; set; }

  /// <summary>
  /// The offset from the absolute grid. `nil` if absolute snapping is not enabled.
  /// </summary>
  [FactorioRconAttribute("blueprint_position_relative_to_grid")]
  public TilePosition BlueprintPositionRelativeToGrid { get; set; }

  /// <summary>
  /// If absolute snapping is enabled on this blueprint item.
  /// </summary>
  [FactorioRconAttribute("blueprint_absolute_snapping")]
  public bool BlueprintAbsoluteSnapping { get; set; }

  /// <summary>
  /// The current label for this item, if any.
  /// </summary>
  [FactorioRconAttribute("label")]
  public string Label { get; set; }

  /// <summary>
  /// The current label color for this item, if any.
  /// </summary>
  [FactorioRconAttribute("label_color")]
  public Color LabelColor { get; set; }

  /// <summary>
  /// Whether the label for this item can be manually changed. When false the label can only be changed through the API.
  /// </summary>
  [FactorioRconAttribute("allow_manual_label_change")]
  public bool AllowManualLabelChange { get; set; }

  /// <summary>
  /// Raw materials required to build this blueprint. Result is a dictionary mapping each item prototype name to the required count.
  /// </summary>
  [FactorioRconAttribute("cost_to_build")]
  public Dictionary<string, uint> CostToBuild { get; private set; }

  /// <summary>
  /// If this item extends the inventory it resides in (provides its contents for counts, crafting, insertion). Only callable on items with inventories.
  /// </summary>
  [FactorioRconAttribute("extends_inventory")]
  public bool ExtendsInventory { get; set; }

  /// <summary>
  /// The insertion mode priority this ItemWithInventory uses when items are inserted into an inventory it resides in. Only callable on items with inventories.
  /// </summary>
  [FactorioRconAttribute("prioritize_insertion_mode")]
  public OneOf<Literal22550079, Literal3789628, Literal12473332, Literal60613391> PrioritizeInsertionMode { get; set; }

  /// <summary>
  /// The default icons for a blueprint item.
  /// </summary>
  [FactorioRconAttribute("default_icons")]
  public BlueprintSignalIcon[] DefaultIcons { get; private set; }

  [FactorioRconAttribute("tags")]
  public Tags Tags { get; set; }

  /// <summary>
  /// The custom description this item-with-tags. This is shown over the normal item description if this is set to a non-empty value.
  /// </summary>
  [FactorioRconAttribute("custom_description")]
  public LocalisedString CustomDescription { get; set; }

  /// <summary>
  /// The entity filters for this deconstruction item. The attribute is a sparse array with the keys representing the index of the filter. All strings in this array must be entity prototype names that don't have the `"not-deconstructable"` flag set and are either a `cliff` or marked as `minable`.
  /// </summary>
  [FactorioRconAttribute("entity_filters")]
  public string[] EntityFilters { get; set; }

  /// <summary>
  /// The tile filters for this deconstruction item. The attribute is a sparse array with the keys representing the index of the filter. All strings in this array must be tile prototype names.
  /// </summary>
  [FactorioRconAttribute("tile_filters")]
  public string[] TileFilters { get; set; }

  /// <summary>
  /// The blacklist/whitelist entity filter mode for this deconstruction item.
  /// </summary>
  [FactorioRconAttribute("entity_filter_mode")]
  public DeconstructionItemEntityFilterModeEnum EntityFilterMode { get; set; }

  /// <summary>
  /// The blacklist/whitelist tile filter mode for this deconstruction item.
  /// </summary>
  [FactorioRconAttribute("tile_filter_mode")]
  public DeconstructionItemTileFilterModeEnum TileFilterMode { get; set; }

  /// <summary>
  /// The tile selection mode for this deconstruction item.
  /// </summary>
  [FactorioRconAttribute("tile_selection_mode")]
  public DeconstructionItemTileSelectionModeEnum TileSelectionMode { get; set; }

  /// <summary>
  /// If this deconstruction item is set to allow trees and rocks only.
  /// </summary>
  [FactorioRconAttribute("trees_and_rocks_only")]
  public bool TreesAndRocksOnly { get; set; }

  /// <summary>
  /// The number of entity filters this deconstruction item supports.
  /// </summary>
  [FactorioRconAttribute("entity_filter_count")]
  public uint EntityFilterCount { get; private set; }

  /// <summary>
  /// The number of tile filters this deconstruction item supports.
  /// </summary>
  [FactorioRconAttribute("tile_filter_count")]
  public uint TileFilterCount { get; private set; }

  /// <summary>
  /// The active blueprint index for this blueprint book. `nil` if this blueprint book is empty.
  /// </summary>
  [FactorioRconAttribute("active_index")]
  public uint ActiveIndex { get; set; }

  /// <summary>
  /// The unique identifier for this item , if any. Note that this ID stays the same no matter where the item is moved to.
  /// 
  /// Only these types of items have unique IDs:
  /// - `"armor"`
  /// - `"spidertron-remote"`
  /// - `"selection-tool"`
  /// - `"copy-paste-tool"`
  /// - `"upgrade-item"`
  /// - `"deconstruction-item"`
  /// - `"blueprint"`
  /// - `"blueprint-book"`
  /// - `"item-with-entity-data"`
  /// - `"item-with-inventory"`
  /// - `"item-with-tags"`
  /// </summary>
  [FactorioRconAttribute("item_number")]
  public uint ItemNumber { get; private set; }

  /// <summary>
  /// If this item is a spidertron remote that has a spidertron bound to it, it returns the connected spider-vehicle entity.
  /// </summary>
  [FactorioRconAttribute("connected_entity")]
  public LuaEntity ConnectedEntity { get; set; }

  /// <summary>
  /// If this is an item with entity data, get the stored entity label.
  /// </summary>
  [FactorioRconAttribute("entity_label")]
  public string EntityLabel { get; set; }

  /// <summary>
  /// If this is an item with entity data, get the stored entity color.
  /// </summary>
  [FactorioRconAttribute("entity_color")]
  public Color EntityColor { get; set; }

  /// <summary>
  /// If this is a blueprint item.
  /// </summary>
  [FactorioRconAttribute("is_blueprint")]
  public bool IsBlueprint { get; private set; }

  /// <summary>
  /// If this is a blueprint book item.
  /// </summary>
  [FactorioRconAttribute("is_blueprint_book")]
  public bool IsBlueprintBook { get; private set; }

  /// <summary>
  /// If this is a module item.
  /// </summary>
  [FactorioRconAttribute("is_module")]
  public bool IsModule { get; private set; }

  /// <summary>
  /// If this is a tool item.
  /// </summary>
  [FactorioRconAttribute("is_tool")]
  public bool IsTool { get; private set; }

  /// <summary>
  /// If this is a mining tool item.
  /// </summary>
  [FactorioRconAttribute("is_mining_tool")]
  public bool IsMiningTool { get; private set; }

  /// <summary>
  /// If this is an armor item.
  /// </summary>
  [FactorioRconAttribute("is_armor")]
  public bool IsArmor { get; private set; }

  /// <summary>
  /// If this is a repair tool item.
  /// </summary>
  [FactorioRconAttribute("is_repair_tool")]
  public bool IsRepairTool { get; private set; }

  /// <summary>
  /// If this is an item with label item.
  /// </summary>
  [FactorioRconAttribute("is_item_with_label")]
  public bool IsItemWithLabel { get; private set; }

  /// <summary>
  /// If this is an item with inventory item.
  /// </summary>
  [FactorioRconAttribute("is_item_with_inventory")]
  public bool IsItemWithInventory { get; private set; }

  /// <summary>
  /// If this is an item with entity data item.
  /// </summary>
  [FactorioRconAttribute("is_item_with_entity_data")]
  public bool IsItemWithEntityData { get; private set; }

  /// <summary>
  /// If this is a selection tool item.
  /// </summary>
  [FactorioRconAttribute("is_selection_tool")]
  public bool IsSelectionTool { get; private set; }

  /// <summary>
  /// If this is an item with tags item.
  /// </summary>
  [FactorioRconAttribute("is_item_with_tags")]
  public bool IsItemWithTags { get; private set; }

  /// <summary>
  /// If this is a deconstruction tool item.
  /// </summary>
  [FactorioRconAttribute("is_deconstruction_item")]
  public bool IsDeconstructionItem { get; private set; }

  /// <summary>
  /// If this is a upgrade item.
  /// </summary>
  [FactorioRconAttribute("is_upgrade_item")]
  public bool IsUpgradeItem { get; private set; }

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
  /// Is this blueprint item setup? I.e. is it a non-empty blueprint?
  /// </summary>
  [FactorioRconMethod("is_blueprint_setup")]
  public bool IsBlueprintSetup() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// The entities in this blueprint.
  /// </summary>
  [FactorioRconMethod("get_blueprint_entities")]
  public BlueprintEntity[]? GetBlueprintEntities() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set new entities to be a part of this blueprint.
  /// </summary>
  /// <param name="entities">Lua name: entities</param>
  [FactorioRconMethod("set_blueprint_entities")]
  public void SetBlueprintEntities(BlueprintEntity[] entities) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Add ammo to this ammo item.
  /// </summary>
  /// <param name="amount">Lua name: amount</param>
  [FactorioRconMethod("add_ammo")]
  public void AddAmmo(float amount) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Remove ammo from this ammo item.
  /// </summary>
  /// <param name="amount">Lua name: amount</param>
  [FactorioRconMethod("drain_ammo")]
  public void DrainAmmo(float amount) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Add durability to this tool item.
  /// </summary>
  /// <param name="amount">Lua name: amount</param>
  [FactorioRconMethod("add_durability")]
  public void AddDurability(double amount) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Remove durability from this tool item.
  /// </summary>
  /// <param name="amount">Lua name: amount</param>
  [FactorioRconMethod("drain_durability")]
  public void DrainDurability(double amount) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Use the capsule item with the entity as the source, targeting the given position.
  /// </summary>
  /// <param name="entity">Lua name: entity</param>
  /// <param name="targetPosition">Lua name: target_position</param>
  [FactorioRconMethod("use_capsule")]
  public LuaEntity[] UseCapsule(LuaEntity entity, MapPosition targetPosition) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Would a call to <see cref="LuaItemStack.SetStack" /> succeed?
  /// </summary>
  /// <param name="stack">Lua name: stack</param>
  [FactorioRconMethod("can_set_stack")]
  public bool CanSetStack(ItemStackIdentification? stack = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set this item stack to another item stack.
  /// </summary>
  /// <param name="stack">Lua name: stack</param>
  [FactorioRconMethod("set_stack")]
  public bool SetStack(ItemStackIdentification? stack = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Transfers the given item stack into this item stack.
  /// </summary>
  /// <param name="stack">Lua name: stack</param>
  [FactorioRconMethod("transfer_stack")]
  public bool TransferStack(ItemStackIdentification stack) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Export a supported item (blueprint, blueprint-book, deconstruction-planner, upgrade-planner, item-with-tags) to a string.
  /// </summary>
  [FactorioRconMethod("export_stack")]
  public string ExportStack() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Import a supported item (blueprint, blueprint-book, deconstruction-planner, upgrade-planner, item-with-tags) from a string.
  /// </summary>
  /// <param name="data">Lua name: data</param>
  [FactorioRconMethod("import_stack")]
  public int ImportStack(string data) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Swaps this item stack with the given item stack if allowed.
  /// </summary>
  /// <param name="stack">Lua name: stack</param>
  [FactorioRconMethod("swap_stack")]
  public bool SwapStack(LuaItemStack stack) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Clear this item stack.
  /// </summary>
  [FactorioRconMethod("clear")]
  public void Clear() => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// A list of the tiles in this blueprint.
  /// </summary>
  [FactorioRconMethod("get_blueprint_tiles")]
  public Tile[]? GetBlueprintTiles() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Set specific tiles in this blueprint.
  /// </summary>
  /// <param name="tiles">Lua name: tiles</param>
  [FactorioRconMethod("set_blueprint_tiles")]
  public void SetBlueprintTiles(Tile[] tiles) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Access the inner inventory of an item.
  /// </summary>
  /// <param name="inventory">Lua name: inventory</param>
  [FactorioRconMethod("get_inventory")]
  public LuaInventory? GetInventory(InventoryEnum inventory) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <remarks>
  /// Built entities can be come invalid between the building of the blueprint and the function returning if by_player or raise_built is used and one of those events invalidates the entity.
  /// </remarks>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="forceBuild">Lua name: force_build</param>
  /// <param name="direction">Lua name: direction</param>
  /// <param name="skipFogOfWar">Lua name: skip_fog_of_war</param>
  /// <param name="byPlayer">Lua name: by_player</param>
  /// <param name="raiseBuilt">Lua name: raise_built</param>
  [FactorioRconMethod("build_blueprint")]
  public LuaEntity[] BuildBlueprint(SurfaceIdentification surface, ForceIdentification force, MapPosition position, bool? forceBuild = null, DirectionEnum? direction = null, bool? skipFogOfWar = null, PlayerIdentification? byPlayer = null, bool? raiseBuilt = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Deconstruct the given area with this deconstruction item.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="area">Lua name: area</param>
  /// <param name="skipFogOfWar">Lua name: skip_fog_of_war</param>
  /// <param name="byPlayer">Lua name: by_player</param>
  [FactorioRconMethod("deconstruct_area")]
  public void DeconstructArea(SurfaceIdentification surface, ForceIdentification force, BoundingBox area, bool? skipFogOfWar = null, PlayerIdentification? byPlayer = null) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Cancel deconstruct the given area with this deconstruction item.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="area">Lua name: area</param>
  /// <param name="skipFogOfWar">Lua name: skip_fog_of_war</param>
  /// <param name="byPlayer">Lua name: by_player</param>
  [FactorioRconMethod("cancel_deconstruct_area")]
  public void CancelDeconstructArea(SurfaceIdentification surface, ForceIdentification force, BoundingBox area, bool? skipFogOfWar = null, PlayerIdentification? byPlayer = null) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Sets up this blueprint using the found blueprintable entities/tiles on the surface.
  /// </summary>
  /// <param name="surface">Lua name: surface</param>
  /// <param name="force">Lua name: force</param>
  /// <param name="area">Lua name: area</param>
  /// <param name="alwaysIncludeTiles">Lua name: always_include_tiles</param>
  /// <param name="includeEntities">Lua name: include_entities</param>
  /// <param name="includeModules">Lua name: include_modules</param>
  /// <param name="includeStationNames">Lua name: include_station_names</param>
  /// <param name="includeTrains">Lua name: include_trains</param>
  /// <param name="includeFuel">Lua name: include_fuel</param>
  [FactorioRconMethod("create_blueprint")]
  public Dictionary<uint, LuaEntity> CreateBlueprint(SurfaceIdentification surface, ForceIdentification force, BoundingBox area, bool? alwaysIncludeTiles = null, bool? includeEntities = null, bool? includeModules = null, bool? includeStationNames = null, bool? includeTrains = null, bool? includeFuel = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Gets the tag with the given name or returns `nil` if it doesn't exist.
  /// </summary>
  /// <param name="tagName">Lua name: tag_name</param>
  [FactorioRconMethod("get_tag")]
  public AnyBasic? GetTag(string tagName) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Sets the tag with the given name and value.
  /// </summary>
  /// <param name="tagName">Lua name: tag_name</param>
  /// <param name="tag">Lua name: tag</param>
  [FactorioRconMethod("set_tag")]
  public void SetTag(string tagName, AnyBasic tag) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Removes a tag with the given name.
  /// </summary>
  /// <param name="tag">Lua name: tag</param>
  [FactorioRconMethod("remove_tag")]
  public bool RemoveTag(string tag) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Clears this blueprint item.
  /// </summary>
  [FactorioRconMethod("clear_blueprint")]
  public void ClearBlueprint() => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Gets the entity filter at the given index for this deconstruction item.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_entity_filter")]
  public string? GetEntityFilter(uint index) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Sets the entity filter at the given index for this deconstruction item.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("set_entity_filter")]
  public bool SetEntityFilter(uint index, OneOf<string, LuaEntityPrototype, LuaEntity, LuaNil> filter) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Gets the tile filter at the given index for this deconstruction item.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_tile_filter")]
  public string? GetTileFilter(uint index) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Sets the tile filter at the given index for this deconstruction item.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("set_tile_filter")]
  public bool SetTileFilter(uint index, OneOf<string, LuaTilePrototype, LuaTile, LuaNil> filter) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Clears all settings/filters on this deconstruction item resetting it to default values.
  /// </summary>
  [FactorioRconMethod("clear_deconstruction_item")]
  public void ClearDeconstructionItem() => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Clears all settings/filters on this upgrade item resetting it to default values.
  /// </summary>
  [FactorioRconMethod("clear_upgrade_item")]
  public void ClearUpgradeItem() => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Gets the filter at the given index for this upgrade item.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="type">Lua name: type</param>
  [FactorioRconMethod("get_mapper")]
  public UpgradeFilter GetMapper(uint index, OneOf<Literal64921669, Literal21177779> type) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Sets the module filter at the given index for this upgrade item.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="type">Lua name: type</param>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("set_mapper")]
  public void SetMapper(uint index, OneOf<Literal42080192, Literal11268815> type, OneOf<UpgradeFilter, LuaNil> filter) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Gets the number of entities in this blueprint item.
  /// </summary>
  [FactorioRconMethod("get_blueprint_entity_count")]
  public uint GetBlueprintEntityCount() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Gets the tags for the given blueprint entity index in this blueprint item.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_blueprint_entity_tags")]
  public Tags GetBlueprintEntityTags(uint index) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Sets the tags on the given blueprint entity index in this blueprint item.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="tags">Lua name: tags</param>
  [FactorioRconMethod("set_blueprint_entity_tags")]
  public void SetBlueprintEntityTags(uint index, Tags tags) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Gets the given tag on the given blueprint entity index in this blueprint item.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="tag">Lua name: tag</param>
  [FactorioRconMethod("get_blueprint_entity_tag")]
  public AnyBasic? GetBlueprintEntityTag(uint index, string tag) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Sets the given tag on the given blueprint entity index in this blueprint item.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="tag">Lua name: tag</param>
  /// <param name="value">Lua name: value</param>
  [FactorioRconMethod("set_blueprint_entity_tag")]
  public void SetBlueprintEntityTag(uint index, string tag, AnyBasic value) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

  /// <summary>
  /// Creates the equipment grid for this item if it doesn't exist and this is an item-with-entity-data that supports equipment grids.
  /// </summary>
  [FactorioRconMethod("create_grid")]
  public LuaEquipmentGrid CreateGrid() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public string Help() => throw FactorioModelUtils.UseClientReadAsyncMethod();

}

/// <summary>
/// Literal value: default
/// </summary>
public class Literal22550079
{
  /// <summary>
  /// Literal value: default
  /// </summary>
  [FactorioRconAttribute("default")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: never
/// </summary>
public class Literal3789628
{
  /// <summary>
  /// Literal value: never
  /// </summary>
  [FactorioRconAttribute("never")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: always
/// </summary>
public class Literal12473332
{
  /// <summary>
  /// Literal value: always
  /// </summary>
  [FactorioRconAttribute("always")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: when-manually-filtered
/// </summary>
public class Literal60613391
{
  /// <summary>
  /// Literal value: when-manually-filtered
  /// </summary>
  [FactorioRconAttribute("when-manually-filtered")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: from
/// </summary>
public class Literal64921669
{
  /// <summary>
  /// Literal value: from
  /// </summary>
  [FactorioRconAttribute("from")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: to
/// </summary>
public class Literal21177779
{
  /// <summary>
  /// Literal value: to
  /// </summary>
  [FactorioRconAttribute("to")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: from
/// </summary>
public class Literal42080192
{
  /// <summary>
  /// Literal value: from
  /// </summary>
  [FactorioRconAttribute("from")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: to
/// </summary>
public class Literal11268815
{
  /// <summary>
  /// Literal value: to
  /// </summary>
  [FactorioRconAttribute("to")]
  public static object Value { get; private set; }

}

