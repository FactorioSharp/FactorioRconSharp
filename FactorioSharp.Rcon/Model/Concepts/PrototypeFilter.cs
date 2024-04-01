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
/// Types `"signal"` and `"item-group"` do not support filters.
/// </summary>
[FactorioRconConcept("PrototypeFilter")]
public class PrototypeFilter: Alias<LuaArray<Union1496072661>>
{
}

