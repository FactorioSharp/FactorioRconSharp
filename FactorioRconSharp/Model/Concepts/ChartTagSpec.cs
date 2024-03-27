#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("ChartTagSpec")]
public abstract class ChartTagSpec
{
  [FactorioRconAttribute("position")]
  public MapPosition Position { get; set; }

  [FactorioRconAttribute("icon")]
  public SignalID Icon { get; set; }

  [FactorioRconAttribute("text")]
  public string Text { get; set; }

  [FactorioRconAttribute("last_user")]
  public PlayerIdentification LastUser { get; set; }

}

