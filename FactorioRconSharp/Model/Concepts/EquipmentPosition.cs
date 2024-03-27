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
public abstract partial class EquipmentPosition: OneOfBase<Table_dfee8b0052fa4341a5161a408caf1ab5, Tuple_ceb4707b717c4723a2387d73c66f45c4>
{
}

