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
/// A prototype of a fluidbox owned by some <see cref="LuaEntityPrototype" />.
/// </summary>
[FactorioRconClass("LuaFluidBoxPrototype")]
public class LuaFluidBoxPrototype
{
  /// <summary>
  /// The entity that this belongs to.
  /// </summary>
  [FactorioRconAttribute("entity")]
  public LuaEntityPrototype Entity { get; private set; }

  /// <summary>
  /// The index of this fluidbox prototype in the owning entity.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; private set; }

  /// <summary>
  /// The pipe connection points.
  /// </summary>
  [FactorioRconAttribute("pipe_connections")]
  public FluidBoxConnection[] PipeConnections { get; private set; }

  /// <summary>
  /// The production type.
  /// </summary>
  [FactorioRconAttribute("production_type")]
  public OneOf<Literal20304321, Literal23737571, Literal28726945, Literal66394946> ProductionType { get; private set; }

  [FactorioRconAttribute("base_area")]
  public double BaseArea { get; private set; }

  [FactorioRconAttribute("base_level")]
  public float BaseLevel { get; private set; }

  [FactorioRconAttribute("height")]
  public double Height { get; private set; }

  [FactorioRconAttribute("volume")]
  public double Volume { get; private set; }

  /// <summary>
  /// The filter, if any is set.
  /// </summary>
  [FactorioRconAttribute("filter")]
  public LuaFluidPrototype Filter { get; private set; }

  /// <summary>
  /// The minimum temperature, if any is set.
  /// </summary>
  [FactorioRconAttribute("minimum_temperature")]
  public double MinimumTemperature { get; private set; }

  /// <summary>
  /// The maximum temperature, if any is set.
  /// </summary>
  [FactorioRconAttribute("maximum_temperature")]
  public double MaximumTemperature { get; private set; }

  /// <summary>
  /// The secondary draw orders for the 4 possible connection directions.
  /// </summary>
  [FactorioRconAttribute("secondary_draw_orders")]
  public int[] SecondaryDrawOrders { get; private set; }

  /// <summary>
  /// The render layer.
  /// </summary>
  [FactorioRconAttribute("render_layer")]
  public string RenderLayer { get; private set; }

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

/// <summary>
/// Literal value: input
/// </summary>
public class Literal20304321
{
  /// <summary>
  /// Literal value: input
  /// </summary>
  [FactorioRconAttribute("input")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: input-output
/// </summary>
public class Literal23737571
{
  /// <summary>
  /// Literal value: input-output
  /// </summary>
  [FactorioRconAttribute("input-output")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: output
/// </summary>
public class Literal28726945
{
  /// <summary>
  /// Literal value: output
  /// </summary>
  [FactorioRconAttribute("output")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: none
/// </summary>
public class Literal66394946
{
  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconAttribute("none")]
  public static object Value { get; private set; }

}

