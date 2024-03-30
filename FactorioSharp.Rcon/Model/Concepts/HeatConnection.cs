#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("HeatConnection")]
public class HeatConnection: IFactorioRconModel
{
  [FactorioRconAttribute("position")]
  public Vector Position { get; set; }

  [FactorioRconAttribute("direction")]
  public DirectionEnum Direction { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

