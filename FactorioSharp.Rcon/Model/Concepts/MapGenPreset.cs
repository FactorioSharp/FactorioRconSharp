#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("MapGenPreset")]
public class MapGenPreset: IFactorioRconModel
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

  public void Load(string str) => throw new NotImplementedException();
}

