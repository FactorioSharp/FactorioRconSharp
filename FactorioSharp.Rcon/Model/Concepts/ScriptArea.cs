#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     An area defined using the map editor.
/// </summary>
[FactorioRconConcept("ScriptArea")]
public class ScriptArea
{
    [FactorioRconAttribute("area")]
    public BoundingBox Area { get; set; }

    [FactorioRconAttribute("name")]
    public string Name { get; set; }

    [FactorioRconAttribute("color")]
    public Color Color { get; set; }

    [FactorioRconAttribute("id")]
    public uint Id { get; set; }
}
