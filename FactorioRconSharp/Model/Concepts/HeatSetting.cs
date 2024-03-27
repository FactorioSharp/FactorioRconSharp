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
  public Union27867915 Mode { get; set; }

}

public abstract class Table23696664
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
  public Union27867915 Mode { get; set; }

}

[GenerateOneOf]
public abstract partial class Union27867915: OneOfBase<Literal48355310, Literal8828568, Literal51182215, Literal1084693, Literal22778559>
{
}

/// <summary>
/// Literal value: at-least
/// </summary>
public enum Literal48355310
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
public enum Literal8828568
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
public enum Literal51182215
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
public enum Literal1084693
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
public enum Literal22778559
{
  /// <summary>
  /// Literal value: remove
  /// </summary>
  [FactorioRconDefinitionValue("remove")]
  Remove,

}

