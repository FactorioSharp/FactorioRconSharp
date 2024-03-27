#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("LogisticsNetworkSupplyPoints")]
public abstract class LogisticsNetworkSupplyPoints
{
  [FactorioRconAttribute("storage")]
  public List<LuaLogisticPoint> Storage { get; set; }

  [FactorioRconAttribute("passive-provider")]
  public List<LuaLogisticPoint> Passivesubtractprovider { get; set; }

  [FactorioRconAttribute("buffer")]
  public List<LuaLogisticPoint> Buffer { get; set; }

  [FactorioRconAttribute("active-provider")]
  public List<LuaLogisticPoint> Activesubtractprovider { get; set; }

}

