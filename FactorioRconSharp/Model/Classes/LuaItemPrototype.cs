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
/// Prototype of an item.
/// </summary>
/// <examples>
/// ```
/// game.item_prototypes["iron-plate"]
/// ```
/// </examples>
[FactorioRconClass("LuaItemPrototype")]
public abstract class LuaItemPrototype: LuaObject
{
  /// <summary>
  /// Type of this prototype. E.g. `"gun"` or `"mining-tool"`.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; private set; }

  /// <summary>
  /// Name of this prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  [FactorioRconAttribute("localised_name")]
  public LocalisedString LocalisedName { get; private set; }

  [FactorioRconAttribute("localised_description")]
  public LocalisedString LocalisedDescription { get; private set; }

  /// <summary>
  /// The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
  public string Order { get; private set; }

  /// <summary>
  /// Prototype of the entity that will be created by placing this item, if any.
  /// </summary>
  [FactorioRconAttribute("place_result")]
  public LuaEntityPrototype PlaceResult { get; private set; }

  /// <summary>
  /// Prototype of the equipment that will be created by placing this item in an equipment grid, if any.
  /// </summary>
  [FactorioRconAttribute("place_as_equipment_result")]
  public LuaEquipmentPrototype PlaceAsEquipmentResult { get; private set; }

  /// <summary>
  /// The place-as-tile result if one is defined, if any.
  /// </summary>
  [FactorioRconAttribute("place_as_tile_result")]
  public PlaceAsTileResult PlaceAsTileResult { get; private set; }

  /// <summary>
  /// Is this item allowed to stack at all?
  /// </summary>
  [FactorioRconAttribute("stackable")]
  public bool Stackable { get; private set; }

  /// <summary>
  /// The default request value.
  /// </summary>
  [FactorioRconAttribute("default_request_amount")]
  public uint DefaultRequestAmount { get; private set; }

  /// <summary>
  /// Maximum stack size of the item specified by this prototype.
  /// </summary>
  [FactorioRconAttribute("stack_size")]
  public uint StackSize { get; private set; }

  /// <summary>
  /// The number of items needed to connect two entities with this as wire.
  /// </summary>
  [FactorioRconAttribute("wire_count")]
  public uint WireCount { get; private set; }

  /// <summary>
  /// The fuel category of this item prototype, if any.
  /// </summary>
  [FactorioRconAttribute("fuel_category")]
  public string FuelCategory { get; private set; }

  /// <summary>
  /// The result of burning this item as fuel, if any.
  /// </summary>
  [FactorioRconAttribute("burnt_result")]
  public LuaItemPrototype BurntResult { get; private set; }

  /// <summary>
  /// Fuel value when burned.
  /// </summary>
  [FactorioRconAttribute("fuel_value")]
  public float FuelValue { get; private set; }

  /// <summary>
  /// The acceleration multiplier when this item is used as fuel in a vehicle.
  /// </summary>
  [FactorioRconAttribute("fuel_acceleration_multiplier")]
  public double FuelAccelerationMultiplier { get; private set; }

  /// <summary>
  /// The fuel top speed multiplier when this item is used as fuel in a vehicle.
  /// </summary>
  [FactorioRconAttribute("fuel_top_speed_multiplier")]
  public double FuelTopSpeedMultiplier { get; private set; }

  /// <summary>
  /// The emissions multiplier if this is used as fuel.
  /// </summary>
  [FactorioRconAttribute("fuel_emissions_multiplier")]
  public double FuelEmissionsMultiplier { get; private set; }

  /// <summary>
  /// The subgroup this prototype belongs to.
  /// </summary>
  [FactorioRconAttribute("subgroup")]
  public LuaGroup Subgroup { get; private set; }

  /// <summary>
  /// The group this prototype belongs to.
  /// </summary>
  [FactorioRconAttribute("group")]
  public LuaGroup Group { get; private set; }

  /// <summary>
  /// The flags for this item prototype.
  /// </summary>
  [FactorioRconAttribute("flags")]
  public ItemPrototypeFlags Flags { get; private set; }

  /// <summary>
  /// The results of launching this item in a rocket.
  /// </summary>
  [FactorioRconAttribute("rocket_launch_products")]
  public List<Product> RocketLaunchProducts { get; private set; }

  /// <summary>
  /// If this item can be mod-opened.
  /// </summary>
  [FactorioRconAttribute("can_be_mod_opened")]
  public bool CanBeModOpened { get; private set; }

  /// <summary>
  /// Size of full magazine.
  /// </summary>
  [FactorioRconAttribute("magazine_size")]
  public float MagazineSize { get; private set; }

  /// <summary>
  /// Amount of extra time (in ticks) it takes to reload the weapon after depleting the magazine.
  /// </summary>
  [FactorioRconAttribute("reload_time")]
  public float ReloadTime { get; private set; }

  /// <summary>
  /// The prototype of this armor's equipment grid, if any.
  /// </summary>
  [FactorioRconAttribute("equipment_grid")]
  public LuaEquipmentGridPrototype EquipmentGrid { get; private set; }

  /// <summary>
  /// Resistances of this armor item, if any, indexed by damage type name.
  /// </summary>
  [FactorioRconAttribute("resistances")]
  public Dictionary<string, Resistance> Resistances { get; private set; }

  /// <summary>
  /// The inventory size bonus for this armor prototype.
  /// </summary>
  [FactorioRconAttribute("inventory_size_bonus")]
  public uint InventorySizeBonus { get; private set; }

  /// <summary>
  /// The capsule action for this capsule item prototype.
  /// </summary>
  [FactorioRconAttribute("capsule_action")]
  public CapsuleAction CapsuleAction { get; private set; }

  /// <summary>
  /// The gun attack parameters.
  /// </summary>
  [FactorioRconAttribute("attack_parameters")]
  public AttackParameters AttackParameters { get; private set; }

  /// <summary>
  /// The main inventory size for item-with-inventory-prototype.
  /// </summary>
  [FactorioRconAttribute("inventory_size")]
  public uint InventorySize { get; private set; }

  [FactorioRconAttribute("item_filters")]
  public Dictionary<string, LuaItemPrototype> ItemFilters { get; private set; }

  [FactorioRconAttribute("item_group_filters")]
  public Dictionary<string, LuaGroup> ItemGroupFilters { get; private set; }

  [FactorioRconAttribute("item_subgroup_filters")]
  public Dictionary<string, LuaGroup> ItemSubgroupFilters { get; private set; }

  /// <summary>
  /// The filter mode used by this item with inventory.
  /// </summary>
  [FactorioRconAttribute("filter_mode")]
  public Literals_596e85fadabc4c7cad4e36d534d2314a FilterMode { get; private set; }

  /// <summary>
  /// The insertion priority mode used by this item with inventory.
  /// </summary>
  [FactorioRconAttribute("insertion_priority_mode")]
  public Literals_bc6101c588104c0c8796e89850b6ef56 InsertionPriorityMode { get; private set; }

  /// <summary>
  /// The localised string used when the player attempts to put items into this item with inventory that aren't allowed.
  /// </summary>
  [FactorioRconAttribute("localised_filter_message")]
  public LocalisedString LocalisedFilterMessage { get; private set; }

  /// <summary>
  /// If this item with inventory extends the inventory it resides in by default.
  /// </summary>
  [FactorioRconAttribute("extend_inventory_by_default")]
  public bool ExtendInventoryByDefault { get; private set; }

  /// <summary>
  /// The default label color used for this item with label, if any.
  /// </summary>
  [FactorioRconAttribute("default_label_color")]
  public Color DefaultLabelColor { get; private set; }

  /// <summary>
  /// If true, and this item with label has a label it is drawn in place of the normal number when held in the cursor.
  /// </summary>
  [FactorioRconAttribute("draw_label_for_cursor_render")]
  public bool DrawLabelForCursorRender { get; private set; }

  /// <summary>
  /// The repairing speed if this is a repairing tool.
  /// </summary>
  [FactorioRconAttribute("speed")]
  public float Speed { get; private set; }

  /// <summary>
  /// Effects of this module.
  /// </summary>
  [FactorioRconAttribute("module_effects")]
  public ModuleEffects ModuleEffects { get; private set; }

  /// <summary>
  /// The name of a <see cref="LuaModuleCategoryPrototype" />. Used when upgrading modules: Ctrl + click modules into an entity and it will replace lower tier modules of the same category with higher tier modules.
  /// </summary>
  [FactorioRconAttribute("category")]
  public string Category { get; private set; }

  /// <summary>
  /// Tier of the module inside its category. Used when upgrading modules: Ctrl + click modules into an entity and it will replace lower tier modules with higher tier modules if they have the same category.
  /// </summary>
  [FactorioRconAttribute("tier")]
  public uint Tier { get; private set; }

  /// <summary>
  /// An array of recipe names this module is allowed to work with. Empty when all recipes are allowed.
  /// </summary>
  [FactorioRconAttribute("limitations")]
  public List<string> Limitations { get; private set; }

  /// <summary>
  /// The limitation message key used when the player attempts to use this modules in some place it's not allowed.
  /// </summary>
  [FactorioRconAttribute("limitation_message_key")]
  public string LimitationMessageKey { get; private set; }

  /// <summary>
  /// The straight rail prototype used for this rail planner prototype.
  /// </summary>
  [FactorioRconAttribute("straight_rail")]
  public LuaEntityPrototype StraightRail { get; private set; }

  /// <summary>
  /// The curved rail prototype used for this rail planner prototype.
  /// </summary>
  [FactorioRconAttribute("curved_rail")]
  public LuaEntityPrototype CurvedRail { get; private set; }

  /// <summary>
  /// The repair result of this repair tool prototype.
  /// </summary>
  [FactorioRconAttribute("repair_result")]
  public List<TriggerItem> RepairResult { get; private set; }

  /// <summary>
  /// The color used when doing normal selection with this selection tool prototype.
  /// </summary>
  [FactorioRconAttribute("selection_border_color")]
  public Color SelectionBorderColor { get; private set; }

  /// <summary>
  /// The color used when doing alt selection with this selection tool prototype.
  /// </summary>
  [FactorioRconAttribute("alt_selection_border_color")]
  public Color AltSelectionBorderColor { get; private set; }

  /// <summary>
  /// The color used when doing reverse selection with this selection tool prototype.
  /// </summary>
  [FactorioRconAttribute("reverse_selection_border_color")]
  public Color ReverseSelectionBorderColor { get; private set; }

  /// <summary>
  /// The color used when doing alt reverse selection with this selection tool prototype.
  /// </summary>
  [FactorioRconAttribute("alt_reverse_selection_border_color")]
  public Color AltReverseSelectionBorderColor { get; private set; }

  /// <summary>
  /// Flags that affect which entities will be selected.
  /// </summary>
  [FactorioRconAttribute("selection_mode_flags")]
  public SelectionModeFlags SelectionModeFlags { get; private set; }

  /// <summary>
  /// Flags that affect which entities will be selected during alternate selection.
  /// </summary>
  [FactorioRconAttribute("alt_selection_mode_flags")]
  public SelectionModeFlags AltSelectionModeFlags { get; private set; }

  /// <summary>
  /// Flags that affect which entities will be selected during reverse selection.
  /// </summary>
  [FactorioRconAttribute("reverse_selection_mode_flags")]
  public SelectionModeFlags ReverseSelectionModeFlags { get; private set; }

  /// <summary>
  /// Flags that affect which entities will be selected during alt reverse selection.
  /// </summary>
  [FactorioRconAttribute("alt_reverse_selection_mode_flags")]
  public SelectionModeFlags AltReverseSelectionModeFlags { get; private set; }

  [FactorioRconAttribute("selection_cursor_box_type")]
  public CursorBoxRenderType SelectionCursorBoxType { get; private set; }

  [FactorioRconAttribute("alt_selection_cursor_box_type")]
  public CursorBoxRenderType AltSelectionCursorBoxType { get; private set; }

  [FactorioRconAttribute("reverse_selection_cursor_box_type")]
  public CursorBoxRenderType ReverseSelectionCursorBoxType { get; private set; }

  [FactorioRconAttribute("alt_reverse_selection_cursor_box_type")]
  public CursorBoxRenderType AltReverseSelectionCursorBoxType { get; private set; }

  /// <summary>
  /// If tiles area always included when doing selection with this selection tool prototype.
  /// </summary>
  [FactorioRconAttribute("always_include_tiles")]
  public bool AlwaysIncludeTiles { get; private set; }

  /// <summary>
  /// The entity filter mode used by this selection tool.
  /// </summary>
  [FactorioRconAttribute("entity_filter_mode")]
  public PrototypeFilterMode EntityFilterMode { get; private set; }

  /// <summary>
  /// The alt entity filter mode used by this selection tool.
  /// </summary>
  [FactorioRconAttribute("alt_entity_filter_mode")]
  public PrototypeFilterMode AltEntityFilterMode { get; private set; }

  /// <summary>
  /// The reverse entity filter mode used by this selection tool.
  /// </summary>
  [FactorioRconAttribute("reverse_alt_entity_filter_mode")]
  public PrototypeFilterMode ReverseAltEntityFilterMode { get; private set; }

  /// <summary>
  /// The alt reverse entity filter mode used by this selection tool.
  /// </summary>
  [FactorioRconAttribute("alt_reverse_alt_entity_filter_mode")]
  public PrototypeFilterMode AltReverseAltEntityFilterMode { get; private set; }

  /// <summary>
  /// The tile filter mode used by this selection tool.
  /// </summary>
  [FactorioRconAttribute("tile_filter_mode")]
  public PrototypeFilterMode TileFilterMode { get; private set; }

  /// <summary>
  /// The alt tile filter mode used by this selection tool.
  /// </summary>
  [FactorioRconAttribute("alt_tile_filter_mode")]
  public PrototypeFilterMode AltTileFilterMode { get; private set; }

  /// <summary>
  /// The reverse tile filter mode used by this selection tool.
  /// </summary>
  [FactorioRconAttribute("reverse_tile_filter_mode")]
  public PrototypeFilterMode ReverseTileFilterMode { get; private set; }

  /// <summary>
  /// The alt reverse tile filter mode used by this selection tool.
  /// </summary>
  [FactorioRconAttribute("alt_reverse_tile_filter_mode")]
  public PrototypeFilterMode AltReverseTileFilterMode { get; private set; }

  /// <summary>
  /// The entity filters used by this selection tool indexed by entity name.
  /// </summary>
  [FactorioRconAttribute("entity_filters")]
  public Dictionary<string, LuaEntityPrototype> EntityFilters { get; private set; }

  /// <summary>
  /// The alt entity filters used by this selection tool indexed by entity name.
  /// </summary>
  [FactorioRconAttribute("alt_entity_filters")]
  public Dictionary<string, LuaEntityPrototype> AltEntityFilters { get; private set; }

  /// <summary>
  /// The reverse entity filters used by this selection tool indexed by entity name.
  /// </summary>
  [FactorioRconAttribute("reverse_entity_filters")]
  public Dictionary<string, LuaEntityPrototype> ReverseEntityFilters { get; private set; }

  /// <summary>
  /// The alt reverse entity filters used by this selection tool indexed by entity name.
  /// </summary>
  [FactorioRconAttribute("alt_reverse_entity_filters")]
  public Dictionary<string, LuaEntityPrototype> AltReverseEntityFilters { get; private set; }

  /// <summary>
  /// The entity type filters used by this selection tool indexed by entity type.
  /// </summary>
  [FactorioRconAttribute("entity_type_filters")]
  public Dictionary<string, bool> EntityTypeFilters { get; private set; }

  /// <summary>
  /// The alt entity type filters used by this selection tool indexed by entity type.
  /// </summary>
  [FactorioRconAttribute("alt_entity_type_filters")]
  public Dictionary<string, bool> AltEntityTypeFilters { get; private set; }

  /// <summary>
  /// The reverse entity type filters used by this selection tool indexed by entity type.
  /// </summary>
  [FactorioRconAttribute("reverse_entity_type_filters")]
  public Dictionary<string, bool> ReverseEntityTypeFilters { get; private set; }

  /// <summary>
  /// The alt reverse entity type filters used by this selection tool indexed by entity type.
  /// </summary>
  [FactorioRconAttribute("alt_reverse_entity_type_filters")]
  public Dictionary<string, bool> AltReverseEntityTypeFilters { get; private set; }

  /// <summary>
  /// The tile filters used by this selection tool indexed by tile name.
  /// </summary>
  [FactorioRconAttribute("tile_filters")]
  public Dictionary<string, LuaTilePrototype> TileFilters { get; private set; }

  /// <summary>
  /// The alt tile filters used by this selection tool indexed by tile name.
  /// </summary>
  [FactorioRconAttribute("alt_tile_filters")]
  public Dictionary<string, LuaTilePrototype> AltTileFilters { get; private set; }

  /// <summary>
  /// The reverse tile filters used by this selection tool indexed by tile name.
  /// </summary>
  [FactorioRconAttribute("reverse_tile_filters")]
  public Dictionary<string, LuaTilePrototype> ReverseTileFilters { get; private set; }

  /// <summary>
  /// The alt reverse tile filters used by this selection tool indexed by tile name.
  /// </summary>
  [FactorioRconAttribute("alt_reverse_tile_filters")]
  public Dictionary<string, LuaTilePrototype> AltReverseTileFilters { get; private set; }

  /// <summary>
  /// The number of entity filters this deconstruction item has.
  /// </summary>
  [FactorioRconAttribute("entity_filter_slots")]
  public uint EntityFilterSlots { get; private set; }

  /// <summary>
  /// The number of tile filters this deconstruction item has.
  /// </summary>
  [FactorioRconAttribute("tile_filter_slots")]
  public uint TileFilterSlots { get; private set; }

  /// <summary>
  /// The durability message key used when displaying the durability of this tool.
  /// </summary>
  [FactorioRconAttribute("durability_description_key")]
  public string DurabilityDescriptionKey { get; private set; }

  /// <summary>
  /// The durability of this tool item.
  /// </summary>
  [FactorioRconAttribute("durability")]
  public double Durability { get; private set; }

  /// <summary>
  /// If this tool item has infinite durability.
  /// </summary>
  [FactorioRconAttribute("infinite")]
  public bool Infinite { get; private set; }

  /// <summary>
  /// How many filters an upgrade item has.
  /// </summary>
  [FactorioRconAttribute("mapper_count")]
  public uint MapperCount { get; private set; }

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
  /// Does this prototype have a flag enabled?
  /// </summary>
  /// <param name="flag">Lua name: flag</param>
  [FactorioRconMethod("has_flag")]
  public abstract bool HasFlag(ItemPrototypeFlag flag);

  /// <summary>
  /// The type of this ammo prototype.
  /// </summary>
  /// <param name="ammoSourceType">Lua name: ammo_source_type</param>
  [FactorioRconMethod("get_ammo_type")]
  public abstract AmmoType? GetAmmoType(Literals_944ef29ba42d4c2ba787fbb056331a14? ammoSourceType = null);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

