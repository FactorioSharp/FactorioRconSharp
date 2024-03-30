#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A fluid may be specified in one of three ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("FluidIdentification")]
public partial class FluidIdentification : OneOfBase<string, LuaFluidPrototype, Fluid>
{
}