#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     An item prototype may be specified in one of three ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("ItemPrototypeIdentification")]
public partial class ItemPrototypeIdentification : OneOfBase<LuaItemStack, LuaItemPrototype, string>
{
}
