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
public class LogisticsNetworkSupplyPoints
{
  [FactorioRconAttribute("storage")]
  public LuaArray<LuaLogisticPoint> Storage { get; set; }

  [FactorioRconAttribute("passive-provider")]
  public LuaArray<LuaLogisticPoint> PassiveProvider { get; set; }

  [FactorioRconAttribute("buffer")]
  public LuaArray<LuaLogisticPoint> Buffer { get; set; }

  [FactorioRconAttribute("active-provider")]
  public LuaArray<LuaLogisticPoint> ActiveProvider { get; set; }

}

