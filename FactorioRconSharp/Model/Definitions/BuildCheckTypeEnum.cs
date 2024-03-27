#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("build_check_type")]
public enum BuildCheckTypeEnum
{
  [FactorioRconDefinitionValue("script")]
  Script,

  [FactorioRconDefinitionValue("manual")]
  Manual,

  [FactorioRconDefinitionValue("manual_ghost")]
  ManualGhost,

  [FactorioRconDefinitionValue("script_ghost")]
  ScriptGhost,

  [FactorioRconDefinitionValue("blueprint_ghost")]
  BlueprintGhost,

  [FactorioRconDefinitionValue("ghost_revive")]
  GhostRevive,

}

