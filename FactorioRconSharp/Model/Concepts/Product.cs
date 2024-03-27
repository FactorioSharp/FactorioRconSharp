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
  public Union53346435 Type { get; set; }

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
  public Union3542765 AmountMin { get; set; }

  /// <summary>
  /// Maximum amount of the item or fluid to give. Has no effect when `amount` is specified.
  /// </summary>
  [FactorioRconAttribute("amount_max")]
  public Union35631340 AmountMax { get; set; }

  /// <summary>
  /// A value in range [0, 1]. Item or fluid is only given with this probability; otherwise no product is produced.
  /// </summary>
  [FactorioRconAttribute("probability")]
  public double Probability { get; set; }

  /// <summary>
  /// How much of this product is a catalyst.
  /// </summary>
  [FactorioRconAttribute("catalyst_amount")]
  public Union26675914 CatalystAmount { get; set; }

}

public abstract class Table18038223
{
  [FactorioRconAttribute("type")]
  public Union53346435 Type { get; set; }

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
  public Union3542765 AmountMin { get; set; }

  /// <summary>
  /// Maximum amount of the item or fluid to give. Has no effect when `amount` is specified.
  /// </summary>
  [FactorioRconAttribute("amount_max")]
  public Union35631340 AmountMax { get; set; }

  /// <summary>
  /// A value in range [0, 1]. Item or fluid is only given with this probability; otherwise no product is produced.
  /// </summary>
  [FactorioRconAttribute("probability")]
  public double Probability { get; set; }

  /// <summary>
  /// How much of this product is a catalyst.
  /// </summary>
  [FactorioRconAttribute("catalyst_amount")]
  public Union26675914 CatalystAmount { get; set; }

}

[GenerateOneOf]
public abstract partial class Union35631340: OneOfBase<uint, double>
{
}

[GenerateOneOf]
public abstract partial class Union3542765: OneOfBase<uint, double>
{
}

[GenerateOneOf]
public abstract partial class Union26675914: OneOfBase<uint, double>
{
}

[GenerateOneOf]
public abstract partial class Union53346435: OneOfBase<Literal35404016, Literal20083532>
{
}

/// <summary>
/// Literal value: item
/// </summary>
public enum Literal35404016
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconDefinitionValue("item")]
  Item,

}

/// <summary>
/// Literal value: fluid
/// </summary>
public enum Literal20083532
{
  /// <summary>
  /// Literal value: fluid
  /// </summary>
  [FactorioRconDefinitionValue("fluid")]
  Fluid,

}

