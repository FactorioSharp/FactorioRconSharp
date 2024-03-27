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
/// A set of flags. Active flags are in the dictionary as `true`, while inactive flags aren't present at all.
/// 
/// By default, none of these flags are set.
/// </summary>
[FactorioRconConcept("ItemPrototypeFlags")]
public abstract class ItemPrototypeFlags: Dictionary<ItemPrototypeFlag, Literal_b36dbe3b10d14af8bea2ec781245305a>
{
}

