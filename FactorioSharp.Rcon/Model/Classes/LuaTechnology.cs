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
/// One research item.
/// </summary>
[FactorioRconClass("LuaTechnology")]
public abstract class LuaTechnology: LuaObject
{
  /// <summary>
  /// The force this technology belongs to.
  /// </summary>
  [FactorioRconAttribute("force")]
  public LuaForce Force { get; private set; }

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
  /// The prototype of this technology.
  /// </summary>
  [FactorioRconAttribute("prototype")]
  public LuaTechnologyPrototype Prototype { get; private set; }

  /// <summary>
  /// Can this technology be researched?
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; set; }

  /// <summary>
  /// If this technology will be visible in the research GUI even though it is disabled.
  /// </summary>
  [FactorioRconAttribute("visible_when_disabled")]
  public bool VisibleWhenDisabled { get; set; }

  /// <summary>
  /// Is this an upgrade-type research?
  /// </summary>
  [FactorioRconAttribute("upgrade")]
  public bool Upgrade { get; private set; }

  /// <summary>
  /// Has this technology been researched? Switching from `false` to `true` will trigger the technology advancement perks; switching from `true` to `false` will reverse them.
  /// </summary>
  [FactorioRconAttribute("researched")]
  public bool Researched { get; set; }

  /// <summary>
  /// Prerequisites of this technology. The result maps technology name to the <see cref="LuaTechnology" /> object.
  /// </summary>
  [FactorioRconAttribute("prerequisites")]
  public Dictionary<string, LuaTechnology> Prerequisites { get; private set; }

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
  /// The current level of this technology. For level-based technology writing to this is the same as researching the technology to the previous level. Writing the level will set <see cref="LuaTechnology.Enabled" /> to `true`.
  /// </summary>
  [FactorioRconAttribute("level")]
  public uint Level { get; set; }

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
  /// Reload this technology from its prototype.
  /// </summary>
  [FactorioRconMethod("reload")]
  public abstract void Reload();

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

