#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ModuleEffectValue")]
public abstract class ModuleEffectValue
{
  /// <summary>
  /// The percentual increase of the attribute. A value of `0.6` means a 60% increase.
  /// </summary>
  [FactorioRconAttribute("bonus")]
  public float Bonus { get; set; }

}

