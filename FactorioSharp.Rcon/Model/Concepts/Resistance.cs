#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Resistance")]
public class Resistance: IFactorioRconModel
{
  /// <summary>
  /// Absolute damage decrease
  /// </summary>
  [FactorioRconAttribute("decrease")]
  public float Decrease { get; set; }

  /// <summary>
  /// Percentual damage decrease
  /// </summary>
  [FactorioRconAttribute("percent")]
  public float Percent { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

