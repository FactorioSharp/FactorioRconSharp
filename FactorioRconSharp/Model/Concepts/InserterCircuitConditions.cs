#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("InserterCircuitConditions")]
public abstract class InserterCircuitConditions
{
  [FactorioRconAttribute("circuit")]
  public CircuitCondition Circuit { get; set; }

  [FactorioRconAttribute("logistics")]
  public CircuitCondition Logistics { get; set; }

}

