#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CraftingQueueItem")]
public abstract class CraftingQueueItem
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

}

