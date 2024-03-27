#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

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

