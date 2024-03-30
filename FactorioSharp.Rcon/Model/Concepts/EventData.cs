#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// Information about the event that has been raised. The table can also contain other fields depending on the type of event. See <see cref="Events" /> for more information on these.
/// </summary>
[FactorioRconConcept("EventData")]
public class EventData: IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

