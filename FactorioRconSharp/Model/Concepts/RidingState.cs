#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("RidingState")]
public class RidingState
{
  [FactorioRconAttribute("acceleration")]
  public RidingAccelerationEnum Acceleration { get; set; }

  [FactorioRconAttribute("direction")]
  public RidingDirectionEnum Direction { get; set; }

}

