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
/// An entity prototype may be specified in one of three ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("EntityPrototypeIdentification")]
public abstract partial class EntityPrototypeIdentification: OneOfBase<LuaEntity, LuaEntityPrototype, string>
{
}

[GenerateOneOf]
public abstract partial class Union6827688: OneOfBase<LuaEntity, LuaEntityPrototype, string>
{
}

