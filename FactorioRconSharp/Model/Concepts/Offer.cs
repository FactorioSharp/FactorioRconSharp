#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A single offer on a market entity.
/// </summary>
[FactorioRconConcept("Offer")]
public abstract class Offer
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

}

