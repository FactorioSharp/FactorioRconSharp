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
/// Coordinates on a surface, for example of an entity. MapPositions may be specified either as a dictionary with `x`, `y` as keys, or simply as an array with two elements.
/// 
/// The coordinates are saved as a fixed-size 32 bit integer, with 8 bits reserved for decimal precision, meaning the smallest value step is `1/2^8 = 0.00390625` tiles.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("MapPosition")]
public abstract partial class MapPosition: OneOfBase<Table1066488171, Tuple536254748>
{
}

