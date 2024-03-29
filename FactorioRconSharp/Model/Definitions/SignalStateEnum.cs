#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

/// <summary>
/// State of an ordinary rail signal.
/// </summary>
[FactorioRconDefinition("signal_state")]
public enum SignalStateEnum
{
  /// <summary>
  /// Green.
  /// </summary>
  [FactorioRconDefinitionValue("open")]
  Open,

  /// <summary>
  /// Red.
  /// </summary>
  [FactorioRconDefinitionValue("closed")]
  Closed,

  /// <summary>
  /// Orange.
  /// </summary>
  [FactorioRconDefinitionValue("reserved")]
  Reserved,

  /// <summary>
  /// Red - From circuit network.
  /// </summary>
  [FactorioRconDefinitionValue("reserved_by_circuit_network")]
  ReservedByCircuitNetwork,

}

