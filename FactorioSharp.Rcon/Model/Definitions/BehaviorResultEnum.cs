#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Definitions;

/// <summary>
///     AI command exit status. See <see cref="LuaEntity.SetCommand" />
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
    Deleted
}
