#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("relative_gui_position")]
public enum RelativeGuiPositionEnum
{
  [FactorioRconDefinitionValue("top")]
  Top,

  [FactorioRconDefinitionValue("bottom")]
  Bottom,

  [FactorioRconDefinitionValue("left")]
  Left,

  [FactorioRconDefinitionValue("right")]
  Right,

}

