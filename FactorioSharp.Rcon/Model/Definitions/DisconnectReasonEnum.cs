#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Definitions;

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

