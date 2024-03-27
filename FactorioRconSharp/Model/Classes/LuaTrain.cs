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
/// A train. Trains are a sequence of connected rolling stocks -- locomotives and wagons.
/// </summary>
[FactorioRconClass("LuaTrain")]
public abstract class LuaTrain: LuaObject
{
  /// <summary>
  /// When `true`, the train is explicitly controlled by the player or script. When `false`, the train moves autonomously according to its schedule.
  /// </summary>
  [FactorioRconAttribute("manual_mode")]
  public bool ManualMode { get; set; }

  /// <summary>
  /// Current speed.
  /// </summary>
  [FactorioRconAttribute("speed")]
  public double Speed { get; set; }

  /// <summary>
  /// Current max speed when moving forward, depends on locomotive prototype and fuel.
  /// </summary>
  [FactorioRconAttribute("max_forward_speed")]
  public double MaxForwardSpeed { get; private set; }

  /// <summary>
  /// Current max speed when moving backwards, depends on locomotive prototype and fuel.
  /// </summary>
  [FactorioRconAttribute("max_backward_speed")]
  public double MaxBackwardSpeed { get; private set; }

  /// <summary>
  /// The weight of this train.
  /// </summary>
  [FactorioRconAttribute("weight")]
  public double Weight { get; private set; }

  /// <summary>
  /// The rolling stocks this train is composed of, with the numbering starting at the <see cref="LuaTrain.FrontStock" /> of the train.
  /// </summary>
  [FactorioRconAttribute("carriages")]
  public List<LuaEntity> Carriages { get; private set; }

  /// <summary>
  /// Locomotives of the train.
  /// </summary>
  [FactorioRconAttribute("locomotives")]
  public Table1316174655 Locomotives { get; private set; }

  /// <summary>
  /// The cargo carriages the train contains.
  /// </summary>
  [FactorioRconAttribute("cargo_wagons")]
  public List<LuaEntity> CargoWagons { get; private set; }

  /// <summary>
  /// The fluid carriages the train contains.
  /// </summary>
  [FactorioRconAttribute("fluid_wagons")]
  public List<LuaEntity> FluidWagons { get; private set; }

  /// <summary>
  /// This train's current schedule, if any. Set to `nil` to clear.
  /// </summary>
  [FactorioRconAttribute("schedule")]
  public TrainSchedule Schedule { get; set; }

  /// <summary>
  /// This train's current state.
  /// </summary>
  [FactorioRconAttribute("state")]
  public TrainStateEnum State { get; private set; }

  /// <summary>
  /// The rail at the front end of the train, if any.
  /// </summary>
  [FactorioRconAttribute("front_rail")]
  public LuaEntity FrontRail { get; private set; }

  /// <summary>
  /// The rail at the back end of the train, if any.
  /// </summary>
  [FactorioRconAttribute("back_rail")]
  public LuaEntity BackRail { get; private set; }

  [FactorioRconAttribute("rail_direction_from_front_rail")]
  public RailDirectionEnum RailDirectionFromFrontRail { get; private set; }

  [FactorioRconAttribute("rail_direction_from_back_rail")]
  public RailDirectionEnum RailDirectionFromBackRail { get; private set; }

  /// <summary>
  /// The front stock of this train, if any. The front of the train is in the direction that a majority of locomotives are pointing in. If it's a tie, the North and West directions take precedence.
  /// </summary>
  [FactorioRconAttribute("front_stock")]
  public LuaEntity FrontStock { get; private set; }

  /// <summary>
  /// The back stock of this train, if any. The back of the train is at the opposite end of the <see cref="LuaTrain.FrontStock" />.
  /// </summary>
  [FactorioRconAttribute("back_stock")]
  public LuaEntity BackStock { get; private set; }

  /// <summary>
  /// The train stop this train is stopped at, if any.
  /// </summary>
  [FactorioRconAttribute("station")]
  public LuaEntity Station { get; private set; }

  /// <summary>
  /// If this train has a path.
  /// </summary>
  [FactorioRconAttribute("has_path")]
  public bool HasPath { get; private set; }

  /// <summary>
  /// The destination rail this train is currently pathing to, if any.
  /// </summary>
  [FactorioRconAttribute("path_end_rail")]
  public LuaEntity PathEndRail { get; private set; }

  /// <summary>
  /// The destination train stop this train is currently pathing to, if any.
  /// </summary>
  [FactorioRconAttribute("path_end_stop")]
  public LuaEntity PathEndStop { get; private set; }

  /// <summary>
  /// The unique train ID.
  /// </summary>
  [FactorioRconAttribute("id")]
  public uint Id { get; private set; }

  /// <summary>
  /// The player passengers on the train
  /// </summary>
  [FactorioRconAttribute("passengers")]
  public List<LuaPlayer> Passengers { get; private set; }

  /// <summary>
  /// The riding state of this train.
  /// </summary>
  [FactorioRconAttribute("riding_state")]
  public RidingState RidingState { get; private set; }

  /// <summary>
  /// The players killed by this train.
  /// 
  /// The keys are the player indices, the values are how often this train killed that player.
  /// </summary>
  [FactorioRconAttribute("killed_players")]
  public Dictionary<uint, uint> KilledPlayers { get; private set; }

  /// <summary>
  /// The total number of kills by this train.
  /// </summary>
  [FactorioRconAttribute("kill_count")]
  public uint KillCount { get; private set; }

  /// <summary>
  /// The path this train is using, if any.
  /// </summary>
  [FactorioRconAttribute("path")]
  public LuaRailPath Path { get; private set; }

  /// <summary>
  /// The signal this train is arriving or waiting at, if any.
  /// </summary>
  [FactorioRconAttribute("signal")]
  public LuaEntity Signal { get; private set; }

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
  /// Get the amount of a particular item stored in the train.
  /// </summary>
  /// <param name="item">Lua name: item</param>
  [FactorioRconMethod("get_item_count")]
  public abstract uint GetItemCount(string? item = null);

  /// <summary>
  /// Get a mapping of the train's inventory.
  /// </summary>
  [FactorioRconMethod("get_contents")]
  public abstract Dictionary<string, uint> GetContents();

  /// <summary>
  /// Remove some items from the train.
  /// </summary>
  /// <param name="stack">Lua name: stack</param>
  [FactorioRconMethod("remove_item")]
  public abstract uint RemoveItem(ItemStackIdentification stack);

  /// <summary>
  /// Insert a stack into the train.
  /// </summary>
  /// <param name="stack">Lua name: stack</param>
  [FactorioRconMethod("insert")]
  public abstract void Insert(ItemStackIdentification stack);

  /// <summary>
  /// Clear all items in this train.
  /// </summary>
  [FactorioRconMethod("clear_items_inside")]
  public abstract void ClearItemsInside();

  /// <summary>
  /// Checks if the path is invalid and tries to re-path if it isn't.
  /// </summary>
  /// <param name="force">Lua name: force</param>
  [FactorioRconMethod("recalculate_path")]
  public abstract bool RecalculatePath(bool? force = null);

  /// <summary>
  /// Get the amount of a particular fluid stored in the train.
  /// </summary>
  /// <param name="fluid">Lua name: fluid</param>
  [FactorioRconMethod("get_fluid_count")]
  public abstract double GetFluidCount(string? fluid = null);

  /// <summary>
  /// Gets a mapping of the train's fluid inventory.
  /// </summary>
  [FactorioRconMethod("get_fluid_contents")]
  public abstract Dictionary<string, double> GetFluidContents();

  /// <summary>
  /// Remove some fluid from the train.
  /// </summary>
  /// <param name="fluid">Lua name: fluid</param>
  [FactorioRconMethod("remove_fluid")]
  public abstract double RemoveFluid(Fluid fluid);

  /// <summary>
  /// Inserts the given fluid into the first available location in this train.
  /// </summary>
  /// <param name="fluid">Lua name: fluid</param>
  [FactorioRconMethod("insert_fluid")]
  public abstract double InsertFluid(Fluid fluid);

  /// <summary>
  /// Clears all fluids in this train.
  /// </summary>
  [FactorioRconMethod("clear_fluids_inside")]
  public abstract void ClearFluidsInside();

  /// <summary>
  /// Go to the station specified by the index in the train's schedule.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("go_to_station")]
  public abstract void GoToStation(uint index);

  /// <summary>
  /// Gets all rails under the train.
  /// </summary>
  [FactorioRconMethod("get_rails")]
  public abstract List<LuaEntity> GetRails();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

