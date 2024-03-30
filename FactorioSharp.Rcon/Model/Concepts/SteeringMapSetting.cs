#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("SteeringMapSetting")]
public class SteeringMapSetting: IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

