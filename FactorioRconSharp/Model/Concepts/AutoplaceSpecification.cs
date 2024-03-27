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
/// Specifies how probability and richness are calculated when placing something on the map. Can be specified either using `probability_expression` and `richness_expression` or by using all the other fields.
/// </summary>
[FactorioRconConcept("AutoplaceSpecification")]
public abstract class AutoplaceSpecification
{
  [FactorioRconAttribute("probability_expression")]
  public NoiseExpression ProbabilityExpression { get; set; }

  [FactorioRconAttribute("richness_expression")]
  public NoiseExpression RichnessExpression { get; set; }

  [FactorioRconAttribute("coverage")]
  public double Coverage { get; set; }

  [FactorioRconAttribute("sharpness")]
  public double Sharpness { get; set; }

  [FactorioRconAttribute("max_probability")]
  public double MaxProbability { get; set; }

  [FactorioRconAttribute("placement_density")]
  public uint PlacementDensity { get; set; }

  [FactorioRconAttribute("richness_base")]
  public double RichnessBase { get; set; }

  [FactorioRconAttribute("richness_multiplier")]
  public double RichnessMultiplier { get; set; }

  [FactorioRconAttribute("richness_multiplier_distance_bonus")]
  public double RichnessMultiplierDistanceBonus { get; set; }

  [FactorioRconAttribute("starting_area_size")]
  public uint StartingAreaSize { get; set; }

  [FactorioRconAttribute("order")]
  public string Order { get; set; }

  [FactorioRconAttribute("default_enabled")]
  public bool DefaultEnabled { get; set; }

  [FactorioRconAttribute("peaks")]
  public List<AutoplaceSpecificationPeak> Peaks { get; set; }

  /// <summary>
  /// Control prototype name.
  /// </summary>
  [FactorioRconAttribute("control")]
  public string Control { get; set; }

  [FactorioRconAttribute("tile_restriction")]
  public List<AutoplaceSpecificationRestriction> TileRestriction { get; set; }

  [FactorioRconAttribute("force")]
  public string Force { get; set; }

  [FactorioRconAttribute("random_probability_penalty")]
  public double RandomProbabilityPenalty { get; set; }

}

public abstract class Table57000122
{
  [FactorioRconAttribute("probability_expression")]
  public NoiseExpression ProbabilityExpression { get; set; }

  [FactorioRconAttribute("richness_expression")]
  public NoiseExpression RichnessExpression { get; set; }

  [FactorioRconAttribute("coverage")]
  public double Coverage { get; set; }

  [FactorioRconAttribute("sharpness")]
  public double Sharpness { get; set; }

  [FactorioRconAttribute("max_probability")]
  public double MaxProbability { get; set; }

  [FactorioRconAttribute("placement_density")]
  public uint PlacementDensity { get; set; }

  [FactorioRconAttribute("richness_base")]
  public double RichnessBase { get; set; }

  [FactorioRconAttribute("richness_multiplier")]
  public double RichnessMultiplier { get; set; }

  [FactorioRconAttribute("richness_multiplier_distance_bonus")]
  public double RichnessMultiplierDistanceBonus { get; set; }

  [FactorioRconAttribute("starting_area_size")]
  public uint StartingAreaSize { get; set; }

  [FactorioRconAttribute("order")]
  public string Order { get; set; }

  [FactorioRconAttribute("default_enabled")]
  public bool DefaultEnabled { get; set; }

  [FactorioRconAttribute("peaks")]
  public List<AutoplaceSpecificationPeak> Peaks { get; set; }

  /// <summary>
  /// Control prototype name.
  /// </summary>
  [FactorioRconAttribute("control")]
  public string Control { get; set; }

  [FactorioRconAttribute("tile_restriction")]
  public List<AutoplaceSpecificationRestriction> TileRestriction { get; set; }

  [FactorioRconAttribute("force")]
  public string Force { get; set; }

  [FactorioRconAttribute("random_probability_penalty")]
  public double RandomProbabilityPenalty { get; set; }

}

