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
public partial class RenderLayer: OneOfBase<Union396441620_0, Union396441620_1, Union396441620_2, Union396441620_3, Union396441620_4>
{
}

[GenerateOneOf]
public partial class Union396441620_0: OneOfBase<string, Literal785176625, Literal1122206333, Literal1079284900, Literal846077040, Literal1768304625, Literal906832243, Literal1393360230, Literal981041311>
{
}

[GenerateOneOf]
public partial class Union396441620_1: OneOfBase<Literal854961950, Literal1068955747, Literal1108511369, Literal1436470375, Literal280008327, Literal2050018241, Literal173586344, Literal1117921224, Literal508743920>
{
}

[GenerateOneOf]
public partial class Union396441620_2: OneOfBase<Literal2129654647, Literal2093131094, Literal187566171, Literal492181361, Literal528234710, Literal827100120, Literal1090376482, Literal322671826, Literal1545859840>
{
}

[GenerateOneOf]
public partial class Union396441620_3: OneOfBase<Literal1748773722, Literal264597246, Literal1385855715, Literal1535820354, Literal249581260, Literal2137464667, Literal1036516845, Literal452811066, Literal1547695486>
{
}

[GenerateOneOf]
public partial class Union396441620_4: OneOfBase<Literal703137882, Literal1856269419, Literal1543504295, Literal2012603005, Literal852558859, Literal1021610954, Literal523417407, Literal1019994805>
{
}

