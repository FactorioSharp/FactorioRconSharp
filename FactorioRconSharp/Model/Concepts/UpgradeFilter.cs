#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("UpgradeFilter")]
public abstract class UpgradeFilter
{
  [FactorioRconAttribute("type")]
  public Union26415768 Type { get; set; }

  /// <summary>
  /// Name of the item, or entity.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

public abstract class Table11596458
{
  [FactorioRconAttribute("type")]
  public Union26415768 Type { get; set; }

  /// <summary>
  /// Name of the item, or entity.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

}

[GenerateOneOf]
public abstract partial class Union26415768: OneOfBase<Literal37859355, Literal58618865>
{
}

/// <summary>
/// Literal value: item
/// </summary>
public abstract class Literal37859355
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconAttribute("item")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: entity
/// </summary>
public abstract class Literal58618865
{
  /// <summary>
  /// Literal value: entity
  /// </summary>
  [FactorioRconAttribute("entity")]
  public static object Value { get; private set; }

}

