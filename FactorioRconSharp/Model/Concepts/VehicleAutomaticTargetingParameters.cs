#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("VehicleAutomaticTargetingParameters")]
public abstract class VehicleAutomaticTargetingParameters
{
  [FactorioRconAttribute("auto_target_without_gunner")]
  public bool AutoTargetWithoutGunner { get; set; }

  [FactorioRconAttribute("auto_target_with_gunner")]
  public bool AutoTargetWithGunner { get; set; }

}

public abstract class Table13782879
{
  [FactorioRconAttribute("auto_target_without_gunner")]
  public bool AutoTargetWithoutGunner { get; set; }

  [FactorioRconAttribute("auto_target_with_gunner")]
  public bool AutoTargetWithGunner { get; set; }

}

