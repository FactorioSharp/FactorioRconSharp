#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("LogisticsNetworkSupplyPoints")]
public class LogisticsNetworkSupplyPoints
{
    [FactorioRconAttribute("storage")]
    public List<LuaLogisticPoint> Storage { get; set; }

    [FactorioRconAttribute("passive-provider")]
    public List<LuaLogisticPoint> PassiveProvider { get; set; }

    [FactorioRconAttribute("buffer")]
    public List<LuaLogisticPoint> Buffer { get; set; }

    [FactorioRconAttribute("active-provider")]
    public List<LuaLogisticPoint> ActiveProvider { get; set; }
}
