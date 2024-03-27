#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("AutoplaceSettings")]
public abstract class AutoplaceSettings
{
  /// <summary>
  /// Whether missing autoplace names for this type should be default enabled.
  /// </summary>
  [FactorioRconAttribute("treat_missing_as_default")]
  public bool TreatMissingAsDefault { get; set; }

  [FactorioRconAttribute("settings")]
  public Dictionary<string, AutoplaceControl> Settings { get; set; }

}

public abstract class Table57503891
{
  /// <summary>
  /// Whether missing autoplace names for this type should be default enabled.
  /// </summary>
  [FactorioRconAttribute("treat_missing_as_default")]
  public bool TreatMissingAsDefault { get; set; }

  [FactorioRconAttribute("settings")]
  public Dictionary<string, AutoplaceControl> Settings { get; set; }

}

