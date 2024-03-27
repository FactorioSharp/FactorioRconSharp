#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerParameters")]
public abstract class ProgrammableSpeakerParameters
{
  [FactorioRconAttribute("playback_volume")]
  public double PlaybackVolume { get; set; }

  [FactorioRconAttribute("playback_globally")]
  public bool PlaybackGlobally { get; set; }

  [FactorioRconAttribute("allow_polyphony")]
  public bool AllowPolyphony { get; set; }

}

