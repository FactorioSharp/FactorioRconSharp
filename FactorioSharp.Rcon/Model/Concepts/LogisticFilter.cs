#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("LogisticFilter")]
public class LogisticFilter
{
  /// <summary>
  ///     The index this filter applies to.
  /// </summary>
  [FactorioRconAttribute("index")]
    public uint Index { get; set; }

  /// <summary>
  ///     The item name for this filter.
  /// </summary>
  [FactorioRconAttribute("name")]
    public string Name { get; set; }

  /// <summary>
  ///     The count for this filter.
  /// </summary>
  [FactorioRconAttribute("count")]
    public uint Count { get; set; }
}
