#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("MapDifficultySettings")]
public abstract class MapDifficultySettings
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
  public Union27614525 ResearchQueueSetting { get; set; }

}

public abstract class Table28721410
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
  public Union27614525 ResearchQueueSetting { get; set; }

}

[GenerateOneOf]
public abstract partial class Union27614525: OneOfBase<Literal62623739, Literal4149120, Literal53215622>
{
}

/// <summary>
/// Literal value: after-victory
/// </summary>
public abstract class Literal62623739
{
  /// <summary>
  /// Literal value: after-victory
  /// </summary>
  [FactorioRconAttribute("after-victory")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: always
/// </summary>
public abstract class Literal4149120
{
  /// <summary>
  /// Literal value: always
  /// </summary>
  [FactorioRconAttribute("always")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: never
/// </summary>
public abstract class Literal53215622
{
  /// <summary>
  /// Literal value: never
  /// </summary>
  [FactorioRconAttribute("never")]
  public static object Value { get; private set; }

}

