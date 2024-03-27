#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Technology and recipe difficulty settings. Updating any of the attributes will immediately take effect in the game engine.
/// </summary>
[FactorioRconConcept("DifficultySettings")]
public abstract class DifficultySettings
{
  [FactorioRconAttribute("recipe_difficulty")]
  public DifficultySettingsRecipeDifficultyEnum RecipeDifficulty { get; set; }

  [FactorioRconAttribute("technology_difficulty")]
  public DifficultySettingsTechnologyDifficultyEnum TechnologyDifficulty { get; set; }

  /// <summary>
  /// A value in range [0.001, 1000].
  /// </summary>
  [FactorioRconAttribute("technology_price_multiplier")]
  public double TechnologyPriceMultiplier { get; set; }

  /// <summary>
  /// Changing this to `"always"` or `"after-victory"` does not automatically unlock the research queue. See <see cref="LuaForce.ResearchQueueEnabled" /> for that.
  /// </summary>
  [FactorioRconAttribute("research_queue_setting")]
  public Literals_2ba76542c15c4d93ba847cb7005b7705 ResearchQueueSetting { get; set; }

}

