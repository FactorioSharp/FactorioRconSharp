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
/// Depending on the value of `filter`, the table may take additional fields. `filter` may be one of the following:
/// </summary>
[FactorioRconConcept("DecorativePrototypeFilter")]
public abstract class DecorativePrototypeFilter
{
  /// <summary>
  /// The condition to filter on. One of `"decal"`, `"autoplace"`, `"collision-mask"`.
  /// </summary>
  [FactorioRconAttribute("filter")]
  public string Filter { get; set; }

  /// <summary>
  /// How to combine this with the previous filter. Defaults to `"or"`. When evaluating the filters, `"and"` has higher precedence than `"or"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union61698184 Mode { get; set; }

  /// <summary>
  /// Inverts the condition. Default is `false`.
  /// </summary>
  [FactorioRconAttribute("invert")]
  public bool Invert { get; set; }

}

public abstract class Table52709690
{
  /// <summary>
  /// The condition to filter on. One of `"decal"`, `"autoplace"`, `"collision-mask"`.
  /// </summary>
  [FactorioRconAttribute("filter")]
  public string Filter { get; set; }

  /// <summary>
  /// How to combine this with the previous filter. Defaults to `"or"`. When evaluating the filters, `"and"` has higher precedence than `"or"`.
  /// </summary>
  [FactorioRconAttribute("mode")]
  public Union61698184 Mode { get; set; }

  /// <summary>
  /// Inverts the condition. Default is `false`.
  /// </summary>
  [FactorioRconAttribute("invert")]
  public bool Invert { get; set; }

}

[GenerateOneOf]
public abstract partial class Union61698184: OneOfBase<Literal22774183, Literal13350567>
{
}

/// <summary>
/// Literal value: or
/// </summary>
public abstract class Literal22774183
{
  /// <summary>
  /// Literal value: or
  /// </summary>
  [FactorioRconAttribute("or")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: and
/// </summary>
public abstract class Literal13350567
{
  /// <summary>
  /// Literal value: and
  /// </summary>
  [FactorioRconAttribute("and")]
  public static object Value { get; private set; }

}

[GenerateOneOf]
public abstract partial class Union37915543: OneOfBase<CollisionMask, CollisionMaskWithFlags>
{
}

