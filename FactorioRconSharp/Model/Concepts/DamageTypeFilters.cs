#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("DamageTypeFilters")]
public abstract class DamageTypeFilters
{
  /// <summary>
  /// Whether this is a whitelist or a blacklist of damage types. `true` means whitelist.
  /// </summary>
  [FactorioRconAttribute("whitelist")]
  public bool Whitelist { get; set; }

  /// <summary>
  /// The damage types to filter for. The value in the dictionary is meaningless and exists just to allow for easy lookup.
  /// </summary>
  [FactorioRconAttribute("types")]
  public Dictionary<string, Literal_b36dbe3b10d14af8bea2ec781245305a> Types { get; set; }

}

