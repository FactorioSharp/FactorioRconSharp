#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("RailEnd")]
public class RailEnd
{
    [FactorioRconAttribute("rail")]
    public LuaEntity Rail { get; set; }

    [FactorioRconAttribute("direction")]
    public RailDirectionEnum Direction { get; set; }
}
