#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

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

