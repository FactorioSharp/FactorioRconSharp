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
/// Two positions, specifying the top-left and bottom-right corner of the box respectively. Like with <see cref="MapPosition" />, the names of the members may be omitted. When read from the game, the third member `orientation` is present if it is non-zero.
/// </summary>
[GenerateOneOf]
[FactorioRconConcept("BoundingBox")]
public partial class BoundingBox: OneOfBase<Table1448100345, Tuple95508044>
{
}

