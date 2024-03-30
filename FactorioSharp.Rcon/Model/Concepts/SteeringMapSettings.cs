#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("SteeringMapSettings")]
public class SteeringMapSettings
{
  [FactorioRconAttribute("default")]
  public SteeringMapSetting Default { get; set; }

  [FactorioRconAttribute("moving")]
  public SteeringMapSetting Moving { get; set; }

}

