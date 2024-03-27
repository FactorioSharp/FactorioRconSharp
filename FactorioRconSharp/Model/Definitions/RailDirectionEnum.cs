#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("rail_direction")]
public enum RailDirectionEnum
{
  [FactorioRconDefinitionValue("front")]
  Front,

  [FactorioRconDefinitionValue("back")]
  Back,

}

