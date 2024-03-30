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
/// A set of flags. Active flags are in the dictionary as `true`, while inactive flags aren't present at all.
/// 
/// By default, none of these flags are set.
/// </summary>
[FactorioRconConcept("ItemPrototypeFlags")]
public class ItemPrototypeFlags: Alias<Dictionary<ItemPrototypeFlag, Literal265409079>>
{
}

