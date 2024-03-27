#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// Entry point for registering event handlers. It is accessible through the global object named `script`.
/// </summary>
[FactorioRconClass("LuaBootstrap")]
public abstract class LuaBootstrap: LuaObject
{
  /// <summary>
  /// The name of the mod from the environment this is used in.
  /// </summary>
  [FactorioRconAttribute("mod_name")]
  public string ModName { get; private set; }

  /// <summary>
  /// Information about the currently running scenario/campaign/tutorial.
  /// </summary>
  [FactorioRconAttribute("level")]
  public Table50296974 Level { get; private set; }

  /// <summary>
  /// A dictionary listing the names of all currently active mods and mapping them to their version.
  /// </summary>
  [FactorioRconAttribute("active_mods")]
  public Dictionary<string, string> ActiveMods { get; private set; }

  /// <summary>
  /// This object's name.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// Register a function to be run on mod initialization. This is only called when a new save game is created or when a save file is loaded that previously didn't contain the mod. During it, the mod gets the chance to set up initial values that it will use for its lifetime. It has full access to <see cref="Global" /> table and can change anything about them that it deems appropriate. No other events will be raised for the mod until it has finished this step.
  /// </summary>
  /// <remarks>
  /// For more context, refer to the <see cref="DataLifecycle" /> page.
  /// </remarks>
  /// <param name="handler">Lua name: handler</param>
  [FactorioRconMethod("on_init")]
  public abstract void OnInit(Union67040568 handler);

  /// <summary>
  /// Register a function to be run on save load. This is only called for mods that have been part of the save previously, or for players connecting to a running multiplayer session.
  /// 
  /// It gives the mod the opportunity to rectify potential differences in local state introduced by the save/load cycle. Doing anything other than the following three will lead to desyncs, breaking multiplayer and replay functionality. Access to <see cref="Global" /> table can be accessed and is safe to read from, but not write to, as doing so will lead to an error.
  /// 
  /// The only legitimate uses of this event are these:
  /// - Re-setup [metatables](https://www.lua.org/pil/13.html) as they are not persisted through the save/load cycle.
  /// - Re-setup conditional event handlers, meaning subscribing to an event only when some condition is met to save processing time.
  /// - Create local references to data stored in the <see cref="Global" /> table.
  /// 
  /// For all other purposes, <see cref="Migrations" /> should be used instead.
  /// </summary>
  /// <remarks>
  /// For more context, refer to the <see cref="DataLifecycle" /> page.
  /// </remarks>
  /// <param name="handler">Lua name: handler</param>
  [FactorioRconMethod("on_load")]
  public abstract void OnLoad(Union28708324 handler);

  /// <summary>
  /// Register a function to be run when mod configuration changes. This is called when the game version or any mod version changed, when any mod was added or removed, when a startup setting has changed, when any prototypes have been added or removed, or when a migration was applied. It allows the mod to make any changes it deems appropriate to both the data structures in its <see cref="LuaGameScript" />.
  /// </summary>
  /// <remarks>
  /// For more context, refer to the <see cref="DataLifecycle" /> page.
  /// </remarks>
  /// <param name="handler">Lua name: handler</param>
  [FactorioRconMethod("on_configuration_changed")]
  public abstract void OnConfigurationChanged(Union15198770 handler);

  /// <summary>
  /// Register a handler to run on the specified event(s). Each mod can only register once for every event, as any additional registration will overwrite the previous one. This holds true even if different filters are used for subsequent registrations.
  /// </summary>
  /// <param name="@event">Lua name: event</param>
  /// <param name="handler">Lua name: handler</param>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("on_event")]
  public abstract void OnEvent(Union64229338 @event, Union2065345 handler, EventFilter? filters = null);

  /// <summary>
  /// Register a handler to run every nth-tick(s). When the game is on tick 0 it will trigger all registered handlers.
  /// </summary>
  /// <param name="tick">Lua name: tick</param>
  /// <param name="handler">Lua name: handler</param>
  [FactorioRconMethod("on_nth_tick")]
  public abstract void OnNthTick(Union32738818 tick, Union1779205 handler);

  /// <summary>
  /// Registers an entity so that after it's destroyed, <see cref="OnEntityDestroyed" /> will receive the event when it is destroyed. Registering the same entity multiple times will still only fire the destruction event once, and will return the same registration number.
  /// </summary>
  /// <remarks>
  /// Depending on when a given entity is destroyed, <see cref="OnEntityDestroyed" /> will either be fired at the end of the current tick or at the end of the next tick.
  /// </remarks>
  /// <param name="entity">Lua name: entity</param>
  [FactorioRconMethod("register_on_entity_destroyed")]
  public abstract ulong RegisterOnEntityDestroyed(LuaEntity entity);

  /// <summary>
  /// Register a metatable to have linkage recorded and restored when saving/loading. The metatable itself will not be saved. Instead, only the linkage to a registered metatable is saved, and the metatable registered under that name will be used when loading the table.
  /// </summary>
  /// <remarks>
  /// `register_metatable()` can not be used in the console, in event listeners or during a `remote.call()`.
  /// </remarks>
  /// <param name="name">Lua name: name</param>
  /// <param name="metatable">Lua name: metatable</param>
  [FactorioRconMethod("register_metatable")]
  public abstract void RegisterMetatable(string name, LuaTable metatable);

  /// <summary>
  /// Generate a new, unique event ID that can be used to raise custom events with <see cref="LuaBootstrap.RaiseEvent" />.
  /// </summary>
  [FactorioRconMethod("generate_event_name")]
  public abstract uint GenerateEventName();

  /// <summary>
  /// Find the event handler for an event.
  /// </summary>
  /// <param name="@event">Lua name: event</param>
  [FactorioRconMethod("get_event_handler")]
  public abstract Action<EventData>? GetEventHandler(uint @event);

  /// <summary>
  /// Gets the mod event order as a string.
  /// </summary>
  [FactorioRconMethod("get_event_order")]
  public abstract string GetEventOrder();

  /// <summary>
  /// Sets the filters for the given event. The filters are only retained when set after the actual event registration, because registering for an event with different or no filters will overwrite previously set ones.
  /// </summary>
  /// <param name="@event">Lua name: event</param>
  /// <param name="filters">Lua name: filters</param>
  [FactorioRconMethod("set_event_filter")]
  public abstract void SetEventFilter(uint @event, EventFilter? filters = null);

  /// <summary>
  /// Gets the filters for the given event.
  /// </summary>
  /// <param name="@event">Lua name: event</param>
  [FactorioRconMethod("get_event_filter")]
  public abstract EventFilter? GetEventFilter(uint @event);

  /// <summary>
  /// Gets the prototype history for the given type and name.
  /// </summary>
  /// <param name="type">Lua name: type</param>
  /// <param name="name">Lua name: name</param>
  [FactorioRconMethod("get_prototype_history")]
  public abstract PrototypeHistory GetPrototypeHistory(string type, string name);

  /// <summary>
  /// Raise an event. Only events generated with <see cref="LuaBootstrap.GenerateEventName" /> and the following can be raised:
  /// 
  /// - <see cref="OnConsoleChat" />
  /// - <see cref="OnPlayerCraftedItem" />
  /// - <see cref="OnPlayerFastTransferred" />
  /// - <see cref="OnBiterBaseBuilt" />
  /// - <see cref="OnMarketItemPurchased" />
  /// - <see cref="ScriptRaisedBuilt" />
  /// - <see cref="ScriptRaisedDestroy" />
  /// - <see cref="ScriptRaisedRevive" />
  /// - <see cref="ScriptRaisedTeleported" />
  /// - <see cref="ScriptRaisedSetTiles" />
  /// </summary>
  /// <param name="@event">Lua name: event</param>
  /// <param name="data">Lua name: data</param>
  [FactorioRconMethod("raise_event")]
  public abstract void RaiseEvent(uint @event, LuaTable data);

  /// <param name="playerIndex">Lua name: player_index</param>
  /// <param name="message">Lua name: message</param>
  [FactorioRconMethod("raise_console_chat")]
  public abstract void RaiseConsoleChat(uint playerIndex, string message);

  /// <param name="itemStack">Lua name: item_stack</param>
  /// <param name="playerIndex">Lua name: player_index</param>
  /// <param name="recipe">Lua name: recipe</param>
  [FactorioRconMethod("raise_player_crafted_item")]
  public abstract void RaisePlayerCraftedItem(LuaItemStack itemStack, uint playerIndex, LuaRecipe recipe);

  /// <param name="playerIndex">Lua name: player_index</param>
  /// <param name="entity">Lua name: entity</param>
  /// <param name="fromPlayer">Lua name: from_player</param>
  /// <param name="isSplit">Lua name: is_split</param>
  [FactorioRconMethod("raise_player_fast_transferred")]
  public abstract void RaisePlayerFastTransferred(uint playerIndex, LuaEntity entity, bool fromPlayer, bool isSplit);

  /// <param name="entity">Lua name: entity</param>
  [FactorioRconMethod("raise_biter_base_built")]
  public abstract void RaiseBiterBaseBuilt(LuaEntity entity);

  /// <param name="playerIndex">Lua name: player_index</param>
  /// <param name="market">Lua name: market</param>
  /// <param name="offerIndex">Lua name: offer_index</param>
  /// <param name="count">Lua name: count</param>
  [FactorioRconMethod("raise_market_item_purchased")]
  public abstract void RaiseMarketItemPurchased(uint playerIndex, LuaEntity market, uint offerIndex, uint count);

  /// <param name="entity">Lua name: entity</param>
  [FactorioRconMethod("raise_script_built")]
  public abstract void RaiseScriptBuilt(LuaEntity entity);

  /// <param name="entity">Lua name: entity</param>
  [FactorioRconMethod("raise_script_destroy")]
  public abstract void RaiseScriptDestroy(LuaEntity entity);

  /// <param name="entity">Lua name: entity</param>
  /// <param name="tags">Lua name: tags</param>
  [FactorioRconMethod("raise_script_revive")]
  public abstract void RaiseScriptRevive(LuaEntity entity, Tags? tags = null);

  /// <param name="entity">Lua name: entity</param>
  /// <param name="oldSurfaceIndex">Lua name: old_surface_index</param>
  /// <param name="oldPosition">Lua name: old_position</param>
  [FactorioRconMethod("raise_script_teleported")]
  public abstract void RaiseScriptTeleported(LuaEntity entity, byte oldSurfaceIndex, MapPosition oldPosition);

  /// <param name="surfaceIndex">Lua name: surface_index</param>
  /// <param name="tiles">Lua name: tiles</param>
  [FactorioRconMethod("raise_script_set_tiles")]
  public abstract void RaiseScriptSetTiles(uint surfaceIndex, List<Tile> tiles);

}

