#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A <see cref="ChunkPosition" /> with an added bounding box for the area of the chunk.
/// </summary>
[FactorioRconConcept("ChunkPositionAndArea")]
public abstract class ChunkPositionAndArea
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

  [FactorioRconAttribute("area")]
  public BoundingBox Area { get; set; }

}

public abstract class Table28855723
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

  [FactorioRconAttribute("area")]
  public BoundingBox Area { get; set; }

}

