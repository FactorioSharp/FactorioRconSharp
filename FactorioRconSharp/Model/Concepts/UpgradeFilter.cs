#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("UpgradeFilter")]
public abstract class UpgradeFilter
{
  [FactorioRconAttribute("type")]
  public Literals_7aa5822617ec4df9ad980099663933aa Type { get; set; }

  /// <summary>
  /// Name of the item, or entity.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

