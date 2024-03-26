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
/// Used by <see cref="GuiArrowSpecification" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("GuiArrowType")]
public abstract partial class GuiArrowType: OneOfBase<Literal41986689, Literal9654443, Literal11543392, Literal66322936, Literal44316952, Literal10123218, Literal25137887, Literal57910105>
{
}

[GenerateOneOf]
public abstract partial class Union59300285: OneOfBase<Literal41986689, Literal9654443, Literal11543392, Literal66322936, Literal44316952, Literal10123218, Literal25137887, Literal57910105>
{
}

/// <summary>
/// Literal value: nowhere
/// </summary>
public abstract class Literal41986689
{
  /// <summary>
  /// Literal value: nowhere
  /// </summary>
  [FactorioRconAttribute("nowhere")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: goal
/// </summary>
public abstract class Literal9654443
{
  /// <summary>
  /// Literal value: goal
  /// </summary>
  [FactorioRconAttribute("goal")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: entity_info
/// </summary>
public abstract class Literal11543392
{
  /// <summary>
  /// Literal value: entity_info
  /// </summary>
  [FactorioRconAttribute("entity_info")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: active_window
/// </summary>
public abstract class Literal66322936
{
  /// <summary>
  /// Literal value: active_window
  /// </summary>
  [FactorioRconAttribute("active_window")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: entity
/// </summary>
public abstract class Literal44316952
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
public abstract class Literal10123218
{
  /// <summary>
  /// Literal value: position
  /// </summary>
  [FactorioRconAttribute("position")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: crafting_queue
/// </summary>
public abstract class Literal25137887
{
  /// <summary>
  /// Literal value: crafting_queue
  /// </summary>
  [FactorioRconAttribute("crafting_queue")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: item_stack
/// </summary>
public abstract class Literal57910105
{
  /// <summary>
  /// Literal value: item_stack
  /// </summary>
  [FactorioRconAttribute("item_stack")]
  public static object Value { get; private set; }

}

