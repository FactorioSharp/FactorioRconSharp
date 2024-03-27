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
/// A deterministic random generator independent from the core games random generator that can be seeded and re-seeded at will. This random generator can be saved and loaded and will maintain its state. Note this is entirely different from calling [math.random](libraries.html)() and you should be sure you actually want to use this over calling `math.random()`. If you aren't sure if you need to use this over calling `math.random()` then you probably don't need to use this.
/// </summary>
/// <examples>
/// Create a generator and use it to print a random number. 
/// ```
/// global.generator = game.create_random_generator()
/// game.player.print(global.generator())
/// ```
/// </examples>
[FactorioRconClass("LuaRandomGenerator")]
public abstract class LuaRandomGenerator: LuaObject
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

  // Attribute Call skipped because both getter and setter are inaccessible

  /// <summary>
  /// Re-seeds the random generator with the given value.
  /// </summary>
  /// <remarks>
  /// Seeds that are close together will produce similar results. Seeds from 0 to 341 will produce the same results.
  /// </remarks>
  /// <param name="seed">Lua name: seed</param>
  [FactorioRconMethod("re_seed")]
  public abstract void ReSeed(uint seed);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

