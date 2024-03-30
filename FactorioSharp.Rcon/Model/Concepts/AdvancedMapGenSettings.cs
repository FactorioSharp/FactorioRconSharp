#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("AdvancedMapGenSettings")]
public class AdvancedMapGenSettings: IFactorioRconModel
{
  [FactorioRconAttribute("pollution")]
  public PollutionMapSettings Pollution { get; set; }

  [FactorioRconAttribute("enemy_evolution")]
  public EnemyEvolutionMapSettings EnemyEvolution { get; set; }

  [FactorioRconAttribute("enemy_expansion")]
  public EnemyExpansionMapSettings EnemyExpansion { get; set; }

  [FactorioRconAttribute("difficulty_settings")]
  public DifficultySettings DifficultySettings { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

