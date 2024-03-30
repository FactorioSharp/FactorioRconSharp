#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ModuleEffectValue")]
public class ModuleEffectValue
{
  /// <summary>
  /// The percentual increase of the attribute. A value of `0.6` means a 60% increase.
  /// </summary>
  [FactorioRconAttribute("bonus")]
  public float Bonus { get; set; }

}

