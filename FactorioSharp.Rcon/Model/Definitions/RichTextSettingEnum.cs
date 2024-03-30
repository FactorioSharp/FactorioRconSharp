#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("rich_text_setting")]
public enum RichTextSettingEnum
{
    [FactorioRconDefinitionValue("enabled")]
    Enabled,

    [FactorioRconDefinitionValue("disabled")]
    Disabled,

    [FactorioRconDefinitionValue("highlight")]
    Highlight
}
