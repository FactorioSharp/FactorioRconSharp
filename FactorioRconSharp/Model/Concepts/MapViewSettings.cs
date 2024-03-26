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
/// What is shown in the map view. If a field is not given, that setting will not be changed.
/// </summary>
[FactorioRconConcept("MapViewSettings")]
public abstract class MapViewSettings
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

public abstract class Table35896081
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

