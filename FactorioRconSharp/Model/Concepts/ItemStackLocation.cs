#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ItemStackLocation")]
public class ItemStackLocation
{
  [FactorioRconAttribute("inventory")]
  public InventoryEnum Inventory { get; set; }

  [FactorioRconAttribute("slot")]
  public uint Slot { get; set; }

}

