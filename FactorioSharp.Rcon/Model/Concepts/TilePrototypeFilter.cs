#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     Depending on the value of `filter`, the table may take additional fields. `filter` may be one of the following:
/// </summary>
[FactorioRconConcept("TilePrototypeFilter")]
public class TilePrototypeFilter
{
  /// <summary>
  ///     The condition to filter on. One of `"minable"`, `"autoplace"`, `"blueprintable"`, `"item-to-place"`, `"collision-mask"`, `"walking-speed-modifier"`,
  ///     `"vehicle-friction-modifier"`, `"decorative-removal-probability"`, `"emissions"`.
  /// </summary>
  [FactorioRconAttribute("filter")]
    public string Filter { get; set; }

  /// <summary>
  ///     How to combine this with the previous filter. Defaults to `"or"`. When evaluating the filters, `"and"` has higher precedence than `"or"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
    public Literals1643636419 Mode { get; set; }

  /// <summary>
  ///     Inverts the condition. Default is `false`.
  /// </summary>
  [FactorioRconAttribute("invert")]
    public bool Invert { get; set; }
}