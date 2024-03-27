#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("Product")]
public abstract class Product
{
  [FactorioRconAttribute("type")]
  public Union54868387 Type { get; set; }

  /// <summary>
  /// Prototype name of the result.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// Amount of the item or fluid to give. If not specified, `amount_min`, `amount_max` and `probability` must all be specified.
  /// </summary>
  [FactorioRconAttribute("amount")]
  public double Amount { get; set; }

  /// <summary>
  /// Minimal amount of the item or fluid to give. Has no effect when `amount` is specified.
  /// </summary>
  [FactorioRconAttribute("amount_min")]
  public Union11385445 AmountMin { get; set; }

  /// <summary>
  /// Maximum amount of the item or fluid to give. Has no effect when `amount` is specified.
  /// </summary>
  [FactorioRconAttribute("amount_max")]
  public Union37767765 AmountMax { get; set; }

  /// <summary>
  /// A value in range [0, 1]. Item or fluid is only given with this probability; otherwise no product is produced.
  /// </summary>
  [FactorioRconAttribute("probability")]
  public double Probability { get; set; }

  /// <summary>
  /// How much of this product is a catalyst.
  /// </summary>
  [FactorioRconAttribute("catalyst_amount")]
  public Union54925564 CatalystAmount { get; set; }

}

[GenerateOneOf]
public abstract partial class Union37767765: OneOfBase<uint, double>
{
}

[GenerateOneOf]
public abstract partial class Union11385445: OneOfBase<uint, double>
{
}

[GenerateOneOf]
public abstract partial class Union54925564: OneOfBase<uint, double>
{
}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Union54868387
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconDefinitionValue("item")]
  Item,

  /// <summary>
  /// Literal value: fluid
  /// </summary>
  [FactorioRconDefinitionValue("fluid")]
  Fluid,

}

