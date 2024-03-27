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
/// Screen coordinates of a GUI element in a <see cref="TilePosition" />, meaning it can be specified either with or without explicit keys.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("GuiLocation")]
public abstract partial class GuiLocation: OneOfBase<Table1570394128, Tuple1831800379>
{
}

