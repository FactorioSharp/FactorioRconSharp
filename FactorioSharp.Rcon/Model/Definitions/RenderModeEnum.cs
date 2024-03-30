#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

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

