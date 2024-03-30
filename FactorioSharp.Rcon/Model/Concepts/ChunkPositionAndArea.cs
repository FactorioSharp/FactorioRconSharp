#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A <see cref="ChunkPosition" /> with an added bounding box for the area of the chunk.
/// </summary>
[FactorioRconConcept("ChunkPositionAndArea")]
public class ChunkPositionAndArea
{
    [FactorioRconAttribute("x")]
    public int X { get; set; }

    [FactorioRconAttribute("y")]
    public int Y { get; set; }

    [FactorioRconAttribute("area")]
    public BoundingBox Area { get; set; }
}
