#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// The effect that is applied when a technology is researched. It is a table that contains at least the field `type`.
/// </summary>
[FactorioRconConcept("TechnologyModifier")]
public abstract class TechnologyModifier
{
  /// <summary>
  /// Modifier type. Specifies which of the other fields will be available.
  /// </summary>
  [FactorioRconAttribute("type")]
  public ModifierType Type { get; set; }

}

public abstract class Table20338027
{
  /// <summary>
  /// Modifier type. Specifies which of the other fields will be available.
  /// </summary>
  [FactorioRconAttribute("type")]
  public ModifierType Type { get; set; }

}

