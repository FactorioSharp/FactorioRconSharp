#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

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

public abstract class Table23399238
{
  [FactorioRconAttribute("condition")]
  public CircuitCondition Condition { get; set; }

  /// <summary>
  /// Whether the condition is currently fulfilled
  /// </summary>
  [FactorioRconAttribute("fulfilled")]
  public bool Fulfilled { get; set; }

}

