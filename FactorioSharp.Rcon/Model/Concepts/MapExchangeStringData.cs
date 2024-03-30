#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// The data that can be extracted from a map exchange string, as a plain table.
/// </summary>
[FactorioRconConcept("MapExchangeStringData")]
public class MapExchangeStringData
{
  [FactorioRconAttribute("map_settings")]
  public MapAndDifficultySettings MapSettings { get; set; }

  [FactorioRconAttribute("map_gen_settings")]
  public MapGenSettings MapGenSettings { get; set; }

}

