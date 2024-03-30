#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Concepts;

namespace FactorioSharp.Rcon.Model.Classes;

/// <summary>
///     Prototype of a burner energy source.
/// </summary>
[FactorioRconClass("LuaBurnerPrototype")]
public abstract class LuaBurnerPrototype : LuaObject
{
  /// <summary>
  ///     The emissions of this energy source in `pollution/Joule`. Multiplying it by energy consumption in `Watt` gives `pollution/second`.
  /// </summary>
  [FactorioRconAttribute("emissions")]
    public double Emissions { get; private set; }

    [FactorioRconAttribute("render_no_network_icon")]
    public bool RenderNoNetworkIcon { get; private set; }

    [FactorioRconAttribute("render_no_power_icon")]
    public bool RenderNoPowerIcon { get; private set; }

    [FactorioRconAttribute("effectivity")]
    public double Effectivity { get; private set; }

    [FactorioRconAttribute("fuel_inventory_size")]
    public uint FuelInventorySize { get; private set; }

    [FactorioRconAttribute("burnt_inventory_size")]
    public uint BurntInventorySize { get; private set; }

    /// <summary>
    ///     The smoke sources for this burner prototype.
    /// </summary>
    [FactorioRconAttribute("smoke")]
    public List<SmokeSource> Smoke { get; private set; }

    /// <summary>
    ///     The light flicker definition for this burner prototype.
    /// </summary>
    [FactorioRconAttribute("light_flicker")]
    public Table716228940 LightFlicker { get; private set; }

    [FactorioRconAttribute("fuel_categories")]
    public Dictionary<string, bool> FuelCategories { get; private set; }

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
    ///     All methods and properties that this object supports.
    /// </summary>
    [FactorioRconMethod("help")]
    public abstract string Help();
}
