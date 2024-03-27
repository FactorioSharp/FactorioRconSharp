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
/// Used to filter out irrelevant event callbacks in a performant way.
/// </summary>
[FactorioRconConcept("EventFilter")]
public abstract class EventFilter: List<Union_c5dbae64c731463082587c789d0a3d82>
{
}

