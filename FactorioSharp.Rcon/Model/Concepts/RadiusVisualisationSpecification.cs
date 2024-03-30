#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("RadiusVisualisationSpecification")]
public class RadiusVisualisationSpecification
{
  [FactorioRconAttribute("distance")]
  public double Distance { get; set; }

  [FactorioRconAttribute("offset")]
  public Vector Offset { get; set; }

  [FactorioRconAttribute("draw_in_cursor")]
  public bool DrawInCursor { get; set; }

  [FactorioRconAttribute("draw_on_selection")]
  public bool DrawOnSelection { get; set; }

}

