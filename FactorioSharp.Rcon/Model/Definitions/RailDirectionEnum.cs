#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("rail_direction")]
public enum RailDirectionEnum
{
  [FactorioRconDefinitionValue("front")]
  Front,

  [FactorioRconDefinitionValue("back")]
  Back,

}

