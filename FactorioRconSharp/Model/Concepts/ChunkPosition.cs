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
public abstract partial class ChunkPosition: OneOfBase<Table_34a448b189464b11b795847ce8f32900, Tuple_c8ef66468fb54cd697f3ad9f01afcaa3>
{
}

