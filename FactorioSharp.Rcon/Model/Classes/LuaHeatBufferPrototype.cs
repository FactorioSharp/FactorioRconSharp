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
/// Prototype of a heat buffer.
/// </summary>
[FactorioRconClass("LuaHeatBufferPrototype")]
public abstract class LuaHeatBufferPrototype: LuaObject
{
  [FactorioRconAttribute("max_temperature")]
  public double MaxTemperature { get; private set; }

  [FactorioRconAttribute("default_temperature")]
  public double DefaultTemperature { get; private set; }

  [FactorioRconAttribute("specific_heat")]
  public double SpecificHeat { get; private set; }

  [FactorioRconAttribute("max_transfer")]
  public double MaxTransfer { get; private set; }

  [FactorioRconAttribute("min_temperature_gradient")]
  public double MinTemperatureGradient { get; private set; }

  [FactorioRconAttribute("min_working_temperature")]
  public double MinWorkingTemperature { get; private set; }

  [FactorioRconAttribute("minimum_glow_temperature")]
  public double MinimumGlowTemperature { get; private set; }

  [FactorioRconAttribute("connections")]
  public List<HeatConnection> Connections { get; private set; }

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

