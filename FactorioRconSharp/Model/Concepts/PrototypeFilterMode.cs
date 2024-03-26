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
public abstract partial class PrototypeFilterMode: OneOfBase<Literal30778096, Literal65047755, Literal57956701>
{
}

[GenerateOneOf]
public abstract partial class Union20783124: OneOfBase<Literal30778096, Literal65047755, Literal57956701>
{
}

/// <summary>
/// Literal value: none
/// </summary>
public abstract class Literal30778096
{
  /// <summary>
  /// Literal value: none
  /// </summary>
  [FactorioRconAttribute("none")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: whitelist
/// </summary>
public abstract class Literal65047755
{
  /// <summary>
  /// Literal value: whitelist
  /// </summary>
  [FactorioRconAttribute("whitelist")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: blacklist
/// </summary>
public abstract class Literal57956701
{
  /// <summary>
  /// Literal value: blacklist
  /// </summary>
  [FactorioRconAttribute("blacklist")]
  public static object Value { get; private set; }

}

