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
/// An object used to measure script performance.
/// </summary>
[FactorioRconClass("LuaProfiler")]
public abstract class LuaProfiler: LuaObject
{
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
  /// Resets the clock, also restarting it.
  /// </summary>
  [FactorioRconMethod("reset")]
  public abstract void Reset();

  /// <summary>
  /// Stops the clock.
  /// </summary>
  [FactorioRconMethod("stop")]
  public abstract void Stop();

  /// <summary>
  /// Start the clock again, without resetting it.
  /// </summary>
  [FactorioRconMethod("restart")]
  public abstract void Restart();

  /// <summary>
  /// Add the duration of another timer to this timer. Useful to reduce start/stop overhead when accumulating time onto many timers at once.
  /// </summary>
  /// <remarks>
  /// If other is running, the time to now will be added.
  /// </remarks>
  /// <param name="other">Lua name: other</param>
  [FactorioRconMethod("add")]
  public abstract void Add(LuaProfiler other);

  /// <summary>
  /// Divides the current duration by a set value. Useful for calculating the average of many iterations.
  /// </summary>
  /// <remarks>
  /// Does nothing if this isn't stopped.
  /// </remarks>
  /// <param name="number">Lua name: number</param>
  [FactorioRconMethod("divide")]
  public abstract void Divide(double number);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

