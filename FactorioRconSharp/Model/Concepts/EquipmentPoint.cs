#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A table used to define a manual shape for a piece of equipment.
/// </summary>
[FactorioRconConcept("EquipmentPoint")]
public class EquipmentPoint
{
  [FactorioRconAttribute("x")]
  public uint X { get; set; }

  [FactorioRconAttribute("y")]
  public uint Y { get; set; }

}

