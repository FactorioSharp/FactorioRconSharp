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
/// A prototype of a fluidbox owned by some <see cref="LuaEntityPrototype" />.
/// </summary>
[FactorioRconClass("LuaFluidBoxPrototype")]
public abstract class LuaFluidBoxPrototype: LuaObject, IFactorioRconModel
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
  public List<FluidBoxConnection> PipeConnections { get; private set; }

  /// <summary>
  /// The production type.
  /// </summary>
  [FactorioRconAttribute("production_type")]
  public Literals1983825503 ProductionType { get; private set; }

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
  public List<int> SecondaryDrawOrders { get; private set; }

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
  public abstract string Help();

  public void Load(string str) => throw new NotImplementedException();
}

