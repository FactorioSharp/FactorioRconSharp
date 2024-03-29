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
/// An entity prototype may be specified in one of three ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("EntityPrototypeIdentification")]
public partial class EntityPrototypeIdentification: OneOfBase<LuaEntity, LuaEntityPrototype, string>
{
}

