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
/// A dictionary of string to the four basic Lua types: `string`, `boolean`, `number`, `table`.
/// 
/// Note that the API returns tags as a simple table, meaning any modifications to it will not propagate back to the game. Thus, to modify a set of tags, the whole table needs to be written back to the respective property.
/// </summary>
[FactorioRconConcept("Tags")]
public class Tags: Alias<Dictionary<string, AnyBasic>>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

