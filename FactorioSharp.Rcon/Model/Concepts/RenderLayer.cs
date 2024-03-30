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
public partial class RenderLayer: OneOfBase<Union661167950_0, Union661167950_1, Union661167950_2, Union661167950_3, Union661167950_4>
{
}

[GenerateOneOf]
public partial class Union661167950_0: OneOfBase<string, Literal414700809, Literal668216515, Literal489097366, Literal39617829, Literal2055788555, Literal1761222738, Literal58610471, Literal752359185>
{
}

[GenerateOneOf]
public partial class Union661167950_1: OneOfBase<Literal811325174, Literal134974244, Literal764195536, Literal282354808, Literal1792309517, Literal1507026321, Literal2089840598, Literal1028211361, Literal736937334>
{
}

[GenerateOneOf]
public partial class Union661167950_2: OneOfBase<Literal1086409466, Literal511700903, Literal1359640333, Literal853309070, Literal799235092, Literal1175363736, Literal484233192, Literal849807437, Literal776082575>
{
}

[GenerateOneOf]
public partial class Union661167950_3: OneOfBase<Literal170709323, Literal157787379, Literal118575484, Literal1430549630, Literal1496177911, Literal1717504663, Literal1485125349, Literal243174832, Literal774841213>
{
}

[GenerateOneOf]
public partial class Union661167950_4: OneOfBase<Literal624942818, Literal675492792, Literal1649793853, Literal2041851728, Literal8546033, Literal2069016308, Literal1313519210, Literal836290718>
{
}

