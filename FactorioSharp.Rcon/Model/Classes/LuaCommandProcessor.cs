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
/// Allows for the registration of custom console commands through the global object named `commands`. Similarly to <see cref="LuaBootstrap.OnEvent" />, these don't persist through a save-and-load cycle.
/// </summary>
[FactorioRconClass("LuaCommandProcessor")]
public abstract class LuaCommandProcessor: LuaObject, IFactorioRconModel
{
  /// <summary>
  /// Lists the custom commands registered by scripts through `LuaCommandProcessor`.
  /// </summary>
  [FactorioRconAttribute("commands")]
  public Dictionary<string, LocalisedString> Commands { get; private set; }

  /// <summary>
  /// Lists the built-in commands of the core game. The [wiki](https://wiki.factorio.com/Console) has an overview of these.
  /// </summary>
  [FactorioRconAttribute("game_commands")]
  public Dictionary<string, LocalisedString> GameCommands { get; private set; }

  /// <summary>
  /// This object's name.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// Add a custom console command.
  /// </summary>
  /// <remarks>
  /// Trying to add a command with the `name` of a game command or the name of a custom command that is already in use will result in an error.
  /// </remarks>
  /// <param name="name">Lua name: name</param>
  /// <param name="help">Lua name: help</param>
  /// <param name="function">Lua name: function</param>
  [FactorioRconMethod("add_command")]
  public abstract void AddCommand(string name, LocalisedString help, Action<CustomCommandData> function);

  /// <summary>
  /// Remove a custom console command.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("remove_command")]
  public abstract bool RemoveCommand(string name);

  public void Load(string str) => throw new NotImplementedException();
}

