#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
///     A set of flags. Active flags are in the dictionary as `true`, while inactive flags aren't present at all.
///     To write to this, use an array<see cref="String" />] of the mouse buttons that should be possible to use with on button. The flag `"left-and-right"` can also be set, which
///     will set `"left"` and `"right"` to `true`.
/// </summary>
[FactorioRconConcept("MouseButtonFlags")]
public class MouseButtonFlags : Alias<Dictionary<Literals1854270051, Literal666164478>>
{
}
