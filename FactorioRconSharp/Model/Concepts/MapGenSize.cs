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
public abstract partial class MapGenSize: OneOfBase<float, Literal_6e112a76f6e742498a2daf6b43752757, Literal_36f16dc4bf3c482798237f03b16f1117, Literal_c11a047309184a86a34cd6652a6312d9, Literal_ef812de4bd5a43eab3ebc20aa91baeb3, Literal_cb4fef1da0d64d46b0eeb74db189e6b7, Literal_0bec2b182a3e4925b39d11e14adc6eb2, Literal_904fdad438824710956859afaea7c1cc, Literal_db612332ea0140c79be93506f40055d2, Literal_83511215ebb143b39af1801878a70ce0, Literal_e159e4fbf5034e3fa180d4ff9dcc36b8, Literal_f3e07ca701cd4a239755ad5ef65f89c2, Literal_f9c9c25063084cdea454e01db0d36263, Literal_072e303f7d8645249bc7a37011b7016f, Literal_a3535ab5ac62472f8354f70a9d8f04b8, Literal_03d43b12fa75449884e4c023d9d4379d, Literal_23ad07c49dd04afebbd8a18628f7c624>
{
}

