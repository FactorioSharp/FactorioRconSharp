#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// A single offer on a market entity.
/// </summary>
[FactorioRconConcept("Offer")]
public class Offer: IFactorioRconModel
{
  /// <summary>
  /// List of prices.
  /// </summary>
  [FactorioRconAttribute("price")]
  public List<Ingredient> Price { get; set; }

  /// <summary>
  /// The action that will take place when a player accepts the offer. Usually a `"give-item"` modifier.
  /// </summary>
  [FactorioRconAttribute("offer")]
  public TechnologyModifier OfferProp { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

