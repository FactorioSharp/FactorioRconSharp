#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TrainStopGoal")]
public class TrainStopGoal
{
  /// <summary>
  ///     Train stop target. Must be connected to rail (<see cref="LuaEntity.ConnectedRail)ReturnsValidLuaEntity" />.
  /// </summary>
  [FactorioRconAttribute("train_stop")]
    public LuaEntity TrainStop { get; set; }
}
