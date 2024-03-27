#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

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

