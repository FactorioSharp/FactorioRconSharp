#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     An item stack may be specified in one of two ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("SimpleItemStack")]
public partial class SimpleItemStack : OneOfBase<string, ItemStackDefinition>
{
}
