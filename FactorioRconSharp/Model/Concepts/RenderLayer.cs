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
/// A number between 0 and 255 inclusive, represented by one of the following named strings or the string version of the number. For example `"27"` and `"decals"` are both valid. Higher values are rendered above lower values.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("RenderLayer")]
public partial class RenderLayer: OneOfBase<Union1116325269_0, Union1116325269_1, Union1116325269_2, Union1116325269_3, Union1116325269_4>
{
}

[GenerateOneOf]
public partial class Union1116325269_0: OneOfBase<string, Literal829270103, Literal985793284, Literal800524584, Literal763877967, Literal1716161522, Literal1370355229, Literal388424524, Literal647148376>
{
}

[GenerateOneOf]
public partial class Union1116325269_1: OneOfBase<Literal1860963724, Literal637346437, Literal1926955804, Literal1824174703, Literal216486875, Literal1576233040, Literal242446949, Literal1216633590, Literal1921846406>
{
}

[GenerateOneOf]
public partial class Union1116325269_2: OneOfBase<Literal810600631, Literal599236249, Literal241133721, Literal1392226586, Literal673136048, Literal77844417, Literal662407630, Literal1968301476, Literal1054803351>
{
}

[GenerateOneOf]
public partial class Union1116325269_3: OneOfBase<Literal1346576724, Literal1367073630, Literal664994789, Literal1164743991, Literal1850285334, Literal1936404511, Literal568412180, Literal2109412028, Literal2118294396>
{
}

[GenerateOneOf]
public partial class Union1116325269_4: OneOfBase<Literal747213718, Literal520708170, Literal516461454, Literal1823914636, Literal1872579151, Literal1802769305, Literal180233992, Literal878099446>
{
}

