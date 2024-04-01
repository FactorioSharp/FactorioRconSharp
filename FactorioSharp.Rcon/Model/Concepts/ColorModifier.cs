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
/// Same as <see cref="Color" />, but red, green, blue and alpha values can be any floating point number, without any special handling of the range [1, 255].
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ColorModifier")]
public partial class ColorModifier: OneOfBase<Table531944975, Tuple526134302>
{
}

