#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("LogisticFilter")]
public class LogisticFilter
{
  /// <summary>
  /// The index this filter applies to.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

  /// <summary>
  /// The item name for this filter.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The count for this filter.
  /// </summary>
  [FactorioRconAttribute("count")]
  public uint Count { get; set; }

}

