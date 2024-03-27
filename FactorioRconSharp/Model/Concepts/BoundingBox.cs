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
/// Two positions, specifying the top-left and bottom-right corner of the box respectively. Like with <see cref="MapPosition" />, the names of the members may be omitted. When read from the game, the third member `orientation` is present if it is non-zero.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("BoundingBox")]
public abstract partial class BoundingBox: OneOfBase<Table_942be70db2a44649ab5666d238380c46, Tuple_8a579f39d4bb4eb8a8f1244f1a227868>
{
}

