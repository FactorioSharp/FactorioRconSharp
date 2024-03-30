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
/// Specifies how probability and richness are calculated when placing something on the map. Can be specified either using `probability_expression` and `richness_expression` or by using all the other fields.
/// </summary>
[FactorioRconConcept("AutoplaceSpecification")]
public class AutoplaceSpecification
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

