#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("CircuitConditionDefinition")]
public class CircuitConditionDefinition: IFactorioRconModel
{
  [FactorioRconAttribute("condition")]
  public CircuitCondition Condition { get; set; }

  /// <summary>
  /// Whether the condition is currently fulfilled
  /// </summary>
  [FactorioRconAttribute("fulfilled")]
  public bool Fulfilled { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

