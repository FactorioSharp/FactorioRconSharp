#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerCircuitParameters")]
public class ProgrammableSpeakerCircuitParameters
{
    [FactorioRconAttribute("signal_value_is_pitch")]
    public bool SignalValueIsPitch { get; set; }

    [FactorioRconAttribute("instrument_id")]
    public uint InstrumentId { get; set; }

    [FactorioRconAttribute("note_id")]
    public uint NoteId { get; set; }
}
