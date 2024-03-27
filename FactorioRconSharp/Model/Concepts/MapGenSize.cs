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
/// A floating point number specifying an amount.
/// 
/// For backwards compatibility, MapGenSizes can also be specified as one of the following strings, which will be converted to a number (when queried, a number will always be returned):
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("MapGenSize")]
public abstract partial class MapGenSize: OneOfBase<float, Literal354846551, Literal2059969705, Literal1410056151, Literal363506414, Literal892972009, Literal686134346, Literal1955325612, Literal888195366, Literal274479976, Literal260338842, Literal1017103329, Literal657923541, Literal9558861, Literal1432433727, Literal2062107382, Literal893015467>
{
}

