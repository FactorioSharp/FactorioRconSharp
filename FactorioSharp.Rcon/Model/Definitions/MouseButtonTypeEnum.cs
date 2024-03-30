#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("mouse_button_type")]
public enum MouseButtonTypeEnum
{
  [FactorioRconDefinitionValue("none")]
  None,

  [FactorioRconDefinitionValue("left")]
  Left,

  [FactorioRconDefinitionValue("right")]
  Right,

  [FactorioRconDefinitionValue("middle")]
  Middle,

}

