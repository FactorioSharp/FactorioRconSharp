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
/// Control behavior for constant combinators.
/// </summary>
[FactorioRconClass("LuaConstantCombinatorControlBehavior")]
public abstract class LuaConstantCombinatorControlBehavior: LuaObject
{
  /// <summary>
  /// This constant combinator's parameters. `nil` if the <see cref="LuaEntityPrototype.ItemSlotCount" /> of the combinator's prototype is `0`.
  /// 
  /// Writing `nil` clears the combinator's parameters.
  /// </summary>
  [FactorioRconAttribute("parameters")]
  public List<ConstantCombinatorParameters> Parameters { get; set; }

  /// <summary>
  /// Turns this constant combinator on and off.
  /// </summary>
  [FactorioRconAttribute("enabled")]
  public bool Enabled { get; set; }

  /// <summary>
  /// The number of signals this constant combinator supports.
  /// </summary>
  [FactorioRconAttribute("signals_count")]
  public uint SignalsCount { get; private set; }

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
  /// Sets the signal at the given index.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  /// <param name="signal">Lua name: signal</param>
  [FactorioRconMethod("set_signal")]
  public abstract void SetSignal(uint index, Signal? signal = null);

  /// <summary>
  /// Gets the signal at the given index. Returned <see cref="Signal" /> will not contain signal if none is set for the index.
  /// </summary>
  /// <param name="index">Lua name: index</param>
  [FactorioRconMethod("get_signal")]
  public abstract Signal GetSignal(uint index);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}
