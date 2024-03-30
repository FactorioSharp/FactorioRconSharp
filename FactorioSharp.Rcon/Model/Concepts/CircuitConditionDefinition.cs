#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("CircuitConditionDefinition")]
public class CircuitConditionDefinition
{
    [FactorioRconAttribute("condition")]
    public CircuitCondition Condition { get; set; }

    /// <summary>
    ///     Whether the condition is currently fulfilled
    /// </summary>
    [FactorioRconAttribute("fulfilled")]
    public bool Fulfilled { get; set; }
}
