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
/// Logistic cell of a particular <see cref="LuaEntity).A"LogisticCell"IsTheGivenNameForSettingsAndPropertiesUsedByWhatWouldNormallyBeSeenAsA"Roboport".ALogisticCellHoweverDoesn'THaveToBeAttachedToTheRoboportEntity(TheCharacterHasOneForThePersonalRoboport" />.
/// </summary>
[FactorioRconClass("LuaLogisticCell")]
public abstract class LuaLogisticCell: LuaObject
{
  /// <summary>
  /// Logistic radius of this cell.
  /// </summary>
  [FactorioRconAttribute("logistic_radius")]
  public float LogisticRadius { get; private set; }

  /// <summary>
  /// Logistic connection distance of this cell.
  /// </summary>
  [FactorioRconAttribute("logistics_connection_distance")]
  public float LogisticsConnectionDistance { get; private set; }

  /// <summary>
  /// Construction radius of this cell.
  /// </summary>
  [FactorioRconAttribute("construction_radius")]
  public float ConstructionRadius { get; private set; }

  /// <summary>
  /// Number of stationed logistic robots in this cell.
  /// </summary>
  [FactorioRconAttribute("stationed_logistic_robot_count")]
  public uint StationedLogisticRobotCount { get; private set; }

  /// <summary>
  /// Number of stationed construction robots in this cell.
  /// </summary>
  [FactorioRconAttribute("stationed_construction_robot_count")]
  public uint StationedConstructionRobotCount { get; private set; }

  /// <summary>
  /// `true` if this is a mobile cell. In vanilla, only the logistic cell created by a character's personal roboport is mobile.
  /// </summary>
  [FactorioRconAttribute("mobile")]
  public bool Mobile { get; private set; }

  /// <summary>
  /// `true` if this cell is active.
  /// </summary>
  [FactorioRconAttribute("transmitting")]
  public bool Transmitting { get; private set; }

  /// <summary>
  /// Radius at which the robots hover when waiting to be charged.
  /// </summary>
  [FactorioRconAttribute("charge_approach_distance")]
  public float ChargeApproachDistance { get; private set; }

  /// <summary>
  /// Number of robots currently charging.
  /// </summary>
  [FactorioRconAttribute("charging_robot_count")]
  public uint ChargingRobotCount { get; private set; }

  /// <summary>
  /// Number of robots waiting to charge.
  /// </summary>
  [FactorioRconAttribute("to_charge_robot_count")]
  public uint ToChargeRobotCount { get; private set; }

  /// <summary>
  /// This cell's owner.
  /// </summary>
  [FactorioRconAttribute("owner")]
  public LuaEntity Owner { get; private set; }

  /// <summary>
  /// The network that owns this cell, if any.
  /// </summary>
  [FactorioRconAttribute("logistic_network")]
  public LuaLogisticNetwork LogisticNetwork { get; private set; }

  /// <summary>
  /// Neighbouring cells.
  /// </summary>
  [FactorioRconAttribute("neighbours")]
  public List<LuaLogisticCell> Neighbours { get; private set; }

  /// <summary>
  /// Robots currently being charged.
  /// </summary>
  [FactorioRconAttribute("charging_robots")]
  public List<LuaEntity> ChargingRobots { get; private set; }

  /// <summary>
  /// Robots waiting to charge.
  /// </summary>
  [FactorioRconAttribute("to_charge_robots")]
  public List<LuaEntity> ToChargeRobots { get; private set; }

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
  /// Is a given position within the logistic range of this cell?
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("is_in_logistic_range")]
  public abstract bool IsInLogisticRange(MapPosition position);

  /// <summary>
  /// Is a given position within the construction range of this cell?
  /// </summary>
  /// <param name="position">Lua name: position</param>
  [FactorioRconMethod("is_in_construction_range")]
  public abstract bool IsInConstructionRange(MapPosition position);

  /// <summary>
  /// Are two cells neighbours?
  /// </summary>
  /// <param name="other">Lua name: other</param>
  [FactorioRconMethod("is_neighbour_with")]
  public abstract bool IsNeighbourWith(LuaLogisticCell other);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}
