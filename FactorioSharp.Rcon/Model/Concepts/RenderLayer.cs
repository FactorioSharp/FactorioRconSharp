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
/// A number between 0 and 255 inclusive, represented by one of the following named strings or the string version of the number. For example `"27"` and `"decals"` are both valid. Higher values are rendered above lower values.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("RenderLayer")]
public partial class RenderLayer: OneOfBase<Union638830327_0, Union638830327_1, Union638830327_2, Union638830327_3, Union638830327_4>
{
}

[GenerateOneOf]
public partial class Union638830327_0: OneOfBase<string, Literal2053549129, Literal1540034001, Literal1102248446, Literal2010215296, Literal1458777078, Literal673746839, Literal1296591758, Literal1842345359>
{
}

[GenerateOneOf]
public partial class Union638830327_1: OneOfBase<Literal13925337, Literal281865761, Literal680750582, Literal756357730, Literal397062830, Literal341467938, Literal288994453, Literal1776671115, Literal160612193>
{
}

[GenerateOneOf]
public partial class Union638830327_2: OneOfBase<Literal401102142, Literal1605735839, Literal813100313, Literal775887229, Literal1068463236, Literal65244356, Literal1054217749, Literal505982321, Literal1519768649>
{
}

[GenerateOneOf]
public partial class Union638830327_3: OneOfBase<Literal1509186546, Literal1326619191, Literal835849398, Literal1614252387, Literal537192782, Literal1263655565, Literal1605896322, Literal411152254, Literal2020792767>
{
}

[GenerateOneOf]
public partial class Union638830327_4: OneOfBase<Literal1649137212, Literal1721949904, Literal513519426, Literal1696402987, Literal936552253, Literal816005672, Literal171552650, Literal1144723239>
{
}

