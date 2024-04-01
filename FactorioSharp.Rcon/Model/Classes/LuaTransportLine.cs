#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
/// One line on a transport belt.
/// </summary>
[FactorioRconClass("LuaTransportLine")]
public abstract class LuaTransportLine: LuaObject
{
  /// <summary>
  /// The entity this transport line belongs to.
  /// </summary>
  [FactorioRconAttribute("owner")]
  public LuaEntity Owner { get; private set; }

  /// <summary>
  /// The transport lines that this transport line outputs items to or an empty table if none.
  /// </summary>
  [FactorioRconAttribute("output_lines")]
  public LuaArray<LuaTransportLine> OutputLines { get; private set; }

  /// <summary>
  /// The transport lines that this transport line is fed by or an empty table if none.
  /// </summary>
  [FactorioRconAttribute("input_lines")]
  public LuaArray<LuaTransportLine> InputLines { get; private set; }

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
  /// Get the number of items on this transport line.
  /// </summary>
  [FactorioRconAttribute("length")]
  public uint Length { get; private set; }

  /// <summary>
  /// The indexing operator.
  /// </summary>
  public abstract LuaItemStack this[uint key] { get; }

  /// <summary>
  /// Remove all items from this transport line.
  /// </summary>
  [FactorioRconMethod("clear")]
  public abstract void Clear();

  /// <summary>
  /// Count some or all items on this line, similar to how <see cref="LuaInventory.GetItemCount" /> does.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_item_count")]
  public abstract uint GetItemCount(string? item = null);

  /// <summary>
  /// Remove some items from this line.
  /// </summary>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("remove_item")]
  public abstract uint RemoveItem(ItemStackIdentification items);

  /// <summary>
  /// Can an item be inserted at a given position?
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("can_insert_at")]
  public abstract bool CanInsertAt(float position);

  /// <summary>
  /// Can an item be inserted at the back of this line?
  /// </summary>
  [FactorioRconMethod("can_insert_at_back")]
  public abstract bool CanInsertAtBack();

  /// <summary>
  /// Insert items at a given position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("insert_at")]
  public abstract bool InsertAt(float position, ItemStackIdentification items);

  /// <summary>
  /// Insert items at the back of this line.
  /// </summary>
  /// <param name="items">Lua name: items</param>
  [FactorioRconMethod("insert_at_back")]
  public abstract bool InsertAtBack(ItemStackIdentification items);

  /// <summary>
  /// Get counts of all items on this line, similar to how <see cref="LuaInventory.GetContents" /> does.
  /// </summary>
  [FactorioRconMethod("get_contents")]
  public abstract Dictionary<string, uint> GetContents();

  /// <summary>
  /// Returns whether the associated internal transport line of this line is the same as the others associated internal transport line.
  /// </summary>
  /// <remarks>
  /// This can return true even when the <see cref="LuaTransportLine.Owner)SAreDifferent(So`This==Other`IsFalse" />, because the internal transport lines can span multiple tiles.
  /// </remarks>
  /// <param name="other">Lua name: other</param>
  [FactorioRconMethod("line_equals")]
  public abstract bool LineEquals(LuaTransportLine other);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

