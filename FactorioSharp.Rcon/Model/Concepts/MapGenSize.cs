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
public partial class MapGenSize: OneOfBase<Union310625457_0, Union310625457_1>
{
}

[GenerateOneOf]
public partial class Union310625457_0: OneOfBase<float, Literal440243395, Literal1406079683, Literal1132764350, Literal385105859, Literal1161457328, Literal185388464, Literal1825344215, Literal788070672>
{
}

[GenerateOneOf]
public partial class Union310625457_1: OneOfBase<Literal242097688, Literal1633423983, Literal1759391102, Literal267487537, Literal1504458719, Literal1874956755, Literal1182825855, Literal1119430570>
{
}

