#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Classes;

[FactorioRconClass("LuaCombinatorControlBehavior")]
public abstract class LuaCombinatorControlBehavior: LuaObject
{
  /// <summary>
  /// The circuit network signals sent by this combinator last tick.
  /// </summary>
  [FactorioRconAttribute("signals_last_tick")]
  public List<Signal> SignalsLastTick { get; private set; }

  /// <summary>
  /// Gets the value of a specific signal sent by this combinator behavior last tick or `nil` if the signal didn't exist.
  /// </summary>
  /// <param name="signal">Lua name: signal</param>
  [FactorioRconMethod("get_signal_last_tick")]
  public abstract int? GetSignalLastTick(SignalID signal);

}

