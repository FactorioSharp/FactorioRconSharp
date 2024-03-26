#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ConfigurationChangedData")]
public abstract class ConfigurationChangedData
{
  /// <summary>
  /// Old version of the map. Present only when loading map version other than the current version.
  /// </summary>
  [FactorioRconAttribute("old_version")]
  public string OldVersion { get; set; }

  /// <summary>
  /// New version of the map. Present only when loading map version other than the current version.
  /// </summary>
  [FactorioRconAttribute("new_version")]
  public string NewVersion { get; set; }

  /// <summary>
  /// Dictionary of mod changes. It is indexed by mod name.
  /// </summary>
  [FactorioRconAttribute("mod_changes")]
  public Dictionary<string, ModChangeData> ModChanges { get; set; }

  /// <summary>
  /// `true` when mod startup settings have changed since the last time this save was loaded.
  /// </summary>
  [FactorioRconAttribute("mod_startup_settings_changed")]
  public bool ModStartupSettingsChanged { get; set; }

  /// <summary>
  /// `true` when mod prototype migrations have been applied since the last time this save was loaded.
  /// </summary>
  [FactorioRconAttribute("migration_applied")]
  public bool MigrationApplied { get; set; }

}

public abstract class Table49129953
{
  /// <summary>
  /// Old version of the map. Present only when loading map version other than the current version.
  /// </summary>
  [FactorioRconAttribute("old_version")]
  public string OldVersion { get; set; }

  /// <summary>
  /// New version of the map. Present only when loading map version other than the current version.
  /// </summary>
  [FactorioRconAttribute("new_version")]
  public string NewVersion { get; set; }

  /// <summary>
  /// Dictionary of mod changes. It is indexed by mod name.
  /// </summary>
  [FactorioRconAttribute("mod_changes")]
  public Dictionary<string, ModChangeData> ModChanges { get; set; }

  /// <summary>
  /// `true` when mod startup settings have changed since the last time this save was loaded.
  /// </summary>
  [FactorioRconAttribute("mod_startup_settings_changed")]
  public bool ModStartupSettingsChanged { get; set; }

  /// <summary>
  /// `true` when mod prototype migrations have been applied since the last time this save was loaded.
  /// </summary>
  [FactorioRconAttribute("migration_applied")]
  public bool MigrationApplied { get; set; }

}

