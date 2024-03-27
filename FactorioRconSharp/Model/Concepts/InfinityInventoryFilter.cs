#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

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
  public Literals319035694 Mode { get; set; }

  /// <summary>
  /// The index of this filter in the filters list. Not required when writing a filter.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

}

