#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("RidingState")]
public abstract class RidingState
{
  [FactorioRconAttribute("acceleration")]
  public RidingAccelerationEnum Acceleration { get; set; }

  [FactorioRconAttribute("direction")]
  public RidingDirectionEnum Direction { get; set; }

}

public abstract class Table3081139
{
  [FactorioRconAttribute("acceleration")]
  public RidingAccelerationEnum Acceleration { get; set; }

  [FactorioRconAttribute("direction")]
  public RidingDirectionEnum Direction { get; set; }

}

