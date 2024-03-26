#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Utils;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// A dictionary of string to the four basic Lua types: `string`, `boolean`, `number`, `table`.
/// 
/// Note that the API returns tags as a simple table, meaning any modifications to it will not propagate back to the game. Thus, to modify a set of tags, the whole table needs to be written back to the respective property.
/// </summary>
[FactorioRconConcept("Tags")]
public abstract class Tags: Dictionary<string, AnyBasic>
{
}

