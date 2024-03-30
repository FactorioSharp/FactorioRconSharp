#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("InventoryFilter")]
public class InventoryFilter
{
  /// <summary>
  ///     Position of the corresponding filter slot.
  /// </summary>
  [FactorioRconAttribute("index")]
    public uint Index { get; set; }

  /// <summary>
  ///     Item prototype name of the item to filter.
  /// </summary>
  [FactorioRconAttribute("name")]
    public string Name { get; set; }
}
