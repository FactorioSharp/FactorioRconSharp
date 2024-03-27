#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ItemStackLocation")]
public abstract class ItemStackLocation
{
  [FactorioRconAttribute("inventory")]
  public InventoryEnum Inventory { get; set; }

  [FactorioRconAttribute("slot")]
  public uint Slot { get; set; }

}

public abstract class Table24802162
{
  [FactorioRconAttribute("inventory")]
  public InventoryEnum Inventory { get; set; }

  [FactorioRconAttribute("slot")]
  public uint Slot { get; set; }

}

