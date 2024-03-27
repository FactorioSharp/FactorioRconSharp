#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("MapGenPreset")]
public abstract class MapGenPreset
{
  /// <summary>
  /// The string used to alphabetically sort the presets. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
  public string Order { get; set; }

  /// <summary>
  /// Whether this is the preset that is selected by default.
  /// </summary>
  [FactorioRconAttribute("default")]
  public bool Default { get; set; }

  [FactorioRconAttribute("basic_settings")]
  public MapGenSettings BasicSettings { get; set; }

  [FactorioRconAttribute("advanced_settings")]
  public AdvancedMapGenSettings AdvancedSettings { get; set; }

}

public abstract class Table14966502
{
  /// <summary>
  /// The string used to alphabetically sort the presets. It is a simple string that has no additional semantic meaning.
  /// </summary>
  [FactorioRconAttribute("order")]
  public string Order { get; set; }

  /// <summary>
  /// Whether this is the preset that is selected by default.
  /// </summary>
  [FactorioRconAttribute("default")]
  public bool Default { get; set; }

  [FactorioRconAttribute("basic_settings")]
  public MapGenSettings BasicSettings { get; set; }

  [FactorioRconAttribute("advanced_settings")]
  public AdvancedMapGenSettings AdvancedSettings { get; set; }

}

