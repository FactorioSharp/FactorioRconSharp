#pragma warning disable CS8618
// ReSharper disable UnassignedGetOnlyAutoProperty

using FactorioRconSharp.Core.Abstractions;
using FactorioRconSharp.Model.Anonymous;
using FactorioRconSharp.Model.Builtins;
using FactorioRconSharp.Model.Classes;
using FactorioRconSharp.Model.Definitions;
using FactorioRconSharp.Model.Utils;

namespace FactorioRconSharp.Model.Concepts;

/// <summary>
/// The smooth orientation. It is a <see cref="Float)InTheRange`[0,1" />` that covers a full circle, starting at the top and going clockwise. This means a value of `0` indicates "north", a value of `0.5` indicates "south".
/// 
/// For example then, a value of `0.625` would indicate "south-west", and a value of `0.875` would indicate "north-west".
/// </summary>
[FactorioRconConcept("RealOrientation")]
public abstract class RealOrientation: float
{
}

