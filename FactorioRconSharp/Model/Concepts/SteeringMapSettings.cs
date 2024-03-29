#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("SteeringMapSettings")]
public class SteeringMapSettings
{
  [FactorioRconAttribute("default")]
  public SteeringMapSetting Default { get; set; }

  [FactorioRconAttribute("moving")]
  public SteeringMapSetting Moving { get; set; }

}

