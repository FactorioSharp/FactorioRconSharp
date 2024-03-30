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
/// A number between 0 and 255 inclusive, represented by one of the following named strings or the string version of the number. For example `"27"` and `"decals"` are both valid. Higher values are rendered above lower values.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("RenderLayer")]
public partial class RenderLayer: OneOfBase<Union1570381151_0, Union1570381151_1, Union1570381151_2, Union1570381151_3, Union1570381151_4>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

[GenerateOneOf]
public partial class Union1570381151_0: OneOfBase<string, Literal1190531420, Literal992523301, Literal545296100, Literal1738126300, Literal1408652924, Literal544816229, Literal1308947436, Literal2020293635>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

[GenerateOneOf]
public partial class Union1570381151_1: OneOfBase<Literal1314456949, Literal474236957, Literal1774563933, Literal1283434295, Literal1425772202, Literal785189810, Literal755660705, Literal1236359711, Literal186931502>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

[GenerateOneOf]
public partial class Union1570381151_2: OneOfBase<Literal153270625, Literal144926022, Literal1503446078, Literal1355326679, Literal291935877, Literal510565501, Literal733162864, Literal1003641519, Literal1278539468>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

[GenerateOneOf]
public partial class Union1570381151_3: OneOfBase<Literal1807888760, Literal978866263, Literal500993740, Literal1278485532, Literal1225685126, Literal1396054277, Literal1997006081, Literal217973907, Literal185020913>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

[GenerateOneOf]
public partial class Union1570381151_4: OneOfBase<Literal2114175475, Literal1476488925, Literal1910724811, Literal1304965129, Literal247892230, Literal78331916, Literal916320522, Literal1972854258>, IFactorioRconModel
{
  public void Load(string str) => throw new NotImplementedException();
}

