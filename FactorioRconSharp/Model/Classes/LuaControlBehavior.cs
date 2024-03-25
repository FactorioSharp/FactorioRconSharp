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
/// The control behavior for an entity. Inserters have logistic network and circuit network behavior logic, lamps have circuit logic and so on. This is an abstract base class that concrete control behaviors inherit.
/// </summary>
[FactorioRconClass("LuaControlBehavior")]
public class LuaControlBehavior
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
  public LuaCircuitNetwork GetCircuitNetwork(WireTypeEnum wire, CircuitConnectorIdEnum? circuitConnector = null) => throw FactorioModelUtils.UseClientReadAsyncMethod();

}

