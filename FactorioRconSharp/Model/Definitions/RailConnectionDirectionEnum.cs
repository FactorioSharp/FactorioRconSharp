#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("rail_connection_direction")]
public enum RailConnectionDirectionEnum
{
  [FactorioRconDefinitionValue("left")]
  Left,

  [FactorioRconDefinitionValue("straight")]
  Straight,

  [FactorioRconDefinitionValue("right")]
  Right,

  [FactorioRconDefinitionValue("none")]
  None,

}
