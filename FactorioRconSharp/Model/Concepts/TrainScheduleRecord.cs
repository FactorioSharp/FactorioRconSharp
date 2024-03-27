#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TrainScheduleRecord")]
public abstract class TrainScheduleRecord
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

public abstract class Table40727441
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

