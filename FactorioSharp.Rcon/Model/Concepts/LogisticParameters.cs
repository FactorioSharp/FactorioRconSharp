#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("LogisticParameters")]
public class LogisticParameters
{
  /// <summary>
  ///     The item. `nil` clears the filter.
  /// </summary>
  [FactorioRconAttribute("name")]
    public string Name { get; set; }

  /// <summary>
  ///     Defaults to `0`.
  /// </summary>
  [FactorioRconAttribute("min")]
    public uint Min { get; set; }

  /// <summary>
  ///     Defaults to max uint.
  /// </summary>
  [FactorioRconAttribute("max")]
    public uint Max { get; set; }
}
