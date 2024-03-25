#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

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

