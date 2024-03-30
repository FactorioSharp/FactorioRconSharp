#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("logistic_mode")]
public enum LogisticModeEnum
{
  [FactorioRconDefinitionValue("none")]
  None,

  [FactorioRconDefinitionValue("active_provider")]
  ActiveProvider,

  [FactorioRconDefinitionValue("storage")]
  Storage,

  [FactorioRconDefinitionValue("requester")]
  Requester,

  [FactorioRconDefinitionValue("passive_provider")]
  PassiveProvider,

  [FactorioRconDefinitionValue("buffer")]
  Buffer,

}

