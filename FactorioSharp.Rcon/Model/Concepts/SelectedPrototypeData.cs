#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("SelectedPrototypeData")]
public class SelectedPrototypeData
{
  /// <summary>
  ///     E.g. `"entity"`.
  /// </summary>
  [FactorioRconAttribute("base_type")]
    public string BaseType { get; set; }

  /// <summary>
  ///     The `type` of the prototype. E.g. `"tree"`.
  /// </summary>
  [FactorioRconAttribute("derived_type")]
    public string DerivedType { get; set; }

  /// <summary>
  ///     The `name` of the prototype. E.g. `"tree-05"`.
  /// </summary>
  [FactorioRconAttribute("name")]
    public string Name { get; set; }
}
