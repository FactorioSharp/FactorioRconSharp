#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("RidingState")]
public class RidingState: IFactorioRconModel
{
  [FactorioRconAttribute("acceleration")]
  public RidingAccelerationEnum Acceleration { get; set; }

  [FactorioRconAttribute("direction")]
  public RidingDirectionEnum Direction { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

