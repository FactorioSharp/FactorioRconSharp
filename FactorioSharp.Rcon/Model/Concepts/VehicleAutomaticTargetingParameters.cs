#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("VehicleAutomaticTargetingParameters")]
public class VehicleAutomaticTargetingParameters: IFactorioRconModel
{
  [FactorioRconAttribute("auto_target_without_gunner")]
  public bool AutoTargetWithoutGunner { get; set; }

  [FactorioRconAttribute("auto_target_with_gunner")]
  public bool AutoTargetWithGunner { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

