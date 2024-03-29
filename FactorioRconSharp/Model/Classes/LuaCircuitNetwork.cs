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
/// A circuit network associated with a given entity, connector, and wire type.
/// </summary>
[FactorioRconClass("LuaCircuitNetwork")]
public abstract class LuaCircuitNetwork: LuaObject
{
  /// <summary>
  /// The entity this circuit network reference is associated with.
  /// </summary>
  [FactorioRconAttribute("entity")]
  public LuaEntity Entity { get; private set; }

  /// <summary>
  /// The wire type this network is associated with.
  /// </summary>
  [FactorioRconAttribute("wire_type")]
  public WireTypeEnum WireType { get; private set; }

  /// <summary>
  /// The circuit connector ID on the associated entity this network was gotten from.
  /// </summary>
  [FactorioRconAttribute("circuit_connector_id")]
  public CircuitConnectorIdEnum CircuitConnectorId { get; private set; }

  /// <summary>
  /// The circuit network signals last tick. `nil` if there were no signals last tick.
  /// </summary>
  [FactorioRconAttribute("signals")]
  public List<Signal> Signals { get; private set; }

  /// <summary>
  /// The circuit networks ID.
  /// </summary>
  [FactorioRconAttribute("network_id")]
  public uint NetworkId { get; private set; }

  /// <summary>
  /// The number of circuits connected to this network.
  /// </summary>
  [FactorioRconAttribute("connected_circuit_count")]
  public uint ConnectedCircuitCount { get; private set; }

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

  /// <param name="signal">Lua name: signal</param>
  [FactorioRconMethod("get_signal")]
  public abstract int GetSignal(SignalID signal);

  /// <summary>
  /// All methods and properties that this object supports.
  /// </summary>
  [FactorioRconMethod("help")]
  public abstract string Help();

}

