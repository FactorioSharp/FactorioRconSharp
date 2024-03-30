#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// A <see cref="ChunkPosition" /> with an added bounding box for the area of the chunk.
/// </summary>
[FactorioRconConcept("ChunkPositionAndArea")]
public class ChunkPositionAndArea: IFactorioRconModel
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

  [FactorioRconAttribute("area")]
  public BoundingBox Area { get; set; }

  public void Load(string str) => throw new NotImplementedException();
}

