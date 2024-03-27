#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

[FactorioRconConcept("Product")]
public abstract class Product
{
  [FactorioRconAttribute("type")]
  public Literals_4955dbd0fee64c0f985e497b4ba694ab Type { get; set; }

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
  public Union_2d9031c826144ad8975193bcf53b4a24 AmountMin { get; set; }

  /// <summary>
  /// Maximum amount of the item or fluid to give. Has no effect when `amount` is specified.
  /// </summary>
  [FactorioRconAttribute("amount_max")]
  public Union_fec29e92639543aca3841937d716a5a9 AmountMax { get; set; }

  /// <summary>
  /// A value in range [0, 1]. Item or fluid is only given with this probability; otherwise no product is produced.
  /// </summary>
  [FactorioRconAttribute("probability")]
  public double Probability { get; set; }

  /// <summary>
  /// How much of this product is a catalyst.
  /// </summary>
  [FactorioRconAttribute("catalyst_amount")]
  public Union_de908da6c66c47529d8abef63a8c7ec1 CatalystAmount { get; set; }

}

