#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("control_behavior")]
public enum ControlBehaviorEnum
{
}

[FactorioRconDefinition("control_behavior.inserter")]
public enum ControlBehaviorInserterEnum
{
}

[FactorioRconDefinition("control_behavior.inserter.circuit_mode_of_operation")]
public enum ControlBehaviorInserterCircuitModeOfOperationEnum
{
  [FactorioRconDefinitionValue("none")]
  None,

  [FactorioRconDefinitionValue("enable_disable")]
  EnableDisable,

  [FactorioRconDefinitionValue("set_filters")]
  SetFilters,

  [FactorioRconDefinitionValue("read_hand_contents")]
  ReadHandContents,

  [FactorioRconDefinitionValue("set_stack_size")]
  SetStackSize,

}

[FactorioRconDefinition("control_behavior.inserter.hand_read_mode")]
public enum ControlBehaviorInserterHandReadModeEnum
{
  [FactorioRconDefinitionValue("hold")]
  Hold,

  [FactorioRconDefinitionValue("pulse")]
  Pulse,

}

[FactorioRconDefinition("control_behavior.lamp")]
public enum ControlBehaviorLampEnum
{
}

[FactorioRconDefinition("control_behavior.lamp.circuit_mode_of_operation")]
public enum ControlBehaviorLampCircuitModeOfOperationEnum
{
  [FactorioRconDefinitionValue("use_colors")]
  UseColors,

}

[FactorioRconDefinition("control_behavior.logistic_container")]
public enum ControlBehaviorLogisticContainerEnum
{
}

[FactorioRconDefinition("control_behavior.logistic_container.circuit_mode_of_operation")]
public enum ControlBehaviorLogisticContainerCircuitModeOfOperationEnum
{
  [FactorioRconDefinitionValue("send_contents")]
  SendContents,

  [FactorioRconDefinitionValue("set_requests")]
  SetRequests,

}

[FactorioRconDefinition("control_behavior.mining_drill")]
public enum ControlBehaviorMiningDrillEnum
{
}

[FactorioRconDefinition("control_behavior.mining_drill.resource_read_mode")]
public enum ControlBehaviorMiningDrillResourceReadModeEnum
{
  [FactorioRconDefinitionValue("this_miner")]
  ThisMiner,

  [FactorioRconDefinitionValue("entire_patch")]
  EntirePatch,

}

[FactorioRconDefinition("control_behavior.transport_belt")]
public enum ControlBehaviorTransportBeltEnum
{
}

[FactorioRconDefinition("control_behavior.transport_belt.content_read_mode")]
public enum ControlBehaviorTransportBeltContentReadModeEnum
{
  [FactorioRconDefinitionValue("pulse")]
  Pulse,

  [FactorioRconDefinitionValue("hold")]
  Hold,

}

[FactorioRconDefinition("control_behavior.type")]
public enum ControlBehaviorTypeEnum
{
  /// <summary>
  /// <see cref="LuaContainerControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("container")]
  Container,

  /// <summary>
  /// <see cref="LuaGenericOnOffControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("generic_on_off")]
  GenericOnOff,

  /// <summary>
  /// <see cref="LuaInserterControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("inserter")]
  Inserter,

  /// <summary>
  /// <see cref="LuaLampControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("lamp")]
  Lamp,

  /// <summary>
  /// <see cref="LuaLogisticContainerControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("logistic_container")]
  LogisticContainer,

  /// <summary>
  /// <see cref="LuaRoboportControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("roboport")]
  Roboport,

  /// <summary>
  /// <see cref="LuaStorageTankControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("storage_tank")]
  StorageTank,

  /// <summary>
  /// <see cref="LuaTrainStopControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("train_stop")]
  TrainStop,

  /// <summary>
  /// <see cref="LuaDeciderCombinatorControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("decider_combinator")]
  DeciderCombinator,

  /// <summary>
  /// <see cref="LuaArithmeticCombinatorControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("arithmetic_combinator")]
  ArithmeticCombinator,

  /// <summary>
  /// <see cref="LuaConstantCombinatorControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("constant_combinator")]
  ConstantCombinator,

  /// <summary>
  /// <see cref="LuaTransportBeltControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("transport_belt")]
  TransportBelt,

  /// <summary>
  /// <see cref="LuaAccumulatorControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("accumulator")]
  Accumulator,

  /// <summary>
  /// <see cref="LuaRailSignalControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("rail_signal")]
  RailSignal,

  /// <summary>
  /// <see cref="LuaRailChainSignalControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("rail_chain_signal")]
  RailChainSignal,

  /// <summary>
  /// <see cref="LuaWallControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("wall")]
  Wall,

  /// <summary>
  /// <see cref="LuaMiningDrillControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("mining_drill")]
  MiningDrill,

  /// <summary>
  /// <see cref="LuaProgrammableSpeakerControlBehavior" />
  /// </summary>
  [FactorioRconDefinitionValue("programmable_speaker")]
  ProgrammableSpeaker,

}

