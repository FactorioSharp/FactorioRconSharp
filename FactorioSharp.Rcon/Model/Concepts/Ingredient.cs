#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Ingredient")]
public class Ingredient: IFactorioRconModel
{
  [FactorioRconAttribute("type")]
  public Literals182373934 Type { get; set; }

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
  public Union2037116456 CatalystAmount { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

