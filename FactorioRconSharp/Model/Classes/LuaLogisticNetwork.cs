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
/// A single logistic network of a given force on a given surface.
/// </summary>
[FactorioRconClass("LuaLogisticNetwork")]
public class LuaLogisticNetwork
{
  /// <summary>
  /// The force this logistic network belongs to.
  /// </summary>
  [FactorioRconAttribute("force")]
  public LuaForce Force { get; private set; }

  /// <summary>
  /// Number of logistic robots available for a job.
  /// </summary>
  [FactorioRconAttribute("available_logistic_robots")]
  public uint AvailableLogisticRobots { get; private set; }

  /// <summary>
  /// The total number of logistic robots in the network (idle and active + in roboports).
  /// </summary>
  [FactorioRconAttribute("all_logistic_robots")]
  public uint AllLogisticRobots { get; private set; }

  /// <summary>
  /// Number of construction robots available for a job.
  /// </summary>
  [FactorioRconAttribute("available_construction_robots")]
  public uint AvailableConstructionRobots { get; private set; }

  /// <summary>
  /// The total number of construction robots in the network (idle and active + in roboports).
  /// </summary>
  [FactorioRconAttribute("all_construction_robots")]
  public uint AllConstructionRobots { get; private set; }

  /// <summary>
  /// Maximum number of robots the network can work with. Currently only used for the personal roboport.
  /// </summary>
  [FactorioRconAttribute("robot_limit")]
  public uint RobotLimit { get; private set; }

  /// <summary>
  /// All cells in this network.
  /// </summary>
  [FactorioRconAttribute("cells")]
  public LuaLogisticCell[] Cells { get; private set; }

  /// <summary>
  /// All entities that have logistic provider points in this network.
  /// </summary>
  [FactorioRconAttribute("providers")]
  public LuaEntity[] Providers { get; private set; }

  /// <summary>
  /// All entities that have empty logistic provider points in this network.
  /// </summary>
  [FactorioRconAttribute("empty_providers")]
  public LuaEntity[] EmptyProviders { get; private set; }

  /// <summary>
  /// All entities that have logistic requester points in this network.
  /// </summary>
  [FactorioRconAttribute("requesters")]
  public LuaEntity[] Requesters { get; private set; }

  /// <summary>
  /// All entities that have logistic storage points in this network.
  /// </summary>
  [FactorioRconAttribute("storages")]
  public LuaEntity[] Storages { get; private set; }

  /// <summary>
  /// All other entities that have logistic points in this network (inserters mostly).
  /// </summary>
  [FactorioRconAttribute("logistic_members")]
  public LuaEntity[] LogisticMembers { get; private set; }

  /// <summary>
  /// All things that have provider points in this network.
  /// </summary>
  [FactorioRconAttribute("provider_points")]
  public LuaLogisticPoint[] ProviderPoints { get; private set; }

  /// <summary>
  /// All passive provider points in this network.
  /// </summary>
  [FactorioRconAttribute("passive_provider_points")]
  public LuaLogisticPoint[] PassiveProviderPoints { get; private set; }

  /// <summary>
  /// All active provider points in this network.
  /// </summary>
  [FactorioRconAttribute("active_provider_points")]
  public LuaLogisticPoint[] ActiveProviderPoints { get; private set; }

  /// <summary>
  /// All things that have empty provider points in this network.
  /// </summary>
  [FactorioRconAttribute("empty_provider_points")]
  public LuaLogisticPoint[] EmptyProviderPoints { get; private set; }

  /// <summary>
  /// All things that have requester points in this network.
  /// </summary>
  [FactorioRconAttribute("requester_points")]
  public LuaLogisticPoint[] RequesterPoints { get; private set; }

  /// <summary>
  /// All things that have storage points in this network.
  /// </summary>
  [FactorioRconAttribute("storage_points")]
  public LuaLogisticPoint[] StoragePoints { get; private set; }

  /// <summary>
  /// All robots in this logistic network.
  /// </summary>
  [FactorioRconAttribute("robots")]
  public LuaEntity[] Robots { get; private set; }

  /// <summary>
  /// All construction robots in this logistic network.
  /// </summary>
  [FactorioRconAttribute("construction_robots")]
  public LuaEntity[] ConstructionRobots { get; private set; }

  /// <summary>
  /// All logistic robots in this logistic network.
  /// </summary>
  [FactorioRconAttribute("logistic_robots")]
  public LuaEntity[] LogisticRobots { get; private set; }

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
  /// Count given or all items in the network or given members.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  /// <param name="member">Lua name: member</param>
  [FactorioRconMethod("get_item_count")]
  public int GetItemCount(string? item = null, OneOf<Literal35318532, Literal3491672>? member = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Get item counts for the entire network, similar to how <see cref="LuaInventory.GetContents" /> does.
  /// </summary>
  [FactorioRconMethod("get_contents")]
  public Dictionary<string, uint> GetContents() => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Remove items from the logistic network. This will actually remove the items from some logistic chests.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  /// <param name="members">Lua name: members</param>
  [FactorioRconMethod("remove_item")]
  public uint RemoveItem(ItemStackIdentification item, OneOf<Literal44203036, Literal55848526, Literal31968364, Literal247016>? members = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Insert items into the logistic network. This will actually insert the items into some logistic chests.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  /// <param name="members">Lua name: members</param>
  [FactorioRconMethod("insert")]
  public uint Insert(ItemStackIdentification item, OneOf<Literal6216253, Literal63432468, Literal57013419, Literal56431129>? members = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Find logistic cell closest to a given position.
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("find_cell_closest_to")]
  public LuaLogisticCell? FindCellClosestTo(MapPosition position) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Find the 'best' logistic point with this item ID and from the given position or from given chest type.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="position">Lua name: position</param>
  /// <param name="includeBuffers">Lua name: include_buffers</param>
  /// <param name="members">Lua name: members</param>
  [FactorioRconMethod("select_pickup_point")]
  public LuaLogisticPoint? SelectPickupPoint(string name, MapPosition? position = null, bool? includeBuffers = null, OneOf<Literal58490299, Literal20336737, Literal24418296, Literal43022188>? members = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Find a logistic point to drop the specific item stack.
  /// </summary>
  /// <param name="stack">Lua name: stack</param>
  /// <param name="members">Lua name: members</param>
  [FactorioRconMethod("select_drop_point")]
  public LuaLogisticPoint? SelectDropPoint(ItemStackIdentification stack, OneOf<Literal5187339, Literal41825261, Literal5915254, Literal57111475>? members = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Can the network satisfy a request for a given item and count.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  /// <param name="count">Lua name: count</param>
  /// <param name="includeBuffers">Lua name: include_buffers</param>
  [FactorioRconMethod("can_satisfy_request")]
  public bool CanSatisfyRequest(string item, uint? count = null, bool? includeBuffers = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Get the amount of items of the given type indexed by the storage member.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_supply_counts")]
  public LogisticsNetworkSupplyCounts GetSupplyCounts(string item) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// Gets the logistic points with of the given type indexed by the storage member.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_supply_points")]
  public LogisticsNetworkSupplyPoints GetSupplyPoints(string item) => throw FactorioModelUtils.UseClientReadAsyncMethod();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public string Help() => throw FactorioModelUtils.UseClientReadAsyncMethod();

}

/// <summary>
/// Literal value: storage
/// </summary>
public class Literal35318532
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconAttribute("storage")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: providers
/// </summary>
public class Literal3491672
{
  /// <summary>
  /// Literal value: providers
  /// </summary>
  [FactorioRconAttribute("providers")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: storage
/// </summary>
public class Literal6216253
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconAttribute("storage")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: storage-empty
/// </summary>
public class Literal63432468
{
  /// <summary>
  /// Literal value: storage-empty
  /// </summary>
  [FactorioRconAttribute("storage-empty")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: storage-empty-slot
/// </summary>
public class Literal57013419
{
  /// <summary>
  /// Literal value: storage-empty-slot
  /// </summary>
  [FactorioRconAttribute("storage-empty-slot")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: requester
/// </summary>
public class Literal56431129
{
  /// <summary>
  /// Literal value: requester
  /// </summary>
  [FactorioRconAttribute("requester")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: active-provider
/// </summary>
public class Literal44203036
{
  /// <summary>
  /// Literal value: active-provider
  /// </summary>
  [FactorioRconAttribute("active-provider")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: passive-provider
/// </summary>
public class Literal55848526
{
  /// <summary>
  /// Literal value: passive-provider
  /// </summary>
  [FactorioRconAttribute("passive-provider")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: buffer
/// </summary>
public class Literal31968364
{
  /// <summary>
  /// Literal value: buffer
  /// </summary>
  [FactorioRconAttribute("buffer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: storage
/// </summary>
public class Literal247016
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconAttribute("storage")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: storage
/// </summary>
public class Literal5187339
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconAttribute("storage")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: storage-empty
/// </summary>
public class Literal41825261
{
  /// <summary>
  /// Literal value: storage-empty
  /// </summary>
  [FactorioRconAttribute("storage-empty")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: storage-empty-slot
/// </summary>
public class Literal5915254
{
  /// <summary>
  /// Literal value: storage-empty-slot
  /// </summary>
  [FactorioRconAttribute("storage-empty-slot")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: requester
/// </summary>
public class Literal57111475
{
  /// <summary>
  /// Literal value: requester
  /// </summary>
  [FactorioRconAttribute("requester")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: active-provider
/// </summary>
public class Literal58490299
{
  /// <summary>
  /// Literal value: active-provider
  /// </summary>
  [FactorioRconAttribute("active-provider")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: passive-provider
/// </summary>
public class Literal20336737
{
  /// <summary>
  /// Literal value: passive-provider
  /// </summary>
  [FactorioRconAttribute("passive-provider")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: buffer
/// </summary>
public class Literal24418296
{
  /// <summary>
  /// Literal value: buffer
  /// </summary>
  [FactorioRconAttribute("buffer")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: storage
/// </summary>
public class Literal43022188
{
  /// <summary>
  /// Literal value: storage
  /// </summary>
  [FactorioRconAttribute("storage")]
  public static object Value { get; private set; }

}

