#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

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

