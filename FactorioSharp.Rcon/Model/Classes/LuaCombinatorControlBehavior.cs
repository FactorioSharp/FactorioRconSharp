#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Classes;

[FactorioRconClass("LuaCombinatorControlBehavior")]
public abstract class LuaCombinatorControlBehavior: LuaControlBehavior, IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

