#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ProgrammableSpeakerInstrument")]
public abstract class ProgrammableSpeakerInstrument
{
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("notes")]
  public List<string> Notes { get; set; }

}

public abstract class Table56775157
{
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  [FactorioRconAttribute("notes")]
  public List<string> Notes { get; set; }

}

