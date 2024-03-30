#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

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

