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
/// Depending on the value of `filter`, the table may take additional fields. `filter` may be one of the following:
/// </summary>
[FactorioRconConcept("RecipePrototypeFilter")]
public class RecipePrototypeFilter
{
  /// <summary>
  /// The condition to filter on. One of `"enabled"`, `"hidden"`, `"hidden-from-flow-stats"`, `"hidden-from-player-crafting"`, `"allow-as-intermediate"`, `"allow-intermediates"`, `"allow-decomposition"`, `"always-show-made-in"`, `"always-show-products"`, `"show-amount-in-title"`, `"has-ingredients"`, `"has-products"`, `"has-ingredient-item"`, `"has-ingredient-fluid"`, `"has-product-item"`, `"has-product-fluid"`, `"subgroup"`, `"category"`, `"energy"`, `"emissions-multiplier"`, `"request-paste-multiplier"`, `"overload-multiplier"`.
  /// </summary>
  [FactorioRconAttribute("filter")]
  public string Filter { get; set; }

  /// <summary>
  /// How to combine this with the previous filter. Defaults to `"or"`. When evaluating the filters, `"and"` has higher precedence than `"or"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Literals1753461264 Mode { get; set; }

  /// <summary>
  /// Inverts the condition. Default is `false`.
  /// </summary>
  [FactorioRconAttribute("invert")]
  public bool Invert { get; set; }

}

