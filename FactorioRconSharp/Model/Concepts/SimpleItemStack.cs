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
/// An item stack may be specified in one of two ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("SimpleItemStack")]
public abstract partial class SimpleItemStack: OneOfBase<string, ItemStackDefinition>
{
}

[GenerateOneOf]
public abstract partial class Union59367627: OneOfBase<string, ItemStackDefinition>
{
}

