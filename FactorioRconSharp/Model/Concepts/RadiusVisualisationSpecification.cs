#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("RadiusVisualisationSpecification")]
public abstract class RadiusVisualisationSpecification
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

