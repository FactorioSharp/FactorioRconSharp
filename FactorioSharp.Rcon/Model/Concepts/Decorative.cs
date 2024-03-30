#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Decorative")]
public class Decorative
{
  /// <summary>
  ///     The name of the decorative prototype.
  /// </summary>
  [FactorioRconAttribute("name")]
    public string Name { get; set; }

    [FactorioRconAttribute("position")]
    public TilePosition Position { get; set; }

    [FactorioRconAttribute("amount")]
    public byte Amount { get; set; }
}
