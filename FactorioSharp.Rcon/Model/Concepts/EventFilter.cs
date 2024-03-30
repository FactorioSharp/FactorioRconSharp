#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     Used to filter out irrelevant event callbacks in a performant way.
/// </summary>
[FactorioRconConcept("EventFilter")]
public class EventFilter : Alias<List<Union424113022>>
{
}
