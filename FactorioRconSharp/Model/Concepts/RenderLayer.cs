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
public partial class RenderLayer: OneOfBase<Union454344545_0, Union454344545_1, Union454344545_2, Union454344545_3, Union454344545_4>
{
}

[GenerateOneOf]
public partial class Union454344545_0: OneOfBase<string, Literal1229088808, Literal1403385148, Literal320608118, Literal307055857, Literal1432400790, Literal2003034430, Literal787677799, Literal992617774>
{
}

[GenerateOneOf]
public partial class Union454344545_1: OneOfBase<Literal1544103246, Literal1411256037, Literal1334332990, Literal417285863, Literal1739830175, Literal301815651, Literal152380036, Literal678065848, Literal536035853>
{
}

[GenerateOneOf]
public partial class Union454344545_2: OneOfBase<Literal1102191356, Literal1708644846, Literal835234050, Literal1795124014, Literal828113806, Literal1465292703, Literal1711021894, Literal1958136677, Literal304673406>
{
}

[GenerateOneOf]
public partial class Union454344545_3: OneOfBase<Literal570826533, Literal1815743260, Literal105266778, Literal806987070, Literal695027097, Literal2073136626, Literal425244835, Literal246990460, Literal1356290865>
{
}

[GenerateOneOf]
public partial class Union454344545_4: OneOfBase<Literal396619393, Literal1866136299, Literal1028522575, Literal4121598, Literal1926081820, Literal1881235182, Literal1049962658, Literal141211978>
{
}

