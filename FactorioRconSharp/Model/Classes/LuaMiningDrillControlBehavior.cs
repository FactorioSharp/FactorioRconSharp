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
/// Control behavior for mining drills.
/// </summary>
[FactorioRconClass("LuaMiningDrillControlBehavior")]
public abstract class LuaMiningDrillControlBehavior: LuaObject
{
  /// <summary>
  /// `true` if this drill is enabled or disabled using the logistics or circuit condition.
  /// </summary>
  [FactorioRconAttribute("circuit_enable_disable")]
  public bool CircuitEnableDisable { get; set; }

  /// <summary>
  /// `true` if this drill should send the resources in the field to the circuit network. Which resources depends on <see cref="LuaMiningDrillControlBehavior.ResourceReadMode" />
  /// </summary>
  [FactorioRconAttribute("circuit_read_resources")]
  public bool CircuitReadResources { get; set; }

  /// <summary>
  /// If the mining drill should send just the resources in its area or the entire field it's on to the circuit network.
  /// </summary>
  [FactorioRconAttribute("resource_read_mode")]
  public ControlBehaviorMiningDrillResourceReadModeEnum ResourceReadMode { get; set; }

  /// <summary>
  /// The resource entities that the mining drill will send information about to the circuit network or an empty array.
  /// </summary>
  [FactorioRconAttribute("resource_read_targets")]
  public List<LuaEntity> ResourceReadTargets { get; private set; }

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

