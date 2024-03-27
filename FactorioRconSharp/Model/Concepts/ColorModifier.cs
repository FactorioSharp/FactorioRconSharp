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
public abstract partial class ColorModifier: OneOfBase<Table_cd1f6465420a4cd09014336d8c9ebef5, Tuple_cf6ec2ffd906414a967b565dd54f419d>
{
}

