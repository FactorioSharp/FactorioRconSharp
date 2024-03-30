#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("AutoplaceSpecificationRestriction")]
public class AutoplaceSpecificationRestriction
{
  /// <summary>
  ///     Tile prototype name
  /// </summary>
  [FactorioRconAttribute("first")]
    public string First { get; set; }

  /// <summary>
  ///     Second prototype name
  /// </summary>
  [FactorioRconAttribute("second")]
    public string Second { get; set; }
}