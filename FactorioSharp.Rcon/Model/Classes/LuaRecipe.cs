#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
///     A crafting recipe. Recipes belong to forces (see <see cref="LuaForce)" /> because some recipes are unlocked by research, and researches are per-force.
/// </summary>
[FactorioRconClass("LuaRecipe")]
public abstract class LuaRecipe : LuaObject
{
  /// <summary>
  ///     Name of the recipe. This can be different than the name of the result items as there could be more recipes to make the same item.
  /// </summary>
  [FactorioRconAttribute("name")]
    public string Name { get; private set; }

  /// <summary>
  ///     Localised name of the recipe.
  /// </summary>
  [FactorioRconAttribute("localised_name")]
    public LocalisedString LocalisedName { get; private set; }

    [FactorioRconAttribute("localised_description")]
    public LocalisedString LocalisedDescription { get; private set; }

    /// <summary>
    ///     The prototype for this recipe.
    /// </summary>
    [FactorioRconAttribute("prototype")]
    public LuaRecipePrototype Prototype { get; private set; }

    /// <summary>
    ///     Can the recipe be used?
    /// </summary>
    [FactorioRconAttribute("enabled")]
    public bool Enabled { get; set; }

    /// <summary>
    ///     Category of the recipe.
    /// </summary>
    [FactorioRconAttribute("category")]
    public string Category { get; private set; }

    /// <summary>
    ///     The ingredients to this recipe.
    /// </summary>
    [FactorioRconAttribute("ingredients")]
    public List<Ingredient> Ingredients { get; private set; }

    /// <summary>
    ///     The results/products of this recipe.
    /// </summary>
    [FactorioRconAttribute("products")]
    public List<Product> Products { get; private set; }

    /// <summary>
    ///     Is the recipe hidden? Hidden recipe don't show up in the crafting menu.
    /// </summary>
    [FactorioRconAttribute("hidden")]
    public bool Hidden { get; private set; }

    /// <summary>
    ///     Is the recipe hidden from flow statistics?
    /// </summary>
    [FactorioRconAttribute("hidden_from_flow_stats")]
    public bool HiddenFromFlowStats { get; set; }

    /// <summary>
    ///     Energy required to execute this recipe. This directly affects the crafting time: Recipe's energy is exactly its crafting time in seconds, when crafted in an assembling machine
    ///     with crafting speed exactly equal to one.
    /// </summary>
    [FactorioRconAttribute("energy")]
    public double Energy { get; private set; }

    /// <summary>
    ///     The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
    /// </summary>
    [FactorioRconAttribute("order")]
    public string Order { get; private set; }

    /// <summary>
    ///     Group of this recipe.
    /// </summary>
    [FactorioRconAttribute("group")]
    public LuaGroup Group { get; private set; }

    /// <summary>
    ///     Subgroup of this recipe.
    /// </summary>
    [FactorioRconAttribute("subgroup")]
    public LuaGroup Subgroup { get; private set; }

    /// <summary>
    ///     The force that owns this recipe.
    /// </summary>
    [FactorioRconAttribute("force")]
    public LuaForce Force { get; private set; }

    /// <summary>
    ///     Is this object valid? This Lua object holds a reference to an object within the game engine. It is possible that the game-engine object is removed whilst a mod still holds the
    ///     corresponding Lua object. If that happens, the object becomes invalid, i.e. this attribute will be `false`. Mods are advised to check for object validity if any change to the
    ///     game state might have occurred between the creation of the Lua object and its access.
    /// </summary>
    [FactorioRconAttribute("valid")]
    public bool Valid { get; private set; }

    /// <summary>
    ///     The class name of this object. Available even when `valid` is false. For LuaStruct objects it may also be suffixed with a dotted path to a member of the struct.
    /// </summary>
    [FactorioRconAttribute("object_name")]
    public string ObjectName { get; private set; }

    /// <summary>
    ///     Reload the recipe from the prototype.
    /// </summary>
    [FactorioRconMethod("reload")]
    public abstract void Reload();

    /// <summary>
    ///     All methods and properties that this object supports.
    /// </summary>
    [FactorioRconMethod("help")]
    public abstract string Help();
}
