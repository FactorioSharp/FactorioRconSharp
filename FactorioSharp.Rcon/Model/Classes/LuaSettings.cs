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
/// Object containing mod settings of three distinct types: `startup`, `global`, and `player`. An instance of LuaSettings is available through the global object named `settings`.
/// </summary>
[FactorioRconClass("LuaSettings")]
public abstract class LuaSettings: LuaObject, IFactorioRconModel
{
  /// <summary>
  /// The startup mod settings, indexed by prototype name.
  /// </summary>
  [FactorioRconAttribute("startup")]
  public LuaCustomTable<string, ModSetting> Startup { get; private set; }

  /// <summary>
  /// The current global mod settings, indexed by prototype name.
  /// 
  /// Even though this attribute is marked as read-only, individual settings can be changed by overwriting their <see cref="ModSetting" /> table. Mods can only change their own settings. Using the in-game console, all player settings can be changed.
  /// </summary>
  [FactorioRconAttribute("global")]
  public LuaCustomTable<string, ModSetting> Global { get; private set; }

  /// <summary>
  /// The default player mod settings for this map, indexed by prototype name.
  /// 
  /// Even though this attribute is marked as read-only, individual settings can be changed by overwriting their <see cref="ModSetting" /> table. Mods can only change their own settings. Using the in-game console, all player settings can be changed.
  /// </summary>
  [FactorioRconAttribute("player")]
  public LuaCustomTable<string, ModSetting> Player { get; private set; }

  /// <summary>
  /// This object's name.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// Gets the current per-player settings for the given player, indexed by prototype name. Returns the same structure as <see cref="LuaPlayer.ModSettings" />. This table becomes invalid if its associated player does.
  /// 
  /// Even though this attribute is marked as read-only, individual settings can be changed by overwriting their <see cref="ModSetting" /> table. Mods can only change their own settings. Using the in-game console, all player settings can be changed.
  /// </summary>
  /// <param name="player">Lua name: player</param>
  [FactorioRconMethod("get_player_settings")]
  public abstract LuaCustomTable<string, ModSetting> GetPlayerSettings(PlayerIdentification player);

  public void Load(string str) => throw new NotImplementedException();
}

