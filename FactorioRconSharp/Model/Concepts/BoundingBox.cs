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
/// Two positions, specifying the top-left and bottom-right corner of the box respectively. Like with <see cref="MapPosition" />, the names of the members may be omitted. When read from the game, the third member `orientation` is present if it is non-zero.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("BoundingBox")]
public abstract partial class BoundingBox: OneOfBase<Table_8b8d83ceab384d2bbab03c5f2ec7872c, Tuple_4c6f522565ce43baabcda365689f25c8>
{
}

