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
public abstract partial class MapGenSize: OneOfBase<float, Literal_e9929c90497d487ebc684fc282e5d70c, Literal_2a191aaf64c241bead95618d06337b55, Literal_636714bb197e41d494e5f367ea3dd314, Literal_d4bb5b9c00a74423bfb34ba231ef41d5, Literal_6798e93c9e824006b19648ebcb87639e, Literal_2533f537226a41718997d37ec2ea4991, Literal_ab2b8a90ae154667bd788752663d9471, Literal_ae11bf2472b84b2ebe45ee7bb805df21, Literal_f49afaa62bec464a85810361bbc7b1da, Literal_9220240aab6b4a4d9427bbdd460557f2, Literal_371629012161408c85c034031cc6b76b, Literal_b85c793885be4f378b4cfec88d808a51, Literal_085a6f20ed044abf9704c694d7cae693, Literal_ba582ea63c5148f5b5977d540866b5a7, Literal_0d9516a3afaf4422b6f9a7e350d1824e, Literal_6067d49bef83424d9c88354358d7633f>
{
}

