#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("HeatConnection")]
public abstract class HeatConnection
{
  [FactorioRconAttribute("position")]
  public Vector Position { get; set; }

  [FactorioRconAttribute("direction")]
  public DirectionEnum Direction { get; set; }

}

