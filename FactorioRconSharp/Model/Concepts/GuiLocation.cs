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
public abstract partial class GuiLocation: OneOfBase<Table_ed5a91c2cb6741a4ae7a0c4254ec839f, Table_5b9d9e8bd4164da684d8fb5577e17d1f>
{
}

