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
public partial class MapGenSize: OneOfBase<Union2103532465_0, Union2103532465_1>
{
}

[GenerateOneOf]
public partial class Union2103532465_0: OneOfBase<float, Literal1274922415, Literal1077430962, Literal1004547864, Literal232739815, Literal1095510702, Literal1189542022, Literal1293159333, Literal1164590158>
{
}

[GenerateOneOf]
public partial class Union2103532465_1: OneOfBase<Literal1689411682, Literal1950156636, Literal1769768771, Literal2127626780, Literal2065878395, Literal1647615892, Literal619214192, Literal1930687915>
{
}

