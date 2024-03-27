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
/// Types `"signal"` and `"item-group"` do not support filters.
/// </summary>
[FactorioRconConcept("PrototypeFilter")]
public abstract class PrototypeFilter: Alias<List<Union256602862>>
{
}

