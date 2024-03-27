#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerCircuitParameters")]
public abstract class ProgrammableSpeakerCircuitParameters
{
  [FactorioRconAttribute("signal_value_is_pitch")]
  public bool SignalValueIsPitch { get; set; }

  [FactorioRconAttribute("instrument_id")]
  public uint InstrumentId { get; set; }

  [FactorioRconAttribute("note_id")]
  public uint NoteId { get; set; }

}

public abstract class Table45925640
{
  [FactorioRconAttribute("signal_value_is_pitch")]
  public bool SignalValueIsPitch { get; set; }

  [FactorioRconAttribute("instrument_id")]
  public uint InstrumentId { get; set; }

  [FactorioRconAttribute("note_id")]
  public uint NoteId { get; set; }

}

