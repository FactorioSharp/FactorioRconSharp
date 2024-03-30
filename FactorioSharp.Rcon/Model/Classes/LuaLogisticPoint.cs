#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;
using FactorioSharp.Rcon.Model.Definitions;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
///     Logistic point of a particular <see cref="LuaEntity" />. A "Logistic point" is the name given for settings and properties used by requester, provider, and storage points in a
///     given logistic network. These "points" don't have to be a logistic container but often are. One other entity that can own several points is the "character" character type
///     entity.
/// </summary>
[FactorioRconClass("LuaLogisticPoint")]
public abstract class LuaLogisticPoint : LuaObject
{
  /// <summary>
  ///     The <see cref="LuaLogisticPoint" />.
  /// </summary>
  [FactorioRconAttribute("owner")]
    public LuaEntity Owner { get; private set; }

    [FactorioRconAttribute("logistic_network")]
    public LuaLogisticNetwork LogisticNetwork { get; private set; }

    /// <summary>
    ///     The Logistic member index of this logistic point.
    /// </summary>
    [FactorioRconAttribute("logistic_member_index")]
    public uint LogisticMemberIndex { get; private set; }

    /// <summary>
    ///     The logistic filters for this logistic point, if this uses any.
    /// </summary>
    [FactorioRconAttribute("filters")]
    public List<LogisticFilter> Filters { get; private set; }

    /// <summary>
    ///     The logistic mode.
    /// </summary>
    [FactorioRconAttribute("mode")]
    public LogisticModeEnum Mode { get; private set; }

    /// <summary>
    ///     The force of this logistic point.
    /// </summary>
    [FactorioRconAttribute("force")]
    public LuaForce Force { get; private set; }

    /// <summary>
    ///     Items targeted to be picked up from this logistic point by robots. The attribute is a dictionary mapping the item prototype names to their item counts.
    /// </summary>
    [FactorioRconAttribute("targeted_items_pickup")]
    public Dictionary<string, uint> TargetedItemsPickup { get; private set; }

    /// <summary>
    ///     Items targeted to be dropped off into this logistic point by robots. The attribute is a dictionary mapping the item prototype names to their item counts.
    /// </summary>
    [FactorioRconAttribute("targeted_items_deliver")]
    public Dictionary<string, uint> TargetedItemsDeliver { get; private set; }

    /// <summary>
    ///     If this logistic point is using the exact mode. In exact mode robots never over-deliver requests.
    /// </summary>
    [FactorioRconAttribute("exact")]
    public bool Exact { get; private set; }

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
    ///     All methods and properties that this object supports.
    /// </summary>
    [FactorioRconMethod("help")]
    public abstract string Help();
}
