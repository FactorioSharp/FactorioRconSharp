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
/// Prototype of a fluid energy source.
/// </summary>
[FactorioRconClass("LuaFluidEnergySourcePrototype")]
public abstract class LuaFluidEnergySourcePrototype: LuaObject
{
  /// <summary>
  /// The emissions of this energy source in `pollution/Joule`. Multiplying it by energy consumption in `Watt` gives `pollution/second`.
  /// </summary>
  [FactorioRconAttribute("emissions")]
  public double Emissions { get; private set; }

  [FactorioRconAttribute("render_no_network_icon")]
  public bool RenderNoNetworkIcon { get; private set; }

  [FactorioRconAttribute("render_no_power_icon")]
  public bool RenderNoPowerIcon { get; private set; }

  [FactorioRconAttribute("effectivity")]
  public double Effectivity { get; private set; }

  [FactorioRconAttribute("burns_fluid")]
  public bool BurnsFluid { get; private set; }

  [FactorioRconAttribute("scale_fluid_usage")]
  public bool ScaleFluidUsage { get; private set; }

  [FactorioRconAttribute("destroy_non_fuel_fluid")]
  public bool DestroyNonFuelFluid { get; private set; }

  [FactorioRconAttribute("fluid_usage_per_tick")]
  public double FluidUsagePerTick { get; private set; }

  /// <summary>
  /// The smoke sources for this prototype, if any.
  /// </summary>
  [FactorioRconAttribute("smoke")]
  public List<SmokeSource> Smoke { get; private set; }

  [FactorioRconAttribute("maximum_temperature")]
  public double MaximumTemperature { get; private set; }

  /// <summary>
  /// The fluid box for this energy source.
  /// </summary>
  [FactorioRconAttribute("fluid_box")]
  public LuaFluidBoxPrototype FluidBox { get; private set; }

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

