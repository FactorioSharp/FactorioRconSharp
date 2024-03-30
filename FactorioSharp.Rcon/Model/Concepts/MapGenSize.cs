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
/// A floating point number specifying an amount.
/// 
/// For backwards compatibility, MapGenSizes can also be specified as one of the following strings, which will be converted to a number (when queried, a number will always be returned):
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("MapGenSize")]
public partial class MapGenSize: OneOfBase<Union1807241770_0, Union1807241770_1>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

[GenerateOneOf]
public partial class Union1807241770_0: OneOfBase<float, Literal2041329128, Literal63603103, Literal1134776557, Literal1539596955, Literal1019749245, Literal1375552333, Literal959215129, Literal2021785025>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

[GenerateOneOf]
public partial class Union1807241770_1: OneOfBase<Literal1501367464, Literal566134406, Literal792708459, Literal1387279352, Literal789130510, Literal1139827560, Literal1005892558, Literal758657492>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

