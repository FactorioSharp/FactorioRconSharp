#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("UpgradeFilter")]
public class UpgradeFilter
{
    [FactorioRconAttribute("type")]
    public Literals1991223196 Type { get; set; }

    /// <summary>
    ///     Name of the item, or entity.
    /// </summary>
    [FactorioRconAttribute("name")]
    public string Name { get; set; }
}
