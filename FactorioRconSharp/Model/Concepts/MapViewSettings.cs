#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// What is shown in the map view. If a field is not given, that setting will not be changed.
/// </summary>
[FactorioRconConcept("MapViewSettings")]
public abstract class MapViewSettings
{
  [FactorioRconAttribute("show-logistic-network")]
  public bool Showsubtractlogisticsubtractnetwork { get; set; }

  [FactorioRconAttribute("show-electric-network")]
  public bool Showsubtractelectricsubtractnetwork { get; set; }

  [FactorioRconAttribute("show-turret-range")]
  public bool Showsubtractturretsubtractrange { get; set; }

  [FactorioRconAttribute("show-pollution")]
  public bool Showsubtractpollution { get; set; }

  [FactorioRconAttribute("show-train-station-names")]
  public bool Showsubtracttrainsubtractstationsubtractnames { get; set; }

  [FactorioRconAttribute("show-player-names")]
  public bool Showsubtractplayersubtractnames { get; set; }

  [FactorioRconAttribute("show-networkless-logistic-members")]
  public bool Showsubtractnetworklesssubtractlogisticsubtractmembers { get; set; }

  [FactorioRconAttribute("show-non-standard-map-info")]
  public bool Showsubtractnonsubtractstandardsubtractmapsubtractinfo { get; set; }

}

