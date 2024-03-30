#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ModuleEffectValue")]
public class ModuleEffectValue
{
  /// <summary>
  ///     The percentual increase of the attribute. A value of `0.6` means a 60% increase.
  /// </summary>
  [FactorioRconAttribute("bonus")]
    public float Bonus { get; set; }
}
