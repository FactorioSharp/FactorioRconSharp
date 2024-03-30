#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("BeamTarget")]
public class BeamTarget
{
  /// <summary>
  ///     The target entity.
  /// </summary>
  [FactorioRconAttribute("entity")]
    public LuaEntity Entity { get; set; }

  /// <summary>
  ///     The target position.
  /// </summary>
  [FactorioRconAttribute("position")]
    public MapPosition Position { get; set; }
}
