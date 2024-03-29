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
/// Coordinates of a tile on a <see cref="MapPosition" />, except it rounds any non-integer `x`/`y` down to whole numbers. It can be specified either with or without explicit keys.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TilePosition")]
public partial class TilePosition: OneOfBase<Table912949041, Tuple1378645933>
{
}

