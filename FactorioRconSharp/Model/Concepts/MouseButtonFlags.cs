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
/// To write to this, use an array<see cref="String" />] of the mouse buttons that should be possible to use with on button. The flag `"left-and-right"` can also be set, which will set `"left"` and `"right"` to `true`.
/// </summary>
[FactorioRconConcept("MouseButtonFlags")]
public abstract class MouseButtonFlags: Dictionary<Literals_f895380ef3de4866852d2a0acf932d5b, Literal_4b540f4f67c7473bbb772e816a0021ee>
{
}

