#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Two positions, specifying the top-left and bottom-right corner of the box respectively. Like with <see cref="MapPosition" />, the names of the members may be omitted. When read from the game, the third member `orientation` is present if it is non-zero.
/// </summary>
[FactorioRconConcept("BoundingBox")]
public class BoundingBox
{
}

