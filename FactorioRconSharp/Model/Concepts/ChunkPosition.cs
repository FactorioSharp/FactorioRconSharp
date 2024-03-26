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
/// Coordinates of a chunk in a <see cref="MapPosition" /> can be translated to a ChunkPosition by dividing the `x`/`y` values by 32.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ChunkPosition")]
public abstract partial class ChunkPosition: OneOfBase<Table42472704, Table27986180>
{
}

[GenerateOneOf]
public abstract partial class Union1147910: OneOfBase<Table42472704, Table27986180>
{
}

public abstract class Table42472704
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

public abstract class Table27986180
{
  [FactorioRconAttribute("x")]
  public int X { get; set; }

  [FactorioRconAttribute("y")]
  public int Y { get; set; }

}

