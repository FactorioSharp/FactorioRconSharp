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
  public Union45707720 Mode { get; set; }

}

public abstract class Table8567878
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
  public Union45707720 Mode { get; set; }

}

[GenerateOneOf]
public abstract partial class Union45707720: OneOfBase<Literal20338027, Literal24445403, Literal43591415, Literal43004497, Literal30679207>
{
}

/// <summary>
/// Literal value: at-least
/// </summary>
public enum Literal20338027
{
  /// <summary>
  /// Literal value: at-least
  /// </summary>
  [FactorioRconDefinitionValue("at-least")]
  AtLeast,

}

/// <summary>
/// Literal value: at-most
/// </summary>
public enum Literal24445403
{
  /// <summary>
  /// Literal value: at-most
  /// </summary>
  [FactorioRconDefinitionValue("at-most")]
  AtMost,

}

/// <summary>
/// Literal value: exactly
/// </summary>
public enum Literal43591415
{
  /// <summary>
  /// Literal value: exactly
  /// </summary>
  [FactorioRconDefinitionValue("exactly")]
  Exactly,

}

/// <summary>
/// Literal value: add
/// </summary>
public enum Literal43004497
{
  /// <summary>
  /// Literal value: add
  /// </summary>
  [FactorioRconDefinitionValue("add")]
  Add,

}

/// <summary>
/// Literal value: remove
/// </summary>
public enum Literal30679207
{
  /// <summary>
  /// Literal value: remove
  /// </summary>
  [FactorioRconDefinitionValue("remove")]
  Remove,

}

