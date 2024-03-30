#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
///     Registry of interfaces between scripts. An interface is simply a dictionary mapping names to functions. A script or mod can then register an interface with
///     <see cref="LuaRemote" />, after that any script can call the registered functions, provided it knows the interface name and the desired function name. An instance of LuaRemote
///     is available through the global object named `remote`.
/// </summary>
/// <examples>
///     Will register a remote interface containing two functions. Later, it will call these functions through `remote`.
///     ```
///     remote.add_interface("human interactor",
///     {hello = function() game.player.print("Hi!") end,
///     bye = function(name) game.player.print("Bye " .. name) end})
///     -- Some time later, possibly in a different mod...
///     remote.call("human interactor", "hello")
///     remote.call("human interactor", "bye", "dear reader")
///     ```
/// </examples>
[FactorioRconClass("LuaRemote")]
public abstract class LuaRemote : LuaObject
{
  /// <summary>
  ///     This object's name.
  /// </summary>
  [FactorioRconAttribute("object_name")]
    public string ObjectName { get; private set; }

  /// <summary>
  ///     List of all registered interfaces. For each interface name, `remote.interfaces[name]` is a dictionary mapping the interface's registered functions to `true`.
  /// </summary>
  [FactorioRconAttribute("interfaces")]
    public Dictionary<string, Dictionary<string, Literal666164478>> Interfaces { get; private set; }

  /// <summary>
  ///     Add a remote interface.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  /// <param name="functions">Lua name: functions</param>
  [FactorioRconMethod("add_interface")]
    public abstract void AddInterface(string name, Dictionary<string, Action> functions);

  /// <summary>
  ///     Removes an interface with the given name.
  /// </summary>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("remove_interface")]
    public abstract bool RemoveInterface(string name);

  /// <summary>
  ///     Call a function of an interface.
  /// </summary>
  /// <param name="@interface">Lua name: interface</param>
  /// <param name="function">Lua name: function</param>
  [FactorioRconMethod("call")]
    public abstract Any? Call(string @interface, string function);
}
