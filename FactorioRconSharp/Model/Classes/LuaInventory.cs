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
/// A storage of item stacks.
/// </summary>
[FactorioRconClass("LuaInventory")]
public abstract class LuaInventory: LuaObject
{
  /// <summary>
  /// The inventory index this inventory uses, if any.
  /// </summary>
  [FactorioRconAttribute("index")]
  public InventoryEnum Index { get; private set; }

  /// <summary>
  /// The entity that owns this inventory, if any.
  /// </summary>
  [FactorioRconAttribute("entity_owner")]
  public LuaEntity EntityOwner { get; private set; }

  /// <summary>
  /// The player that owns this inventory, if any.
  /// </summary>
  [FactorioRconAttribute("player_owner")]
  public LuaPlayer PlayerOwner { get; private set; }

  /// <summary>
  /// The equipment that owns this inventory, if any.
  /// </summary>
  [FactorioRconAttribute("equipment_owner")]
  public LuaEquipment EquipmentOwner { get; private set; }

  /// <summary>
  /// The mod that owns this inventory, if any.
  /// </summary>
  [FactorioRconAttribute("mod_owner")]
  public string ModOwner { get; private set; }

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
  /// Get the number of slots in this inventory.
  /// </summary>
  [FactorioRconAttribute("length")]
  public uint Length { get; private set; }

  /// <summary>
  /// The indexing operator.
  /// </summary>
  public abstract LuaItemStack this[uint key] { get; }

  /// <summary>
  /// Make this inventory empty.
  /// </summary>
  [FactorioRconMethod("clear")]
  public abstract void Clear();

  /// <summary>
  /// Can at least some items be inserted?
  /// </summary>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("can_insert")]
  public abstract bool CanInsert(ItemStackIdentification items);

  /// <summary>
  /// Insert items into this inventory.
  /// </summary>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("insert")]
  public abstract uint Insert(ItemStackIdentification items);

  /// <summary>
  /// Remove items from this inventory.
  /// </summary>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("remove")]
  public abstract uint Remove(ItemStackIdentification items);

  /// <summary>
  /// Get the number of all or some items in this inventory.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_item_count")]
  public abstract uint GetItemCount(string? item = null);

  /// <summary>
  /// Does this inventory contain nothing?
  /// </summary>
  [FactorioRconMethod("is_empty")]
  public abstract bool IsEmpty();

  /// <summary>
  /// Is every stack in this inventory full? Ignores stacks blocked by the current bar.
  /// </summary>
  [FactorioRconMethod("is_full")]
  public abstract bool IsFull();

  /// <summary>
  /// Get counts of all items in this inventory.
  /// </summary>
  [FactorioRconMethod("get_contents")]
  public abstract Dictionary<string, uint> GetContents();

  /// <summary>
  /// Does this inventory support a bar? Bar is the draggable red thing, found for example on chests, that limits the portion of the inventory that may be manipulated by machines.
  /// </summary>
  /// <remarks>
  /// "Supporting a bar" doesn't mean that the bar is set to some nontrivial value. Supporting a bar means the inventory supports having this limit at all. The character's inventory is an example of an inventory without a bar; the wooden chest's inventory is an example of one with a bar.
  /// </remarks>
  [FactorioRconMethod("supports_bar")]
  public abstract bool SupportsBar();

  /// <summary>
  /// Get the current bar. This is the index at which the red area starts.
  /// </summary>
  /// <remarks>
  /// Only useable if this inventory supports having a bar.
  /// </remarks>
  [FactorioRconMethod("get_bar")]
  public abstract uint GetBar();

  /// <summary>
  /// Set the current bar.
  /// </summary>
  /// <remarks>
  /// Only useable if this inventory supports having a bar.
  /// </remarks>
  /// <param name="bar">Lua name: bar</param>
  [FactorioRconMethod("set_bar")]
  public abstract void SetBar(uint? bar = null);

  /// <summary>
  /// If this inventory supports filters.
  /// </summary>
  [FactorioRconMethod("supports_filters")]
  public abstract bool SupportsFilters();

  /// <summary>
  /// If this inventory supports filters and has at least 1 filter set.
  /// </summary>
  [FactorioRconMethod("is_filtered")]
  public abstract bool IsFiltered();

  /// <summary>
  /// If the given inventory slot filter can be set to the given filter.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("can_set_filter")]
  public abstract bool CanSetFilter(uint index, string filter);

  /// <summary>
  /// Gets the filter for the given item stack index.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_filter")]
  public abstract string? GetFilter(uint index);

  /// <summary>
  /// Sets the filter for the given item stack index.
  /// </summary>
  /// <remarks>
  /// Some inventory slots don't allow some filters (gun ammo can't be filtered for non-ammo).
  /// </remarks>
  /// <param name="index">Lua name: index</param>
  /// <param name="filter">Lua name: filter</param>
  [FactorioRconMethod("set_filter")]
  public abstract bool SetFilter(uint index, Union49924125 filter);

  /// <summary>
  /// Finds the first LuaItemStack in the inventory that matches the given item name.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("find_item_stack")]
  public abstract (LuaItemStack?, uint?) FindItemStack(string item);

  /// <summary>
  /// Finds the first empty stack. Filtered slots are excluded unless a filter item is given.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("find_empty_stack")]
  public abstract (LuaItemStack?, uint?) FindEmptyStack(string? item = null);

  /// <summary>
  /// Counts the number of empty stacks.
  /// </summary>
  /// <param name="includeFiltered">Lua name: include_filtered</param>
  /// <param name="includeBar">Lua name: include_bar</param>
  [FactorioRconMethod("count_empty_stacks")]
  public abstract uint CountEmptyStacks(bool? includeFiltered = null, bool? includeBar = null);

  /// <summary>
  /// Gets the number of the given item that can be inserted into this inventory.
  /// </summary>
  /// <remarks>
  /// This is a "best guess" number; things like assembling machine filtered slots, module slots, items with durability, and items with mixed health will cause the result to be inaccurate.
  /// The main use for this is in checking how many of a basic item can fit into a basic inventory.
  /// This accounts for the 'bar' on the inventory.
  /// </remarks>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_insertable_count")]
  public abstract uint GetInsertableCount(string item);

  /// <summary>
  /// Sorts and merges the items in this inventory.
  /// </summary>
  [FactorioRconMethod("sort_and_merge")]
  public abstract void SortAndMerge();

  /// <summary>
  /// Resizes the inventory.
  /// </summary>
  /// <remarks>
  /// Items in slots beyond the new capacity are deleted.
  /// Only inventories created by <see cref="LuaGameScript.CreateInventory" /> can be resized.
  /// </remarks>
  /// <param name="size">Lua name: size</param>
  [FactorioRconMethod("resize")]
  public abstract void Resize(ushort size);

  /// <summary>
  /// Destroys this inventory.
  /// </summary>
  /// <remarks>
  /// Only inventories created by <see cref="LuaGameScript.CreateInventory" /> can be destroyed this way.
  /// </remarks>
  [FactorioRconMethod("destroy")]
  public abstract void Destroy();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

[GenerateOneOf]
public abstract partial class Union49924125: OneOfBase<string, LuaNil>
{
}

