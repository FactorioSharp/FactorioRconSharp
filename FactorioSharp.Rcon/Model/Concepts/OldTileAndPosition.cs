#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;

namespace FactorioSharp.Rcon.Model.Concepts;

[FactorioRconConcept("OldTileAndPosition")]
public class OldTileAndPosition
{
    [FactorioRconAttribute("old_tile")]
    public LuaTilePrototype OldTile { get; set; }

    [FactorioRconAttribute("position")]
    public TilePosition Position { get; set; }
}
