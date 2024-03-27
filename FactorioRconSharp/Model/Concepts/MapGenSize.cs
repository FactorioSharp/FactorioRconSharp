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
/// A floating point number specifying an amount.
/// 
/// For backwards compatibility, MapGenSizes can also be specified as one of the following strings, which will be converted to a number (when queried, a number will always be returned):
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("MapGenSize")]
public abstract partial class MapGenSize: OneOfBase<float, Literal_f30eb622d040419eaa8d58740838aabc, Literal_e51c581fc1a34fb39011f02ae3ad4eec, Literal_102b380c45344ac383740a26f6ab1e09, Literal_e43b361f899a45ddba10f1eca5d38cda, Literal_115914cc1e104744aa75a0fdf4f2dca1, Literal_616300625ab84e489d9fe5a1f02d9e6d, Literal_a0111335fcc74b7baca051ed86540c1c, Literal_51b682aeef244d4b930d9a78557a26dc, Literal_0040f0baa4a94329b81a42986e8810a0, Literal_99ad6bbdf8924229a61dc2c5917ee807, Literal_488d1f1551424c3a815a5ca30414a0e7, Literal_369219cc278d46a996eddcf902fc14f3, Literal_1c132724e24743b0a3b56de070d7c093, Literal_c538f795210b4f0ea9262a285bb75415, Literal_b6406933cc45404f8e579ab0a8430e85, Literal_17801df5a2ec4c8480e7f41bbaeb0edc>
{
}

