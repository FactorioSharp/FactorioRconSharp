#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CircuitConditionDefinition")]
public abstract class CircuitConditionDefinition
{
  [FactorioRconAttribute("condition")]
  public CircuitCondition Condition { get; set; }

  /// <summary>
  /// Whether the condition is currently fulfilled
  /// </summary>
  [FactorioRconAttribute("fulfilled")]
  public bool Fulfilled { get; set; }

}

