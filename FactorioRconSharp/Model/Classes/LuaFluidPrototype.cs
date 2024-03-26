#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Concepts;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Classes;

/// <summary>
/// Prototype of a fluid.
/// </summary>
[FactorioRconClass("LuaFluidPrototype")]
public abstract class LuaFluidPrototype: LuaObject
{
  /// <summary>
  /// Name of this prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  [FactorioRconAttribute("localised_name")]
  public LocalisedString LocalisedName { get; private set; }

  [FactorioRconAttribute("localised_description")]
  public LocalisedString LocalisedDescription { get; private set; }

  /// <summary>
  /// Default temperature of this fluid.
  /// </summary>
  [FactorioRconAttribute("default_temperature")]
  public double DefaultTemperature { get; private set; }

  /// <summary>
  /// Maximum temperature this fluid can reach.
  /// </summary>
  [FactorioRconAttribute("max_temperature")]
  public double MaxTemperature { get; private set; }

  /// <summary>
  /// The amount of energy in Joules required to heat one unit of this fluid by 1°C.
  /// </summary>
  [FactorioRconAttribute("heat_capacity")]
  public double HeatCapacity { get; private set; }

  /// <summary>
  /// The string used to alphabetically sort these prototypes. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
  public string Order { get; private set; }

  /// <summary>
  /// Group of this prototype.
  /// </summary>
  [FactorioRconAttribute("group")]
  public LuaGroup Group { get; private set; }

  /// <summary>
  /// Subgroup of this prototype.
  /// </summary>
  [FactorioRconAttribute("subgroup")]
  public LuaGroup Subgroup { get; private set; }

  [FactorioRconAttribute("base_color")]
  public Color BaseColor { get; private set; }

  [FactorioRconAttribute("flow_color")]
  public Color FlowColor { get; private set; }

  /// <summary>
  /// The temperature above which this fluid will be shown as gaseous inside tanks and pipes.
  /// </summary>
  [FactorioRconAttribute("gas_temperature")]
  public double GasTemperature { get; private set; }

  /// <summary>
  /// A multiplier on the amount of emissions produced when this fluid is burnt in a generator. A value above `1.0` increases emissions and vice versa. The multiplier can't be negative.
  /// </summary>
  [FactorioRconAttribute("emissions_multiplier")]
  public double EmissionsMultiplier { get; private set; }

  /// <summary>
  /// The amount of energy in Joules one unit of this fluid will produce when burnt in a generator. A value of `0` means this fluid can't be used for energy generation. The value can't be negative.
  /// </summary>
  [FactorioRconAttribute("fuel_value")]
  public double FuelValue { get; private set; }

  /// <summary>
  /// Whether this fluid is hidden from the fluid and signal selectors.
  /// </summary>
  [FactorioRconAttribute("hidden")]
  public bool Hidden { get; private set; }

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

