#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("SignalID")]
public abstract class SignalID
{
  [FactorioRconAttribute("type")]
  public Union52364178 Type { get; set; }

  /// <summary>
  /// Name of the item, fluid or virtual signal.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

public abstract class Table32249050
{
  [FactorioRconAttribute("type")]
  public Union52364178 Type { get; set; }

  /// <summary>
  /// Name of the item, fluid or virtual signal.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

[GenerateOneOf]
public abstract partial class Union52364178: OneOfBase<Literal58426401, Literal14293208, Literal59086672>
{
}

/// <summary>
/// Literal value: item
/// </summary>
public abstract class Literal58426401
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconAttribute("item")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: fluid
/// </summary>
public abstract class Literal14293208
{
  /// <summary>
  /// Literal value: fluid
  /// </summary>
  [FactorioRconAttribute("fluid")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: virtual
/// </summary>
public abstract class Literal59086672
{
  /// <summary>
  /// Literal value: virtual
  /// </summary>
  [FactorioRconAttribute("virtual")]
  public static object Value { get; private set; }

}

