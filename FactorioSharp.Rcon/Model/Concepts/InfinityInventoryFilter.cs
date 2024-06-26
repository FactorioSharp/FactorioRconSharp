#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// A single filter used by an infinity-filters instance.
/// </summary>
[FactorioRconConcept("InfinityInventoryFilter")]
public class InfinityInventoryFilter
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
  public Literals1040884443 Mode { get; set; }

  /// <summary>
  /// The index of this filter in the filters list. Not required when writing a filter.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

}

