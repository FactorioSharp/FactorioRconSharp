#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
/// A crafting recipe prototype.
/// </summary>
[FactorioRconClass("LuaRecipePrototype")]
public abstract class LuaRecipePrototype: LuaObject, IFactorioRconModel
{
  /// <summary>
  /// If this recipe prototype is enabled by default (enabled at the beginning of a game).
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; private set; }

  /// <summary>
  /// Name of the recipe. This can be different than the name of the result items as there could be more recipes to make the same item.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// Localised name of the recipe.
  /// </summary>
  [FactorioRconAttribute("localised_name")]
  public LocalisedString LocalisedName { get; private set; }

  [FactorioRconAttribute("localised_description")]
  public LocalisedString LocalisedDescription { get; private set; }

  /// <summary>
  /// Category of the recipe.
  /// </summary>
  [FactorioRconAttribute("category")]
  public string Category { get; private set; }

  /// <summary>
  /// The ingredients to this recipe.
  /// </summary>
  [FactorioRconAttribute("ingredients")]
  public List<Ingredient> Ingredients { get; private set; }

  /// <summary>
  /// The results/products of this recipe.
  /// </summary>
  [FactorioRconAttribute("products")]
  public List<Product> Products { get; private set; }

  /// <summary>
  /// The main product of this recipe, if any.
  /// </summary>
  [FactorioRconAttribute("main_product")]
  public Product MainProduct { get; private set; }

  /// <summary>
  /// Is the recipe hidden? Hidden recipe don't show up in the crafting menu.
  /// </summary>
  [FactorioRconAttribute("hidden")]
  public bool Hidden { get; private set; }

  /// <summary>
  /// Is the recipe hidden from flow statistics (item/fluid production statistics)?
  /// </summary>
  [FactorioRconAttribute("hidden_from_flow_stats")]
  public bool HiddenFromFlowStats { get; private set; }

  /// <summary>
  /// Is the recipe hidden from player crafting? The recipe will still show up for selection in machines.
  /// </summary>
  [FactorioRconAttribute("hidden_from_player_crafting")]
  public bool HiddenFromPlayerCrafting { get; private set; }

  /// <summary>
  /// Should this recipe always show "Made in" in the tooltip?
  /// </summary>
  [FactorioRconAttribute("always_show_made_in")]
  public bool AlwaysShowMadeIn { get; private set; }

  /// <summary>
  /// Energy required to execute this recipe. This directly affects the crafting time: Recipe's energy is exactly its crafting time in seconds, when crafted in an assembling machine with crafting speed exactly equal to one.
  /// </summary>
  [FactorioRconAttribute("energy")]
  public double Energy { get; private set; }

  /// <summary>
  /// The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
  public string Order { get; private set; }

  /// <summary>
  /// Group of this recipe.
  /// </summary>
  [FactorioRconAttribute("group")]
  public LuaGroup Group { get; private set; }

  /// <summary>
  /// Subgroup of this recipe.
  /// </summary>
  [FactorioRconAttribute("subgroup")]
  public LuaGroup Subgroup { get; private set; }

  /// <summary>
  /// The multiplier used when this recipe is copied from an assembling machine to a requester chest. For each item in the recipe the item count * this value is set in the requester chest.
  /// </summary>
  [FactorioRconAttribute("request_paste_multiplier")]
  public uint RequestPasteMultiplier { get; private set; }

  /// <summary>
  /// Used to determine how many extra items are put into an assembling machine before it's considered "full enough".
  /// </summary>
  [FactorioRconAttribute("overload_multiplier")]
  public uint OverloadMultiplier { get; private set; }

  /// <summary>
  /// If the recipe is allowed to have the extra inserter overload bonus applied (4 * stack inserter stack size).
  /// </summary>
  [FactorioRconAttribute("allow_inserter_overload")]
  public bool AllowInserterOverload { get; private set; }

  /// <summary>
  /// If this recipe is enabled for the purpose of intermediate hand-crafting.
  /// </summary>
  [FactorioRconAttribute("allow_as_intermediate")]
  public bool AllowAsIntermediate { get; private set; }

  /// <summary>
  /// If this recipe is allowed to use intermediate recipes when hand-crafting.
  /// </summary>
  [FactorioRconAttribute("allow_intermediates")]
  public bool AllowIntermediates { get; private set; }

  /// <summary>
  /// If the amount is shown in the recipe tooltip title when the recipe produces more than 1 product.
  /// </summary>
  [FactorioRconAttribute("show_amount_in_title")]
  public bool ShowAmountInTitle { get; private set; }

  /// <summary>
  /// If the products are always shown in the recipe tooltip.
  /// </summary>
  [FactorioRconAttribute("always_show_products")]
  public bool AlwaysShowProducts { get; private set; }

  /// <summary>
  /// The emissions multiplier for this recipe.
  /// </summary>
  [FactorioRconAttribute("emissions_multiplier")]
  public double EmissionsMultiplier { get; private set; }

  /// <summary>
  /// Is this recipe allowed to be broken down for the recipe tooltip "Total raw" calculations?
  /// </summary>
  [FactorioRconAttribute("allow_decomposition")]
  public bool AllowDecomposition { get; private set; }

  /// <summary>
  /// Is this recipe unlocks the result item(s) so they're shown in filter-select GUIs.
  /// </summary>
  [FactorioRconAttribute("unlock_results")]
  public bool UnlockResults { get; private set; }

  /// <summary>
  /// Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the game state might have occurred between the creation of the Lua object and its access.
  /// </summary>
  [FactorioRconAttribute("valid")]
  public bool Valid { get; private set; }

  /// <summary>
  /// The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
  /// </summary>
  [FactorioRconAttribute("object_name")]
  public string ObjectName { get; private set; }

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

  public void Load(string str) => throw new NotImplementedException();
}

