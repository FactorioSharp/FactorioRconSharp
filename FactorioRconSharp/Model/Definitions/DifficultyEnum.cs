#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("difficulty")]
public enum DifficultyEnum
{
  [FactorioRconDefinitionValue("easy")]
  Easy,

  [FactorioRconDefinitionValue("normal")]
  Normal,

  [FactorioRconDefinitionValue("hard")]
  Hard,

}

