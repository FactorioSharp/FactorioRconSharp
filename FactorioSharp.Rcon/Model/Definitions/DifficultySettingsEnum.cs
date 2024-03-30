#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("difficulty_settings")]
public enum DifficultySettingsEnum
{
}

[FactorioRconDefinition("difficulty_settings.recipe_difficulty")]
public enum DifficultySettingsRecipeDifficultyEnum
{
    [FactorioRconDefinitionValue("normal")]
    Normal,

    [FactorioRconDefinitionValue("expensive")]
    Expensive
}

[FactorioRconDefinition("difficulty_settings.technology_difficulty")]
public enum DifficultySettingsTechnologyDifficultyEnum
{
    [FactorioRconDefinitionValue("normal")]
    Normal,

    [FactorioRconDefinitionValue("expensive")]
    Expensive
}
