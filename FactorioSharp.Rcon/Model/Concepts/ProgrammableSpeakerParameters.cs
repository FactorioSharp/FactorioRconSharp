#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerParameters")]
public class ProgrammableSpeakerParameters
{
    [FactorioRconAttribute("playback_volume")]
    public double PlaybackVolume { get; set; }

    [FactorioRconAttribute("playback_globally")]
    public bool PlaybackGlobally { get; set; }

    [FactorioRconAttribute("allow_polyphony")]
    public bool AllowPolyphony { get; set; }
}
