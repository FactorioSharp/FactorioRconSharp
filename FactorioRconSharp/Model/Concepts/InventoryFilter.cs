#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("InventoryFilter")]
public class InventoryFilter
{
  /// <summary>
  /// Position of the corresponding filter slot.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

  /// <summary>
  /// Item prototype name of the item to filter.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

