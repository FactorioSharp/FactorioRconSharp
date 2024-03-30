#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ModuleEffects")]
public class ModuleEffects: IFactorioRconModel
{
  [FactorioRconAttribute("consumption")]
  public ModuleEffectValue Consumption { get; set; }

  [FactorioRconAttribute("speed")]
  public ModuleEffectValue Speed { get; set; }

  [FactorioRconAttribute("productivity")]
  public ModuleEffectValue Productivity { get; set; }

  [FactorioRconAttribute("pollution")]
  public ModuleEffectValue Pollution { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

