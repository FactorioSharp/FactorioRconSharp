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
/// Red, green, blue and alpha values, all in range [0, 1] or all in range [0, 255] if any value is > 1. All values here are optional. Color channels default to `0`, the alpha channel defaults to `1`.
/// 
/// Similar to <see cref="MapPosition),ColorAllowsTheShortHandNotationOfPassingAnArrayOfExactly3Or4Numbers.TheGameUsuallyExpectsColorsToBeInPreMultipliedForm(ColorChannelsArePreMultipliedByAlpha" />.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("Color")]
public abstract partial class Color: OneOfBase<Table501783562, Tuple32101292>
{
}

