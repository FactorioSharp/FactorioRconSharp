#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A floating point number specifying an amount.
///     For backwards compatibility, MapGenSizes can also be specified as one of the following strings, which will be converted to a number (when queried, a number will always be
///     returned):
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("MapGenSize")]
public partial class MapGenSize : OneOfBase<Union602293719_0, Union602293719_1>
{
}

[GenerateOneOf]
public partial class Union602293719_0
    : OneOfBase<float, Literal454947645, Literal1640958002, Literal1895387756, Literal1188150639, Literal685208893, Literal437896026, Literal1800004541, Literal39260770>
{
}

[GenerateOneOf]
public partial class Union602293719_1
    : OneOfBase<Literal1335578432, Literal1436522388, Literal1781632603, Literal521429334, Literal2042580432, Literal1685315224, Literal1416605479, Literal728989117>
{
}
