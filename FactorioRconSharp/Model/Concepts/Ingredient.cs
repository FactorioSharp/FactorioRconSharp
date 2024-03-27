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
  public Union34257225 Type { get; set; }

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
  public Union48313086 CatalystAmount { get; set; }

}

[GenerateOneOf]
public abstract partial class Union48313086: OneOfBase<uint, double>
{
}

/// <summary>
/// Union of literals:
///   - item
///   - fluid
/// </summary>
public enum Union34257225
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

