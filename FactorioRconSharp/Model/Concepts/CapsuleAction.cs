#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("CapsuleAction")]
public abstract class CapsuleAction
{
  [FactorioRconAttribute("type")]
  public Union6599358 Type { get; set; }

}

public abstract class Table16426255
{
  [FactorioRconAttribute("type")]
  public Union6599358 Type { get; set; }

}

[GenerateOneOf]
public abstract partial class Union6599358: OneOfBase<Literal57163663, Literal47133519, Literal24694787, Literal45060192, Literal31677167>
{
}

/// <summary>
/// Literal value: throw
/// </summary>
public enum Literal57163663
{
  /// <summary>
  /// Literal value: throw
  /// </summary>
  [FactorioRconDefinitionValue("throw")]
  Throw,

}

/// <summary>
/// Literal value: equipment-remote
/// </summary>
public enum Literal47133519
{
  /// <summary>
  /// Literal value: equipment-remote
  /// </summary>
  [FactorioRconDefinitionValue("equipment-remote")]
  EquipmentRemote,

}

/// <summary>
/// Literal value: use-on-self
/// </summary>
public enum Literal24694787
{
  /// <summary>
  /// Literal value: use-on-self
  /// </summary>
  [FactorioRconDefinitionValue("use-on-self")]
  UseOnSelf,

}

/// <summary>
/// Literal value: artillery-remote
/// </summary>
public enum Literal45060192
{
  /// <summary>
  /// Literal value: artillery-remote
  /// </summary>
  [FactorioRconDefinitionValue("artillery-remote")]
  ArtilleryRemote,

}

/// <summary>
/// Literal value: destroy-cliffs
/// </summary>
public enum Literal31677167
{
  /// <summary>
  /// Literal value: destroy-cliffs
  /// </summary>
  [FactorioRconDefinitionValue("destroy-cliffs")]
  DestroyCliffs,

}

