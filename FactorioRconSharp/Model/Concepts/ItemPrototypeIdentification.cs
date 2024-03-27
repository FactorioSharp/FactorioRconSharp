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
/// An item prototype may be specified in one of three ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ItemPrototypeIdentification")]
public abstract partial class ItemPrototypeIdentification: OneOfBase<LuaItemStack, LuaItemPrototype, string>
{
}

