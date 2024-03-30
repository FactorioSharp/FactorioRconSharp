#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerInstrument")]
public class ProgrammableSpeakerInstrument
{
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("notes")]
  public List<string> Notes { get; set; }

}

