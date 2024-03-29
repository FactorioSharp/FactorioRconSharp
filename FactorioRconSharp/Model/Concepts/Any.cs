#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;
using OneOf;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// Any basic type (string, number, boolean), table, or LuaObject.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("Any")]
public partial class Any: OneOfBase<string, bool, double, LuaTable, LuaObject>
{
}

