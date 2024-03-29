#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A <see cref="CollisionMask" /> which also includes any flags this mask has.
/// </summary>
[FactorioRconConcept("CollisionMaskWithFlags")]
public class CollisionMaskWithFlags: Alias<Dictionary<Union65647394, Literal666164478>>
{
}

