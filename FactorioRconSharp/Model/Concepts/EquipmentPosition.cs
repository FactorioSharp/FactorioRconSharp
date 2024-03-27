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
/// Position inside an equipment grid. This uses the same format as <see cref="MapPosition" />, meaning it can be specified either with or without explicit keys.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("EquipmentPosition")]
public abstract partial class EquipmentPosition: OneOfBase<Type375078767, Type375078767>
{
}

