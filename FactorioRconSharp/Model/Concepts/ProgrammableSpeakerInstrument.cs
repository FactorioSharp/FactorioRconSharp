#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerInstrument")]
public class ProgrammableSpeakerInstrument
{
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("notes")]
  public List<string> Notes { get; set; }

}

