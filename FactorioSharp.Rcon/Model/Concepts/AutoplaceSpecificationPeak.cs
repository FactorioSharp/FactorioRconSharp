#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("AutoplaceSpecificationPeak")]
public class AutoplaceSpecificationPeak: IFactorioRconModel
{
  [FactorioRconAttribute("influence")]
  public double Influence { get; set; }

  [FactorioRconAttribute("max_influence")]
  public double MaxInfluence { get; set; }

  [FactorioRconAttribute("min_influence")]
  public double MinInfluence { get; set; }

  [FactorioRconAttribute("richness_influence")]
  public double RichnessInfluence { get; set; }

  [FactorioRconAttribute("noisePersistence")]
  public double NoisePersistence { get; set; }

  /// <summary>
  /// Prototype name of the noise layer.
  /// </summary>
  [FactorioRconAttribute("noise_layer")]
  public string NoiseLayer { get; set; }

  [FactorioRconAttribute("noise_octaves_difference")]
  public double NoiseOctavesDifference { get; set; }

  [FactorioRconAttribute("water_optimal")]
  public double WaterOptimal { get; set; }

  [FactorioRconAttribute("water_range")]
  public double WaterRange { get; set; }

  [FactorioRconAttribute("water_max_range")]
  public double WaterMaxRange { get; set; }

  [FactorioRconAttribute("water_top_property_limit")]
  public double WaterTopPropertyLimit { get; set; }

  [FactorioRconAttribute("elevation_optimal")]
  public double ElevationOptimal { get; set; }

  [FactorioRconAttribute("elevation_range")]
  public double ElevationRange { get; set; }

  [FactorioRconAttribute("elevation_max_range")]
  public double ElevationMaxRange { get; set; }

  [FactorioRconAttribute("elevation_top_property_limit")]
  public double ElevationTopPropertyLimit { get; set; }

  [FactorioRconAttribute("temperature_optimal")]
  public double TemperatureOptimal { get; set; }

  [FactorioRconAttribute("temperature_range")]
  public double TemperatureRange { get; set; }

  [FactorioRconAttribute("temperature_max_range")]
  public double TemperatureMaxRange { get; set; }

  [FactorioRconAttribute("temperature_top_property_limit")]
  public double TemperatureTopPropertyLimit { get; set; }

  [FactorioRconAttribute("starting_area_weight_optimal")]
  public double StartingAreaWeightOptimal { get; set; }

  [FactorioRconAttribute("starting_area_weight_range")]
  public double StartingAreaWeightRange { get; set; }

  [FactorioRconAttribute("starting_area_weight_max_range")]
  public double StartingAreaWeightMaxRange { get; set; }

  [FactorioRconAttribute("starting_area_weight_top_property_limit")]
  public double StartingAreaWeightTopPropertyLimit { get; set; }

  [FactorioRconAttribute("tier_from_start_optimal")]
  public double TierFromStartOptimal { get; set; }

  [FactorioRconAttribute("tier_from_start_range")]
  public double TierFromStartRange { get; set; }

  [FactorioRconAttribute("tier_from_start_max_range")]
  public double TierFromStartMaxRange { get; set; }

  [FactorioRconAttribute("tier_from_start_top_property_limit")]
  public double TierFromStartTopPropertyLimit { get; set; }

  [FactorioRconAttribute("distance_optimal")]
  public double DistanceOptimal { get; set; }

  [FactorioRconAttribute("distance_range")]
  public double DistanceRange { get; set; }

  [FactorioRconAttribute("distance_max_range")]
  public double DistanceMaxRange { get; set; }

  [FactorioRconAttribute("distance_top_property_limit")]
  public double DistanceTopPropertyLimit { get; set; }

  [FactorioRconAttribute("aux_optimal")]
  public double AuxOptimal { get; set; }

  [FactorioRconAttribute("aux_range")]
  public double AuxRange { get; set; }

  [FactorioRconAttribute("aux_max_range")]
  public double AuxMaxRange { get; set; }

  [FactorioRconAttribute("aux_top_property_limit")]
  public double AuxTopPropertyLimit { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

