#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("render_mode")]
public enum RenderModeEnum
{
  [FactorioRconDefinitionValue("game")]
  Game,

  [FactorioRconDefinitionValue("chart")]
  Chart,

  [FactorioRconDefinitionValue("chart_zoomed_in")]
  ChartZoomedIn,

}
