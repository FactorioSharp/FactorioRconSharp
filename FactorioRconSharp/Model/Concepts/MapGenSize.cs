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
public partial class MapGenSize: OneOfBase<Union47190607_0, Union47190607_1>
{
}

[GenerateOneOf]
public partial class Union47190607_0: OneOfBase<float, Literal835456369, Literal816447896, Literal1713676508, Literal107137479, Literal1285808477, Literal800080852, Literal1733007002, Literal1321232754>
{
}

[GenerateOneOf]
public partial class Union47190607_1: OneOfBase<Literal1280339421, Literal1392592511, Literal1095450733, Literal43710182, Literal827382368, Literal591579523, Literal1429666094, Literal66289711>
{
}

