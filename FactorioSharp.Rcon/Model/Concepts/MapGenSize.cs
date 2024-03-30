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
/// A floating point number specifying an amount.
/// 
/// For backwards compatibility, MapGenSizes can also be specified as one of the following strings, which will be converted to a number (when queried, a number will always be returned):
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("MapGenSize")]
public partial class MapGenSize: OneOfBase<Union2125337336_0, Union2125337336_1>
{
}

[GenerateOneOf]
public partial class Union2125337336_0: OneOfBase<float, Literal932840264, Literal1786125409, Literal651634713, Literal335299620, Literal17129871, Literal1926858249, Literal1041687566, Literal676714703>
{
}

[GenerateOneOf]
public partial class Union2125337336_1: OneOfBase<Literal376251075, Literal1007696418, Literal1610299092, Literal2112597430, Literal2013898009, Literal1158648576, Literal1172930104, Literal1732649855>
{
}

