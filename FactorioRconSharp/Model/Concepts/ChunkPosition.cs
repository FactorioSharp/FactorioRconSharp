#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Coordinates of a chunk in a <see cref="MapPosition" /> can be translated to a ChunkPosition by dividing the `x`/`y` values by 32.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ChunkPosition")]
public abstract partial class ChunkPosition: OneOfBase<Table_adfdacdb8baf4b4997fb8e29cfd0c9a6, Table_75cd2f4401c04355ae57993a4561f2b1>
{
}

