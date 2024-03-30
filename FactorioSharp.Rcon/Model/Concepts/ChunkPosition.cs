#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// Coordinates of a chunk in a <see cref="MapPosition" /> can be translated to a ChunkPosition by dividing the `x`/`y` values by 32.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ChunkPosition")]
public partial class ChunkPosition: OneOfBase<Table1108165145, Tuple1990400661>
{
}

