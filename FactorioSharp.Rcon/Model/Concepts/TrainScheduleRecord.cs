#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TrainScheduleRecord")]
public class TrainScheduleRecord
{
  /// <summary>
  /// Name of the station.
  /// </summary>
  [FactorioRconAttribute("station")]
  public string Station { get; set; }

  /// <summary>
  /// Rail to path to. Ignored if `station` is present.
  /// </summary>
  [FactorioRconAttribute("rail")]
  public LuaEntity Rail { get; set; }

  /// <summary>
  /// When a train is allowed to reach rail target from any direction it will be `nil`. If rail has to be reached from specific direction, this value allows to choose the direction. This value corresponds to <see cref="LuaEntity.ConnectedRailDirection" /> of a TrainStop.
  /// </summary>
  [FactorioRconAttribute("rail_direction")]
  public RailDirectionEnum RailDirection { get; set; }

  [FactorioRconAttribute("wait_conditions")]
  public List<WaitCondition> WaitConditions { get; set; }

  /// <summary>
  /// Only present when the station is temporary, the value is then always `true`.
  /// </summary>
  [FactorioRconAttribute("temporary")]
  public bool Temporary { get; set; }

}

