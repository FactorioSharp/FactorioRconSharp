#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("AdvancedMapGenSettings")]
public class AdvancedMapGenSettings
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
