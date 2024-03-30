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
/// Lazily evaluated table. For performance reasons, we sometimes return a custom table-like type instead of a native Lua table. This custom type lazily constructs the necessary Lua wrappers of the corresponding C++ objects, therefore preventing their unnecessary construction in some cases.
/// 
/// There are some notable consequences to the usage of a custom table type rather than the native Lua table type: Iterating a custom table is only possible using the `pairs` Lua function; `ipairs` won't work. Another key difference is that custom tables cannot be serialised into a game save file -- if saving the game would require serialisation of a custom table, an error will be displayed and the game will not be saved.
/// </summary>
/// <examples>
/// <list type="bullet">  <item>In previous versions of Factorio, this would create a <see cref="LuaPlayer" /> instance, no matter how many elements there are in `game.players`. 
/// ```
/// game.players["Oxyd"].character.die()
/// ```</item>  <item>Custom tables may be iterated using `pairs`. 
/// ```
/// for _, p in pairs(game.players) do game.player.print(p.name); end
/// ```</item>  <item>The following will produce no output because `ipairs` is not supported with custom tables. 
/// ```
/// for _, p in ipairs(game.players) do game.player.print(p.name); end  -- incorrect; use pairs instead
/// ```</item>  <item>This statement will execute successfully and `global.p` will be useable as one might expect. However, as soon as the user tries to save the game, a "LuaCustomTable cannot be serialized" error will be shown. The game will remain unsaveable so long as `global.p` refers to an instance of a custom table. 
/// ```
/// global.p = game.players  -- This has high potential to make the game unsaveable
/// ```</item></list>
/// </examples>
[FactorioRconClass("LuaCustomTable")]
public abstract class LuaCustomTable: LuaObject, IFactorioRconModel
{
  /// <summary>
  /// Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the game state might have occurred between the creation of the Lua object and its access.
  /// </summary>
  [FactorioRconAttribute("valid")]
  public bool Valid { get; private set; }

  /// <summary>
  /// The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// Number of elements in this table.
  /// </summary>
  [FactorioRconAttribute("length")]
  public uint Length { get; private set; }

  /// <summary>
  /// Access an element of this custom table.
  /// </summary>
  public abstract Any this[uint key] { get; set; }

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

  public void Load(string str) => throw new NotImplementedException();
}

