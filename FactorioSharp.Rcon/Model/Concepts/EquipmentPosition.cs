#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     Position inside an equipment grid. This uses the same format as <see cref="MapPosition" />, meaning it can be specified either with or without explicit keys.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("EquipmentPosition")]
public partial class EquipmentPosition : OneOfBase<Table912949041, Tuple272689614>
{
}
