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
/// A single filter used by an infinity-pipe type entity.
/// </summary>
[FactorioRconConcept("InfinityPipeFilter")]
public abstract class InfinityPipeFilter
{
  /// <summary>
  /// Name of the fluid.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The fill percentage the pipe (`0.5` for 50%). Can't be negative.
  /// </summary>
  [FactorioRconAttribute("percentage")]
  public double Percentage { get; set; }

  /// <summary>
  /// The temperature of the fluid. Defaults to the default/minimum temperature of the fluid.
  /// </summary>
  [FactorioRconAttribute("temperature")]
  public double Temperature { get; set; }

  /// <summary>
  /// Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union5991177 Mode { get; set; }

}

public abstract class Table51116765
{
  /// <summary>
  /// Name of the fluid.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// The fill percentage the pipe (`0.5` for 50%). Can't be negative.
  /// </summary>
  [FactorioRconAttribute("percentage")]
  public double Percentage { get; set; }

  /// <summary>
  /// The temperature of the fluid. Defaults to the default/minimum temperature of the fluid.
  /// </summary>
  [FactorioRconAttribute("temperature")]
  public double Temperature { get; set; }

  /// <summary>
  /// Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union5991177 Mode { get; set; }

}

[GenerateOneOf]
public abstract partial class Union5991177: OneOfBase<Literal39526418, Literal5415451, Literal22830370, Literal58100981, Literal7206868>
{
}

/// <summary>
/// Literal value: at-least
/// </summary>
public abstract class Literal39526418
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
public abstract class Literal5415451
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
public abstract class Literal22830370
{
  /// <summary>
  /// Literal value: exactly
  /// </summary>
  [FactorioRconAttribute("exactly")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: add
/// </summary>
public abstract class Literal58100981
{
  /// <summary>
  /// Literal value: add
  /// </summary>
  [FactorioRconAttribute("add")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: remove
/// </summary>
public abstract class Literal7206868
{
  /// <summary>
  /// Literal value: remove
  /// </summary>
  [FactorioRconAttribute("remove")]
  public static object Value { get; private set; }

}

