#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("Ingredient")]
public class Ingredient
{
    [FactorioRconAttribute("type")]
    public Literals877552609 Type { get; set; }

    /// <summary>
    ///     Prototype name of the required item or fluid.
    /// </summary>
    [FactorioRconAttribute("name")]
    public string Name { get; set; }

    /// <summary>
    ///     Amount of the item or fluid.
    /// </summary>
    [FactorioRconAttribute("amount")]
    public double Amount { get; set; }

    /// <summary>
    ///     How much of this ingredient is a catalyst.
    /// </summary>
    [FactorioRconAttribute("catalyst_amount")]
    public Union613135482 CatalystAmount { get; set; }
}
