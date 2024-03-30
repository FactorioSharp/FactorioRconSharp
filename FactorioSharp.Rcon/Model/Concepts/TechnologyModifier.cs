#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     The effect that is applied when a technology is researched. It is a table that contains at least the field `type`.
/// </summary>
[FactorioRconConcept("TechnologyModifier")]
public class TechnologyModifier
{
  /// <summary>
  ///     Modifier type. Specifies which of the other fields will be available.
  /// </summary>
  [FactorioRconAttribute("type")]
    public ModifierType Type { get; set; }
}
