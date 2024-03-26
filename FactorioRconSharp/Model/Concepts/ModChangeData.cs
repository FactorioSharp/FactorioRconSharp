#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ModChangeData")]
public abstract class ModChangeData
{
  /// <summary>
  /// Old version of the mod. May be `nil` if the mod wasn't previously present (i.e. it was just added).
  /// </summary>
  [FactorioRconAttribute("old_version")]
  public string OldVersion { get; set; }

  /// <summary>
  /// New version of the mod. May be `nil` if the mod is no longer present (i.e. it was just removed).
  /// </summary>
  [FactorioRconAttribute("new_version")]
  public string NewVersion { get; set; }

}

public abstract class Table34353393
{
  /// <summary>
  /// Old version of the mod. May be `nil` if the mod wasn't previously present (i.e. it was just added).
  /// </summary>
  [FactorioRconAttribute("old_version")]
  public string OldVersion { get; set; }

  /// <summary>
  /// New version of the mod. May be `nil` if the mod is no longer present (i.e. it was just removed).
  /// </summary>
  [FactorioRconAttribute("new_version")]
  public string NewVersion { get; set; }

}

