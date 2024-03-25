#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// An interface to send messages to the calling RCON interface through the global object named `rcon`.
/// </summary>
[FactorioRconClass("LuaRCON")]
public class LuaRCON
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
  public void Print(LocalisedString message) => throw FactorioModelUtils.UseClientExecuteAsyncMethod();

}

