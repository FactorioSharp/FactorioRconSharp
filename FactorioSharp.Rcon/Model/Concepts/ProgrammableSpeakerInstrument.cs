#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerInstrument")]
public class ProgrammableSpeakerInstrument
{
    [FactorioRconAttribute("name")]
    public string Name { get; set; }

    [FactorioRconAttribute("notes")]
    public List<string> Notes { get; set; }
}
