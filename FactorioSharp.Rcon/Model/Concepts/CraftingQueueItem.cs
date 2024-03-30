#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("CraftingQueueItem")]
public class CraftingQueueItem: IFactorioRconModel
{
  /// <summary>
  /// The index of the item in the crafting queue.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

  /// <summary>
  /// The recipe being crafted.
  /// </summary>
  [FactorioRconAttribute("recipe")]
  public string Recipe { get; set; }

  /// <summary>
  /// The amount of items being crafted.
  /// </summary>
  [FactorioRconAttribute("count")]
  public uint Count { get; set; }

  /// <summary>
  /// The item is a prerequisite for another item in the queue.
  /// </summary>
  [FactorioRconAttribute("prerequisite")]
  public bool Prerequisite { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

