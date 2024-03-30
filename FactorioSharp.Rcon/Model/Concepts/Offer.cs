#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A single offer on a market entity.
/// </summary>
[FactorioRconConcept("Offer")]
public class Offer
{
  /// <summary>
  ///     List of prices.
  /// </summary>
  [FactorioRconAttribute("price")]
    public List<Ingredient> Price { get; set; }

  /// <summary>
  ///     The action that will take place when a player accepts the offer. Usually a `"give-item"` modifier.
  /// </summary>
  [FactorioRconAttribute("offer")]
    public TechnologyModifier OfferProp { get; set; }
}
