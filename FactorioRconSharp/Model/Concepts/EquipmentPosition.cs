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
public abstract partial class EquipmentPosition: OneOfBase<Table_00e4a96940cb4356a7391fc9a07736a9, Table_69a3f2c3725c4b04b5d961d8b10f14e6>
{
}

