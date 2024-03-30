#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("SignalID")]
public class SignalID
{
    [FactorioRconAttribute("type")]
    public Literals342557859 Type { get; set; }

    /// <summary>
    ///     Name of the item, fluid or virtual signal.
    /// </summary>
    [FactorioRconAttribute("name")]
    public string Name { get; set; }
}
