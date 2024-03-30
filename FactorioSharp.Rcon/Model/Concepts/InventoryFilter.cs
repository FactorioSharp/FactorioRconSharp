#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("InventoryFilter")]
public class InventoryFilter: IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

