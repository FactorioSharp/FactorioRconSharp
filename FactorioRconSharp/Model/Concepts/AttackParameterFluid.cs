#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("AttackParameterFluid")]
public abstract class AttackParameterFluid
{
  /// <summary>
  /// Name of the <see cref="LuaFluidPrototype" />.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; set; }

  /// <summary>
  /// Multiplier applied to the damage of an attack.
  /// </summary>
  [FactorioRconAttribute("damage_modifier")]
  public double DamageModifier { get; set; }

}

