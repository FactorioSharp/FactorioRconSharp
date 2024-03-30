#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Alert")]
public class Alert: IFactorioRconModel
{
  /// <summary>
  /// The tick this alert was created.
  /// </summary>
  [FactorioRconAttribute("tick")]
  public uint Tick { get; set; }

  [FactorioRconAttribute("target")]
  public LuaEntity Target { get; set; }

  [FactorioRconAttribute("prototype")]
  public LuaEntityPrototype Prototype { get; set; }

  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  /// <summary>
  /// The SignalID used for a custom alert. Only present for custom alerts.
  /// </summary>
  [FactorioRconAttribute("icon")]
  public SignalID Icon { get; set; }

  /// <summary>
  /// The message for a custom alert. Only present for custom alerts.
  /// </summary>
  [FactorioRconAttribute("message")]
  public LocalisedString Message { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

