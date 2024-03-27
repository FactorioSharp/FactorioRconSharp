#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Definitions;

[FactorioRconDefinition("gui_type")]
public enum GuiTypeEnum
{
  [FactorioRconDefinitionValue("none")]
  None,

  [FactorioRconDefinitionValue("entity")]
  Entity,

  [FactorioRconDefinitionValue("research")]
  Research,

  [FactorioRconDefinitionValue("controller")]
  Controller,

  [FactorioRconDefinitionValue("production")]
  Production,

  [FactorioRconDefinitionValue("item")]
  Item,

  [FactorioRconDefinitionValue("bonus")]
  Bonus,

  [FactorioRconDefinitionValue("trains")]
  Trains,

  [FactorioRconDefinitionValue("achievement")]
  Achievement,

  [FactorioRconDefinitionValue("blueprint_library")]
  BlueprintLibrary,

  [FactorioRconDefinitionValue("equipment")]
  Equipment,

  [FactorioRconDefinitionValue("logistic")]
  Logistic,

  [FactorioRconDefinitionValue("other_player")]
  OtherPlayer,

  [FactorioRconDefinitionValue("permissions")]
  Permissions,

  [FactorioRconDefinitionValue("tutorials")]
  Tutorials,

  [FactorioRconDefinitionValue("custom")]
  Custom,

  [FactorioRconDefinitionValue("server_management")]
  ServerManagement,

  [FactorioRconDefinitionValue("player_management")]
  PlayerManagement,

  [FactorioRconDefinitionValue("tile")]
  Tile,

  [FactorioRconDefinitionValue("script_inventory")]
  ScriptInventory,

}

