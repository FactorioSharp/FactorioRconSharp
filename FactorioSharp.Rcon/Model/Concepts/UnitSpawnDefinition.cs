#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("UnitSpawnDefinition")]
public class UnitSpawnDefinition
{
  /// <summary>
  /// Prototype name of the unit that would be spawned.
  /// </summary>
  [FactorioRconAttribute("unit")]
  public string Unit { get; set; }

  /// <summary>
  /// The points at which to spawn the unit.
  /// </summary>
  [FactorioRconAttribute("spawn_points")]
  public List<SpawnPointDefinition> SpawnPoints { get; set; }

}

