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
/// An abstract base class for behaviors that support switching the entity on or off based on some condition.
/// </summary>
[FactorioRconClass("LuaGenericOnOffControlBehavior")]
public class LuaGenericOnOffControlBehavior
{
  /// <summary>
  /// If the entity is currently disabled because of the control behavior.
  /// </summary>
  [FactorioRconAttribute("disabled")]
  public bool Disabled { get; private set; }

  /// <summary>
  /// The circuit condition. Writing `nil` clears the circuit condition.
  /// </summary>
  [FactorioRconAttribute("circuit_condition")]
  public CircuitConditionDefinition CircuitCondition { get; set; }

  /// <summary>
  /// The logistic condition. Writing `nil` clears the logistic condition.
  /// </summary>
  [FactorioRconAttribute("logistic_condition")]
  public CircuitConditionDefinition LogisticCondition { get; set; }

  /// <summary>
  /// `true` if this should connect to the logistic network.
  /// </summary>
  [FactorioRconAttribute("connect_to_logistic_network")]
  public bool ConnectToLogisticNetwork { get; set; }

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
  public string Help() => throw FactorioModelUtils.UseClientReadAsyncMethod();

}

