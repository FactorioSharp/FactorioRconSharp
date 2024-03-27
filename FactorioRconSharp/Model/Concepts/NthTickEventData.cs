#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("NthTickEventData")]
public abstract class NthTickEventData
{
  /// <summary>
  /// The tick during which the event happened.
  /// </summary>
  [FactorioRconAttribute("tick")]
  public uint Tick { get; set; }

  /// <summary>
  /// The nth tick this handler was registered to.
  /// </summary>
  [FactorioRconAttribute("nth_tick")]
  public uint NthTick { get; set; }

}

