#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Information about the event that has been raised. The table can also contain other fields depending on the type of event. See <see cref="Events" /> for more information on these.
/// </summary>
[FactorioRconConcept("EventData")]
public abstract class EventData
{
  /// <summary>
  /// The identifier of the event this handler was registered to.
  /// </summary>
  [FactorioRconAttribute("name")]
  public EventsEnum Name { get; set; }

  /// <summary>
  /// The tick during which the event happened.
  /// </summary>
  [FactorioRconAttribute("tick")]
  public uint Tick { get; set; }

  /// <summary>
  /// The name of the mod that raised the event if it was raised using <see cref="LuaBootstrap.RaiseEvent" />.
  /// </summary>
  [FactorioRconAttribute("mod_name")]
  public string ModName { get; set; }

}

public abstract class Table51434360
{
  /// <summary>
  /// The identifier of the event this handler was registered to.
  /// </summary>
  [FactorioRconAttribute("name")]
  public EventsEnum Name { get; set; }

  /// <summary>
  /// The tick during which the event happened.
  /// </summary>
  [FactorioRconAttribute("tick")]
  public uint Tick { get; set; }

  /// <summary>
  /// The name of the mod that raised the event if it was raised using <see cref="LuaBootstrap.RaiseEvent" />.
  /// </summary>
  [FactorioRconAttribute("mod_name")]
  public string ModName { get; set; }

}

