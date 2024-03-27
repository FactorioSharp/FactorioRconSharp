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
/// An item in a <see cref="LuaEquipmentGrid" />, for example a fusion reactor placed in one's power armor.
/// 
/// An equipment reference becomes invalid once the equipment is removed or the equipment grid it resides in is destroyed.
/// </summary>
[FactorioRconClass("LuaEquipment")]
public abstract class LuaEquipment: LuaObject
{
  /// <summary>
  /// Name of this equipment.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; private set; }

  /// <summary>
  /// Type of this equipment.
  /// </summary>
  [FactorioRconAttribute("type")]
  public string Type { get; private set; }

  /// <summary>
  /// Position of this equipment in the equipment grid.
  /// </summary>
  [FactorioRconAttribute("position")]
  public EquipmentPosition Position { get; private set; }

  /// <summary>
  /// Shape of this equipment.
  /// </summary>
  [FactorioRconAttribute("shape")]
  public Type1947253782 Shape { get; private set; }

  /// <summary>
  /// Current shield value of the equipment.
  /// </summary>
  [FactorioRconAttribute("shield")]
  public double Shield { get; set; }

  /// <summary>
  /// Maximum shield value.
  /// </summary>
  [FactorioRconAttribute("max_shield")]
  public double MaxShield { get; private set; }

  /// <summary>
  /// Maximum solar power generated.
  /// </summary>
  [FactorioRconAttribute("max_solar_power")]
  public double MaxSolarPower { get; private set; }

  /// <summary>
  /// Movement speed bonus.
  /// </summary>
  [FactorioRconAttribute("movement_bonus")]
  public double MovementBonus { get; private set; }

  /// <summary>
  /// Energy generated per tick.
  /// </summary>
  [FactorioRconAttribute("generator_power")]
  public double GeneratorPower { get; private set; }

  /// <summary>
  /// Current available energy.
  /// </summary>
  [FactorioRconAttribute("energy")]
  public double Energy { get; set; }

  /// <summary>
  /// Maximum amount of energy that can be stored in this equipment.
  /// </summary>
  [FactorioRconAttribute("max_energy")]
  public double MaxEnergy { get; private set; }

  [FactorioRconAttribute("prototype")]
  public LuaEquipmentPrototype Prototype { get; private set; }

  /// <summary>
  /// The burner energy source for this equipment, if any.
  /// </summary>
  [FactorioRconAttribute("burner")]
  public LuaBurner Burner { get; private set; }

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

