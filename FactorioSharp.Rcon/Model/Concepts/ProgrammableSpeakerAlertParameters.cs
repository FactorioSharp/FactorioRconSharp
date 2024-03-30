#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerAlertParameters")]
public class ProgrammableSpeakerAlertParameters
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

