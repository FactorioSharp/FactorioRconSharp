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
/// A technology may be specified in one of three ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("TechnologyIdentification")]
public abstract partial class TechnologyIdentification: OneOfBase<string, LuaTechnology, LuaTechnologyPrototype>
{
}

