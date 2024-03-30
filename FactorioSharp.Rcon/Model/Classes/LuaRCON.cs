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
/// An interface to send messages to the calling RCON interface through the global object named `rcon`.
/// </summary>
[FactorioRconClass("LuaRCON")]
public abstract class LuaRCON: LuaObject
{
  /// <summary>
  /// This object's name.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// Print text to the calling RCON interface if any.
  /// </summary>
  /// <param name="message">Lua name: message</param>
  [FactorioRconMethod("print")]
  public abstract void Print(LocalisedString message);

}

