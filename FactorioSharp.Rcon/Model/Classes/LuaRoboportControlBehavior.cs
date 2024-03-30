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
/// Control behavior for roboports.
/// </summary>
[FactorioRconClass("LuaRoboportControlBehavior")]
public abstract class LuaRoboportControlBehavior: LuaControlBehavior
{
  /// <summary>
  /// `true` if the roboport should report the logistics network content to the circuit network.
  /// </summary>
  [FactorioRconAttribute("read_logistics")]
  public bool ReadLogistics { get; set; }

  /// <summary>
  /// `true` if the roboport should report the robot statistics to the circuit network.
  /// </summary>
  [FactorioRconAttribute("read_robot_stats")]
  public bool ReadRobotStats { get; set; }

  [FactorioRconAttribute("available_logistic_output_signal")]
  public SignalID AvailableLogisticOutputSignal { get; set; }

  [FactorioRconAttribute("total_logistic_output_signal")]
  public SignalID TotalLogisticOutputSignal { get; set; }

  [FactorioRconAttribute("available_construction_output_signal")]
  public SignalID AvailableConstructionOutputSignal { get; set; }

  [FactorioRconAttribute("total_construction_output_signal")]
  public SignalID TotalConstructionOutputSignal { get; set; }

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
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

