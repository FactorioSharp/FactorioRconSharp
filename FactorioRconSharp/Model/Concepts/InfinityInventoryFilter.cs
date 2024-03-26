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
/// A single filter used by an infinity-filters instance.
/// </summary>
[FactorioRconConcept("InfinityInventoryFilter")]
public abstract class InfinityInventoryFilter
{
  /// <summary>
  /// Name of the item.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The count of the filter.
  /// </summary>
  [FactorioRconAttribute("count")]
  public uint Count { get; set; }

  /// <summary>
  /// Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union63935578 Mode { get; set; }

  /// <summary>
  /// The index of this filter in the filters list. Not required when writing a filter.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

}

public abstract class Table57743045
{
  /// <summary>
  /// Name of the item.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The count of the filter.
  /// </summary>
  [FactorioRconAttribute("count")]
  public uint Count { get; set; }

  /// <summary>
  /// Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union63935578 Mode { get; set; }

  /// <summary>
  /// The index of this filter in the filters list. Not required when writing a filter.
  /// </summary>
  [FactorioRconAttribute("index")]
  public uint Index { get; set; }

}

[GenerateOneOf]
public abstract partial class Union63935578: OneOfBase<Literal42192436, Literal15621100, Literal50358721>
{
}

/// <summary>
/// Literal value: at-least
/// </summary>
public abstract class Literal42192436
{
  /// <summary>
  /// Literal value: at-least
  /// </summary>
  [FactorioRconAttribute("at-least")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: at-most
/// </summary>
public abstract class Literal15621100
{
  /// <summary>
  /// Literal value: at-most
  /// </summary>
  [FactorioRconAttribute("at-most")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: exactly
/// </summary>
public abstract class Literal50358721
{
  /// <summary>
  /// Literal value: exactly
  /// </summary>
  [FactorioRconAttribute("exactly")]
  public static object Value { get; private set; }

}

