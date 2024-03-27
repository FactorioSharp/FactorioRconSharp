#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[GenerateOneOf]
[FactorioRconConcept("ForceCondition")]
public abstract partial class ForceCondition: OneOfBase<Literal29782071, Literal21443715, Literal47664838, Literal61437506, Literal15119229, Literal49068367, Literal23802763>
{
}

[GenerateOneOf]
public abstract partial class Union20592155: OneOfBase<Literal29782071, Literal21443715, Literal47664838, Literal61437506, Literal15119229, Literal49068367, Literal23802763>
{
}

/// <summary>
/// Literal value: all
/// </summary>
public enum Literal29782071
{
  /// <summary>
  /// Literal value: all
  /// </summary>
  [FactorioRconDefinitionValue("all")]
  All,

}

/// <summary>
/// Literal value: enemy
/// </summary>
public enum Literal21443715
{
  /// <summary>
  /// Literal value: enemy
  /// </summary>
  [FactorioRconDefinitionValue("enemy")]
  Enemy,

}

/// <summary>
/// Literal value: ally
/// </summary>
public enum Literal47664838
{
  /// <summary>
  /// Literal value: ally
  /// </summary>
  [FactorioRconDefinitionValue("ally")]
  Ally,

}

/// <summary>
/// Literal value: friend
/// </summary>
public enum Literal61437506
{
  /// <summary>
  /// Literal value: friend
  /// </summary>
  [FactorioRconDefinitionValue("friend")]
  Friend,

}

/// <summary>
/// Literal value: not-friend
/// </summary>
public enum Literal15119229
{
  /// <summary>
  /// Literal value: not-friend
  /// </summary>
  [FactorioRconDefinitionValue("not-friend")]
  NotFriend,

}

/// <summary>
/// Literal value: same
/// </summary>
public enum Literal49068367
{
  /// <summary>
  /// Literal value: same
  /// </summary>
  [FactorioRconDefinitionValue("same")]
  Same,

}

/// <summary>
/// Literal value: not-same
/// </summary>
public enum Literal23802763
{
  /// <summary>
  /// Literal value: not-same
  /// </summary>
  [FactorioRconDefinitionValue("not-same")]
  NotSame,

}

