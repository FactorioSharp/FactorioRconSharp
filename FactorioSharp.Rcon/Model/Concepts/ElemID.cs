#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("ElemID")]
public class ElemID
{
    [FactorioRconAttribute("type")]
    public ElemType Type { get; set; }

    /// <summary>
    ///     Name of a prototype as defined by `type`.
    /// </summary>
    [FactorioRconAttribute("name")]
    public string Name { get; set; }
}
