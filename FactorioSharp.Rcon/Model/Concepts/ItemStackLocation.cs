#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Definitions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ItemStackLocation")]
public class ItemStackLocation
{
    [FactorioRconAttribute("inventory")]
    public InventoryEnum Inventory { get; set; }

    [FactorioRconAttribute("slot")]
    public uint Slot { get; set; }
}
