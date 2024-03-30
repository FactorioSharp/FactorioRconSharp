#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Concepts;

namespace FactorioSharp.Rcon.Model;

/// <summary>
///     Objects and methods available globally in the Factorio console
/// </summary>
public abstract class FactorioRconGlobals
{
  /// <summary>
  ///     Allows registration of custom commands for the in-game console.
  /// </summary>
  [FactorioRconAttribute("commands")]
    public LuaCommandProcessor Commands { get; private set; }

  /// <summary>
  ///     The main scripting interface through which most of the API is accessed.
  /// </summary>
  [FactorioRconAttribute("game")]
    public LuaGameScript Game { get; private set; }

  /// <summary>
  ///     Allows printing messages to the calling RCON instance, if any.
  /// </summary>
  [FactorioRconAttribute("rcon")]
    public LuaRCON Rcon { get; private set; }

  /// <summary>
  ///     Allows registration and use of functions to communicate between mods.
  /// </summary>
  [FactorioRconAttribute("remote")]
    public LuaRemote Remote { get; private set; }

  /// <summary>
  ///     Allows rendering of geometric shapes, text and sprites in the game world.
  /// </summary>
  [FactorioRconAttribute("rendering")]
    public LuaRendering Rendering { get; private set; }

  /// <summary>
  ///     Provides an interface for registering game event handlers.
  /// </summary>
  [FactorioRconAttribute("script")]
    public LuaBootstrap Script { get; private set; }

  /// <summary>
  ///     Provides access to the current mod settings.
  /// </summary>
  [FactorioRconAttribute("settings")]
    public LuaSettings Settings { get; private set; }

  /// <summary>
  ///     `localised_print()` allows printing <see cref="LocalisedString//Wiki.Factorio.Com/LogFile" />. This is primarily useful when communicating with external tools that launch
  ///     Factorio as a child process.
  /// </summary>
  /// <param name="@string">Lua name: string</param>
  [FactorioRconMethod("localised_print")]
    public abstract void LocalisedPrint(LocalisedString @string);

  /// <summary>
  ///     `log()` can print
  ///     <see
  ///         cref="LocalisedString)ToTheFactorio[LogFile](Https://Wiki.Factorio.Com/LogFile).This,InCombinationWithTheSerpentLibrary,MakesDebuggingInTheDataStageEasierBecauseItAllowsTheInspectionOfEntirePrototypeTables.ForExample,PrintingAllPropertiesOfTheSulfurItemPrototypeCanBeDoneLikeSo:`Log(Serpent.Block(Data.Raw["
  ///         Item"][" Sulfur"])" />
  ///     `
  /// </summary>
  /// <param name="@string">Lua name: string</param>
  [FactorioRconMethod("log")]
    public abstract void Log(LocalisedString @string);

  /// <summary>
  ///     Factorio provides the `table_size()` function as a simple way to determine the size of tables with non-continuous keys, as the standard `#` operator does not work correctly
  ///     for these. The function is a C++ implementation of the following Lua code, which is faster than doing the same in Lua:
  ///     ```
  ///     local function size(t)
  ///     local count = 0
  ///     for k,v in pairs(t) do
  ///     count = count + 1
  ///     end
  ///     return count
  ///     end
  ///     ```
  ///     Note that `table_size()` does not work correctly for <see cref="LuaCustomTable.LengthOperator" /> instead.
  /// </summary>
  /// <param name="table">Lua name: table</param>
  [FactorioRconMethod("table_size")]
    public abstract uint TableSize(LuaTable table);
}
