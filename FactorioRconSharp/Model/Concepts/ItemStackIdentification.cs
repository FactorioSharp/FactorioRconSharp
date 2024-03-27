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
/// An item may be specified in one of two ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ItemStackIdentification")]
public abstract partial class ItemStackIdentification: OneOfBase<SimpleItemStack, LuaItemStack>
{
}

