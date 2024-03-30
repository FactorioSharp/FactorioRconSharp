#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("SelectedPrototypeData")]
public class SelectedPrototypeData: IFactorioRconModel
{
  /// <summary>
  /// E.g. `"entity"`.
  /// </summary>
  [FactorioRconAttribute("base_type")]
  public string BaseType { get; set; }

  /// <summary>
  /// The `type` of the prototype. E.g. `"tree"`.
  /// </summary>
  [FactorioRconAttribute("derived_type")]
  public string DerivedType { get; set; }

  /// <summary>
  /// The `name` of the prototype. E.g. `"tree-05"`.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

