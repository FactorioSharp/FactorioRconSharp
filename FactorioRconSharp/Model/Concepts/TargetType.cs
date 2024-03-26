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
/// Target type of an <see cref="AmmoType" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TargetType")]
public abstract partial class TargetType: OneOfBase<Literal6715097, Literal6799314, Literal8567878>
{
}

[GenerateOneOf]
public abstract partial class Union29080708: OneOfBase<Literal6715097, Literal6799314, Literal8567878>
{
}

/// <summary>
/// Literal value: entity
/// </summary>
public abstract class Literal6715097
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconAttribute("entity")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: position
/// </summary>
public abstract class Literal6799314
{
  /// <summary>
  /// Literal value: position
  /// </summary>
  [FactorioRconAttribute("position")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: direction
/// </summary>
public abstract class Literal8567878
{
  /// <summary>
  /// Literal value: direction
  /// </summary>
  [FactorioRconAttribute("direction")]
  public static object Value { get; private set; }

}

