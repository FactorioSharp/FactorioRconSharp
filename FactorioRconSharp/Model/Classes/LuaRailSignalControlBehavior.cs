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
/// Control behavior for rail signals.
/// </summary>
[FactorioRconClass("LuaRailSignalControlBehavior")]
public abstract class LuaRailSignalControlBehavior: LuaObject
{
  [FactorioRconAttribute("red_signal")]
  public SignalID RedSignal { get; set; }

  [FactorioRconAttribute("orange_signal")]
  public SignalID OrangeSignal { get; set; }

  [FactorioRconAttribute("green_signal")]
  public SignalID GreenSignal { get; set; }

  /// <summary>
  /// If this will close the rail signal based off the circuit condition.
  /// </summary>
  [FactorioRconAttribute("close_signal")]
  public bool CloseSignal { get; set; }

  /// <summary>
  /// If this will read the rail signal state.
  /// </summary>
  [FactorioRconAttribute("read_signal")]
  public bool ReadSignal { get; set; }

  /// <summary>
  /// The circuit condition when controlling the signal through the circuit network.
  /// </summary>
  [FactorioRconAttribute("circuit_condition")]
  public CircuitConditionDefinition CircuitCondition { get; set; }

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
