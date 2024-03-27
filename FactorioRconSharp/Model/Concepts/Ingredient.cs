#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("Ingredient")]
public abstract class Ingredient
{
  [FactorioRconAttribute("type")]
  public Literals524796330 Type { get; set; }

  /// <summary>
  /// Prototype name of the required item or fluid.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// Amount of the item or fluid.
  /// </summary>
  [FactorioRconAttribute("amount")]
  public double Amount { get; set; }

  /// <summary>
  /// How much of this ingredient is a catalyst.
  /// </summary>
  [FactorioRconAttribute("catalyst_amount")]
  public Union2000401922 CatalystAmount { get; set; }

}

