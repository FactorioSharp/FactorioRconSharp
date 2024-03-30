#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("LogisticsNetworkSupplyPoints")]
public class LogisticsNetworkSupplyPoints: IFactorioRconModel
{
  [FactorioRconAttribute("storage")]
  public List<LuaLogisticPoint> Storage { get; set; }

  [FactorioRconAttribute("passive-provider")]
  public List<LuaLogisticPoint> PassiveProvider { get; set; }

  [FactorioRconAttribute("buffer")]
  public List<LuaLogisticPoint> Buffer { get; set; }

  [FactorioRconAttribute("active-provider")]
  public List<LuaLogisticPoint> ActiveProvider { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

