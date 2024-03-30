#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Classes;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A player may be specified in one of three ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("PlayerIdentification")]
public partial class PlayerIdentification : OneOfBase<uint, string, LuaPlayer>
{
}
