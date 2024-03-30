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
/// What is shown in the map view. If a field is not given, that setting will not be changed.
/// </summary>
[FactorioRconConcept("MapViewSettings")]
public class MapViewSettings
{
  [FactorioRconAttribute("show-logistic-network")]
  public bool ShowLogisticNetwork { get; set; }

  [FactorioRconAttribute("show-electric-network")]
  public bool ShowElectricNetwork { get; set; }

  [FactorioRconAttribute("show-turret-range")]
  public bool ShowTurretRange { get; set; }

  [FactorioRconAttribute("show-pollution")]
  public bool ShowPollution { get; set; }

  [FactorioRconAttribute("show-train-station-names")]
  public bool ShowTrainStationNames { get; set; }

  [FactorioRconAttribute("show-player-names")]
  public bool ShowPlayerNames { get; set; }

  [FactorioRconAttribute("show-networkless-logistic-members")]
  public bool ShowNetworklessLogisticMembers { get; set; }

  [FactorioRconAttribute("show-non-standard-map-info")]
  public bool ShowNonStandardMapInfo { get; set; }

}

