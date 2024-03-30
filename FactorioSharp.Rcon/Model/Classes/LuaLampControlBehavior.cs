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
/// Control behavior for lamps.
/// </summary>
[FactorioRconClass("LuaLampControlBehavior")]
public abstract class LuaLampControlBehavior: LuaGenericOnOffControlBehavior, IFactorioRconModel
{
  /// <summary>
  /// `true` if the lamp should set the color from the circuit network signals.
  /// </summary>
  [FactorioRconAttribute("use_colors")]
  public bool UseColors { get; set; }

  /// <summary>
  /// The color the lamp is showing, if any.
  /// </summary>
  [FactorioRconAttribute("color")]
  public Color Color { get; private set; }

  public void Load(string str) => throw new NotImplementedException();
}

