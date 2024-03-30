#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("DamageTypeFilters")]
public class DamageTypeFilters
{
  /// <summary>
  ///     Whether this is a whitelist or a blacklist of damage types. `true` means whitelist.
  /// </summary>
  [FactorioRconAttribute("whitelist")]
    public bool Whitelist { get; set; }

  /// <summary>
  ///     The damage types to filter for. The value in the dictionary is meaningless and exists just to allow for easy lookup.
  /// </summary>
  [FactorioRconAttribute("types")]
    public Dictionary<string, Literal666164478> Types { get; set; }
}
