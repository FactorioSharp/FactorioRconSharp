#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("circuit_condition_index")]
public enum CircuitConditionIndexEnum
{
  [FactorioRconDefinitionValue("inserter_circuit")]
  InserterCircuit,

  [FactorioRconDefinitionValue("inserter_logistic")]
  InserterLogistic,

  [FactorioRconDefinitionValue("lamp")]
  Lamp,

  [FactorioRconDefinitionValue("arithmetic_combinator")]
  ArithmeticCombinator,

  [FactorioRconDefinitionValue("decider_combinator")]
  DeciderCombinator,

  [FactorioRconDefinitionValue("constant_combinator")]
  ConstantCombinator,

  [FactorioRconDefinitionValue("offshore_pump")]
  OffshorePump,

  [FactorioRconDefinitionValue("pump")]
  Pump,

}

