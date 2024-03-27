#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconDefinition("ForceCondition")]
public enum ForceCondition
{
  /// <summary>
  /// Literal value: all
  /// </summary>
  [FactorioRconDefinitionValue("all")]
  All,

  /// <summary>
  /// Literal value: enemy
  /// </summary>
  [FactorioRconDefinitionValue("enemy")]
  Enemy,

  /// <summary>
  /// Literal value: ally
  /// </summary>
  [FactorioRconDefinitionValue("ally")]
  Ally,

  /// <summary>
  /// Literal value: friend
  /// </summary>
  [FactorioRconDefinitionValue("friend")]
  Friend,

  /// <summary>
  /// Literal value: not-friend
  /// </summary>
  [FactorioRconDefinitionValue("not-friend")]
  Notsubtractfriend,

  /// <summary>
  /// Literal value: same
  /// </summary>
  [FactorioRconDefinitionValue("same")]
  Same,

  /// <summary>
  /// Literal value: not-same
  /// </summary>
  [FactorioRconDefinitionValue("not-same")]
  Notsubtractsame,

}

