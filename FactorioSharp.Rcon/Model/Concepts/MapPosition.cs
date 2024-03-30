#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     Coordinates on a surface, for example of an entity. MapPositions may be specified either as a dictionary with `x`, `y` as keys, or simply as an array with two elements.
///     The coordinates are saved as a fixed-size 32 bit integer, with 8 bits reserved for decimal precision, meaning the smallest value step is `1/2^8 = 0.00390625` tiles.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("MapPosition")]
public partial class MapPosition : OneOfBase<Table759843722, Tuple68614424>
{
}
