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
/// Any basic type (string, number, boolean) or table.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("AnyBasic")]
public abstract partial class AnyBasic: OneOfBase<string, bool, double, LuaTable>
{
}

