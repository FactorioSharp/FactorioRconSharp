#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Product")]
public class Product
{
    [FactorioRconAttribute("type")]
    public Literals1969734777 Type { get; set; }

    /// <summary>
    ///     Prototype name of the result.
    /// </summary>
    [FactorioRconAttribute("name")]
    public string Name { get; set; }

    /// <summary>
    ///     Amount of the item or fluid to give. If not specified, `amount_min`, `amount_max` and `probability` must all be specified.
    /// </summary>
    [FactorioRconAttribute("amount")]
    public double Amount { get; set; }

    /// <summary>
    ///     Minimal amount of the item or fluid to give. Has no effect when `amount` is specified.
    /// </summary>
    [FactorioRconAttribute("amount_min")]
    public Union613135482 AmountMin { get; set; }

    /// <summary>
    ///     Maximum amount of the item or fluid to give. Has no effect when `amount` is specified.
    /// </summary>
    [FactorioRconAttribute("amount_max")]
    public Union613135482 AmountMax { get; set; }

    /// <summary>
    ///     A value in range [0, 1]. Item or fluid is only given with this probability; otherwise no product is produced.
    /// </summary>
    [FactorioRconAttribute("probability")]
    public double Probability { get; set; }

    /// <summary>
    ///     How much of this product is a catalyst.
    /// </summary>
    [FactorioRconAttribute("catalyst_amount")]
    public Union613135482 CatalystAmount { get; set; }
}
