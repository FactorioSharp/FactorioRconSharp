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
/// The settings used by a heat-interface type entity.
/// </summary>
[FactorioRconConcept("HeatSetting")]
public abstract class HeatSetting
{
  /// <summary>
  /// The target temperature. Defaults to the minimum temperature of the heat buffer.
  /// </summary>
  [FactorioRconAttribute("temperature")]
  public double Temperature { get; set; }

  /// <summary>
  /// Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union49515534 Mode { get; set; }

}

public abstract class Table59559901
{
  /// <summary>
  /// The target temperature. Defaults to the minimum temperature of the heat buffer.
  /// </summary>
  [FactorioRconAttribute("temperature")]
  public double Temperature { get; set; }

  /// <summary>
  /// Defaults to `"at-least"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union49515534 Mode { get; set; }

}

[GenerateOneOf]
public abstract partial class Union49515534: OneOfBase<Literal26664368, Literal35069176, Literal10373162, Literal32386246, Literal66785904>
{
}

/// <summary>
/// Literal value: at-least
/// </summary>
public abstract class Literal26664368
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
public abstract class Literal35069176
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
public abstract class Literal10373162
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
public abstract class Literal32386246
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
public abstract class Literal66785904
{
  /// <summary>
  /// Literal value: remove
  /// </summary>
  [FactorioRconAttribute("remove")]
  public static object Value { get; private set; }

}

