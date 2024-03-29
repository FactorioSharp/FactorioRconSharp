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
/// Control behavior for inserters.
/// </summary>
[FactorioRconClass("LuaInserterControlBehavior")]
public abstract class LuaInserterControlBehavior: LuaObject
{
  /// <summary>
  /// `true` if the contents of the inserter hand should be sent to the circuit network
  /// </summary>
  [FactorioRconAttribute("circuit_read_hand_contents")]
  public bool CircuitReadHandContents { get; set; }

  /// <summary>
  /// The circuit mode of operations for the inserter.
  /// </summary>
  [FactorioRconAttribute("circuit_mode_of_operation")]
  public ControlBehaviorInserterCircuitModeOfOperationEnum CircuitModeOfOperation { get; set; }

  /// <summary>
  /// The hand read mode for the inserter.
  /// </summary>
  [FactorioRconAttribute("circuit_hand_read_mode")]
  public ControlBehaviorInserterHandReadModeEnum CircuitHandReadMode { get; set; }

  /// <summary>
  /// If the stack size of the inserter is set through the circuit network or not.
  /// </summary>
  [FactorioRconAttribute("circuit_set_stack_size")]
  public bool CircuitSetStackSize { get; set; }

  /// <summary>
  /// The signal used to set the stack size of the inserter.
  /// </summary>
  [FactorioRconAttribute("circuit_stack_control_signal")]
  public SignalID CircuitStackControlSignal { get; set; }

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

