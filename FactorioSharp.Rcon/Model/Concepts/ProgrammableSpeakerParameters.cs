#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerParameters")]
public class ProgrammableSpeakerParameters: IFactorioRconModel
{
  [FactorioRconAttribute("playback_volume")]
  public double PlaybackVolume { get; set; }

  [FactorioRconAttribute("playback_globally")]
  public bool PlaybackGlobally { get; set; }

  [FactorioRconAttribute("allow_polyphony")]
  public bool AllowPolyphony { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

