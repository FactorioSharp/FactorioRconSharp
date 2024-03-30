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
/// Control behavior for train stops.
/// </summary>
[FactorioRconClass("LuaTrainStopControlBehavior")]
public abstract class LuaTrainStopControlBehavior: LuaGenericOnOffControlBehavior, IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

