#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("wire_type")]
public enum WireTypeEnum
{
  [FactorioRconDefinitionValue("red")]
  Red,

  [FactorioRconDefinitionValue("green")]
  Green,

  [FactorioRconDefinitionValue("copper")]
  Copper,

}

