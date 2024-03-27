#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ModuleEffects")]
public abstract class ModuleEffects
{
  [FactorioRconAttribute("consumption")]
  public ModuleEffectValue Consumption { get; set; }

  [FactorioRconAttribute("speed")]
  public ModuleEffectValue Speed { get; set; }

  [FactorioRconAttribute("productivity")]
  public ModuleEffectValue Productivity { get; set; }

  [FactorioRconAttribute("pollution")]
  public ModuleEffectValue Pollution { get; set; }

}

