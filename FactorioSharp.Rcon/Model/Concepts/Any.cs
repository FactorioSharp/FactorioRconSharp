#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioSharp.Rcon.Core.Abstractions;
using FactorioSharp.Rcon.Model.Anonymous;
using FactorioSharp.Rcon.Model.Builtins;
using FactorioSharp.Rcon.Model.Classes;
using FactorioSharp.Rcon.Model.Definitions;
using FactorioSharp.Rcon.Model.Utils;
using OneOf;

namespace FactorioSharp.Rcon.Model.Concepts;

/// <summary>
/// Any basic type (string, number, boolean), table, or LuaObject.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("Any")]
public partial class Any: OneOfBase<string, bool, double, LuaTable, LuaObject>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

