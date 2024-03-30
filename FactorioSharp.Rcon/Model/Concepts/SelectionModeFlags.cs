#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A set of flags on a selection tool that define how entities and tiles are selected. Active flags are in the dictionary as `true`, while inactive flags aren't present at all.
/// </summary>
[FactorioRconConcept("SelectionModeFlags")]
public class SelectionModeFlags : Alias<Dictionary<Literals1542139774, Literal666164478>>
{
}
