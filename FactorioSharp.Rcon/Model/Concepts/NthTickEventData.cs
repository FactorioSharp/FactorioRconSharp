#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("NthTickEventData")]
public class NthTickEventData
{
  /// <summary>
  ///     The tick during which the event happened.
  /// </summary>
  [FactorioRconAttribute("tick")]
    public uint Tick { get; set; }

  /// <summary>
  ///     The nth tick this handler was registered to.
  /// </summary>
  [FactorioRconAttribute("nth_tick")]
    public uint NthTick { get; set; }
}
