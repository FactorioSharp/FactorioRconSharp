#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("direction")]
public enum DirectionEnum
{
  [FactorioRconDefinitionValue("north")]
  North,

  [FactorioRconDefinitionValue("northeast")]
  Northeast,

  [FactorioRconDefinitionValue("east")]
  East,

  [FactorioRconDefinitionValue("southeast")]
  Southeast,

  [FactorioRconDefinitionValue("south")]
  South,

  [FactorioRconDefinitionValue("southwest")]
  Southwest,

  [FactorioRconDefinitionValue("west")]
  West,

  [FactorioRconDefinitionValue("northwest")]
  Northwest,

}
