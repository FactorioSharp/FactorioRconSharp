#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("GunShift4Way")]
public class GunShift4Way: IFactorioRconModel
{
  [FactorioRconAttribute("north")]
  public Vector North { get; set; }

  [FactorioRconAttribute("east")]
  public Vector East { get; set; }

  [FactorioRconAttribute("south")]
  public Vector South { get; set; }

  [FactorioRconAttribute("west")]
  public Vector West { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

