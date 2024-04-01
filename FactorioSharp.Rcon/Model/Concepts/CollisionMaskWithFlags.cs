#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// A <see cref="CollisionMask" /> which also includes any flags this mask has.
/// </summary>
[FactorioRconConcept("CollisionMaskWithFlags")]
public class CollisionMaskWithFlags: Alias<Dictionary<Union1777727082, Literal1719260023>>
{
}

