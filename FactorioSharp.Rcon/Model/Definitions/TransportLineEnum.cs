#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("transport_line")]
public enum TransportLineEnum
{
  [FactorioRconDefinitionValue("left_line")]
  LeftLine,

  [FactorioRconDefinitionValue("right_line")]
  RightLine,

  [FactorioRconDefinitionValue("left_underground_line")]
  LeftUndergroundLine,

  [FactorioRconDefinitionValue("right_underground_line")]
  RightUndergroundLine,

  [FactorioRconDefinitionValue("secondary_left_line")]
  SecondaryLeftLine,

  [FactorioRconDefinitionValue("secondary_right_line")]
  SecondaryRightLine,

  [FactorioRconDefinitionValue("left_split_line")]
  LeftSplitLine,

  [FactorioRconDefinitionValue("right_split_line")]
  RightSplitLine,

  [FactorioRconDefinitionValue("secondary_left_split_line")]
  SecondaryLeftSplitLine,

  [FactorioRconDefinitionValue("secondary_right_split_line")]
  SecondaryRightSplitLine,

}

