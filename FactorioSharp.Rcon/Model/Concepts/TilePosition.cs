#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     Coordinates of a tile on a <see cref="MapPosition" />, except it rounds any non-integer `x`/`y` down to whole numbers. It can be specified either with or without explicit
///     keys.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TilePosition")]
public partial class TilePosition : OneOfBase<Table912949041, Tuple1378645933>
{
}
