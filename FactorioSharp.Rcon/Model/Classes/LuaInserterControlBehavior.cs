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
/// Control behavior for inserters.
/// </summary>
[FactorioRconClass("LuaInserterControlBehavior")]
public abstract class LuaInserterControlBehavior: LuaGenericOnOffControlBehavior, IFactorioRconModel
{
  /// <summary>
  /// `true` if the contents of the inserter hand should be sent to the circuit network
  /// </summary>
  [FactorioRconAttribute("circuit_read_hand_contents")]
  public bool CircuitReadHandContents { get; set; }

  /// <summary>
  /// The circuit mode of operations for the inserter.
  /// </summary>
  [FactorioRconAttribute("circuit_mode_of_operation")]
  public ControlBehaviorInserterCircuitModeOfOperationEnum CircuitModeOfOperation { get; set; }

  /// <summary>
  /// The hand read mode for the inserter.
  /// </summary>
  [FactorioRconAttribute("circuit_hand_read_mode")]
  public ControlBehaviorInserterHandReadModeEnum CircuitHandReadMode { get; set; }

  /// <summary>
  /// If the stack size of the inserter is set through the circuit network or not.
  /// </summary>
  [FactorioRconAttribute("circuit_set_stack_size")]
  public bool CircuitSetStackSize { get; set; }

  /// <summary>
  /// The signal used to set the stack size of the inserter.
  /// </summary>
  [FactorioRconAttribute("circuit_stack_control_signal")]
  public SignalID CircuitStackControlSignal { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

