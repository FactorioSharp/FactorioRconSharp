#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

[FactorioRconDefinition("group_state")]
public enum GroupStateEnum
{
  [FactorioRconDefinitionValue("gathering")]
  Gathering,

  [FactorioRconDefinitionValue("moving")]
  Moving,

  [FactorioRconDefinitionValue("attacking_distraction")]
  AttackingDistraction,

  [FactorioRconDefinitionValue("attacking_target")]
  AttackingTarget,

  [FactorioRconDefinitionValue("finished")]
  Finished,

  [FactorioRconDefinitionValue("pathfinding")]
  Pathfinding,

  [FactorioRconDefinitionValue("wander_in_group")]
  WanderInGroup,

}

