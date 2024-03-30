#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("CapsuleAction")]
public class CapsuleAction
{
    [FactorioRconAttribute("type")]
    public Literals830635357 Type { get; set; }
}
