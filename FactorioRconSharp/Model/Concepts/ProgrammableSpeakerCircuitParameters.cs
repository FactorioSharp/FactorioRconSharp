#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

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

