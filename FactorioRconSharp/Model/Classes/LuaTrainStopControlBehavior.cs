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
/// Control behavior for train stops.
/// </summary>
[FactorioRconClass("LuaTrainStopControlBehavior")]
public abstract class LuaTrainStopControlBehavior: LuaObject
{
  /// <summary>
  /// `true` if the train stop should send the circuit network contents to the train to use.
  /// </summary>
  [FactorioRconAttribute("send_to_train")]
  public bool SendToTrain { get; set; }

  /// <summary>
  /// `true` if the train stop should send the train contents to the circuit network.
  /// </summary>
  [FactorioRconAttribute("read_from_train")]
  public bool ReadFromTrain { get; set; }

  /// <summary>
  /// `true` if the train stop should send the stopped train id to the circuit network.
  /// </summary>
  [FactorioRconAttribute("read_stopped_train")]
  public bool ReadStoppedTrain { get; set; }

  /// <summary>
  /// `true` if the trains_limit_signal is used to set a limit of trains incoming for train stop.
  /// </summary>
  [FactorioRconAttribute("set_trains_limit")]
  public bool SetTrainsLimit { get; set; }

  /// <summary>
  /// `true` if the train stop should send amount of incoming trains to the circuit network.
  /// </summary>
  [FactorioRconAttribute("read_trains_count")]
  public bool ReadTrainsCount { get; set; }

  /// <summary>
  /// `true` if the train stop is enabled/disabled through the circuit network.
  /// </summary>
  [FactorioRconAttribute("enable_disable")]
  public bool EnableDisable { get; set; }

  /// <summary>
  /// The signal that will be sent when using the send-train-id option.
  /// </summary>
  [FactorioRconAttribute("stopped_train_signal")]
  public SignalID StoppedTrainSignal { get; set; }

  /// <summary>
  /// The signal that will be sent when using the read-trains-count option.
  /// </summary>
  [FactorioRconAttribute("trains_count_signal")]
  public SignalID TrainsCountSignal { get; set; }

  /// <summary>
  /// The signal to be used by set-trains-limit to limit amount of incoming trains
  /// </summary>
  [FactorioRconAttribute("trains_limit_signal")]
  public SignalID TrainsLimitSignal { get; set; }

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

