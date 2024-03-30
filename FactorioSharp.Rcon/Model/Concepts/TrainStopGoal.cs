#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("TrainStopGoal")]
public class TrainStopGoal: IFactorioRconModel
{
  /// <summary>
  /// Train stop target. Must be connected to rail (<see cref="LuaEntity.ConnectedRail)ReturnsValidLuaEntity" />.
  /// </summary>
  [FactorioRconAttribute("train_stop")]
  public LuaEntity TrainStop { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

