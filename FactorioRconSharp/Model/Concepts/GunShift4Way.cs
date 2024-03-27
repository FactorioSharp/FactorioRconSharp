#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("GunShift4Way")]
public abstract class GunShift4Way
{
  [FactorioRconAttribute("north")]
  public Vector North { get; set; }

  [FactorioRconAttribute("east")]
  public Vector East { get; set; }

  [FactorioRconAttribute("south")]
  public Vector South { get; set; }

  [FactorioRconAttribute("west")]
  public Vector West { get; set; }

}

