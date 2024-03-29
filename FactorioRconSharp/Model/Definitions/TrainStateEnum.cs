#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("train_state")]
public enum TrainStateEnum
{
  /// <summary>
  /// Normal state -- following the path.
  /// </summary>
  [FactorioRconDefinitionValue("on_the_path")]
  OnThePath,

  /// <summary>
  /// Had path and lost it -- must stop.
  /// </summary>
  [FactorioRconDefinitionValue("path_lost")]
  PathLost,

  /// <summary>
  /// Doesn't have anywhere to go.
  /// </summary>
  [FactorioRconDefinitionValue("no_schedule")]
  NoSchedule,

  /// <summary>
  /// Has no path and is stopped.
  /// </summary>
  [FactorioRconDefinitionValue("no_path")]
  NoPath,

  /// <summary>
  /// Braking before a rail signal.
  /// </summary>
  [FactorioRconDefinitionValue("arrive_signal")]
  ArriveSignal,

  /// <summary>
  /// Waiting at a signal.
  /// </summary>
  [FactorioRconDefinitionValue("wait_signal")]
  WaitSignal,

  /// <summary>
  /// Braking before a station.
  /// </summary>
  [FactorioRconDefinitionValue("arrive_station")]
  ArriveStation,

  /// <summary>
  /// Waiting at a station.
  /// </summary>
  [FactorioRconDefinitionValue("wait_station")]
  WaitStation,

  /// <summary>
  /// Switched to manual control and has to stop.
  /// </summary>
  [FactorioRconDefinitionValue("manual_control_stop")]
  ManualControlStop,

  /// <summary>
  /// Can move if user explicitly sits in and rides the train.
  /// </summary>
  [FactorioRconDefinitionValue("manual_control")]
  ManualControl,

  /// <summary>
  /// Same as no_path but all candidate train stops are full
  /// </summary>
  [FactorioRconDefinitionValue("destination_full")]
  DestinationFull,

}

