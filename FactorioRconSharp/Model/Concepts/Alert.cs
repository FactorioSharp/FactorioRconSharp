#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("Alert")]
public abstract class Alert
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

}

public abstract class Table66313729
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

}

