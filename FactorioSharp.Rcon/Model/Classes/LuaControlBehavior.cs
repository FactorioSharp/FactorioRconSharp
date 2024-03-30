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
/// The control behavior for an entity. Inserters have logistic network and circuit network behavior logic, lamps have circuit logic and so on. This is an abstract base class that concrete control behaviors inherit.
/// </summary>
[FactorioRconClass("LuaControlBehavior")]
public abstract class LuaControlBehavior: LuaObject
{
  /// <summary>
  /// The concrete type of this control behavior.
  /// </summary>
  [FactorioRconAttribute("type")]
  public ControlBehaviorTypeEnum Type { get; private set; }

  /// <summary>
  /// The entity this control behavior belongs to.
  /// </summary>
  [FactorioRconAttribute("entity")]
  public LuaEntity Entity { get; private set; }

  /// <param name="wire">Lua name: wire</param>
  /// <param name="circuitConnector">Lua name: circuit_connector</param>
  [FactorioRconMethod("get_circuit_network")]
  public abstract LuaCircuitNetwork GetCircuitNetwork(WireTypeEnum wire, CircuitConnectorIdEnum? circuitConnector = null);

}

