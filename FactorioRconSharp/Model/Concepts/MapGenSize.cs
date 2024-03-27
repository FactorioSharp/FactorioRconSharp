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
public abstract partial class MapGenSize: OneOfBase<float, Literal915727866, Literal1529743095, Literal441002546, Literal1976566792, Literal1663384455, Literal1995701129, Literal272741371, Literal835339334, Literal744811335, Literal1774316398, Literal1724991380, Literal181033013, Literal1475620671, Literal846897890, Literal1057755151, Literal1981147410>
{
}

