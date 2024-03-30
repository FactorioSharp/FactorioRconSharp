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
/// An entity prototype may be specified in one of three ways.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("EntityPrototypeIdentification")]
public partial class EntityPrototypeIdentification: OneOfBase<LuaEntity, LuaEntityPrototype, string>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

