#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("AdvancedMapGenSettings")]
public abstract class AdvancedMapGenSettings
{
  [FactorioRconAttribute("pollution")]
  public PollutionMapSettings Pollution { get; set; }

  [FactorioRconAttribute("enemy_evolution")]
  public EnemyEvolutionMapSettings EnemyEvolution { get; set; }

  [FactorioRconAttribute("enemy_expansion")]
  public EnemyExpansionMapSettings EnemyExpansion { get; set; }

  [FactorioRconAttribute("difficulty_settings")]
  public DifficultySettings DifficultySettings { get; set; }

}

