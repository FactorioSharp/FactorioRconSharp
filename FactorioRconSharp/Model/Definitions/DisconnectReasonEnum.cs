#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("disconnect_reason")]
public enum DisconnectReasonEnum
{
  [FactorioRconDefinitionValue("quit")]
  Quit,

  [FactorioRconDefinitionValue("dropped")]
  Dropped,

  [FactorioRconDefinitionValue("reconnect")]
  Reconnect,

  [FactorioRconDefinitionValue("wrong_input")]
  WrongInput,

  [FactorioRconDefinitionValue("desync_limit_reached")]
  DesyncLimitReached,

  [FactorioRconDefinitionValue("cannot_keep_up")]
  CannotKeepUp,

  [FactorioRconDefinitionValue("afk")]
  Afk,

  [FactorioRconDefinitionValue("kicked")]
  Kicked,

  [FactorioRconDefinitionValue("kicked_and_deleted")]
  KickedAndDeleted,

  [FactorioRconDefinitionValue("banned")]
  Banned,

  [FactorioRconDefinitionValue("switching_servers")]
  SwitchingServers,

}

