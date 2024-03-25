#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Concepts;

namespace FactorioRconSharp.Model.Definitions;

/// <summary>
/// AI command exit status. See <see cref="LuaEntity.SetCommand" />
/// </summary>
[FactorioRconDefinition("behavior_result")]
public enum BehaviorResultEnum
{
  [FactorioRconDefinitionValue("in_progress")]
  InProgress,

  [FactorioRconDefinitionValue("fail")]
  Fail,

  [FactorioRconDefinitionValue("success")]
  Success,

  [FactorioRconDefinitionValue("deleted")]
  Deleted,

}

