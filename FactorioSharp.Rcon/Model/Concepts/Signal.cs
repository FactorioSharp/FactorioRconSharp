#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// An actual signal transmitted by the network.
/// </summary>
[FactorioRconConcept("Signal")]
public class Signal: IFactorioRconModel
{
  /// <summary>
  /// ID of the signal.
  /// </summary>
  [FactorioRconAttribute("signal")]
  public SignalID SignalProp { get; set; }

  /// <summary>
  /// Value of the signal.
  /// </summary>
  [FactorioRconAttribute("count")]
  public int Count { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

