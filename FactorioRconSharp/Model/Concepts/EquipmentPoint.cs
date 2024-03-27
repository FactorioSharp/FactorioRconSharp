#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A table used to define a manual shape for a piece of equipment.
/// </summary>
[FactorioRconConcept("EquipmentPoint")]
public abstract class EquipmentPoint
{
  [FactorioRconAttribute("x")]
  public uint X { get; set; }

  [FactorioRconAttribute("y")]
  public uint Y { get; set; }

}

public abstract class Table63785227
{
  [FactorioRconAttribute("x")]
  public uint X { get; set; }

  [FactorioRconAttribute("y")]
  public uint Y { get; set; }

}

