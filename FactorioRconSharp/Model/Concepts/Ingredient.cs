#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("Ingredient")]
public abstract class Ingredient
{
  [FactorioRconAttribute("type")]
  public Union21178267 Type { get; set; }

  /// <summary>
  /// Prototype name of the required item or fluid.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// Amount of the item or fluid.
  /// </summary>
  [FactorioRconAttribute("amount")]
  public double Amount { get; set; }

  /// <summary>
  /// How much of this ingredient is a catalyst.
  /// </summary>
  [FactorioRconAttribute("catalyst_amount")]
  public Union10189992 CatalystAmount { get; set; }

}

public abstract class Table7672581
{
  [FactorioRconAttribute("type")]
  public Union21178267 Type { get; set; }

  /// <summary>
  /// Prototype name of the required item or fluid.
  /// </summary>
  [FactorioRconAttribute("name")]
  public string Name { get; set; }

  /// <summary>
  /// Amount of the item or fluid.
  /// </summary>
  [FactorioRconAttribute("amount")]
  public double Amount { get; set; }

  /// <summary>
  /// How much of this ingredient is a catalyst.
  /// </summary>
  [FactorioRconAttribute("catalyst_amount")]
  public Union10189992 CatalystAmount { get; set; }

}

[GenerateOneOf]
public abstract partial class Union10189992: OneOfBase<uint, double>
{
}

[GenerateOneOf]
public abstract partial class Union21178267: OneOfBase<Literal27074336, Literal46958254>
{
}

/// <summary>
/// Literal value: item
/// </summary>
public abstract class Literal27074336
{
  /// <summary>
  /// Literal value: item
  /// </summary>
  [FactorioRconAttribute("item")]
  public static object Value { get; private set; }

}

/// <summary>
/// Literal value: fluid
/// </summary>
public abstract class Literal46958254
{
  /// <summary>
  /// Literal value: fluid
  /// </summary>
  [FactorioRconAttribute("fluid")]
  public static object Value { get; private set; }

}

