#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerAlertParameters")]
public abstract class ProgrammableSpeakerAlertParameters
{
  [FactorioRconAttribute("show_alert")]
  public bool ShowAlert { get; set; }

  [FactorioRconAttribute("show_on_map")]
  public bool ShowOnMap { get; set; }

  [FactorioRconAttribute("icon_signal_id")]
  public SignalID IconSignalId { get; set; }

  [FactorioRconAttribute("alert_message")]
  public string AlertMessage { get; set; }

}

public abstract class Table33072896
{
  [FactorioRconAttribute("show_alert")]
  public bool ShowAlert { get; set; }

  [FactorioRconAttribute("show_on_map")]
  public bool ShowOnMap { get; set; }

  [FactorioRconAttribute("icon_signal_id")]
  public SignalID IconSignalId { get; set; }

  [FactorioRconAttribute("alert_message")]
  public string AlertMessage { get; set; }

}

