#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("InserterCircuitConditions")]
public class InserterCircuitConditions: IFactorioRconModel
{
  [FactorioRconAttribute("circuit")]
  public CircuitCondition Circuit { get; set; }

  [FactorioRconAttribute("logistics")]
  public CircuitCondition Logistics { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

