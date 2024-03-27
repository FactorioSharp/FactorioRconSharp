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
/// Same as <see cref="Color" />, but red, green, blue and alpha values can be any floating point number, without any special handling of the range [1, 255].
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ColorModifier")]
public abstract partial class ColorModifier: OneOfBase<Table1986481333, Tuple4279884>
{
}

