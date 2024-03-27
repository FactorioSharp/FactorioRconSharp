#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("SteeringMapSetting")]
public abstract class SteeringMapSetting
{
  /// <summary>
  /// Does not include the radius of the unit.
  /// </summary>
  [FactorioRconAttribute("radius")]
  public double Radius { get; set; }

  [FactorioRconAttribute("separation_factor")]
  public double SeparationFactor { get; set; }

  [FactorioRconAttribute("separation_force")]
  public double SeparationForce { get; set; }

  /// <summary>
  /// Used to make steering look better for aesthetic purposes.
  /// </summary>
  [FactorioRconAttribute("force_unit_fuzzy_goto_behavior")]
  public bool ForceUnitFuzzyGotoBehavior { get; set; }

}

public abstract class Table58903419
{
  /// <summary>
  /// Does not include the radius of the unit.
  /// </summary>
  [FactorioRconAttribute("radius")]
  public double Radius { get; set; }

  [FactorioRconAttribute("separation_factor")]
  public double SeparationFactor { get; set; }

  [FactorioRconAttribute("separation_force")]
  public double SeparationForce { get; set; }

  /// <summary>
  /// Used to make steering look better for aesthetic purposes.
  /// </summary>
  [FactorioRconAttribute("force_unit_fuzzy_goto_behavior")]
  public bool ForceUnitFuzzyGotoBehavior { get; set; }

}

