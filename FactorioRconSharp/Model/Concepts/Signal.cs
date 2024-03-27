#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// An actual signal transmitted by the network.
/// </summary>
[FactorioRconConcept("Signal")]
public abstract class Signal
{
  /// <summary>
  /// ID of the signal.
  /// </summary>
  [FactorioRconAttribute("signal")]
  public SignalID Signal { get; set; }

  /// <summary>
  /// Value of the signal.
  /// </summary>
  [FactorioRconAttribute("count")]
  public int Count { get; set; }

}

