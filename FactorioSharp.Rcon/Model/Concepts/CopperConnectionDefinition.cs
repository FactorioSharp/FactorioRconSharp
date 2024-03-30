#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("CopperConnectionDefinition")]
public class CopperConnectionDefinition
{
    [FactorioRconAttribute("source_wire_connector")]
    public WireConnectionIdEnum SourceWireConnector { get; set; }

    [FactorioRconAttribute("target_entity")]
    public LuaEntity TargetEntity { get; set; }

    [FactorioRconAttribute("target_wire_connector")]
    public WireConnectionIdEnum TargetWireConnector { get; set; }
}
