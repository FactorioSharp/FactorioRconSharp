#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("flow_precision_index")]
public enum FlowPrecisionIndexEnum
{
  [FactorioRconDefinitionValue("five_seconds")]
  FiveSeconds,

  [FactorioRconDefinitionValue("one_minute")]
  OneMinute,

  [FactorioRconDefinitionValue("ten_minutes")]
  TenMinutes,

  [FactorioRconDefinitionValue("one_hour")]
  OneHour,

  [FactorioRconDefinitionValue("ten_hours")]
  TenHours,

  [FactorioRconDefinitionValue("fifty_hours")]
  FiftyHours,

  [FactorioRconDefinitionValue("two_hundred_fifty_hours")]
  TwoHundredFiftyHours,

  [FactorioRconDefinitionValue("one_thousand_hours")]
  OneThousandHours,

}

