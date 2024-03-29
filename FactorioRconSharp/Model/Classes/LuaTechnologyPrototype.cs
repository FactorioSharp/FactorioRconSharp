#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// A Technology prototype.
/// </summary>
[FactorioRconClass("LuaTechnologyPrototype")]
public abstract class LuaTechnologyPrototype: LuaObject
{
  /// <summary>
  /// Name of this technology.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// Localised name of this technology.
  /// </summary>
  [FactorioRconAttribute("localised_name")]
  public LocalisedString LocalisedName { get; private set; }

  [FactorioRconAttribute("localised_description")]
  public LocalisedString LocalisedDescription { get; private set; }

  /// <summary>
  /// If this technology prototype is enabled by default (enabled at the beginning of a game).
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; private set; }

  /// <summary>
  /// If this technology prototype is hidden.
  /// </summary>
  [FactorioRconAttribute("hidden")]
  public bool Hidden { get; private set; }

  /// <summary>
  /// If this technology will be visible in the research GUI even though it is disabled.
  /// </summary>
  [FactorioRconAttribute("visible_when_disabled")]
  public bool VisibleWhenDisabled { get; private set; }

  /// <summary>
  /// If this technology ignores the technology cost multiplier setting.
  /// </summary>
  [FactorioRconAttribute("ignore_tech_cost_multiplier")]
  public bool IgnoreTechCostMultiplier { get; private set; }

  /// <summary>
  /// If the is technology prototype is an upgrade to some other technology.
  /// </summary>
  [FactorioRconAttribute("upgrade")]
  public bool Upgrade { get; private set; }

  /// <summary>
  /// Prerequisites of this technology. The result maps technology name to the <see cref="LuaTechnologyPrototype" /> object.
  /// </summary>
  [FactorioRconAttribute("prerequisites")]
  public Dictionary<string, LuaTechnologyPrototype> Prerequisites { get; private set; }

  /// <summary>
  /// The types of ingredients that labs will require to research this technology.
  /// </summary>
  [FactorioRconAttribute("research_unit_ingredients")]
  public List<Ingredient> ResearchUnitIngredients { get; private set; }

  /// <summary>
  /// Effects applied when this technology is researched.
  /// </summary>
  [FactorioRconAttribute("effects")]
  public List<TechnologyModifier> Effects { get; private set; }

  /// <summary>
  /// The number of research units required for this technology.
  /// </summary>
  [FactorioRconAttribute("research_unit_count")]
  public uint ResearchUnitCount { get; private set; }

  /// <summary>
  /// Amount of energy required to finish a unit of research.
  /// </summary>
  [FactorioRconAttribute("research_unit_energy")]
  public double ResearchUnitEnergy { get; private set; }

  /// <summary>
  /// The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
  public string Order { get; private set; }

  /// <summary>
  /// The level of this research.
  /// </summary>
  [FactorioRconAttribute("level")]
  public uint Level { get; private set; }

  /// <summary>
  /// The max level of this research.
  /// </summary>
  [FactorioRconAttribute("max_level")]
  public uint MaxLevel { get; private set; }

  /// <summary>
  /// The count formula, if this research has any. See [TechnologyUnit::count_formula](prototype:TechnologyUnit::count_formula) for details.
  /// </summary>
  [FactorioRconAttribute("research_unit_count_formula")]
  public string ResearchUnitCountFormula { get; private set; }

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

}

