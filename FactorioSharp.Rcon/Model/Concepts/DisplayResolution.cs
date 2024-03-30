#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("DisplayResolution")]
public class DisplayResolution
{
    [FactorioRconAttribute("width")]
    public uint Width { get; set; }

    [FactorioRconAttribute("height")]
    public uint Height { get; set; }
}
