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
/// A single filter used by an infinity-filters instance.
/// </summary>
[FactorioRconConcept("InfinityInventoryFilter")]
public abstract class InfinityInventoryFilter
{
  /// <summary>
  /// Name of the item.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The count of the filter.
  /// </summary>
  [FactorioRconAttribute("count")]
  public uint Count { get; set; }

  /// <summary>
  /// Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union23558896 Mode { get; set; }

  /// <summary>
  /// The index of this filter in the filters list. Not required when writing a filter.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

}

/// <summary>
/// Union of literals:
///   - at-least
///   - at-most
///   - exactly
/// </summary>
public enum Union23558896
{
  /// <summary>
  /// Literal value: at-least
  /// </summary>
  [FactorioRconDefinitionValue("at-least")]
  AtLeast,

  /// <summary>
  /// Literal value: at-most
  /// </summary>
  [FactorioRconDefinitionValue("at-most")]
  AtMost,

  /// <summary>
  /// Literal value: exactly
  /// </summary>
  [FactorioRconDefinitionValue("exactly")]
  Exactly,

}

