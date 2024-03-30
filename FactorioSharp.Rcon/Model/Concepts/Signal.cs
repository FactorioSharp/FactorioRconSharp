#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     An actual signal transmitted by the network.
/// </summary>
[FactorioRconConcept("Signal")]
public class Signal
{
  /// <summary>
  ///     ID of the signal.
  /// </summary>
  [FactorioRconAttribute("signal")]
    public SignalID SignalProp { get; set; }

  /// <summary>
  ///     Value of the signal.
  /// </summary>
  [FactorioRconAttribute("count")]
    public int Count { get; set; }
}
