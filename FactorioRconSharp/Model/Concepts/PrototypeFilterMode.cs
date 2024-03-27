#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// One of the following values:
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("PrototypeFilterMode")]
public abstract partial class PrototypeFilterMode: OneOfBase<Literal65357506, Literal30330347, Literal32957531>
{
}

[GenerateOneOf]
public abstract partial class Union12699242: OneOfBase<Literal65357506, Literal30330347, Literal32957531>
{
}

/// <summary>
/// Literal value: none
/// </summary>
public enum Literal65357506
{
  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconDefinitionValue("none")]
  None,

}

/// <summary>
/// Literal value: whitelist
/// </summary>
public enum Literal30330347
{
  /// <summary>
  /// Literal value: whitelist
  /// </summary>
  [FactorioRconDefinitionValue("whitelist")]
  Whitelist,

}

/// <summary>
/// Literal value: blacklist
/// </summary>
public enum Literal32957531
{
  /// <summary>
  /// Literal value: blacklist
  /// </summary>
  [FactorioRconDefinitionValue("blacklist")]
  Blacklist,

}

