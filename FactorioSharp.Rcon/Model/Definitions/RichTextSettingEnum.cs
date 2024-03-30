#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("rich_text_setting")]
public enum RichTextSettingEnum
{
  [FactorioRconDefinitionValue("enabled")]
  Enabled,

  [FactorioRconDefinitionValue("disabled")]
  Disabled,

  [FactorioRconDefinitionValue("highlight")]
  Highlight,

}

