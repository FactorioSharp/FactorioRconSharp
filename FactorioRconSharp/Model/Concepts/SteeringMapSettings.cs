#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("SteeringMapSettings")]
public abstract class SteeringMapSettings
{
  [FactorioRconAttribute("default")]
  public SteeringMapSetting Default { get; set; }

  [FactorioRconAttribute("moving")]
  public SteeringMapSetting Moving { get; set; }

}

public abstract class Table30477555
{
  [FactorioRconAttribute("default")]
  public SteeringMapSetting Default { get; set; }

  [FactorioRconAttribute("moving")]
  public SteeringMapSetting Moving { get; set; }

}

