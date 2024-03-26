#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("TrainStopGoal")]
public abstract class TrainStopGoal
{
  /// <summary>
  /// Train stop target. Must be connected to rail (<see cref="LuaEntity.ConnectedRail)ReturnsValidLuaEntity" />.
  /// </summary>
  [FactorioRconAttribute("train_stop")]
  public LuaEntity TrainStop { get; set; }

}

public abstract class Table48342539
{
  /// <summary>
  /// Train stop target. Must be connected to rail (<see cref="LuaEntity.ConnectedRail)ReturnsValidLuaEntity" />.
  /// </summary>
  [FactorioRconAttribute("train_stop")]
  public LuaEntity TrainStop { get; set; }

}

