#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// The data that can be extracted from a map exchange string, as a plain table.
/// </summary>
[FactorioRconConcept("MapExchangeStringData")]
public abstract class MapExchangeStringData
{
  [FactorioRconAttribute("map_settings")]
  public MapAndDifficultySettings MapSettings { get; set; }

  [FactorioRconAttribute("map_gen_settings")]
  public MapGenSettings MapGenSettings { get; set; }

}

public abstract class Table3908350
{
  [FactorioRconAttribute("map_settings")]
  public MapAndDifficultySettings MapSettings { get; set; }

  [FactorioRconAttribute("map_gen_settings")]
  public MapGenSettings MapGenSettings { get; set; }

}

